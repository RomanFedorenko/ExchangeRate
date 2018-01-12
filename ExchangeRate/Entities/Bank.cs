using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRate
{
    public class Bank
    {
        private string name;
        private List<Currency> valutas;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        

        public Bank(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Valutas = new List<Currency>();
        }

        public List<Currency> Valutas
        {
            get { return valutas; }
            set { valutas = value; }
        }



    }
}
