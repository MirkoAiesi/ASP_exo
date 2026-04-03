using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers;

public class AProposController : Controller
{
    public readonly List<Film> films = new()
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
    public IActionResult Index()
    {
        return View(films);
    }
}