﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace currency {

  public class DataProvider {

    private readonly string nbuRatesFile;
    private List<CombinedRatesItem> rates;
    private DateTime lastPrivat24HistoryGet;

    static DataProvider() {
      ServicePointManager.Expect100Continue = false;
      ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
      ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
    }

    public DataProvider(string appPath) {

      if (!string.IsNullOrEmpty(appPath)) {
        nbuRatesFile= $"{Path.GetDirectoryName(appPath)}\\nbu.rates.json";
      }

      LoadNbuRates();
    }

    public bool IsEmpty() {
      lock(rates)
        return rates.Count == 0;
    }

    public CombinedRatesItem GetByDate(DateTime date) {
      lock (rates)
        return IsEmpty() ? null : rates.FirstOrDefault(i => i.Date.Date == date.Date);
    }

    public CombinedRatesItem[] Take(int count) {
      lock (rates)
        return IsEmpty() ? null : rates
        .Skip(Math.Max(0, rates.Count - count)).ToArray();
    }

    public event Action OnDataChanged;

    private void LoadNbuRates() {
      if (!string.IsNullOrEmpty(nbuRatesFile) && File.Exists(nbuRatesFile))
        rates = File.ReadAllText(nbuRatesFile).FromJson<List<CombinedRatesItem>>();
      
      if (rates == null)
        rates = new List<CombinedRatesItem>();
    }

    private void SaveNbuRates() {
      if (!string.IsNullOrEmpty(nbuRatesFile)) {
        lock (rates) {
          var data = rates.ToJson();
          File.WriteAllText(nbuRatesFile, data);
        }
      }
    }

    public void Refresh() {

      Task.Factory.StartNew(async () => {
        var dataChanged = false;

        var dataUsd = await Helper.GetJsonData($"https://minfin.com.ua/data/currency/nbu/nbu.usd.stock.json")
          .ConfigureAwait(false);
        if (!string.IsNullOrEmpty(dataUsd)) {
          var newRatesUsd = dataUsd.FromJson<NbuRateItem[]>();
          if (newRatesUsd != null && newRatesUsd.Length > 0) {
            for (var i = 0; i < newRatesUsd.Length; i++) {
              var old = GetByDate(newRatesUsd[i].Date);
              if (old == null) {
                lock (rates) {
                  rates.Add(new CombinedRatesItem {
                    Date = newRatesUsd[i].Date.Date,
                    NbuRateUsd = newRatesUsd[i].Rate,
                  });
                }
                dataChanged = true;
              }
              else if (old.NbuRateUsd != newRatesUsd[i].Rate) {
                old.NbuRateUsd = newRatesUsd[i].Rate;
                dataChanged = true;
              }
            }
          }
        }

        var dataEur = await Helper.GetJsonData($"https://minfin.com.ua/data/currency/nbu/nbu.eur.stock.json")
  .ConfigureAwait(false);
        if (!string.IsNullOrEmpty(dataEur)) {
          var newRatesEur = dataEur.FromJson<NbuRateItem[]>();
          if (newRatesEur != null && newRatesEur.Length > 0) {
            for (var i = 0; i < newRatesEur.Length; i++) {
              var old = GetByDate(newRatesEur[i].Date);
              if (old == null) {
                lock (rates) {
                  rates.Add(new CombinedRatesItem {
                    Date = newRatesEur[i].Date.Date,
                    NbuRateEur = newRatesEur[i].Rate,
                  });
                }
                dataChanged = true;
              }
              else if (old.NbuRateEur != newRatesEur[i].Rate) {
                old.NbuRateEur = newRatesEur[i].Rate;
                dataChanged = true;
              }
            }
          }
        }

        if (lastPrivat24HistoryGet.Date != DateTime.Now.Date) {

          var dataPrivat24 = await Helper.GetJsonData("https://otp24.privatbank.ua/v3/api/1/info/currency/history", 30, "POST");
          if (!string.IsNullOrEmpty(dataPrivat24)) {
            var historyData = dataPrivat24.FromJson<Privat24HistoryResponse>();
            if ((historyData?.Data?.History) != null && historyData.Data.History.Length > 0) {
              var currencyCodes = new[] { "USD", "EUR" };
              var filteredItems = historyData.Data.History.Where(i => currencyCodes.Contains(i.CurrencyCode))
                .OrderByDescending(x => {
                  DateTime.TryParseExact(x.Date, "dd-MM-yyyy", null, DateTimeStyles.AllowWhiteSpaces, out var dt);
                  x.DateParsed = dt;
                  return dt;
                }).ToArray();
              if (filteredItems.Length != 0) {
                for (var i = 0; i < filteredItems.Length; i += 2) {
                  var itemEur = filteredItems[i]; //todo: get by Date & CurrencyCode
                  var itemUsd = filteredItems[i + 1]; //todo: get by Date & CurrencyCode

                  var old = GetByDate(itemUsd.DateParsed);
                  if (old == null) {
                    lock (rates) {
                      rates.Add(new CombinedRatesItem {
                        Date = itemUsd.DateParsed.Date,
                        PbRateUsdB = itemUsd.Rate_B,
                        PbRateUsdS = itemUsd.Rate_S,
                        PbRateEurB = itemEur.Rate_B,
                        PbRateEurS = itemEur.Rate_S,
                      });
                    }
                    dataChanged = true;
                  }
                  else if (old.PbRateUsdB != itemUsd.Rate_B || old.PbRateUsdS != itemUsd.Rate_S || 
                           old.PbRateEurB != itemEur.Rate_B || old.PbRateEurS != itemEur.Rate_S) {
                    old.PbRateUsdB = itemUsd.Rate_B;
                    old.PbRateUsdS = itemUsd.Rate_S;
                    old.PbRateEurB = itemEur.Rate_B;
                    old.PbRateEurS = itemEur.Rate_S;
                    dataChanged = true;
                  }
                }

                if (filteredItems[0].DateParsed.Date == DateTime.Today)
                  lastPrivat24HistoryGet = DateTime.Now;
                //if (lastPrivat24HistoryGet < filteredItems[0].DateParsed)
                //  lastPrivat24HistoryGet = filteredItems[0].DateParsed;
              }
            }
          }
        }

        if (dataChanged) {
          SaveNbuRates();
          OnDataChanged?.Invoke();
        }

      });

    }
  }
}
