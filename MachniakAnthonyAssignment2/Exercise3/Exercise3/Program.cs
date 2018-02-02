using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Author: Anthony Machniak
 * Start Date: 1/23/17
 * Title: CITP 180 - Chapter 2 - Exercise 3
 * Description: Computes average of 5 exam scores. No user input for scores.
 */

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int exam1 = 82,
                exam2 = 40,
                exam3 = 63,
                exam4 = 95,
                exam5 = 79;

            int numberOfExams = 5;

            float examAverage;
            examAverage = (exam1 + exam2 + exam3 + exam4 + exam5) / (float) numberOfExams;

            Console.WriteLine("The score on exam #1 is: {0:F0}%", exam1);
            Console.WriteLine("The score on exam #2 is: {0:F0}%", exam2);
            Console.WriteLine("The score on exam #3 is: {0:F0}%", exam3);
            Console.WriteLine("The score on exam #4 is: {0:F0}%", exam4);
            Console.WriteLine("The score on exam #5 is: {0:F0}%", exam5);
            Console.WriteLine("The average of all {0:F0} exams is: {1:F2}%", numberOfExams, examAverage);
            Console.ReadKey();

        }
    }
}
