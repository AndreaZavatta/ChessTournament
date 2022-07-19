using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Context.Data
{
    [Table("Allenamento")]
    public class Allenamento
    {
        [Key]
        public int Codice { get; set; }
        public int CodiceAllenatore { get; set; }
        public int CodiceGiocatore { get; set; }

        [ForeignKey("CodiceAllenatore")]
        public virtual Allenatore Allenatore { get; set; }

        [ForeignKey("CodiceGiocatore")]
        public virtual Giocatore Giocatore { get; set; }


    }
}
