using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenTanTien
{
    public class Elephant : Animal
    {
        public Elephant(string Name, byte Age, string Species) : base(Name, Age, Species){}

        public override void makeSound()
        {
            Console.WriteLine("la-la-la");
        }
    }
}
