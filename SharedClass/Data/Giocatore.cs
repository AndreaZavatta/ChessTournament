using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Context.Data
{
    [Table("Giocatore")]
    public class Giocatore
    {
        [Key]
        public int Codice { get; set; }
        public int CodicePersona { get; set; }
        public int PartiteVinte { get; set; }
        public string Federazione { get; set; }
        public int Rating { get; set; }

        [ForeignKey("CodicePersona")]
        public virtual Persona Persona { get; set; }

    }
}
