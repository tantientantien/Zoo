using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NguyenTanTien
{
    public interface IAnimalDataAdapter
    {
        void Save(List<Animal> animals, string filePath);
        List<Animal> Load(string filePath);
    }


    // DTO for animal class
    public class AnimalJson
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("age")]
        public ushort Age { get; set; }
        [JsonPropertyName("species")]
        public string Species { get; set; }
        [JsonPropertyName("datetimeCreated")]
        public DateTime DatetimeCreated { get; set; } = DateTime.Now;
    }

    public class JsonAnimalAdapter : IAnimalDataAdapter
    {
        public void Save(List<Animal> animals, string filePath)
        {
            if (animals == null || animals.Count == 0)
                throw new ArgumentException("Animal list cannot be null or empty", nameof(animals));

            var jsonList = animals.Select(a => new AnimalJson
            {
                Name = a.Name,
                Age = a.Age,
                Species = a.species
            }).ToList();

            var jsonData = JsonSerializer.Serialize(jsonList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonData);
        }

        public List<Animal> Load(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("File not found", filePath);

            var jsonData = File.ReadAllText(filePath);
            var animalsJson = JsonSerializer.Deserialize<List<AnimalJson>>(jsonData);

            if (animalsJson == null)
                throw new InvalidOperationException("Failed to deserialize animal data.");

            return animalsJson.Select(a => AnimalFactory.CreateAnimal(a.Species, a.Name, a.Age)).ToList();
        }
    }



    public static class AnimalFactory
    {
        private static readonly Dictionary<string, Type> AnimalTypes = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase);

        static AnimalFactory()
        {
            RegisterAnimals();
        }

        private static void RegisterAnimals()
        {
            var animalTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(Animal)));

            foreach (var type in animalTypes)
            {
                AnimalTypes[type.Name] = type;
            }
        }

        public static Animal CreateAnimal(string species, string name, ushort age)
        {
            if (AnimalTypes.TryGetValue(species, out var animalType))
            {
                return (Animal)Activator.CreateInstance(animalType, name, age);
            }

            throw new InvalidOperationException($"Unknown animal species: {species}");
        }
    }
}