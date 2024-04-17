namespace Task4
{
    interface ISwimmable
    {
        void Swim() {
            Console.WriteLine("I can swim!");
        }
    }
    interface IFlyable
    {
        int MaxHeight => 0;
        void Fly()
        {
            Console.WriteLine($"I can fly at {MaxHeight} meters height!");
        }
    }

    interface IRunnable
    {
        int MaxSpeed => 0;
        void Run()
        {
            Console.WriteLine($"I can run up to {MaxSpeed} kilometers per hour!");
        }
    }
    interface IAnimal
    {
        int LifeDuration => 0;
        void Voice()
        {
            Console.WriteLine("No voice");
        }
        void ShowInfo()
        {
            Console.WriteLine($"I am a {this.GetType().Name} and I live approximately {LifeDuration} years.");
        }
    }

    class Cat : IAnimal, IRunnable
    {
        public int MaxSpeed => 24;
        public int LifeDuration => 12;

        public void Voice()
        {
            Console.WriteLine("Meow");
        }
    }
    class Eagle : IAnimal, IFlyable
    {
        public int MaxSpeed => 120;
        public int LifeDuration => 30;
    }

    class Shark : IAnimal, ISwimmable
    {
        public int MaxSpeed => 40;
        public int LifeDuration => 25;

    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Cat cat = new Cat();
            Eagle eagle = new Eagle();
            Shark shark = new Shark();
            Console.WriteLine(shark.MaxSpeed);
            cat.Voice();
        }

        
    }
}
