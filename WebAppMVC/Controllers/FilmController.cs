using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers;

public class FilmController : Controller
{
    public static List<Film> listDeFilm = new()
    {
        new Film
        {
            Id = 1,
            Titre = "Le seigneur des anneaux : la communauté de l'anneau",
            Genre = "Fantastique",
            AnneeDeSortie = 2001
        },
        new Film
        {
            Id = 2,
            Titre = "Le seigneur des anneaux : les deux tours",
            Genre = "Fantastique",
            AnneeDeSortie = 2002
        },
        new Film
        {
            Id = 3,
            Titre = "Le seigneur des anneaux : le retour du roi",
            Genre = "Fantastique",
            AnneeDeSortie = 2003
        },
        new Film
        {
        Id = 4,
        Titre = "Avatar 3 : de feu et de cendres",
        Genre = "Science-fiction",
        AnneeDeSortie = 2025
        },
        new Film
        {
            Id = 5,
            Titre = "Parasite",
            Genre = "Thriller",
            AnneeDeSortie = 2019
        },
        new Film
        {
            Id = 6,
            Titre = "Real Steel",
            Genre = "Action",
            AnneeDeSortie = 2011
        }
    };

    public IActionResult Index(string? genre = null)
    {
        List<Film> filmFiltres = string.IsNullOrEmpty(genre)
            ? listDeFilm
            : listDeFilm.Where(l => l.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase)).ToList();
        return View(filmFiltres);
    }

    public IActionResult Details(int id)
    {
        Film film = listDeFilm.FirstOrDefault(f => f.Id == id);

        if (film is null)
        {
            return NotFound();
        }

        TempData["Message"] = "Redirection reussie !";
        return View(film);
    }
    public IActionResult APropos()
    {
        return View(listDeFilm);
    }

    [HttpGet]
    public IActionResult Ajouter()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Ajouter(Film film)
    {
        if (ModelState.IsValid)
        {
            int id = listDeFilm.Select(l => l.Id).Max();
            film.Id = id + 1;
            listDeFilm.Add(film);
            TempData["Ajout"] = "Redirection reussie !";
            return RedirectToAction("Index");
            
        }

        return View(film);
    }
}