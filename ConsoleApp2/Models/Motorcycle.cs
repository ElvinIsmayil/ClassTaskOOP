using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTask.Models
{
    public class Motorcycle : Vehicle
    {
        public string RaceType { get; set; }

        public Motorcycle(string brand, string model, int maxspeed, string racetype) : base(brand, model,maxspeed)
        {
            RaceType = racetype;
        }
       

        public void MakeSound()
        {
            Console.WriteLine("Bip-bip");
        }

        public override void Drive()
        {
            Console.WriteLine("Vin vin");
        }
        public Motorcycle()
        {
            
        }
    }
}
