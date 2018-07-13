using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class Racun
    {
        [Required(ErrorMessage = "IDRacun required")]
        public int IDRacun { get; set; }

        [Required(ErrorMessage = "DatumIzdavanja required")]
        public DateTime DatumIzdavanja { get; set; }

        [Required(ErrorMessage = "BrojRacuna required")]
        public string BrojRacuna { get; set; }

        [Required(ErrorMessage = "KupacID required")]
        public int KupacID { get; set; }

        [Required(ErrorMessage = "KomercijalistID required")]
        public int KomercijalistID { get; set; }

        [Required(ErrorMessage = "Komentar required")]
        public string Komentar { get; set; }
    }
}