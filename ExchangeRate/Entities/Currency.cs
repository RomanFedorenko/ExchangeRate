using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRate
{
    public class Currency: Valuta
    {        
        private float buying;
        private float selling;

        public Currency(string cipher, float buying, float selling)
        {
            Cipher = cipher ?? throw new ArgumentNullException(nameof(cipher));
            Buying = buying;
            Selling = selling;
        }

       
        public float Buying { get => buying; set => buying = value; }
        public float Selling { get => selling; set => selling = value; }

        

    }
}
