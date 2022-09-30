using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_min_max_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the elements of the array : ");
            for (int i = 0; i < arr.Length; i++)
            { 
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Minimum number is " + arr.Min());
            Console.WriteLine("Maximum number is " + arr.Max());
            Console.ReadLine();
            
        }
    }
}
