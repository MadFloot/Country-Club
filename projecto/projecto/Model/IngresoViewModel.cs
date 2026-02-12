using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projecto.Model
{
    public class IngresoViewModel
    {
        public int IdSocio { get; set; }

        public string NombreCompleto { get; set; }

        public DateTime FechaIngreso { get; set; }

        public string Identificacion { get; set; }
    }
}