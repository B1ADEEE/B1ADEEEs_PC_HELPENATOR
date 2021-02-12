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
        public int CaseLooks { get; set; }
        public int CasePrice { get; set; }
        public int CaseRating { set; get; }
        public Case(string casename,string casesize,int caselooks,int caseprice,int caserating)
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
        public void CaseChoice(int CaselooksIs)
        {
            if (CaseLooks == 1)
            {
                CaselooksIs = 1;
            }
            else if (CaseLooks == 2)
            {
                CaselooksIs = 2;
            }
            else
            {
                CaselooksIs = 3;
            }
        }
    }
}
