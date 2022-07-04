using System;
using System.Collections.Generic;
using System.Text;

namespace Context.Data
{
    class Edizione
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

    }
}
