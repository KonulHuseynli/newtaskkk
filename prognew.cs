using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();


            car.Probek = 225;

            Console.WriteLine(car.Probek);


            car.Probek = 2222;
            Console.WriteLine(car.Probek);
        }
    }
}
