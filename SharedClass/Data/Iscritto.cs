using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Context.Data
{
    public class Iscritto
    {
        [Key] 
        public int Codice { get; set; }
        public int IsVisibile { get; set; }
        public String Testo { get; set; }
        public int? CodicePersona { get; set; }
        public int? CodicePartita { get; set; }

        [ForeignKey("CodicePersona")]
        public virtual Persona Persona { get; set; }
        [ForeignKey("CodiceEdizione")]
        public virtual Edizione Edizione { get; set; }
    }
}