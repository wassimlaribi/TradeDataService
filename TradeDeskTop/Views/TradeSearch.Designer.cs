namespace TradeDeskTop
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
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.counterPartyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.notionalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tradesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.btnSearch = new System.Windows.Forms.Button();
			this.tbTradeId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
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
			this.tradeDataGridView.Size = new System.Drawing.Size(1032, 576);
			this.tradeDataGridView.TabIndex = 0;
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
			this.tradesBindingSource1.DataSource = typeof(TradeDeskTop.TradeSearchModelPresenter);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(965, 24);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(89, 23);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// tbTradeId
			// 
			this.tbTradeId.Location = new System.Drawing.Point(109, 25);
			this.tbTradeId.Name = "tbTradeId";
			this.tbTradeId.Size = new System.Drawing.Size(125, 22);
			this.tbTradeId.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Trade Id";
			// 
			// TradeSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1166, 657);
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
	}
}

