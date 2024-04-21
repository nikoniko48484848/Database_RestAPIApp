using Microsoft.AspNetCore.Mvc;
using WebApp1.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Animals : ControllerBase
{
    private IAnimalsService _animalsService;

    public Animals(IAnimalsService animalsService)
    {
        _animalsService = animalsService;
    }

    [HttpGet]
    public IActionResult GetAnimals(string orderBy="Name")
    {
        var acceptedQueries = new List<string>() {"Name", "Description", "Category", "Area"};

        if (!acceptedQueries.Contains(orderBy))
        {
            return NotFound("Bad query!");
        }
        
        var animals = _animalsService.GetAnimals(orderBy);
        return Ok(animals);
    }

    [HttpPost] public IActionResult CreateAnimal(Animal animal)
    {
        var affectedCount = _animalsService.CreateAnimal(animal);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut("{idAnimal:int}")]
    public IActionResult UpdateAnimal(int idAnimal, Animal animal)
    {
        var affectedCount = _animalsService.UpdateAnimal(idAnimal, animal);
        return StatusCode(StatusCodes.Status201Created); 
    }

    [HttpDelete("{idAnimal:int}")]
    public IActionResult DeleteAnimal(int idAnimal) 
    {
        var affectedCount = _animalsService.DeleteAnimal(idAnimal);
        return NoContent();
    }
}