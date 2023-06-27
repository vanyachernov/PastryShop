using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweetshop
{
    class Prices
    {
        public string MinValue { get; set; }
        public string MaxValue { get; set; }
        
        public Prices(string minValue, string maxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }
    }
}
