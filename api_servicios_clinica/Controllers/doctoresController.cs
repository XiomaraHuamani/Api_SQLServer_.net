using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using api_servicios_clinica.Models;

namespace api_servicios_clinica.Controllers
{
    public class doctoresController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/doctores
        public IQueryable<doctores> Getdoctores()
        {
            return db.doctores;
        }

        // GET: api/doctores/5
        [ResponseType(typeof(doctores))]
        public IHttpActionResult Getdoctores(int id)
        {
            doctores doctores = db.doctores.Find(id);
            if (doctores == null)
            {
                return NotFound();
            }

            return Ok(doctores);
        }

        // PUT: api/doctores/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putdoctores(int id, doctores doctores)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != doctores.id)
            {
                return BadRequest();
            }

            db.Entry(doctores).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!doctoresExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/doctores
        [ResponseType(typeof(doctores))]
        public IHttpActionResult Postdoctores(doctores doctores)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.doctores.Add(doctores);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (doctoresExists(doctores.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = doctores.id }, doctores);
        }

        // DELETE: api/doctores/5
        [ResponseType(typeof(doctores))]
        public IHttpActionResult Deletedoctores(int id)
        {
            doctores doctores = db.doctores.Find(id);
            if (doctores == null)
            {
                return NotFound();
            }

            db.doctores.Remove(doctores);
            db.SaveChanges();

            return Ok(doctores);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool doctoresExists(int id)
        {
            return db.doctores.Count(e => e.id == id) > 0;
        }
    }
}