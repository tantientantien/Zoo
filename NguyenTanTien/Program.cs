using System;
using System.Collections.Generic;
using System.IO;
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




            //using adapter pattern to write and read animal data to json file

            //IAnimalDataAdapter animalAdapter = new JsonAnimalAdapter();
            //Animal animalToSave = new Lion("Simba", 8);
            //string filePath = Path.Combine(Directory.GetCurrentDirectory(), "data.json");
            //animalAdapter.Save(animalToSave, filePath);
            //Console.WriteLine($"Animal data saved to: {filePath}");

            //Animal loadedAnimal = animalAdapter.Load(filePath);
            //Console.WriteLine("Loaded Animal Info:");
            //Console.WriteLine(loadedAnimal.showInfo());



            try
            {
                Zoo zoo = new Zoo();
                ZooMonitor monitor = new ZooMonitor();
                monitor.Subscribe(zoo);

                IAnimalDataAdapter animalAdapter = new JsonAnimalAdapter();
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "data.json");


                zoo.addAnimal(new Lion("Bob", 12));
                zoo.addAnimal(new Lion("Zoe", 5));
                zoo.addAnimal(new Elephant("Alice", 7));
                zoo.addAnimal(new Monkey("Zara", 4));
                zoo.addAnimal(new Monkey("Simba", 8));

                Console.WriteLine("\nFiltered Animals:");
                var result = zoo.getAnimals(age: 5, species: "Lion");

                foreach (var animal in result)
                {
                    Console.WriteLine($"{animal.showInfo()} ---> With type: {animal.getAnimalType()}");
                }


                //Console.WriteLine("\nSaving Animals to JSON...");
                //animalAdapter.Save(zoo.getAnimals(), filePath);

                Console.WriteLine("\nLoading Animals from JSON...");
                var loadedAnimals = animalAdapter.Load(filePath);

                if (loadedAnimals != null && loadedAnimals.Count > 0)
                {
                    Console.WriteLine("\nLoaded Animal List:");
                    foreach (var animal in loadedAnimals)
                    {
                        Console.WriteLine(animal.showInfo());
                    }
                }
                else
                {
                    Console.WriteLine("No animals loaded from JSON.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
