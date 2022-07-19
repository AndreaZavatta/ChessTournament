using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Context.Data
{
    [Table("Competizione")]
    public class Competizione
    {
        public int CodiceIscritto { get; set; }
        public int CodicePartita { get; set; }
        [ForeignKey("CodicePartita")]
        public virtual Partita Partita { get; set; }
    }
}
