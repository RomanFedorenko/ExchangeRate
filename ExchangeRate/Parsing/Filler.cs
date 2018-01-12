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
                                                   Single.Parse(valuta.Attributes["br"].Value,NumberStyles.Float, new CultureInfo("en-US")),
                                                   Single.Parse(valuta.Attributes["ar"].Value, NumberStyles.Float, new CultureInfo("en-US"))
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

            data.Load(url);
            XmlNodeList valutasNodeList = data.SelectNodes("//c[@title]");
            foreach (XmlNode valuta in valutasNodeList)
            {
                Valuta currvaluta = new Valuta();
                currvaluta.FullName = valuta.Attributes["title"].Value;
                currvaluta.Cipher = valuta.Attributes["id"].Value;

                valutas.Add(currvaluta);

            }

            return valutas;
        }
    }
}
