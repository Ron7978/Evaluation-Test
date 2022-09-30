using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_Abstact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name of bird : ");
            parrot dog = new parrot();
            //Console.WriteLine("Name : ");
            dog.SetName(Console.ReadLine());
            Console.WriteLine("Status : ");
            Console.WriteLine(dog.GetName());
            dog.Fly();

            Console.ReadLine();
        }

        public class parrot : Bird
        {
            public override void Fly()
            {
                Console.WriteLine("Flying");
            }
        }

        public abstract class Bird
        {
            private string Name;

            public void SetName(string name)
            {
                Name = name;
            }

            public string GetName()
            {
                return Name;
            }

            public abstract void Fly();
        }
    }
}