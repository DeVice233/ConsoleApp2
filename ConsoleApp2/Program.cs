using System;

namespace ConsoleApp2
{
    class Animal
    {
        public DateTime Birthday;
        public int Age 
        {
            get {return (int)DateTime.Now.Subtract(Birthday).TotalDays / 365; }
        }
    }
    class Dog : Animal,IWalking
    {
        public string Name;
        public Dog(string name,DateTime birthday) { Name = name;Birthday = birthday; }
        public override string ToString() => Name;
    }
    class Butterfly : Animal
    {

    }
    class Bird : Animal,IFlying
    {
        public string Name;
        public Bird(string name, DateTime birthday) { Name = name; Birthday = birthday; }
        public override string ToString() => Name;
    }
    class Fish : Animal,ISwimming
    {
        public string Name;
        public Fish(string name, DateTime birthday) { Name = name; Birthday = birthday; }
        public override string ToString() => Name;
    }
    interface IWalking
    {
        void Walk()
        {
            Console.WriteLine(this + " идет в новую точку");
        }
    }
    interface IFlying
    {
        void Fly()
        {
            Console.WriteLine(this + " летит в новую точку");
        }
    }
    interface ISwimming
    {
        void Swim()
        {
            Console.WriteLine(this + " плывет в новую точку");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog Sharik = new Dog("Шарик", new DateTime(2015, 6, 1));
            ((IWalking)Sharik).Walk();
            Console.WriteLine(Sharik.Age);
            Bird Kesha = new Bird("Кеша", new DateTime(2017, 8, 14));
            ((IFlying)Kesha).Fly();
            Fish Nemo = new Fish("Немо", new DateTime(2019, 2, 3));
            ((ISwimming)Nemo).Swim();
        }
    }
}
