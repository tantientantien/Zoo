using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenTanTien
{
    public class Elephant : Animal
    {
        public Elephant(string Name, ushort Age) : base(Name, Age, "Elephant"){}

        public void eatLeaves()
        {
            Console.WriteLine($"{this.Name} is eating leaves...");
        }

        public override void makeSound()
        {
            Console.WriteLine("la-la-la");
        }
    }
}
