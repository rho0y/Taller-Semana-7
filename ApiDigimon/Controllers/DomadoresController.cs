using ApiDigimon.Models;
using System.Linq;
using System.Web.Http;

namespace ApiDigimon.Controllers
{
    public class DomadoresController : ApiController
    {
        private DigimonContext db = new DigimonContext();

        // GET: api/domadores
        public IHttpActionResult Get()
            => Ok(db.Domadores.ToList());

        // GET: api/domadores/5
        public IHttpActionResult Get(int id)
        {
            var e = db.Domadores.Find(id);
            return e == null ? (IHttpActionResult)NotFound() : Ok(e);
        }

        // POST: api/domadores
        public IHttpActionResult Post(Domador est)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            db.Domadores.Add(est);
            db.SaveChanges();
            return CreatedAtRoute("DefaultApi", new { id = est.DomadorId }, est);
        }

        // PUT: api/domadores/5
        public IHttpActionResult Put(int id, Domador est)
        {
            var e = db.Domadores.Find(id);
            if (e == null) return NotFound();
            e.Nombre = est.Nombre; e.Edad = est.Edad;
            db.SaveChanges();
            return Ok(e);
        }

        // DELETE: api/domadores/5
        public IHttpActionResult Delete(int id)
        {
            var e = db.Domadores.Find(id);
            if (e == null) return NotFound();
            db.Domadores.Remove(e);
            db.SaveChanges();
            return Ok("Domador eliminado correctamente");
        }

        // Libera la conexión a la base de datos
        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }
    }
}