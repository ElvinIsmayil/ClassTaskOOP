using AnimalTask.Models;

namespace AnimalTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Cat cat = new Cat();
           cat.Name = "Test";
           cat.Age= -1;
           cat.Eat();
           cat.MakeSound();

           Dog dog = new Dog();
           dog.Name = "Test";
           dog.Age = 1;
           dog.Eat();
           dog.MakeSound();

        }
    }
}
