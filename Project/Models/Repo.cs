using Microsoft.ApplicationBlocks.Data;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

public class Repo
{
    public static DataSet ds { get; set; }
    private static string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;


    public static Kupac GetKupac(int IDKupac)
    {
        return GetKupci().Single(k => k.IDKupac == IDKupac);
    }

    public static Drzava GetDrzava(int GradID)
    {
        ds = SqlHelper.ExecuteDataset(cs, "GetDrzava", GradID);
        DataRow row = ds.Tables[0].Rows[0];

        Drzava d = new Drzava();
        d.IDDrzava = (int)row["IDDrzava"];
        d.Naziv = row["Naziv"].ToString();

        return d;
    }

    public static IEnumerable<Kupac> GetKupci()
    {
        ds = SqlHelper.ExecuteDataset(cs, "DohvatiKupce");
        foreach (DataRow row in ds.Tables[0].Rows)
        {
            yield return new Kupac
            {
                IDKupac = (int)row["IDKupac"],
                Ime = row["Ime"].ToString(),
                Prezime = row["Prezime"].ToString(),
                Email = row["Email"].ToString(),
                Telefon = row["Telefon"].ToString(),
                GradID = row["GradID"] != DBNull.Value ? (int)row["GradID"] : 1
            };
        }
    }

    public static IEnumerable<Racun> GetRacuni(int id)
    {
        ds = SqlHelper.ExecuteDataset(cs, "DohvatiRacune", id);
        foreach (DataRow row in ds.Tables[0].Rows)
        {
            yield return new Racun
            {
                IDRacun = (int)row["IDRacun"],
                DatumIzdavanja = DateTime.Parse(row["DatumIzdavanja"].ToString()),
                BrojRacuna = row["Prezime"].ToString(),
                KupacID = (int)row["Email"],
                KomercijalistID = (int)row["Telefon"],
                Komentar = row["Komentar"].ToString()
            };
        }
    }

    public static List<Kupac> GetKupci(int id)
    {
        List<Kupac> kolekcija = GetKupci().ToList();
        List<Kupac> nova = new List<Kupac>();

        foreach (var k in kolekcija)
        {
            if (k.GradID == id)
                nova.Add(k);
        }
        return nova;
    }

    public static List<Grad> GetGrad(int id)
    {
        List<Grad> kolekcija = GetGradovi();
        List<Grad> nova = new List<Grad>();

        foreach (var g in kolekcija)
        {
            if (g.DrzavaID == id)
                nova.Add(g);
        }
        return nova;
    }

    public static List<Drzava> GetDrzave()
    {
        List<Drzava> kolekcija = new List<Drzava>();

        ds = SqlHelper.ExecuteDataset(cs, "GetDrzave");
        foreach (DataRow row in ds.Tables[0].Rows)
        {
            kolekcija.Add(new Drzava
            {
                IDDrzava = (int)row["IDDrzava"],
                Naziv = row["Naziv"].ToString()
            });
        }
        return kolekcija;
    }


    public static List<Grad> GetGradovi()
    {
        List<Grad> kolekcija = new List<Grad>();

        ds = SqlHelper.ExecuteDataset(cs, "GetGradovi");
        foreach (DataRow row in ds.Tables[0].Rows)
        {
            kolekcija.Add(new Grad
            {
                IDGrad = (int)row["IDGrad"],
                Naziv = row["Naziv"].ToString(),
                DrzavaID = (int)row["DrzavaID"]
            });
        }
        return kolekcija;
    }



    public static int UpdateKupac(Kupac kupac)
    {
        return SqlHelper.ExecuteNonQuery(cs, "UpdateKupac", kupac.IDKupac, kupac.Ime, kupac.Prezime, kupac.Email, kupac.Telefon, kupac.GradID);
    }
}
