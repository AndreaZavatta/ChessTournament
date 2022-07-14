using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Context.Data
{
    [Table("Edizione")]
    public class Edizione
    {
        [Key]
        public int Codice { get; set; }
        public int PremioVincita { get; set; }
        public String Descrizione { get; set; }
        public DateTime? DataFine { get; set; }
        public DateTime? DataInizio { get; set; }
        public int NumEdizione { get; set; }
        public int Anno { get; set; }
        public int CodiceTorneo { get; set; }
        public int? CodiceVincitore { get; set; }
        public int? CodiceOrganizzatore { get; set; }
        public int? CodiceLuogo { get; set; }

        [ForeignKey("CodiceTorneo")]
        public virtual Torneo Torneo { get; set; }
        [ForeignKey("CodiceVincitore")]
        public virtual Iscritto Vincitore { get; set; }
        [ForeignKey("CodiceOrganizzatore")]
        public virtual Organizzatore Organizzatore { get; set; }
        [ForeignKey("CodiceLuogo")]
        public virtual Luogo Luogo { get; set; }

    }
}
