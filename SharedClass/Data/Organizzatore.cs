using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Context.Data
{
    public class Organizzatore
    {
        [Key]
        public int Codice { get; set; }
        public int CodicePersona { get; set; }
        [ForeignKey("CodicePersona")]
        public virtual Persona Persona { get; set; }
    }
}
