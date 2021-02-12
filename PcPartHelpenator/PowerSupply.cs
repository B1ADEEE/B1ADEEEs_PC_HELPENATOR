using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcPartHelpenator
{
    public class PowerSupply
    {
        public string PSUWatts { get; set; }
        public string PSUBrand { get; set; }
        public int PSUPrice { get; set; }
        public int PSURating { get; set; }
        public PowerSupply(string psuwatts, string psubrand,int psuprice,int psurating)
        {
            PSUWatts = psuwatts;
            PSUBrand = psubrand;
            PSUPrice = psuprice;
            PSURating = psurating;
        }
        public PowerSupply()
        {

        }
        public override string ToString()
        {
            return PSUBrand + " - " + PSUWatts;
        }
    }
}
