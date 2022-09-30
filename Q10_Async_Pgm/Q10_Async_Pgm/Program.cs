using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10_Async_Pgm
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            flowerDecoration();
            cheifGuestPicked();
            foodArea();
            giftArranged();
            functionStarted();
            Console.ReadKey();
        }
        static async void flowerDecoration()
        {
            Console.WriteLine("Flower decorations will be completed");
        }
        static async void cheifGuestPicked()
        {
            Console.WriteLine("Chief guest getting picked up from the airport");
            await Task.Delay(5000);
            Console.WriteLine("Chief Guest Arrived");
        }
        static async void giftArranged()
        {
            await Task.Delay(4000);
            Console.WriteLine("The gifts arranged will be distributed on stage ");
        }
        static async void functionStarted()
        {
            await Task.Delay(6000);
            Console.WriteLine("Start the function as soon as the Chief guest arrives at the venue. ");
        }
        static async void foodArea()
        {
            Console.WriteLine("Food Area is Set for guests");

        }
    }
}
