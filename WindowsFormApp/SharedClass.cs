using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Context.Data;

namespace WindowsFormApp
{
    public static class SharedClass
    {
        public static Form getFormUser()
        {
            Form form = null;
            switch (LoggedUser.Tipo)
            {
                case Persona.TipoUtente.Giocatore:
                    form = new FormGiocatore();
                    break;
                case Persona.TipoUtente.Organizzatore:
                    form = new FormOrganizzatore();
                    break;
                case Persona.TipoUtente.Allenatore:
                    form = new FormAllenatore();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return form;
        }
    }
}
