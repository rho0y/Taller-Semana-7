using ApiDigimon.Models;
using System.Linq;
using System.Web.Http;

namespace ApiDigimon.Controllers
{
    public class DigimonController : ApiController
    {
        private DigimonContext db = new DigimonContext();

        // GET: api/digimon
        public IHttpActionResult Get()
            => Ok(db.Digimones.ToList());

        // GET: api/digimon/5
        public IHttpActionResult Get(int id)
        {
            var m = db.Digimones.Find(id);
            return m == null ? (IHttpActionResult)NotFound() : Ok(m);
        }

        // POST: api/digimon
        public IHttpActionResult Post(Digimon mat)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            db.Digimones.Add(mat);
            db.SaveChanges();
            return CreatedAtRoute("DefaultApi", new { id = mat.DigimonId }, mat);
        }

        // PUT: api/digimon/5
        public IHttpActionResult Put(int id, Digimon mat)
        {
            var m = db.Digimones.Find(id);
            if (m == null) return NotFound();
            m.Nombre = mat.Nombre; m.Etapa = mat.Etapa;
            db.SaveChanges();
            return Ok(m);
        }

        // DELETE: api/digimon/5
        public IHttpActionResult Delete(int id)
        {
            var m = db.Digimones.Find(id);
            if (m == null) return NotFound();
            db.Digimones.Remove(m);
            db.SaveChanges();
            return Ok("Digimon devuelto al Mundo Digital correctamente");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }
    }
}