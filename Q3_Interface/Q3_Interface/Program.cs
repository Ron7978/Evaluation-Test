using System;

public class Q3_Interface
{
    public interface Vehicle
    {
        void Drive();
        bool Refuel(int amount);
    }

    public class Car : Vehicle
    {
        public int Fuel { get; set; }

        public Car(int fuel)
        {
            Fuel = fuel;
        }

        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("\n\tDriving");
            }
            else
            {
                Console.WriteLine("\n\tNo fuel");
            }
        }

        public bool Refuel(int amount)
        {
            Fuel += amount;
            return true;
        }
        public static void Main(string[] args)
        {
            Car car = new Car(0);

            Console.Write("Enter the ammount of fuel : ");
            int fuel = int.Parse(Console.ReadLine());
            if (car.Refuel(fuel))
            {
                car.Drive();
            }
            Console.ReadLine();
        }
    }
}