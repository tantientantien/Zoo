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
            Animal animal = new Lion("Bob", 10, "Lion");
            Console.WriteLine(animal.showInfo());
            animal.makeSound();

            animal = new Elephant("Cookie", 12, "Elephant");
            Console.WriteLine(animal.showInfo());
            animal.makeSound();

            animal = new Monkey("alice", 5, "Monkey");

            animal.SetName("bov");
            Console.WriteLine(animal.showInfo());
            animal.makeSound();
        }
    }
}
