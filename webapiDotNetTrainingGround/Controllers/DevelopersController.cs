namespace webapiDotNetTrainingGround.Controllers;

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webapiDotNetTrainingGround.Models;

[ApiController]
[Route("/api/[controller]")]
public class DevelopersController : ControllerBase
{
    private Db _db;
    
    public DevelopersController(Db db)
    {
        _db = db;
    }
    [HttpGet]
    public List<Developer> GetAllDevelopers()
    {
        return _db.Developers;
    }

    [HttpGet("{id}")]
    public Developer? GetDeveloperById(int id)
    {
        return _db.Developers.Find(d => d.Id == id);
    }
    [HttpPost]
    public IActionResult CreateNewDeveloper(CreateDeveloperRequest request)
    {
        // map from request to model
        var nextId = _db.Developers.Count + 1;
        var newDev = new Developer()
        {
            Id = nextId,
            Name = request.Name,
            Email = request.Email,
        };

        _db.Developers.Add(newDev);

        return CreatedAtAction(nameof(GetDeveloperById), new { id = nextId }, newDev);
    }
}