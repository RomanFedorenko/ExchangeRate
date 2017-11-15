namespace ExchangeRate
{
    partial class Form1
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
            this.RateTable = new System.Windows.Forms.DataGridView();
            this.Bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buying = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RateTable)).BeginInit();
            this.SuspendLayout();
            // 
            // RateTable
            // 
            this.RateTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RateTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bank,
            this.Buying,
            this.Selling});
            this.RateTable.Location = new System.Drawing.Point(75, 105);
            this.RateTable.Name = "RateTable";
            this.RateTable.Size = new System.Drawing.Size(734, 192);
            this.RateTable.TabIndex = 0;
            // 
            // Bank
            // 
            this.Bank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Bank.HeaderText = "Банк";
            this.Bank.Name = "Bank";
            this.Bank.ReadOnly = true;
            // 
            // Buying
            // 
            this.Buying.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Buying.HeaderText = "Купівля";
            this.Buying.Name = "Buying";
            this.Buying.ReadOnly = true;
            // 
            // Selling
            // 
            this.Selling.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Selling.HeaderText = "Продаж";
            this.Selling.Name = "Selling";
            this.Selling.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 397);
            this.Controls.Add(this.RateTable);
            this.Name = "Form1";
            this.Text = "Exchange Rate";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RateTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RateTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buying;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selling;
    }
}

