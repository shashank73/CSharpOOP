using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public abstract class GourmetShop
    {       
        int code;
        string Name;
        Dictionary<int, double> price = new Dictionary();

        public GourmetShop(int iCode, string iName)
        {
            this.code = iCode;
            this.Name = iName;
        }
        public int ItemCode 
        { 
            get { return code; }
            set { this.code = value; }
        }
        public string ItemName 
        { 
            get { return name; }
            set { this.Name = value; }
        }
        public double ItemPrice 
        {
            get { return price[code]; } 
            set { price[code] = value; }
        }
        public abstract double PayPerPiece(int quantity);
        public abstract double PayPerWeight(int weight);

    }
}