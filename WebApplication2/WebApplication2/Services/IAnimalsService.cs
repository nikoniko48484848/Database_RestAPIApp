using WebApp1.Models;

namespace WebApplication2.Services;

public interface IAnimalsService
{
    IEnumerable<Animal> GetAnimals(string query);
    int CreateAnimal(Animal animals);
    int UpdateAnimal(int idAnimal, Animal animal);
    int DeleteAnimal(int idAnimal);
}