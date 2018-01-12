using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRate
{
    public class Valuta
    {
        private string fullname;
        private string cipher;

        public Valuta()
        {
        }

        public string Cipher
        {
            get { return cipher; }
            set { cipher = value; }
        }

        public string FullName
        {
            get { return fullname; }
            set { fullname = value; }
        }

    }
}
