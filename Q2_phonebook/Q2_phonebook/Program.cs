using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_phonebook
{
    public class Phonebook
    {
        public string name;
        public string phonenumber;
    }
    public class student : Phonebook
    {
        public int age;
        public ArrayList a;
        public Dictionary<string, ArrayList> data;
        public student(int age, string name, string phonenumber)
        {
            this.age = age;
            this.name = name;
            this.phonenumber = phonenumber;
            a = new ArrayList();
            a.Add(age);
            a.Add(phonenumber);
            data = new Dictionary<string, ArrayList>();
            data.Add(name, a);
        }

        public Dictionary<string, ArrayList> Student_data()
        {
            return data;
        }
    }

    public class service : student
    {
        public string profession;
        public service(int age, string name, string phonenumber, string profession) : base(age, name, phonenumber)
        {
            this.profession = profession;
            a.Add(profession);
        }

    }

    internal class program
    {
        static void Main(String[] args)
        {
            student a = new student(22, "Rounak", "9073623298");
            foreach (string key in a.Student_data().Keys)
            {
                Console.Write(key + ":");
                foreach (var value in a.Student_data()[key])
                {
                    Console.Write(value + " ");
                }
            }
            Console.WriteLine("\n");
            service b = new service(31, "Sonali", "7978668077", "Doctor");
            foreach (string key in b.Student_data().Keys)
            {
                Console.Write(key + ":");
                foreach (var value in b.Student_data()[key])
                {
                    Console.Write(value + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
