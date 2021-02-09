using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcPartHelpenator
{
    public class RAM
    {
        public string RAMBrand { get; set; }
        public string RAMType { get; set; }
        public string RAMSpeed { get; set; }
        public int RAMPrice { get; set; }
        public int RAMRating { get; set; }
        public RAM(string rambrand,string ramtype,string ramspeed,int ramprice,int ramrating)
        {
            RAMBrand = rambrand;
            RAMType = ramtype;
            RAMSpeed = ramspeed;
            RAMPrice = ramprice;
            RAMRating = ramrating;
        }
        public RAM()
        {

        }

    }
}
