using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenTanTien
{
    public class Zoo
    {
        public List<Animal> animals { get; private set; } = new List<Animal>();

        public void addAnimal(Animal animal)
        {
            if (animal == null)
                throw new ArgumentNullException(nameof(animal), "Animal cannot be null");

            animals.Add(animal);
        }


        public List<Animal> getAnimals(int? age = null, string species = null)
        {
            return animals.Where(a =>
                (!age.HasValue || a.getAge() >= age.Value) &&
                (string.IsNullOrEmpty(species) || a.getSpecies().Equals(species, StringComparison.OrdinalIgnoreCase))
            ).ToList();
        }
    }
}
