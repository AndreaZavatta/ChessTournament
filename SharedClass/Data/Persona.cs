using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Context.Data
{
    [Table("Persona")]
    public class Persona
    {
        [Key]
        public int Codice { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? Genere { get; set; }
        public DateTime? DataNascita { get; set; }
        public string Telefono { get; set; }

    }
}
