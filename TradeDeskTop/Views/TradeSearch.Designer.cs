﻿namespace TradeDeskTop
{
	partial class TradeSearch
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
			this.components = new System.ComponentModel.Container();
			this.tradeDataGridView = new System.Windows.Forms.DataGridView();
			this.btnSearch = new System.Windows.Forms.Button();
			this.tbTradeId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbCounterParty = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.lbLoadedTradeNumber = new System.Windows.Forms.Label();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.counterPartyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.notionalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tradesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.tradeDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tradesBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// tradeDataGridView
			// 
			this.tradeDataGridView.AutoGenerateColumns = false;
			this.tradeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tradeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.counterPartyDataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn,
            this.notionalDataGridViewTextBoxColumn});
			this.tradeDataGridView.DataSource = this.tradesBindingSource1;
			this.tradeDataGridView.Location = new System.Drawing.Point(22, 61);
			this.tradeDataGridView.Name = "tradeDataGridView";
			this.tradeDataGridView.RowHeadersWidth = 51;
			this.tradeDataGridView.RowTemplate.Height = 24;
			this.tradeDataGridView.Size = new System.Drawing.Size(1032, 529);
			this.tradeDataGridView.TabIndex = 0;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(511, 21);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(89, 23);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// tbTradeId
			// 
			this.tbTradeId.Location = new System.Drawing.Point(109, 21);
			this.tbTradeId.Name = "tbTradeId";
			this.tbTradeId.Size = new System.Drawing.Size(125, 22);
			this.tbTradeId.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Trade Id";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(259, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "CounterParty";
			// 
			// tbCounterParty
			// 
			this.tbCounterParty.Location = new System.Drawing.Point(356, 21);
			this.tbCounterParty.Name = "tbCounterParty";
			this.tbCounterParty.Size = new System.Drawing.Size(125, 22);
			this.tbCounterParty.TabIndex = 4;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(606, 21);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(89, 23);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(807, 27);
			this.progressBar1.MarqueeAnimationSpeed = 0;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(105, 17);
			this.progressBar1.Step = 5;
			this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.progressBar1.TabIndex = 7;
			// 
			// lbLoadedTradeNumber
			// 
			this.lbLoadedTradeNumber.AutoSize = true;
			this.lbLoadedTradeNumber.Location = new System.Drawing.Point(918, 24);
			this.lbLoadedTradeNumber.Name = "lbLoadedTradeNumber";
			this.lbLoadedTradeNumber.Size = new System.Drawing.Size(71, 17);
			this.lbLoadedTradeNumber.TabIndex = 8;
			this.lbLoadedTradeNumber.Text = "Loading 0";
			// 
			// iDDataGridViewTextBoxColumn
			// 
			this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
			this.iDDataGridViewTextBoxColumn.Width = 125;
			// 
			// counterPartyDataGridViewTextBoxColumn
			// 
			this.counterPartyDataGridViewTextBoxColumn.DataPropertyName = "CounterParty";
			this.counterPartyDataGridViewTextBoxColumn.HeaderText = "CounterParty";
			this.counterPartyDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.counterPartyDataGridViewTextBoxColumn.Name = "counterPartyDataGridViewTextBoxColumn";
			this.counterPartyDataGridViewTextBoxColumn.Width = 125;
			// 
			// currencyDataGridViewTextBoxColumn
			// 
			this.currencyDataGridViewTextBoxColumn.DataPropertyName = "Currency";
			this.currencyDataGridViewTextBoxColumn.HeaderText = "Currency";
			this.currencyDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
			this.currencyDataGridViewTextBoxColumn.Width = 125;
			// 
			// notionalDataGridViewTextBoxColumn
			// 
			this.notionalDataGridViewTextBoxColumn.DataPropertyName = "Notional";
			this.notionalDataGridViewTextBoxColumn.HeaderText = "Notional";
			this.notionalDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.notionalDataGridViewTextBoxColumn.Name = "notionalDataGridViewTextBoxColumn";
			this.notionalDataGridViewTextBoxColumn.Width = 125;
			// 
			// tradesBindingSource1
			// 
			this.tradesBindingSource1.DataSource = typeof(TradeDeskTop.TradeModelPresenter);
			// 
			// TradeSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1166, 657);
			this.Controls.Add(this.lbLoadedTradeNumber);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbCounterParty);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbTradeId);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.tradeDataGridView);
			this.Name = "TradeSearch";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.tradeDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tradesBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView tradeDataGridView;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.BindingSource tradesBindingSource1;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn counterPartyDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn notionalDataGridViewTextBoxColumn;
		private System.Windows.Forms.TextBox tbTradeId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbCounterParty;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label lbLoadedTradeNumber;
	}
}

