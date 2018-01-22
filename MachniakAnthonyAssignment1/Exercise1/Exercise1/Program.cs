/* Author: Anthony Machniak
 * Start Date: 1/11/18
 * Title: CITP 180 - Chapter 1 - Exercise 1
 * Description: Write a program that displays the traditional "Hello World" message with a personal introduction.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Hello World! My name is Anthony Machniak!");
            Console.ReadKey();
        }
    }
}
