using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

public class Kupac
{
    public int IDKupac { get; set; }

    [Required(ErrorMessage = "First name required")]
    public string Ime { get; set; }

    [Required(ErrorMessage = "Last name required")]
    public string Prezime { get; set; }

    [EmailAddress(ErrorMessage = "Email format not correct")]
    public string Email { get; set; }

    [PhoneValidator]
    public string Telefon { get; set; }

    [Display(Name = "Grad")]
    public int GradID { get; set; }

    public override string ToString()
    {
        return $"{Ime} {Prezime}";
    }
}
