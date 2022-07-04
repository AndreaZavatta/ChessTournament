using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Context.Data
{
    [Table("Mossa")]
    public class Mossa
    {
        public int CodicePartita { get; set; }
        public int PosPartenzaX { get; set; }
        public int PosPartenzaY { get; set; }
        public int PosArrivoX { get; set; }
        public int PosArrivoY { get; set; }
        public int NumMossa { get; set; }
        public int TipoMossa { get; set; }
        [ForeignKey("CodicePartita")]
        public virtual Partita Partita { get; set; }
    }
}
