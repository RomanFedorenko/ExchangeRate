using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ExchangeRate
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var url = "http://resources.finance.ua/ua/public/currency-cash.xml";
            XmlDocument data = new XmlDocument();
            data.Load(url);
            int currentRow = 0;
            XmlNodeList banksList = data.SelectNodes("//organization[currencies/c[@id='USD']]"); //get all banks, which have USD
            foreach (XmlNode bank in banksList)
            {

                RateTable.Rows.Add();

                RateTable.Rows[currentRow].Cells[0].Value = bank.ChildNodes[0].Attributes[0].Value.ToString(); //get bank name
                XmlNode currencies = bank.SelectSingleNode("currencies/c[@id='USD']");

                RateTable.Rows[currentRow].Cells[1].Value = currencies.Attributes[1].Value.ToString(); //get usd buying price
                RateTable.Rows[currentRow].Cells[2].Value = currencies.Attributes[2].Value.ToString(); //get usd selling price
                currentRow++;




            }
        }
    }
}
