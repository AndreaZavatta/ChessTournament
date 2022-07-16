using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Context.Data
{
    [Table("Iscritto")]
    public class Iscritto
    {
        [Key] 
        public int Codice { get; set; }
        public int CodiceGiocatore { get; set; }
        public int CodiceEdizione { get; set; }
        public DateTime? Data { get; set; }

        [ForeignKey("CodiceGiocatore")]
        public virtual Giocatore Giocatore { get; set; }
        [ForeignKey("CodiceEdizione")]
        public virtual Edizione Edizione { get; set; }
    }
}