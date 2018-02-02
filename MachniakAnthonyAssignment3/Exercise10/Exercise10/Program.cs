using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Author: Anthony Machniak
 *  Start Date: 2/1/18
 *  Title: Chapter 3 - Exercise 10
 *  Description: Property tax calculator. Millage is $10.03 per $1000 in value.
 *  $25,000 in exemptions. Property values increased by 2.7% from the previous year.
 */
  
namespace Exercise10
{
    public class Program
    {
        public static void Main()
        {
            double previousPropertyValue, currentPropertyValue, taxablePropertyValue, exemptions, millage;

            previousPropertyValue = InputPreviousPropertyValue();
            currentPropertyValue = PropertyValueCalculator(previousPropertyValue);
            
            exemptions = 25000; //$25,000 off of assessed home value

            taxablePropertyValue = currentPropertyValue - exemptions;
            millage = MillageCalculator(taxablePropertyValue);

            DisplayPropertyValue(previousPropertyValue, currentPropertyValue, exemptions, taxablePropertyValue, millage);
        }

        public static double InputPreviousPropertyValue()
        {
            string previousPropertyValueInput, address;
            double previousPropertyValue;

            Console.WriteLine("Please enter your address: ");
            address = Console.ReadLine();

            Console.WriteLine("Please enter the value of your home in the previous tax year: ");
            previousPropertyValueInput = Console.ReadLine();
            previousPropertyValue = double.Parse(previousPropertyValueInput);

            return previousPropertyValue;
        }

        public static double PropertyValueCalculator(double previousPropertyValue)
        {
            double propertyValueIncrease = 0.027; //2.7% increase in property value
            double currentPropertyValue;

            currentPropertyValue = previousPropertyValue + previousPropertyValue * propertyValueIncrease;

            return currentPropertyValue;
        }

        public static double MillageCalculator(double propertyValue)
        {
            double millage = 10.03/1000; //$10.03 per $1000 assessed value
            double millageTax;

            millageTax = propertyValue * millage;

            return millageTax;
        }

        public static void DisplayPropertyValue(double previousPropertyValue, double currentPropertyValue, double exemptions, double taxablePropertyValue, double millage)
        {
            Console.WriteLine("{0, -60} {1:C}", "This is the previous property value of your home: ", previousPropertyValue);
            Console.WriteLine("{0, -60} {1:C}", "This is the current property value of your home: ", currentPropertyValue);
            Console.WriteLine("{0, -60} {1:C}", "This is the amount you get in exemptions: ", exemptions);
            Console.WriteLine("{0, -60} {1:C}", "This is the value your taxes are based off of: ", taxablePropertyValue);
            Console.WriteLine("{0, -60} {1:C}", "This is the amount owed for property taxes and millages: ", millage);
            Console.ReadKey();
        }
    }
}
