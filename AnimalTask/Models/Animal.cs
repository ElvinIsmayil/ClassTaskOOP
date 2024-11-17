
namespace AnimalTask.Models
{
    public abstract class Animal
    {
        private int _age;
        public string Name { get; set; }
        public int Age {

            get => _age;


            set
            {
                if (value > 0)
                {
                    _age = value;
                }else
                {
                    Console.WriteLine("Age cannot be any number below zero!");
                }
            }

            }
        public abstract void MakeSound();
        public abstract void Eat();

       




    }
}
