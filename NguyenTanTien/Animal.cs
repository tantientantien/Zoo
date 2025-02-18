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
        private ushort age;
        protected string species;

        protected Animal(string name, ushort age, string species)
        {
            this.name = string.IsNullOrEmpty(name) ? "Unknown" : name;
            this.age = (age < 1) ? (ushort)1 : age;
            this.species = species;
        }

        public void setName(string name) => this.name = string.IsNullOrEmpty(name) ? this.name : name;
        public string getName() => name;

        public void setAge(ushort age) => this.age = (age < 1) ? (ushort)1 : age;
        public ushort getAge() => age;

        public abstract void makeSound();

        public virtual string showInfo() => $"Name: {name}, Age: {age}, Species: {species}";
    }

}
