using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Context.Data
{
    [Table("Torneo")]
    public class Torneo
    {
        [Key]
        public int Codice { get; set; }
        public int QuotaIscrizione { get; set; }
        public string Nome { get; set; }
        public int RatingMinimo { get; set; }
        public int RatingMassimo { get; set; }
        public int MaxPartecipanti { get; set; } 
    }
}
