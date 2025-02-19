﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenTanTien
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal animal;

            //animal = new Lion("Bob", 10);
            //Console.WriteLine(animal.showInfo());
            //animal.makeSound();
            //((Lion)animal).hunt();

            //Console.WriteLine();

            //animal = new Elephant("Cookie", 12);
            //Console.WriteLine(animal.showInfo());
            //animal.makeSound();
            //((Elephant)animal).eatLeaves();

            //Console.WriteLine();

            //animal = new Monkey("Alice", 5);

            //Console.WriteLine(animal.showInfo());
            //animal.makeSound();
            //((Monkey)animal).climbTree();

            Zoo zoo = new Zoo();
            ZooMonitor monitor = new ZooMonitor();
            monitor.Subscribe(zoo);


            zoo.addAnimal(new Lion("bob", 12));
            zoo.addAnimal(new Lion("zoe", 5));
            zoo.addAnimal(new Elephant("alice", 7));
            zoo.addAnimal(new Monkey("zara", 4));

            Console.WriteLine();

            var result = zoo.getAnimals(age: 5, species: "Lion");

            result[0].Age = 0;

            foreach (var animal in result)
            {
                Console.WriteLine(animal.showInfo());
                Console.WriteLine(animal.getAnimalType());
            }
        }
    }
}
