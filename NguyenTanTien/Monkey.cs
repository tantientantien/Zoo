using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenTanTien
{
    public class Monkey : Animal
    {
        public Monkey(string Name, ushort Age) : base(Name, Age, "Monkey"){}

        public void climbTree()
        {
            Console.WriteLine($"{getName()} is climbing a tree...");
        }

        public override void makeSound()
        {
            Console.WriteLine("ec-ec-ec");
        }
    }
}
