using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenTanTien
{
    public class Lion : Animal
    {
        public Lion(string Name, byte Age, string Species) : base(Name, Age, "Lion"){}

        public override void makeSound()
        {
            Console.WriteLine("gru-gru");
        }

    }
}
