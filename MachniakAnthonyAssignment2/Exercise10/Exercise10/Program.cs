using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Author: Anthony Machniak
 * Start Date: 1/23/17
 * Title: CITP 180 - Chapter 2 - Exercise 10
 * Description: Convert weight from metric to U.S. units. No user inputs for prices.
 */


namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {

            double poutineGrams = 1.29; //price of poutine per 100 grams
            double haricotGrams = 0.75; //price of haricot verts per 100 grams

            double pounds = 0.220462; //amount of pounds per 100grams

            double poutineConversion = poutineGrams / pounds;
            double haricotConversion = haricotGrams / pounds;

            Console.WriteLine("Price of Poutine per 100 grams: {0:C}", poutineGrams);
            Console.WriteLine("Price of Poutine per 1 pound: {0:C}", poutineConversion);
            Console.WriteLine("Price of Haricot Verts per 100 grams: {0:C}", haricotGrams);
            Console.WriteLine("Price of Haricot Verts per 1 pound: {0:C}", haricotConversion);
            Console.ReadKey();
        }
    }
}
