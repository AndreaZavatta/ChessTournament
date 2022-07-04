using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Context.Data
{
    [Table("Partita")]
    public class Partita
    {
        [Key]
        public int Codice { get; set; }
        public int CodiceIscritto1 { get; set; }
        public int CodiceIscritto2 { get; set; }
        public int CodiceVincente { get; set; }
        public int CodiceEdizione { get; set; }
        public DateTime? DataInizio { get; set; }
        public DateTime? DataFine { get; set; }
        public int MinutiPerGiocatore { get; set; }

        [ForeignKey("CodiceIscritto1")]
        public virtual Persona Iscritto1 { get; set; }
        [ForeignKey("CodiceIscritto2")]
        public virtual Persona Iscritto2 { get; set; }
        [ForeignKey("CodiceVincente")]
        public virtual Persona Vincente { get; set; }
        [ForeignKey("CodiceEdizione")]
        public virtual Edizione Edizione { get; set; }


    }
}
