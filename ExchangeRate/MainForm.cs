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
        string url = File.ReadAllLines("../../URL.txt").First();
        XmlDocument data = new XmlDocument();
      

        public MainForm()
        {
            InitializeComponent();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Filler.GetAllBanks();
            LoadValuta();
            RefreshTable();
            
        }

        private void valuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTable();
           
        }
        public void LoadValuta() {
            data.Load(url);
            XmlNodeList currencyList = data.SelectNodes("//c[@title]");
            foreach (XmlNode currency in currencyList)
            {

                valuta.Items.Add(currency.Attributes["id"].Value);

            }
            valuta.SelectedItem = "USD";
        }

        public void RefreshTable() {
            data.Load(url);
            RateTable.Rows.Clear();          
            int currentRow = 0;
            XmlNodeList banksList = data.SelectNodes("//organization[currencies/c[@id='" + valuta.SelectedItem.ToString() + "']]"); //get all banks, which have USD
            foreach (XmlNode bank in banksList)
            {

                RateTable.Rows.Add();

                RateTable.Rows[currentRow].Cells[0].Value = bank.ChildNodes[0].Attributes[0].Value.ToString(); //get bank name
                XmlNode currencies = bank.SelectSingleNode("currencies/c[@id='" + valuta.SelectedItem.ToString() + "']");

                RateTable.Rows[currentRow].Cells[1].Value = currencies.Attributes["br"].Value.ToString(); //get valuta buying price
                RateTable.Rows[currentRow].Cells[2].Value = currencies.Attributes["ar"].Value.ToString(); //get valuta selling price
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
