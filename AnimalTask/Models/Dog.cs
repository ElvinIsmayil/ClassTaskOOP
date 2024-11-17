

namespace AnimalTask.Models
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("BARK");
        }
        public override void Eat()
        {
            Console.WriteLine("Dog eats beef");
            
        }

    }
}
