
namespace AnimalTask.Models
{
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("MEOW");
        }

        public override void Eat()
        {
            Console.WriteLine("Cat eats fish");

        }
    }
}
