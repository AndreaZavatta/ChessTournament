using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Context.Data
{
    [Table("Luogo")]
    public class Luogo
    {
        [Key]
        public int Codice { get; set; }
        public string Nome { get; set; }
    }
}
