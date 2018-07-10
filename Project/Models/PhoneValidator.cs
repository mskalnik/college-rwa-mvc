using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class PhoneValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var kupac = validationContext.ObjectInstance as Kupac;
            if (!kupac.Telefon.Any() || kupac.Telefon.Length == 10)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult($"Phone must have 10 numbers, not {kupac.Telefon.Length} and can't have charactes");
            }
        }
    }
}