    using System;
using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

namespace Context.Data
{
    class Lezione
    {
        [Key]
        public int CodiceAllenatore { get; set; }
        public int CodiceGiocatore { get; set; }
        public DateTime? Data { get; set; }
        public string? Argomento { get; set; }
    }
}
