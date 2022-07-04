using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Context.Data
{
    class Iscritto
    {
        [Key] 
        public int Codice { get; set; }
        public int IsVisibile { get; set; }
        public String Testo { get; set; }
        public int? CodicePersona { get; set; }
        public int? CodicePartita { get; set; }

    }
}