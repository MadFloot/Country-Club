using projecto.EF;
using projecto.Model;
using System.Linq;
using System.Web.Mvc;

namespace projecto.Controllers
{
    public class SociosController : Controller
    {
        [HttpGet]
        public ActionResult Buscar(string criterio)
        {
            using (var db = new ControlAccesoDBEntities())
            {
                var socios = db.SOCIO
    .Where(s =>
        string.IsNullOrEmpty(criterio) ||
        s.Nombre.Contains(criterio) ||
        s.CodigoSocio.Contains(criterio))
    .ToList();

                var lista = socios.Select(s => new Socio
                {
                    IdSocio = s.IdSocio,
                    CodigoSocio = s.CodigoSocio,
                    Nombre = s.Nombre,
                    Apellidos = s.Apellidos,
                    EstadoMembresia = s.EstadoMembresia,
                    Categoria = s.Categoria,
                    Email = s.Email,
                    Telefono = s.Telefono
                }).ToList();

                return PartialView("_TablaSocios", lista);
            }
        }
        public ActionResult Detalle(int id)
        {
            using (var db = new ControlAccesoDBEntities())
            {
                var s = db.SOCIO.FirstOrDefault(x => x.IdSocio == id);

                var model = new Socio
                {
                    IdSocio = s.IdSocio,
                    CodigoSocio = s.CodigoSocio,
                    Nombre = s.Nombre,
                    Apellidos = s.Apellidos,
                    Email = s.Email,
                    Telefono = s.Telefono
                };

                return PartialView("_DetalleSocio", model);
            }
        }
    }
}