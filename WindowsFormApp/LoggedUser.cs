﻿using System;
using System.Collections.Generic;
using System.Text;
using Context.Data;

namespace WindowsFormApp
{
    public class LoggedUser
    {

        public static string Email { get; set;}
        public static string Nome { get; set; }
        public static string Cognome { get; set; }
        public static Persona.TipoUtente Tipo { get; set; }
    }
}