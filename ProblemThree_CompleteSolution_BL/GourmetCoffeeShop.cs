using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetCoffeeShop : GourmetShop, ITaxCompute
    {
        double total, price;

        public double TotalBillValue
        {
            get { }
            set { }
        }

        public GourmetCoffeeShop(int iCode, string iName, Dictionary<int, double> iPrice)
        {
            price = iPrice[code];
        }

        public override double PayPerPiece(int quantity)
        {
            total = quantity * price;
            return (total);
        }

        public override double PayPerWeight(int weight)
        {

        }

        public double TaxOnTotalBill()
        {

        }
    }
}
