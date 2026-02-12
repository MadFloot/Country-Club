using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projecto.Model
{
    public class Socio
    {
        public int IdSocio { get; set; }
        public string CodigoSocio { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string EstadoMembresia { get; set; }
        public string Categoria { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}