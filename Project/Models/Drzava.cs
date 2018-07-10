using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

public class Drzava
{
    public int IDDrzava { get; set; }

    [Required(ErrorMessage = "Name of the country required")]
    public string Naziv { get; set; }
}
