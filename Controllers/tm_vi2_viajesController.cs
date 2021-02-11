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
    public class tm_vi2_viajesController : ApiController
    {
        private LeninTravelDBEntities db = new LeninTravelDBEntities();

        // GET: api/tm_vi2_viajes
        public IQueryable<tm_vi2_viajes> Gettm_vi2_viajes()
        {
            return db.tm_vi2_viajes;
        }

        // GET: api/tm_vi2_viajes/5
        [ResponseType(typeof(tm_vi2_viajes))]
        public IHttpActionResult Gettm_vi2_viajes(int id)
        {
            tm_vi2_viajes tm_vi2_viajes = db.tm_vi2_viajes.Find(id);
            if (tm_vi2_viajes == null)
            {
                return NotFound();
            }

            return Ok(tm_vi2_viajes);
        }

        // PUT: api/tm_vi2_viajes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttm_vi2_viajes(int id, tm_vi2_viajes tm_vi2_viajes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tm_vi2_viajes.ID)
            {
                return BadRequest();
            }

            db.Entry(tm_vi2_viajes).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tm_vi2_viajesExists(id))
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

        // POST: api/tm_vi2_viajes
        [ResponseType(typeof(tm_vi2_viajes))]
        public IHttpActionResult Posttm_vi2_viajes(tm_vi2_viajes tm_vi2_viajes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tm_vi2_viajes.Add(tm_vi2_viajes);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tm_vi2_viajes.ID }, tm_vi2_viajes);
        }

        // DELETE: api/tm_vi2_viajes/5
        [ResponseType(typeof(tm_vi2_viajes))]
        public IHttpActionResult Deletetm_vi2_viajes(int id)
        {
            tm_vi2_viajes tm_vi2_viajes = db.tm_vi2_viajes.Find(id);
            if (tm_vi2_viajes == null)
            {
                return NotFound();
            }

            db.tm_vi2_viajes.Remove(tm_vi2_viajes);
            db.SaveChanges();

            return Ok(tm_vi2_viajes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tm_vi2_viajesExists(int id)
        {
            return db.tm_vi2_viajes.Count(e => e.ID == id) > 0;
        }
    }
}