
using VehicleTask.Interfaces;

namespace VehicleTask.Models
{
    public class Car : Vehicle, ISound
    {
        public string FuelType { get; set; }



        public Car(string brand, string model, int maxspeed, string fueltype) : base(brand, model, maxspeed)
        {
            FuelType = fueltype;
        }

        public Car()
        {
            
        }

        public void MakeSound()
        {
            Console.WriteLine("Bip-bip");
        }

        public override void Drive()
        {
            throw new NotImplementedException();
        }
    }
}

