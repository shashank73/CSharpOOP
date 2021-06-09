using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public abstract class GourmetShop
    {       
        int itemCode;
        string itemName;

        public GourmetShop(int iCode, string iName)
        {
            itemCode = iCode;
            itemName = iName;
        }

        public int ItemCode 
        { 
            get { return itemCode; }
            set { itemCode = value; }
        }

        public string ItemName 
        { 
            get { return itemName; }
            set { itemName = value; }
        }

        public double ItemPrice { get; set;}

        public abstract double PayPerPiece(int quantity);
        public abstract double PayPerWeight(int weight);

    }
}