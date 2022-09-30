using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Q7_Collections
{
    class members
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }
    internal class Person
    {
        Queue<members> queue;
        public Person()
        {
            queue = new Queue<members>();

        }

        public void ToString(members members)
        {
            queue.Enqueue(members);
            Thread.Sleep(1000);
            Console.WriteLine($"Name: {members.Name} Age: {members.Age}\n");
        }

        public void ToProcess()
        {
            if (queue.Any())
            {
                var members = queue.Dequeue();
                Thread.Sleep(1000);
                Console.WriteLine($"Processed\nName: {members.Name} Age: {members.Age}");
            }
        }

        public void ShowQueue()
        {
            Console.WriteLine("\nCurrent queue\n");
            foreach (var person in queue)
            {
                Thread.Sleep(500);
                members m = new members();
                Console.WriteLine(m.Name);
                Console.WriteLine(m.Age);
            }
        }
    }
}
