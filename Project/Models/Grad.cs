using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

public class Grad
{
    public int IDGrad { get; set; }

    [Required(ErrorMessage = "Name of the city required")]
    public string Naziv { get; set; }

    [Display(Name = "Drzava")]
    public int DrzavaID { get; set; }
}
