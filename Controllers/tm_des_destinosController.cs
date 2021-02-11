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
    public class tm_des_destinosController : ApiController
    {
        private LeninTravelDBEntities db = new LeninTravelDBEntities();

        // GET: api/tm_des_destinos
        public IQueryable<tm_des_destinos> Gettm_des_destinos()
        {
            return db.tm_des_destinos;
        }

        // GET: api/tm_des_destinos/5
        [ResponseType(typeof(tm_des_destinos))]
        public IHttpActionResult Gettm_des_destinos(int id)
        {
            tm_des_destinos tm_des_destinos = db.tm_des_destinos.Find(id);
            if (tm_des_destinos == null)
            {
                return NotFound();
            }

            return Ok(tm_des_destinos);
        }

        // PUT: api/tm_des_destinos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttm_des_destinos(int id, tm_des_destinos tm_des_destinos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tm_des_destinos.ID)
            {
                return BadRequest();
            }

            db.Entry(tm_des_destinos).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tm_des_destinosExists(id))
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

        // POST: api/tm_des_destinos
        [ResponseType(typeof(tm_des_destinos))]
        public IHttpActionResult Posttm_des_destinos(tm_des_destinos tm_des_destinos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tm_des_destinos.Add(tm_des_destinos);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tm_des_destinos.ID }, tm_des_destinos);
        }

        // DELETE: api/tm_des_destinos/5
        [ResponseType(typeof(tm_des_destinos))]
        public IHttpActionResult Deletetm_des_destinos(int id)
        {
            tm_des_destinos tm_des_destinos = db.tm_des_destinos.Find(id);
            if (tm_des_destinos == null)
            {
                return NotFound();
            }

            db.tm_des_destinos.Remove(tm_des_destinos);
            db.SaveChanges();

            return Ok(tm_des_destinos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tm_des_destinosExists(int id)
        {
            return db.tm_des_destinos.Count(e => e.ID == id) > 0;
        }
    }
}