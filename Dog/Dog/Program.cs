using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dog
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog dog = new Dog("Snoopy");
            dog.breed = "Beagle";
            animal.WhatAreYou();
            animal.jump();
            dog.WhatAreYou();
            Console.WriteLine(dog.breed);
            Console.WriteLine(dog.name);
            Console.ReadLine();


        }
    }
}
