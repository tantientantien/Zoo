using System;
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
            Animal animal;

            animal = new Lion("Bob", 10);
            Console.WriteLine(animal.showInfo());
            animal.makeSound();
            ((Lion)animal).hunt();

            Console.WriteLine();

            animal = new Elephant("Cookie", 12);
            Console.WriteLine(animal.showInfo());
            animal.makeSound();
            ((Elephant)animal).EatLeaves();

            Console.WriteLine();

            animal = new Monkey("Alice", 5);

            animal.setAge(0);

            Console.WriteLine(animal.showInfo());
            animal.makeSound();
            ((Monkey)animal).ClimbTree();
        }
    }
}
