using VehicleTask.Models;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Brand = "sadsada",
                Model = "sskjhajd",
                MaxSpeed = 100,
                FuelType = "dasdkas"
            };

            car.Drive();
            car.MakeSound();


            Train train = new Train()
            {
                Brand = "saada",
                Model = "sskjjd",
                MaxSpeed = 100,
                CarriageCount = 1,
            };

            train.Drive();
            train.MakeSound();

            Motorcycle motorcycle = new Motorcycle()
            {
                Brand = "sadsada",
                Model = "sskjhajd",
                MaxSpeed = 100,
                RaceType = "sdsad"
            };

            motorcycle.Drive();
            motorcycle.MakeSound();




        }
    }
}
