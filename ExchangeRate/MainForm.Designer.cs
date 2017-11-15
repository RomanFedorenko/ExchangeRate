namespace ExchangeRate
{
    partial class MainForm
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
            this.valuta = new System.Windows.Forms.ComboBox();
            this.DictionaryButton = new MaterialSkin.Controls.MaterialFlatButton();
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
            this.RateTable.Location = new System.Drawing.Point(163, 105);
            this.RateTable.Name = "RateTable";
            this.RateTable.Size = new System.Drawing.Size(670, 458);
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
            // valuta
            // 
            this.valuta.FormattingEnabled = true;
            this.valuta.Location = new System.Drawing.Point(12, 150);
            this.valuta.Name = "valuta";
            this.valuta.Size = new System.Drawing.Size(144, 21);
            this.valuta.TabIndex = 1;
            this.valuta.SelectedIndexChanged += new System.EventHandler(this.valuta_SelectedIndexChanged);
            // 
            // DictionaryButton
            // 
            this.DictionaryButton.AutoSize = true;
            this.DictionaryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DictionaryButton.Depth = 0;
            this.DictionaryButton.Icon = null;
            this.DictionaryButton.Location = new System.Drawing.Point(12, 105);
            this.DictionaryButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DictionaryButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DictionaryButton.Name = "DictionaryButton";
            this.DictionaryButton.Primary = false;
            this.DictionaryButton.Size = new System.Drawing.Size(144, 36);
            this.DictionaryButton.TabIndex = 2;
            this.DictionaryButton.Text = "Довідник валют";
            this.DictionaryButton.UseVisualStyleBackColor = true;
            this.DictionaryButton.Click += new System.EventHandler(this.DictionaryButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 591);
            this.Controls.Add(this.DictionaryButton);
            this.Controls.Add(this.valuta);
            this.Controls.Add(this.RateTable);
            this.Name = "Form1";
            this.Text = "Курс валют";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RateTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RateTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buying;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selling;
        private System.Windows.Forms.ComboBox valuta;
        private MaterialSkin.Controls.MaterialFlatButton DictionaryButton;
    }
}

