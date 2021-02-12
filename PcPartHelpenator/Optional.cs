using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcPartHelpenator
{
    public class Optional
    {
        public string OptionalType { get; set; }
        public string OptinalName { get; set; }
        public int OptionalPrice { get; set; }
        public int OptionalRating { get; set; }
        public Optional(string optionaltype, string optionalname, int optionalprice,int optionalrating)
        {
            OptionalType = optionaltype;
            OptinalName = optionalname;
            OptionalPrice = optionalprice;
            OptionalRating = optionalrating;
        }
        public Optional()
        {

        }
        public override string ToString()
        {
            return OptinalName;
        }
    }
}
