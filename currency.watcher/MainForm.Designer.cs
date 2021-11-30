﻿using System.ComponentModel;
using System.Windows.Forms;

namespace currency.watcher
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.btnRefresh = new System.Windows.Forms.Button();
      this.btnTop = new System.Windows.Forms.Button();
      this.cmbCurrency = new System.Windows.Forms.ComboBox();
      this.browser = new System.Windows.Forms.WebBrowser();
      this.panMain = new System.Windows.Forms.Panel();
      this.lstFinanceHistory = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.lblFinanceUa = new System.Windows.Forms.Label();
      this.lstHistory = new System.Windows.Forms.ListView();
      this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colBuy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colSale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.panHistory = new System.Windows.Forms.Panel();
      this.tabControl = new System.Windows.Forms.TabControl();
      this.tabPageMain = new System.Windows.Forms.TabPage();
      this.panel1 = new System.Windows.Forms.Panel();
      this.lblTaxesResult = new System.Windows.Forms.Label();
      this.txtUahResult = new System.Windows.Forms.TextBox();
      this.lblUah = new System.Windows.Forms.Label();
      this.lblDate = new System.Windows.Forms.Label();
      this.lblUsd = new System.Windows.Forms.Label();
      this.txtTaxesResult = new System.Windows.Forms.TextBox();
      this.dtTaxesSource = new System.Windows.Forms.DateTimePicker();
      this.numTaxesSource = new System.Windows.Forms.NumericUpDown();
      this.lblTaxes = new System.Windows.Forms.Label();
      this.panPrivat24Business = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.tabPageGraphic = new System.Windows.Forms.TabPage();
      this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.panStatus = new System.Windows.Forms.Panel();
      this.cbxWeather = new System.Windows.Forms.CheckBox();
      this.panGridOptions = new System.Windows.Forms.Panel();
      this.cbxShowNbu = new System.Windows.Forms.CheckBox();
      this.cmbChartMode = new System.Windows.Forms.ComboBox();
      this.cbxChartGridMode = new System.Windows.Forms.CheckBox();
      this.cbxStickEdges = new System.Windows.Forms.CheckBox();
      this.panMain.SuspendLayout();
      this.panHistory.SuspendLayout();
      this.tabControl.SuspendLayout();
      this.tabPageMain.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numTaxesSource)).BeginInit();
      this.panPrivat24Business.SuspendLayout();
      this.tabPageGraphic.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
      this.panStatus.SuspendLayout();
      this.panGridOptions.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnRefresh
      // 
      this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
      this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btnRefresh.Location = new System.Drawing.Point(73, 0);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(25, 26);
      this.btnRefresh.TabIndex = 1;
      this.btnRefresh.Text = "R";
      this.btnRefresh.UseVisualStyleBackColor = false;
      // 
      // btnTop
      // 
      this.btnTop.Dock = System.Windows.Forms.DockStyle.Left;
      this.btnTop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btnTop.Location = new System.Drawing.Point(98, 0);
      this.btnTop.Name = "btnTop";
      this.btnTop.Size = new System.Drawing.Size(25, 26);
      this.btnTop.TabIndex = 2;
      this.btnTop.Text = "T";
      this.btnTop.UseVisualStyleBackColor = false;
      this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
      // 
      // cmbCurrency
      // 
      this.cmbCurrency.Dock = System.Windows.Forms.DockStyle.Left;
      this.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbCurrency.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.cmbCurrency.FormattingEnabled = true;
      this.cmbCurrency.Items.AddRange(new object[] {
            "USD",
            "EUR"});
      this.cmbCurrency.Location = new System.Drawing.Point(0, 0);
      this.cmbCurrency.Name = "cmbCurrency";
      this.cmbCurrency.Size = new System.Drawing.Size(73, 25);
      this.cmbCurrency.TabIndex = 0;
      // 
      // browser
      // 
      this.browser.Dock = System.Windows.Forms.DockStyle.Top;
      this.browser.IsWebBrowserContextMenuEnabled = false;
      this.browser.Location = new System.Drawing.Point(0, 0);
      this.browser.MinimumSize = new System.Drawing.Size(20, 20);
      this.browser.Name = "browser";
      this.browser.ScrollBarsEnabled = false;
      this.browser.Size = new System.Drawing.Size(159, 110);
      this.browser.TabIndex = 0;
      this.browser.Visible = false;
      // 
      // panMain
      // 
      this.panMain.Controls.Add(this.lstFinanceHistory);
      this.panMain.Controls.Add(this.lblFinanceUa);
      this.panMain.Controls.Add(this.browser);
      this.panMain.Dock = System.Windows.Forms.DockStyle.Left;
      this.panMain.Location = new System.Drawing.Point(3, 3);
      this.panMain.Name = "panMain";
      this.panMain.Size = new System.Drawing.Size(159, 203);
      this.panMain.TabIndex = 17;
      // 
      // lstFinanceHistory
      // 
      this.lstFinanceHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.lstFinanceHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
      this.lstFinanceHistory.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lstFinanceHistory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lstFinanceHistory.FullRowSelect = true;
      this.lstFinanceHistory.GridLines = true;
      this.lstFinanceHistory.HideSelection = false;
      this.lstFinanceHistory.Location = new System.Drawing.Point(0, 123);
      this.lstFinanceHistory.Name = "lstFinanceHistory";
      this.lstFinanceHistory.Size = new System.Drawing.Size(159, 80);
      this.lstFinanceHistory.TabIndex = 1;
      this.lstFinanceHistory.UseCompatibleStateImageBehavior = false;
      this.lstFinanceHistory.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Time";
      this.columnHeader1.Width = 43;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Buy";
      this.columnHeader2.Width = 48;
      // 
      // columnHeader4
      // 
      this.columnHeader4.Text = "Sale";
      this.columnHeader4.Width = 48;
      // 
      // lblFinanceUa
      // 
      this.lblFinanceUa.Dock = System.Windows.Forms.DockStyle.Top;
      this.lblFinanceUa.Location = new System.Drawing.Point(0, 110);
      this.lblFinanceUa.Name = "lblFinanceUa";
      this.lblFinanceUa.Size = new System.Drawing.Size(159, 13);
      this.lblFinanceUa.TabIndex = 2;
      this.lblFinanceUa.Text = "Finance.ua";
      this.lblFinanceUa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // lstHistory
      // 
      this.lstHistory.Activation = System.Windows.Forms.ItemActivation.OneClick;
      this.lstHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.lstHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDate,
            this.colBuy,
            this.colSale});
      this.lstHistory.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lstHistory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lstHistory.FullRowSelect = true;
      this.lstHistory.GridLines = true;
      this.lstHistory.HideSelection = false;
      this.lstHistory.Location = new System.Drawing.Point(0, 13);
      this.lstHistory.Name = "lstHistory";
      this.lstHistory.Size = new System.Drawing.Size(200, 190);
      this.lstHistory.TabIndex = 0;
      this.lstHistory.UseCompatibleStateImageBehavior = false;
      this.lstHistory.View = System.Windows.Forms.View.Details;
      // 
      // colDate
      // 
      this.colDate.Text = "Date";
      this.colDate.Width = 90;
      // 
      // colBuy
      // 
      this.colBuy.Text = "Buy";
      this.colBuy.Width = 55;
      // 
      // colSale
      // 
      this.colSale.Text = "Sale";
      this.colSale.Width = 55;
      // 
      // panHistory
      // 
      this.panHistory.Controls.Add(this.tabControl);
      this.panHistory.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panHistory.Location = new System.Drawing.Point(0, 0);
      this.panHistory.Name = "panHistory";
      this.panHistory.Size = new System.Drawing.Size(566, 235);
      this.panHistory.TabIndex = 19;
      // 
      // tabControl
      // 
      this.tabControl.Controls.Add(this.tabPageMain);
      this.tabControl.Controls.Add(this.tabPageGraphic);
      this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl.Location = new System.Drawing.Point(0, 0);
      this.tabControl.Multiline = true;
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(566, 235);
      this.tabControl.TabIndex = 0;
      this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
      // 
      // tabPageMain
      // 
      this.tabPageMain.Controls.Add(this.panel1);
      this.tabPageMain.Controls.Add(this.panPrivat24Business);
      this.tabPageMain.Controls.Add(this.panMain);
      this.tabPageMain.Location = new System.Drawing.Point(4, 22);
      this.tabPageMain.Name = "tabPageMain";
      this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageMain.Size = new System.Drawing.Size(558, 209);
      this.tabPageMain.TabIndex = 1;
      this.tabPageMain.Text = "Main";
      this.tabPageMain.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.lblTaxesResult);
      this.panel1.Controls.Add(this.txtUahResult);
      this.panel1.Controls.Add(this.lblUah);
      this.panel1.Controls.Add(this.lblDate);
      this.panel1.Controls.Add(this.lblUsd);
      this.panel1.Controls.Add(this.txtTaxesResult);
      this.panel1.Controls.Add(this.dtTaxesSource);
      this.panel1.Controls.Add(this.numTaxesSource);
      this.panel1.Controls.Add(this.lblTaxes);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(362, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(173, 203);
      this.panel1.TabIndex = 19;
      // 
      // lblTaxesResult
      // 
      this.lblTaxesResult.AutoSize = true;
      this.lblTaxesResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lblTaxesResult.Location = new System.Drawing.Point(6, 134);
      this.lblTaxesResult.Name = "lblTaxesResult";
      this.lblTaxesResult.Size = new System.Drawing.Size(40, 17);
      this.lblTaxesResult.TabIndex = 6;
      this.lblTaxesResult.Text = "Taxes";
      // 
      // txtUahResult
      // 
      this.txtUahResult.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.txtUahResult.Location = new System.Drawing.Point(60, 91);
      this.txtUahResult.Name = "txtUahResult";
      this.txtUahResult.ReadOnly = true;
      this.txtUahResult.Size = new System.Drawing.Size(100, 27);
      this.txtUahResult.TabIndex = 5;
      this.txtUahResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // lblUah
      // 
      this.lblUah.AutoSize = true;
      this.lblUah.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lblUah.Location = new System.Drawing.Point(6, 101);
      this.lblUah.Name = "lblUah";
      this.lblUah.Size = new System.Drawing.Size(34, 17);
      this.lblUah.TabIndex = 4;
      this.lblUah.Text = "UAH";
      // 
      // lblDate
      // 
      this.lblDate.AutoSize = true;
      this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lblDate.Location = new System.Drawing.Point(6, 68);
      this.lblDate.Name = "lblDate";
      this.lblDate.Size = new System.Drawing.Size(35, 17);
      this.lblDate.TabIndex = 2;
      this.lblDate.Text = "Date";
      // 
      // lblUsd
      // 
      this.lblUsd.AutoSize = true;
      this.lblUsd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lblUsd.Location = new System.Drawing.Point(6, 35);
      this.lblUsd.Name = "lblUsd";
      this.lblUsd.Size = new System.Drawing.Size(50, 17);
      this.lblUsd.TabIndex = 0;
      this.lblUsd.Text = "Income";
      // 
      // txtTaxesResult
      // 
      this.txtTaxesResult.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.txtTaxesResult.Location = new System.Drawing.Point(60, 124);
      this.txtTaxesResult.Name = "txtTaxesResult";
      this.txtTaxesResult.ReadOnly = true;
      this.txtTaxesResult.Size = new System.Drawing.Size(100, 27);
      this.txtTaxesResult.TabIndex = 7;
      this.txtTaxesResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // dtTaxesSource
      // 
      this.dtTaxesSource.CustomFormat = "dd-MM-yyyy";
      this.dtTaxesSource.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dtTaxesSource.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtTaxesSource.Location = new System.Drawing.Point(60, 58);
      this.dtTaxesSource.Name = "dtTaxesSource";
      this.dtTaxesSource.Size = new System.Drawing.Size(100, 27);
      this.dtTaxesSource.TabIndex = 3;
      this.dtTaxesSource.ValueChanged += new System.EventHandler(this.numTaxesSource_ValueChanged);
      // 
      // numTaxesSource
      // 
      this.numTaxesSource.DecimalPlaces = 2;
      this.numTaxesSource.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.numTaxesSource.Location = new System.Drawing.Point(60, 25);
      this.numTaxesSource.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numTaxesSource.Name = "numTaxesSource";
      this.numTaxesSource.Size = new System.Drawing.Size(100, 27);
      this.numTaxesSource.TabIndex = 1;
      this.numTaxesSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.numTaxesSource.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.numTaxesSource.ValueChanged += new System.EventHandler(this.numTaxesSource_ValueChanged);
      // 
      // lblTaxes
      // 
      this.lblTaxes.Dock = System.Windows.Forms.DockStyle.Top;
      this.lblTaxes.Location = new System.Drawing.Point(0, 0);
      this.lblTaxes.Name = "lblTaxes";
      this.lblTaxes.Size = new System.Drawing.Size(173, 13);
      this.lblTaxes.TabIndex = 0;
      this.lblTaxes.Text = "Taxes calculator";
      this.lblTaxes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // panPrivat24Business
      // 
      this.panPrivat24Business.Controls.Add(this.lstHistory);
      this.panPrivat24Business.Controls.Add(this.label1);
      this.panPrivat24Business.Dock = System.Windows.Forms.DockStyle.Left;
      this.panPrivat24Business.Location = new System.Drawing.Point(162, 3);
      this.panPrivat24Business.Name = "panPrivat24Business";
      this.panPrivat24Business.Size = new System.Drawing.Size(200, 203);
      this.panPrivat24Business.TabIndex = 18;
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(200, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Privat 24 business";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // tabPageGraphic
      // 
      this.tabPageGraphic.Controls.Add(this.chart);
      this.tabPageGraphic.Location = new System.Drawing.Point(4, 22);
      this.tabPageGraphic.Name = "tabPageGraphic";
      this.tabPageGraphic.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageGraphic.Size = new System.Drawing.Size(558, 209);
      this.tabPageGraphic.TabIndex = 0;
      this.tabPageGraphic.Text = "Graphic";
      this.tabPageGraphic.UseVisualStyleBackColor = true;
      // 
      // chart
      // 
      this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
      this.chart.Location = new System.Drawing.Point(3, 3);
      this.chart.Name = "chart";
      this.chart.Size = new System.Drawing.Size(552, 203);
      this.chart.TabIndex = 20;
      this.chart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_MouseMove);
      // 
      // panStatus
      // 
      this.panStatus.Controls.Add(this.cbxWeather);
      this.panStatus.Controls.Add(this.panGridOptions);
      this.panStatus.Controls.Add(this.cbxStickEdges);
      this.panStatus.Controls.Add(this.btnTop);
      this.panStatus.Controls.Add(this.btnRefresh);
      this.panStatus.Controls.Add(this.cmbCurrency);
      this.panStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panStatus.Location = new System.Drawing.Point(0, 235);
      this.panStatus.Name = "panStatus";
      this.panStatus.Size = new System.Drawing.Size(566, 26);
      this.panStatus.TabIndex = 20;
      // 
      // cbxWeather
      // 
      this.cbxWeather.AutoSize = true;
      this.cbxWeather.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.cbxWeather.Dock = System.Windows.Forms.DockStyle.Left;
      this.cbxWeather.Location = new System.Drawing.Point(221, 0);
      this.cbxWeather.Name = "cbxWeather";
      this.cbxWeather.Size = new System.Drawing.Size(70, 26);
      this.cbxWeather.TabIndex = 4;
      this.cbxWeather.Text = "Weather";
      this.cbxWeather.UseVisualStyleBackColor = true;
      // 
      // panGridOptions
      // 
      this.panGridOptions.Controls.Add(this.cbxShowNbu);
      this.panGridOptions.Controls.Add(this.cmbChartMode);
      this.panGridOptions.Controls.Add(this.cbxChartGridMode);
      this.panGridOptions.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panGridOptions.Location = new System.Drawing.Point(221, 0);
      this.panGridOptions.Name = "panGridOptions";
      this.panGridOptions.Size = new System.Drawing.Size(345, 26);
      this.panGridOptions.TabIndex = 5;
      this.panGridOptions.Visible = false;
      // 
      // cbxShowNbu
      // 
      this.cbxShowNbu.AutoSize = true;
      this.cbxShowNbu.Checked = true;
      this.cbxShowNbu.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbxShowNbu.Dock = System.Windows.Forms.DockStyle.Right;
      this.cbxShowNbu.Location = new System.Drawing.Point(100, 0);
      this.cbxShowNbu.Name = "cbxShowNbu";
      this.cbxShowNbu.Size = new System.Drawing.Size(49, 26);
      this.cbxShowNbu.TabIndex = 0;
      this.cbxShowNbu.Text = "NBU";
      this.cbxShowNbu.UseVisualStyleBackColor = true;
      // 
      // cmbChartMode
      // 
      this.cmbChartMode.Dock = System.Windows.Forms.DockStyle.Right;
      this.cmbChartMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbChartMode.FormattingEnabled = true;
      this.cmbChartMode.Items.AddRange(new object[] {
            "1 month",
            "3 months",
            "6 months"});
      this.cmbChartMode.Location = new System.Drawing.Point(149, 0);
      this.cmbChartMode.Name = "cmbChartMode";
      this.cmbChartMode.Size = new System.Drawing.Size(121, 21);
      this.cmbChartMode.TabIndex = 1;
      // 
      // cbxChartGridMode
      // 
      this.cbxChartGridMode.AutoSize = true;
      this.cbxChartGridMode.Dock = System.Windows.Forms.DockStyle.Right;
      this.cbxChartGridMode.Location = new System.Drawing.Point(270, 0);
      this.cbxChartGridMode.Name = "cbxChartGridMode";
      this.cbxChartGridMode.Size = new System.Drawing.Size(75, 26);
      this.cbxChartGridMode.TabIndex = 2;
      this.cbxChartGridMode.Text = "Grid lines";
      this.cbxChartGridMode.UseVisualStyleBackColor = true;
      // 
      // cbxStickEdges
      // 
      this.cbxStickEdges.AutoSize = true;
      this.cbxStickEdges.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.cbxStickEdges.Dock = System.Windows.Forms.DockStyle.Left;
      this.cbxStickEdges.Location = new System.Drawing.Point(123, 0);
      this.cbxStickEdges.Name = "cbxStickEdges";
      this.cbxStickEdges.Size = new System.Drawing.Size(98, 26);
      this.cbxStickEdges.TabIndex = 3;
      this.cbxStickEdges.Text = "Stick to edges";
      this.cbxStickEdges.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.ClientSize = new System.Drawing.Size(566, 261);
      this.Controls.Add(this.panHistory);
      this.Controls.Add(this.panStatus);
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.MaximizeBox = false;
      this.MinimumSize = new System.Drawing.Size(582, 300);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
      this.panMain.ResumeLayout(false);
      this.panHistory.ResumeLayout(false);
      this.tabControl.ResumeLayout(false);
      this.tabPageMain.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numTaxesSource)).EndInit();
      this.panPrivat24Business.ResumeLayout(false);
      this.tabPageGraphic.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
      this.panStatus.ResumeLayout(false);
      this.panStatus.PerformLayout();
      this.panGridOptions.ResumeLayout(false);
      this.panGridOptions.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion
        private Button btnRefresh;
        private Button btnTop;
        private ComboBox cmbCurrency;
        private WebBrowser browser;
    private Panel panMain;
    private ListView lstHistory;
    private ColumnHeader colBuy;
    private ColumnHeader colSale;
    private ColumnHeader colDate;
    private Panel panHistory;
    private ListView lstFinanceHistory;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader4;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    private Panel panStatus;
    private ComboBox cmbChartMode;
    private CheckBox cbxChartGridMode;
    private CheckBox cbxStickEdges;
    private CheckBox cbxShowNbu;
    private TabControl tabControl;
    private TabPage tabPageGraphic;
    private TabPage tabPageMain;
    private Panel panGridOptions;
    private Panel panPrivat24Business;
    private Label label1;
    private Panel panel1;
    private Label lblTaxes;
    private DateTimePicker dtTaxesSource;
    private NumericUpDown numTaxesSource;
    private TextBox txtTaxesResult;
    private Label lblUah;
    private Label lblDate;
    private Label lblUsd;
    private Label lblTaxesResult;
    private TextBox txtUahResult;
    private CheckBox cbxWeather;
    private Label lblFinanceUa;
  }
}

