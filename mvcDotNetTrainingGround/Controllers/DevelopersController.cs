using Microsoft.AspNetCore.Mvc;

namespace mvcDotNetTrainingGround.Controllers;

public class DevelopersController : Controller
{
    private Db _db;
    public DevelopersController(Db db)
    {
        _db = db;
    }
    public IActionResult Index()
    {
        //ViewData return
        //ViewData["Developers"] = _db.Developers;
        //return View();

        //Model return
        return View(_db.Developers);
    }
    public IActionResult Details(int id)
    {
        //return View(_db.Developers.Find(d=>d.Id==id));
        var developer = _db.Developers.Find(d => d.Id == id);
        return View(developer);
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(CreateNewDeveloperViewModel viewModel)
    {
        var nextId = _db.Developers.Count + 1;
        var developerToAdd = new Developer()
        {
            Id = nextId,
            Name = viewModel.Name,
            Email = viewModel.Email
        };
        _db.Developers.Add(developerToAdd);

        //return View(); 
        return RedirectToAction(nameof(Index));
        //return RedirectToAction(nameof(Details), new { Id = nextId });
    }
}