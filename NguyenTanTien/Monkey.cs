using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenTanTien
{
    public class Monkey : Animal
    {
        public Monkey(string Name, byte Age, string Species) : base(Name, Age, "Monkey"){}

        public override void makeSound()
        {
            Console.WriteLine("ec-ec-ec");
        }
    }
}
