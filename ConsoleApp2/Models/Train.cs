

using VehicleTask.Interfaces;

namespace VehicleTask.Models
{

    public class Train : Vehicle, ISound
    {

        private int _carriageCount;
        public int CarriageCount 
        { 
            get => _carriageCount; 
            set {
                if (value >=1)
                {
                    _carriageCount = value;
                }
                else
                {
                    Console.WriteLine("Carriage count should be at least 1");
                }
                }
                 }

        public Train(string brand, string model, int maxspeed, int carriagecount) : base(brand, model, maxspeed)
        {
            CarriageCount = carriagecount;

        }

        public Train()
        {
            
        }



        public void MakeSound()
        {
            Console.WriteLine("Tuf-tuf");
        }

        public override void Drive()
        {
            throw new NotImplementedException();
        }
    }
}

