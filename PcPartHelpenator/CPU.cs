using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcPartHelpenator
{
    public class CPU
    {
        public string CPUName { get; set; }
        public string CPUSocketType { get; set; }
        public int CPUWatts { get; set; }
        public int CPUPrice { get; set; }
        public int CPURating { get; set; }

        public CPU (string cpuname,string cpusockettype,int cpuwatts,int cpuprice,int cpurating)
        {
            CPUName = cpuname;
            CPUSocketType = cpusockettype;
            CPUWatts = cpuwatts;
            CPUPrice = cpuprice;
            CPURating = cpurating;
        }
        public CPU()
        {

        }
        public override string ToString()
        {
            return CPUName;
        }
    }
}
