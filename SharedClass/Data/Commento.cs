using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Context.Data
{
    [Table("Commento")]
    public class Commento
    {
        [Key]
        public int Codice { get; set; }
        public int IsVisibile { get; set; }
        public string Testo { get; set; }
        public string CodicePersona { get; set; }
        public string CodicePartita { get; set; }

        [ForeignKey("CodicePersona")] 
        public virtual Persona Persona { get; set; }
        [ForeignKey("CodicePartita")]
        public virtual Partita Partita { get; set; }




    }
}