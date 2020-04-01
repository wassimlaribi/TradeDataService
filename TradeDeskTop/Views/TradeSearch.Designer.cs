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
			this.tradeDataGridView.Location = new System.Drawing.Point(25, 76);
			this.tradeDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tradeDataGridView.Name = "tradeDataGridView";
			this.tradeDataGridView.RowHeadersWidth = 51;
			this.tradeDataGridView.RowTemplate.Height = 24;
			this.tradeDataGridView.Size = new System.Drawing.Size(1161, 720);
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
			this.btnSearch.Location = new System.Drawing.Point(1086, 30);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(100, 29);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// TradeSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1354, 821);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.tradeDataGridView);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "TradeSearch";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.tradeDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tradesBindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView tradeDataGridView;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.BindingSource tradesBindingSource1;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn counterPartyDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn notionalDataGridViewTextBoxColumn;
	}
}

