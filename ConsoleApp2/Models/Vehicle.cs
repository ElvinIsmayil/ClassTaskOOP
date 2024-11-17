namespace VehicleTask.Models
{
    public abstract class Vehicle
    {

        private int _maxspeed;
        public string Brand { get; set; }
        public string Model { get; set; }

        public int MaxSpeed
        {
            get => _maxspeed;

            set
            {
                if (value > 0)
                {
                    _maxspeed = value;
                }
                else
                {
                    Console.WriteLine("Maxspeed should be greater than zero");
                }

            }
        }

        protected Vehicle()
        {
            
        }
        public Vehicle(string brand, string model,int maxspeed)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxspeed;
         
        }


        

        public abstract void Drive();
        
    }
}


