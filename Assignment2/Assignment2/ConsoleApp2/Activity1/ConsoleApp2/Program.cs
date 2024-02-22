using System;

namespace Activity1; 

    public class Math
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Sub(int num1, int num2)
        {
            return num1 - num2;

        }
        public int Multi(int num1, int num2)
        {
        return num1 * num2;
        }

        public int Div(int num1, int num2)
        {
        return num1 / num2;
        }
    }







class Program
{
    static void Main(string[] args)
    {
        Math math = new Math();
        int num1, num2;

        Console.WriteLine("Enter num1:");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter num2:");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Addition = " + math.Add(num1, num2));
        Console.WriteLine("Subtraction = " + math.Sub(num1, num2));
        Console.WriteLine("Multiplication = " + math.Multi(num1, num2));
        Console.WriteLine("Division = " + math.Div(num1, num2));
    }
}
