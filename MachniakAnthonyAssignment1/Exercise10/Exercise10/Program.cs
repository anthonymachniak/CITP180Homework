/* Author: Anthony Machniak
 * Start Date: 1/11/18
 * Title: Assignment 1 - Chapter 1 - Exercise 10
 * Description: Write a program that displays your initials in block characters
 *              so that each letter is made up of the character that it represents.
 *              Output should be at least 10 rows and all initials must appear.
 * 
 */ 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            string Space = "   ";

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            //Line 1 of Text
            Console.Write(" AAAAAAA ");
            Console.Write(Space);
            Console.Write("JJJJJJJJJ");
            Console.Write(Space);
            Console.Write("M         M");
            Console.WriteLine();

            //Line 2 of Text
            Console.Write("AAAAAAAAA");
            Console.Write(Space);
            Console.Write("    JJ   ");
            Console.Write(Space);
            Console.Write("MM       MM");
            Console.WriteLine();

            //Line 3 of Text
            Console.Write("AA     AA");
            Console.Write(Space);
            Console.Write("    JJ   ");
            Console.Write(Space);
            Console.Write("M M     M M");
            Console.WriteLine();

            //Line 4 of Text
            Console.Write("AA     AA");
            Console.Write(Space);
            Console.Write("    JJ   ");
            Console.Write(Space);
            Console.Write("M  M   M  M");
            Console.WriteLine();

            //Line 5 of Text
            Console.Write("AA     AA");
            Console.Write(Space);
            Console.Write("    JJ   ");
            Console.Write(Space);
            Console.Write("M   M M   M");
            Console.WriteLine();

            //Line 6 of Text
            Console.Write("AAAAAAAAA");
            Console.Write(Space);
            Console.Write("    JJ   ");
            Console.Write(Space);
            Console.Write("M    M    M");
            Console.WriteLine();

            //Line 7 of Text
            Console.Write("AA     AA");
            Console.Write(Space);
            Console.Write("J   JJ   ");
            Console.Write(Space);
            Console.Write("M         M");
            Console.WriteLine();

            //Line 8 of Text
            Console.Write("AA     AA");
            Console.Write(Space);
            Console.Write("JJ  JJ   ");
            Console.Write(Space);
            Console.Write("M         M");
            Console.WriteLine();

            //Line 9 of Text
            Console.Write("AA     AA");
            Console.Write(Space);
            Console.Write("JJJJJJ   ");
            Console.Write(Space);
            Console.Write("M         M");
            Console.WriteLine();

            //Line 10 of Text
            Console.Write("AA     AA");
            Console.Write(Space);
            Console.Write(" JJJJ    ");
            Console.Write(Space);
            Console.Write("M         M");
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
