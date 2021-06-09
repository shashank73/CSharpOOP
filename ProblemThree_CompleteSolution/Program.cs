using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemThree_CompleteSolution_BL;
namespace ProblemThree_CompleteSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //SampleCodeToTestYourclassimplementation
            var organicpricedict = new dictionary<int, double>();
            //key 1 for first product
            organicpricedict.add(1, 234.10);
            //key 2 for second product
            organicpricedict.add(2, 100.100);
            var gosobj = new gourmetorganicshop(1, "non polished tur dal", organicpricedict);
            var gostwoobj = new gourmetorganicshop(2, "non polished tur dal", organicpricedict);
            int quantitytobuy = 2;
            int quantityingrams = 200;
            console.writeline("the total cost for {0} packets of {1} is {2}/- inr", quantitytobuy,gosobj.itemname,gosobj.payperpiece(quantitytobuy));
            console.writeline("the total cost for {0} grams of {1} is {2}/- inr", quantityingrams, gostwoobj.itemname, gostwoobj.payperpiece(quantitytobuy));
                      
            var coffeepricedict = new dictionary<int, double>();
            //key 1 for first product
            coffeepricedict.add(1, 400.40);
            //key 2 for second product
            coffeepricedict.add(2, 250.50);
            var coffobj = new gourmetcoffeeshop(1, "arabica coffee powder pre-packed container", coffeepricedict);
            var cofftwoobj = new gourmetorganicshop(2, "arabica coffee poweder", organicpricedict);
            int quantitytobuycoffee = 2;
            int quantityingramscoffee = 200;
            console.writeline("the total cost for {0} packets of {1} is {2}/- inr", quantitytobuycoffee, coffobj.itemname, coffobj.payperpiece(quantitytobuy));
            console.writeline("the total cost for {0} grams of {1} is {2}/- INR", quantityInGramsCoffee, coffTwoObj.ItemName, coffTwoObj.PayPerPiece(quantityToBuy));


        }
    }
}
