using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcPartHelpenator
{
    public class GPU
    {
        public string GPUName { get; set; }
        public string GPUSocketType { get; set; }
        public int GPUWatts { get; set; }
        public int GPUPrice { get; set; }
        public int GPURating { get; set; }
        public GPU(string gpuname, string gpusockettype, int gpuwatts, int gpuprice, int gpurating)
        {
            GPUName = gpuname;
            GPUSocketType = gpusockettype;
            GPUWatts = gpuwatts;
            GPUPrice = gpuprice;
            GPURating = gpurating;
        }
        public GPU()
        {

        }
    }
}
