namespace ExchangeRate
{
    partial class DictionaryForm
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
            this.DictListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // DictListView
            // 
            this.DictListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DictListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.DictListView.Depth = 0;
            this.DictListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.DictListView.FullRowSelect = true;
            this.DictListView.GridLines = true;
            this.DictListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.DictListView.Location = new System.Drawing.Point(36, 99);
            this.DictListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DictListView.MouseState = MaterialSkin.MouseState.OUT;
            this.DictListView.Name = "DictListView";
            this.DictListView.OwnerDraw = true;
            this.DictListView.Size = new System.Drawing.Size(593, 376);
            this.DictListView.TabIndex = 0;
            this.DictListView.UseCompatibleStateImageBehavior = false;
            this.DictListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Шифр";
            this.columnHeader1.Width = 230;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Назва";
            this.columnHeader2.Width = 341;
            // 
            // DictionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 561);
            this.Controls.Add(this.DictListView);
            this.Name = "DictionaryForm";
            this.Text = "Довідник валют";
            this.Load += new System.EventHandler(this.DictionaryForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView DictListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}