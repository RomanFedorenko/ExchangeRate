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
    public partial class DictionaryForm : MaterialForm
    {
        string url = File.ReadAllLines("../../URL.txt").First();
        XmlDocument data = new XmlDocument();

        public DictionaryForm()
        {
            InitializeComponent();
        }

        private void DictionaryForm_Load(object sender, EventArgs e)
        {
            data.Load(url);
            XmlNodeList currencyList = data.SelectNodes("//c[@title]");
            foreach (XmlNode currency in currencyList)
            {
                string[] row = { currency.Attributes["id"].Value, currency.Attributes["title"].Value };
                var listViewItem = new ListViewItem(row);
                DictListView.Items.Add(listViewItem);
                
            }
        }
    }
}
