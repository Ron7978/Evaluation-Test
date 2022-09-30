using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Q7_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.ToString(new members { Name = "Rounak", Age = 22 });
            p.ToString(new members { Name = "Sonali", Age = 21 });
            p.ToString(new members { Name = "Akshat", Age = 23 });
            p.ToString(new members { Name = "sameer", Age = 30 });
            p.ToString(new members { Name = "Rony", Age = 20 });

            p.ToProcess();
            p.ShowQueue(); 
            Console.ReadKey();
        }
    }
}
