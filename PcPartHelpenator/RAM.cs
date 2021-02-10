using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcPartHelpenator
{
    public class RAM
    {
        public string RAMType { get; set; }
        public string RAMSpeed { get; set; }
        public string RAMSize { get; set; }
        public int RAMPrice { get; set; }
        public int RAMRating { get; set; }
        public RAM(string ramtype,string ramspeed,string ramsize,int ramprice,int ramrating)
        {
            RAMType = ramtype;
            RAMSpeed = ramspeed;
            RAMSize = ramsize;
            RAMPrice = ramprice;
            RAMRating = ramrating;
        }
        public RAM()
        {

        }

    }
}
