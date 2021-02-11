using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Product
    {
        public int productNumber;
        private int productID;
        public string name;
        public int price;

        public Product (string pName, int pID, int pNumber, int pPrice) {
            name = pName;
            productID = pID;
            productNumber = pNumber;
            price = pPrice;
        }

    }
}
