using System;

namespace Properties_Rowland_Ethan
{
    class Program
    {
        static void Main(string[] args)
        {
            // describing the model and type of car
            Car car = new Car();
            car.Make = "Ford";
            car.Model = "Mustang";

            // writing it all out to see
            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}");

            // describing the model and type of car
            Car car2 = new Car();
            car2.Make = "Chevy";
            car2.Model = "Camero";

            // writing it all out to see
            Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}");

            Car car3 = new Car();
            Console.WriteLine($"Make: {car3.Make}, Model: {car3.Model}");
        }
    }
}
