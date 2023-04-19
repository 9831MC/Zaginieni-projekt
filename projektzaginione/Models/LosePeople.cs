using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace projektzaginione.Models
{
    public class LosePeople
    {
        public int Id { get; set; }
        [DisplayName("Imię:")]
        public string Imie { get; set; }
        [DisplayName("Nazwisko:")]
        public string Nazwisko { get; set; }
        [DisplayName("Wiek:")]
        public int Wiek { get; set; }
        public string Opis { get; set; }
        [DisplayName("Data zaginięcia:")]
        public string Data_zaginiecia { get; set; }
        [DisplayName("Znaki szczególne:")]
        public string Znaki_szczegolne { get; set; }
        [DisplayName("Lokalizacja:")]
        public string Lokalizacja { get; set; }

    }
}