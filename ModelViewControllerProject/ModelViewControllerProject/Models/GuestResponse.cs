using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ModelViewControllerProject.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Proszę wpisać swoje imię")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Proszę wpisać swój adres e-mail")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Podałeś nieprawidłowy adres e-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Proszę podać swój telefon")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Wskaż, czy będziesz uczestniczyć w imprezę")]
        public bool? WillAttend { get; set; }
    }
}