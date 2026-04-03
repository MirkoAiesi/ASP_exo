using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models;

public class Film
{
    public int Id { get; set; }
    [Required, StringLength(100)]
    public string Titre { get; set; }
    [Required(ErrorMessage = "Le genre est obligatoire")]
    public string Genre { get; set; }
    [Range(1900, 2030)]
    public int AnneeDeSortie { get; set; }
}