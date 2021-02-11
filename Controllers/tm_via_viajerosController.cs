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
using LeninTravel_API.Models;

namespace LeninTravel_API.Controllers
{
    public class tm_via_viajerosController : ApiController
    {
        private LeninTravelDBEntities db = new LeninTravelDBEntities();

        // GET: api/tm_via_viajeros
        public IQueryable<tm_via_viajeros> Gettm_via_viajeros()
        {
            return db.tm_via_viajeros;
        }

        // GET: api/tm_via_viajeros/5
        [ResponseType(typeof(tm_via_viajeros))]
        public IHttpActionResult Gettm_via_viajeros(int id)
        {
            tm_via_viajeros tm_via_viajeros = db.tm_via_viajeros.Find(id);
            if (tm_via_viajeros == null)
            {
                return NotFound();
            }

            return Ok(tm_via_viajeros);
        }

        // PUT: api/tm_via_viajeros/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttm_via_viajeros(int id, tm_via_viajeros tm_via_viajeros)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tm_via_viajeros.id)
            {
                return BadRequest();
            }

            db.Entry(tm_via_viajeros).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tm_via_viajerosExists(id))
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

        // POST: api/tm_via_viajeros
        [ResponseType(typeof(tm_via_viajeros))]
        public IHttpActionResult Posttm_via_viajeros(tm_via_viajeros tm_via_viajeros)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tm_via_viajeros.Add(tm_via_viajeros);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tm_via_viajeros.id }, tm_via_viajeros);
        }

        // DELETE: api/tm_via_viajeros/5
        [ResponseType(typeof(tm_via_viajeros))]
        public IHttpActionResult Deletetm_via_viajeros(int id)
        {
            tm_via_viajeros tm_via_viajeros = db.tm_via_viajeros.Find(id);
            if (tm_via_viajeros == null)
            {
                return NotFound();
            }

            db.tm_via_viajeros.Remove(tm_via_viajeros);
            db.SaveChanges();

            return Ok(tm_via_viajeros);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tm_via_viajerosExists(int id)
        {
            return db.tm_via_viajeros.Count(e => e.id == id) > 0;
        }
    }
}