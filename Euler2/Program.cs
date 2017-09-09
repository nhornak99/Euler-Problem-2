/*
    By considering the terms in the Fibonacci sequence
    whose values do not exceed four million, find the
    sum of the even-valued terms.
*/

using System;
using System.Collections.Generic;

namespace Euler2
{
    class Program
    {
        public static int maximumTerm = 4000000;

        static void Main(string[] args)
        {
            List<int> listOfTerms = new List<int>();
            // Add the first 2 fibonacci terms to the list.
            listOfTerms.Add(1);
            listOfTerms.Add(2);
            int sumOfEvenTerms = 0;

            // Fibonacci calculator - calculates the next fibonacci term and adds it t the list.
            for (int i = 0; lessThanLimit(i + 1, listOfTerms); i++)
            {
                int newTerm = listOfTerms[i] + listOfTerms[i + 1];
                listOfTerms.Add(newTerm);
            }

            // Filters out the odd terms and adds the even terms to the sum
            foreach (var term in listOfTerms)
            {
                if (term % 2 == 0)
                {
                    sumOfEvenTerms += term;
                }
            }

            Console.Write("The sum of all the even fibonacci numbers less than 4 million is: {0}", sumOfEvenTerms);
            Console.Read();
        }

        // Function that checks if the last term added to list is greater than the maximum.
        public static bool lessThanLimit(int termIndex, List<int> list)
        {
            if (list[termIndex] + list[termIndex - 1] < maximumTerm)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
