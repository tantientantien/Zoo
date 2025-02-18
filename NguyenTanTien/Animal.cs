using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NguyenTanTien
{
    public abstract class Animal
    {
        private string name;
        private byte age;
        protected string species;

        public void SetName(string Name)
        {
            this.name = string.IsNullOrEmpty(Name) ? this.name : Name;
        }


        public string GetName(string Name)
        {
            return name;
        }

        public void SetAge(byte Age)
        {
            this.age = (age <= 0) ? this.age : Age;
        }

        public byte GetAge()
        {
            return age;
        }


        protected Animal(string Name, byte Age, string Species)
        {
            this.name = Name;
            this.age = Age;
            this.species = Species;
        }

        public abstract void makeSound();

        public string showInfo()
        {
            return $"Name: {name}, Age: {age}, Species: {species}";
        }
    }

}
