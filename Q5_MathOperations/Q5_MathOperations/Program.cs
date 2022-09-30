using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_MathOperations
{
    public delegate void cal(int i);
    internal class Program
    {
        public static void factorial(int a)
        {
            int m = 1;
            for (int i = a; i >= 1; i--)
            {
                m *= i;
            }
            Console.WriteLine("Factorial : " + m);
        }

        public static void table(int a)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(" " + a * i);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the no of get the table : ");
            int a = Convert.ToInt32(Console.ReadLine());
            cal obj = new cal(table);
            obj.Invoke(a);

            Console.WriteLine("\n\n-----------------------------------\n");

            obj = factorial;
            Console.Write("Enter the no to get factorial : ");
            int b = Convert.ToInt32(Console.ReadLine());
            obj.Invoke(b);

            Console.ReadLine();
        }
    }
}
