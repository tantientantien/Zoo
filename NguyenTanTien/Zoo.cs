using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenTanTien
{
    public class AddEventArgs : EventArgs
    {
        public string Notification { get; set; }
    }

    public class Zoo
    {
        public List<Animal> animals { get; private set; } = new List<Animal>();

        public event EventHandler<AddEventArgs> addNewAnimal;

        public void addAnimal(Animal animal)
        {
            if (animal == null)
                throw new ArgumentNullException(nameof(animal), "Animal cannot be null");

            animals.Add(animal);
            OnAnimalAdded(animal);
        }

        protected virtual void OnAnimalAdded(Animal animal)
        {
            addNewAnimal?.Invoke(this, new AddEventArgs
            {
                Notification = $"A new animal was added: {animal.Name} ({animal.Species})",
            });
        }

        public List<Animal> getAnimals(int? age = null, string species = null)
        {
            return animals.Where(a =>
                (!age.HasValue || a.Age >= age.Value) &&
                (string.IsNullOrEmpty(species) || a.Species.Equals(species, StringComparison.OrdinalIgnoreCase))
            ).ToList();
        }
    }

    public class ZooMonitor
    {
        public void Subscribe(Zoo zoo)
        {
            zoo.addNewAnimal += OnAnimalAdded;
        }

        private void OnAnimalAdded(object sender, AddEventArgs e)
        {
            Console.WriteLine(e.Notification);
        }
    }


}
