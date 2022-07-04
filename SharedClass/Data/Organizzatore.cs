using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Context.Data
{
    class Organizzatore
    {
        [Key]
        public int Codice { get; set; }
        public int CodicePersona { get; set; }
    }
}
