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

        public string species { get; protected set; }

        protected Animal(string name, ushort age, string species)
        {
            this.name = string.IsNullOrEmpty(name) ? "Unknown" : name;
            this.age = (age < 1) ? (ushort)1 : age;
            this.species = species;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = string.IsNullOrEmpty(value) ? this.name : value; }
        }

        public ushort Age
        {
            get { return this.age; }
            set { this.age = (value < 1) ? this.age : (ushort)value; }
        }

        //public void setAge(ushort age) => this.age = (age < 1) ? (ushort)1 : age;
        //public void setName(string name) => this.name = string.IsNullOrEmpty(name) ? this.name : name;


        //public ushort getAge() => age;
        //public string getName() => name;
        //public string getSpecies() => species;


        public abstract void makeSound();
        public virtual string showInfo() => $"Name: {name}, Age: {age}, Species: {species}";
    }

    public static class AnimalExtension
    {
        public static string getAnimalType(this Animal animal)
        {
            return animal?.GetType().Name ?? "Unknown";
        }
    }
}
