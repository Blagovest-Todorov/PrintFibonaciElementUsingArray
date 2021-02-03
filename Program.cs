using System;
using System.Linq;

namespace ArrayPrintingFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please provide number for FibonacciRowMemeber You want to print, in interval [1 till 46]");
            int nElement = int.Parse(Console.ReadLine()); // read nArticle that You want to print from FibonacciRow
            
            if (nElement <= 0 || nElement >= 47) //when n >= 47 integer DataType overflows/ when n<=0 there is not a such memberIndex into the Row
            {
                Console.WriteLine("Dear User , please enter a positive number > 0");
            }
            else 
            {
                int[] arrFibonaci = new int[nElement]; // create an array with nElements

                //We have to fill the array to the last -> n element, how to do this, We know the value of index 1 and index 2]
                int length = arrFibonaci.Length;

                if (length == 1)
                {
                    arrFibonaci[0] = 1;
                    // Console.WriteLine(arrFibonaci[0]);
                }

                if (length == 2)
                {
                    arrFibonaci[1] = 1;
                    // Console.WriteLine(arrFibonaci[]);
                }

                if (length > 2)
                {
                    arrFibonaci[0] = 1;
                    arrFibonaci[1] = 1;

                    for (int i = 2; i < arrFibonaci.Length; i++)
                    {
                        arrFibonaci[i] = arrFibonaci[i - 1] + arrFibonaci[i - 2]; //We fill the arrFibonaci with numbers,till last desired element
                                                                                  // Console.WriteLine(arrFibonaci[i]); // We print every filled element here
                    }
                }

                Console.WriteLine();
                Console.WriteLine(arrFibonaci[arrFibonaci.Length - 1]); // We print the last Element , so desired by the client
            }
        }
    }
}
