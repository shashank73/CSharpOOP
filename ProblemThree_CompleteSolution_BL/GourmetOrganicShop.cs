using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetOrganicShop : GourmetShop,ITaxCompute
    {
        double total;
        double price;

        public double TotalBillValue
        {
            get { }
            set { }
        }

        public GourmetOrganicShop(int iCode, string iName, Dictionary<int, double> iPrice)
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
