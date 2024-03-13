using System;

namespace Enheritance
{

    internal class Program
    {
        static void Main(string[] args)

        {
            Horse horse = new Horse();
            Dog dog = new Dog();
            Bird bird = new Bird();
            Wolf wolf = new Wolf();
            //public Horse(string name, int weight, in age) : base(name, weight, age)

            Console.WriteLine(horse.name);
            Console.WriteLine(horse.weight);
            Console.WriteLine(horse.age);
            Console.WriteLine("A horse carries " + horse.personCarried + " person at ago");
            horse.DoSound();
            Console.WriteLine();

            Console.WriteLine(dog.name);
            Console.WriteLine(dog.weight);
            Console.WriteLine(dog.age);
            Console.WriteLine(dog.boneseaten);
            Console.WriteLine("A dog east " + dog.boneseaten + " bones");
            dog.DoSound();
            Console.WriteLine();


            Console.WriteLine(bird.name);
            Console.WriteLine(bird.weight);
            Console.WriteLine(bird.age);
            Console.WriteLine("A bird has " + bird.feathers + " feathers");
            bird.DoSound();
            Console.WriteLine();

            Console.WriteLine(wolf.name);
            Console.WriteLine(wolf.weight);
            Console.WriteLine(wolf.age);
            Console.WriteLine("A bird has " + bird.feathers + " legs");
            wolf.DoSound();
            Console.WriteLine();


            Pelican pelican = new Pelican();
            Console.WriteLine("This is  " + pelican.name);// enherits from Animal
            Console.WriteLine("It has " + pelican.feathers + " feathers"); //enherits from bird
            pelican.Fly();// implements its own method
            Console.WriteLine();

            Flamingo flamingo = new Flamingo();
            Console.WriteLine("This is  " + flamingo.name);
            Console.WriteLine("It has " + flamingo.feathers + " feathers");
            flamingo.Drink();
            Console.WriteLine();

            Swan swan = new Swan();
            Console.WriteLine("This is  " + swan.name);
            Console.WriteLine("It has " + swan.feathers + " feathers");
            swan.Run();
            Console.WriteLine();

            Wolfman wolfman = new Wolfman();

            //Wolfman.Talk();

        }
    }
    public class Animal
    {
        public string name = "myAnimal";
        public int weight = 20;
        public int age = 5;
        public string sound = "theSound";
        //If all animals need a new attribute it should be put here in the "Animal class"
        public void DoSound()
        {
            Console.WriteLine("This animal makes a sounds!");
        }
    }

    class Horse : Animal
    {

        public int personCarried = 1;

    }
    class Dog : Animal
    {
        public int boneseaten = 3;

    }

    class Bird : Animal
    {
        public int feathers = 2;
        //13. If all birds need a new attribute it should be put here in the "Bird class"
    }

    class Wolf : Animal
    {

        public int legs = 4;

    }

    class Pelican : Bird
    {
        public void Fly()
        {
            Console.WriteLine("A Palican flies");
        }
    }
    class Flamingo : Bird
    {
        public void Drink()
        {
            Console.WriteLine("A Flamingo drinks water");
        }
    }
    class Swan : Bird
    {
        public void Run()
        {
            Console.WriteLine("A Swan runs");
        }
    }



    class Wolfman : Wolf, IPerson
    {
        public void Talk()
        {
            Console.WriteLine("Wolfman says Hi!");
        }
    }
}

// 13. If all birds need a new attribute it should be put in the "Bird class"
// 14. If all animals need a new attribute it should be put in the "Animal class"
