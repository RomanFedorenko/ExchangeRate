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
            List<Valuta> valutas = Filler.GetValutasDictionary();
            
            foreach (Valuta valuta in valutas)
            {
                string[] row = { valuta.Cipher, valuta.FullName };
                var listViewItem = new ListViewItem(row);
                DictListView.Items.Add(listViewItem);
                
            }
        }
    }
}
