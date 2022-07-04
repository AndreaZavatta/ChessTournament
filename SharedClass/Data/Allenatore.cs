using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Context.Data
{
    [Table("Allenatore")]
    public class Allenatore
    {
        [Key]
        public int Codice { get; set; }
        public string Federazione { get; set; }
        public int CodicePersona { get; set; }
        [ForeignKey("CodicePersona")]
        public virtual Persona Persona { get; set; }

    }
}
