using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcPartHelpenator
{
    public class MotherBoard
    {
        public string MotherboardName { get; set; }
        public string MotherboardSocket { get; set; }
        public string MotherboardSize { get; set; }
        public string MotherboardRam { get; set; }
        public int MotherBoardMaxRam { get; set; }
        public int MotherboardPrice { get; set; }
        public int MotherboardRating { get; set; }
        public MotherBoard(string motherboardname,string motherboardsocket,string motherboardsize,string motherboardram,int motherboardmaxram,int motherboardprice,int motherboardrating)
        {
            MotherboardName = motherboardname;
            MotherboardSocket = motherboardsocket;
            MotherboardSize = motherboardsize;
            MotherboardRam = motherboardram;
            MotherBoardMaxRam = motherboardmaxram;
            MotherboardPrice = motherboardprice;
            MotherboardRating = motherboardrating;
        }
        public MotherBoard()
        {

        }
        public override string ToString()
        {
            return MotherboardName;
        }
    }
}
