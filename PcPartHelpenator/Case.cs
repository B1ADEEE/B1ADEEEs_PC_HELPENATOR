using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcPartHelpenator
{
    public class Case
    {
        public string CaseName { get; set; }
        public string CaseSize { get; set; }
        public string CaseLooks { get; set; }
        public int CasePrice { get; set; }
        public int CaseRating { set; get; }
        public Case(string casename,string casesize,string caselooks,int caseprice,int caserating)
        {
            CaseName = casename;
            CaseSize = casesize;
            CaseLooks = caselooks;
            CasePrice = caseprice;
            CaseRating = caserating;
        }
        public Case()
        {

        }
        public override string ToString()
        {
            return CaseName;
        }
    }
}
