using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetOrganicShop : GourmetShop, ITaxCompute
    {
        double total = 0;
        double price;

        public GourmetOrganicShop(int iCode, string iName, Dictionary<int, double> iPrice) 
            : base(iCode, iName)
        {
            price = iPrice[iCode];
        }

        public double TotalBillValue
        {
            get
            {
                return total;
            }
        }

        public override double PayPerPiece(int quantity)
        {
            try 
            { 
                total = quantity * price;
                TaxOnTotalBill();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error type: {e.Message}");
            }
            return (total);
        }

        public override double PayPerWeight(int weight)
        {
            try
            { 
                double weightInKgs = Convert.ToDouble(weight) / 1000;
                total = weightInKgs * price;
                double totalAfterTax = TaxOnTotalBill();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error type: {e.Message}");
            }
            return (total);
        }

        public double TaxOnTotalBill()
        {
            double taxRate = 18; // GST rate assumend
            total += (total * (taxRate / 100));
            return (total);
        }
    }
}
