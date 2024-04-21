using WebApp1.Models;
using WebApplication2.Repositories;

namespace WebApplication2.Services;

public class AnimalsService : IAnimalsService
{
    private IAnimalsRepository _animalsRepository;

    public AnimalsService(IAnimalsRepository animalsRepository)
    {
        _animalsRepository = animalsRepository;
    }

    public IEnumerable<Animal> GetAnimals(string query)
    {
        //Business logic
        return _animalsRepository.GetAnimals(query);
    }

    public int CreateAnimal(Animal animal)
    {
        return _animalsRepository.CreateAnimal(animal);
    }

    public int UpdateAnimal(int idAnimal, Animal animal)
    {
        return _animalsRepository.UpdateAnimal(idAnimal, animal);
    }
    public int DeleteAnimal(int idAnimal)
    {
        return _animalsRepository.DeleteAnimal(idAnimal);
    } 
}