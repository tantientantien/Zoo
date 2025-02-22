﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenTanTien
{
    public class Lion : Animal, ICarnivore
    {
        public Lion(string name, ushort age) : base(name, age, "Lion") {}

        public void Hunt()
        {
            Console.WriteLine($"{this.Name} is hunting...");
        }

        public override void makeSound()
        {
            Console.WriteLine("Gru-gru");
        }
    }
}
