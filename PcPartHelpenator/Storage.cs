using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcPartHelpenator
{
    public class Storage
    {
        public string StorageType { get; set; }
        public string StorageSize { get; set; }
        public int StoragePrice { get; set; }
        public int StorageRating { get; set; }
        public Storage(string storagetype,string storagesize,int storageprice,int storagerating)
        {
            StorageType = storagetype;
            StorageSize = storagesize;
            StoragePrice = storageprice;
            StorageRating = storagerating;
        }
        public Storage()
        {

        }
        public override string ToString()
        {
            return StorageSize + " - " + StorageType;
        }
    }
}
