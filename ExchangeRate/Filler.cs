using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExchangeRate
{
    public static class Filler
    {
        static string url = File.ReadAllLines("../../URL.txt").First();
        static XmlDocument data = new XmlDocument();

        public static List<Bank> GetAllBanks()
        {
            List<Bank> banksList = new List<Bank>();
            data.Load(url);


            XmlNodeList organizationsNodeList = data.SelectNodes("//organization");//get all banks from XML
            foreach (XmlNode bank in organizationsNodeList)
            {
                Bank currBank = new Bank(bank.SelectSingleNode("title").Attributes["value"].Value); //choosing of a bank (and adding it's name)

                XmlNodeList currencies = bank.SelectNodes("currencies/c");//choosing currencies of current bank
                foreach (XmlNode valuta in currencies) //filling currencies of the current bank
                {

                    Currency currValuta = new Currency(valuta.Attributes["id"].Value,
                                                   Convert.ToSingle(valuta.Attributes["br"].Value, new CultureInfo("en-US")),
                                                   Convert.ToSingle(valuta.Attributes["ar"].Value, new CultureInfo("en-US"))
                        );
                    currBank.Valutas.Add(currValuta);
                }

                banksList.Add(currBank);
            }



            return banksList;
        }

        public static List<Valuta> GetValutasDictionary()
        {
            List<Valuta> valutas = new List<Valuta>();


            return valutas;
        }
    }
}
