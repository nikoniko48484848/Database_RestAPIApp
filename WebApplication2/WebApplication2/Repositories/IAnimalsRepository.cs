using WebApp1.Models;

namespace WebApplication2.Repositories;

public interface IAnimalsRepository
{
    IEnumerable<Animal> GetAnimals(string query);
    int CreateAnimal(Animal animal);
    int UpdateAnimal(int idAnimal, Animal animal);
    int DeleteAnimal(int idAnimal);
}