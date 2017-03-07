using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopsAndArrays
{
    class ForLoopsAndArraysDemo
    {
        static void Main(string[] args)
        {
            //creates an array
            int[] array = new int[] { 1, 2, 3, 4 };

            Console.WriteLine("Iterating through a single-dimensional array using a for loop:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            //creates a 3x3 multidimensional array
            int[,] anArray = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            //using nested for loops to iterate through the array
            //notice that j will iterate from 0-2 for every iteration of i
            Console.WriteLine("\n\nIterating through a multidimensional array using nested for loops:");
            for (int i = 0; i < 3; i++)                   //i is used to refer to which row is being accessed
            {
                for (int j = 0; j < 3; j++)               //j is used to refer to which column is being accessed
                {
                    Console.Write("{0} ", anArray[i, j]); //writes the value at the index i,j to the console
                }
                Console.Write("\n");                      //line break to represent a new row
            }

            Console.WriteLine("\nIterating through an array using the foreach statement:");
            //using the foreach statement to iterate through the array
            //every index is accessed in order
            foreach (int i in anArray)
            {
                System.Console.Write("{0} ", i);          //writes the value at the current index to the console
            }

            //nested for loops can also be used to access an array backwards
            Console.WriteLine("\n\nIterating through a multidimensional array backwards with nested for loops:");
            for (int i = 2; i >= 0; i--)
            {
                for (int j = 2; j >= 0; j--)
                {
                    Console.WriteLine("{0} is the value at anArray[{1}, {2}].", anArray[i, j], i, j);
                }
            }

            //more dimensions? no problem, just nest another for loop inside the others!
            int[,,] thirdArray = new int[2, 2, 2] { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } }; //creates a 2x2x2 3D array
            Console.WriteLine("\nIterating through a three-dimensional array using nested for loops:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.WriteLine("{0} is the value at thirdArray[{1}, {2}, {3}].", thirdArray[i, j, k], i, j, k);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
