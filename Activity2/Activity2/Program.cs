using Activity2;
using System;

namespace Activity2
{
    public class Car
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        
        public void Honk(string stringVariable)
        {
            Console.WriteLine($"{stringVariable}: Honk!!!");
        }
    }
}

class Progress
{
    static void Main(string[] args)
    {
        List<Car> List = new List<Car>();
        while (true)
        {
            Console.WriteLine("Enter new data? [Y/N]");

            if(Console.ReadLine() == "N")
            {
                break;
            }

            Car car1 = new Car();

            Console.WriteLine("Enter car Brand = ");
            car1.Brand = Console.ReadLine();

            Console.WriteLine("Enter car Color = ");
            car1.Color = Console.ReadLine();

            Console.WriteLine("Enter car Price = ");
            car1.Price = int.Parse (Console.ReadLine());

            List.Add(car1);

            List.ForEach(x =>
            {

            }

        }
    }
}