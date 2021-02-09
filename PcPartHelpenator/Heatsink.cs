using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcPartHelpenator
{
    public class Heatsink
    {
        public string HeatsinkName {get;set;}
        public string HeatsinkSocket { get; set; }
        public int HeatsinkPrice { get; set; }
        public int HeatsinkRating { get; set; }
        public Heatsink(string heatsinkname,string heatsinksocket,int heatsinkprice,int heatsinkrating)
        {
            HeatsinkName = heatsinkname;
            HeatsinkSocket = heatsinksocket;
            HeatsinkPrice = heatsinkprice;
            HeatsinkRating = heatsinkrating;
        }
        public Heatsink()
        {

        }
    }
}
