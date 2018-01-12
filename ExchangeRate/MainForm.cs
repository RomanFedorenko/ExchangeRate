using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ExchangeRate
{
    public partial class MainForm : MaterialForm
    {
            

        public MainForm()
        {
            InitializeComponent();            
        }


        private void Form1_Load(object sender, EventArgs e)
        {                  
            FillValutasCmbBox();
            valuta.SelectedItem = "USD";
            RefreshTable();            
        }

        private void FillValutasCmbBox()
        {
            List<Valuta> valutas = Filler.GetValutasDictionary();
            foreach (Valuta item in valutas)
            {
                valuta.Items.Add(item.Cipher);
            }            
        }

        private void valuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTable();           
        }
        

        public void RefreshTable() {
            List<Bank> allbanks = Filler.GetAllBanks();

            RateTable.Rows.Clear();          
            int currentRow = 0;

            IEnumerable<Bank> banks = from x in allbanks  // select banks, which have chosen valuta
                                      where x.Valutas.Find(y=>y.Cipher==valuta.SelectedItem.ToString())!=null
                                      select x;

            foreach (Bank bank in banks)
            {
                RateTable.Rows.Add();

                RateTable.Rows[currentRow].Cells[0].Value = bank.Name;
                RateTable.Rows[currentRow].Cells[1].Value = bank.Valutas.Find(x=>x.Cipher.Equals(valuta.SelectedItem.ToString())).Buying.ToString(); //get valuta's buying price
                RateTable.Rows[currentRow].Cells[2].Value = bank.Valutas.Find(x => x.Cipher.Equals(valuta.SelectedItem.ToString())).Selling.ToString(); //get valuta's selling price

                currentRow++;

            }


        }

        private void DictionaryButton_Click(object sender, EventArgs e)
        {
            DictionaryForm dictionary = new DictionaryForm();
            dictionary.Show();
        }
    }
}
