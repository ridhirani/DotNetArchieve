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
using Demo_WebAPI;

namespace Demo_WebAPI.Controllers
{
    public class EMP_RIDHI_FIFTEENController : ApiController
    {
        private Freshers_Training2022Entities1 db = new Freshers_Training2022Entities1();

        // GET: api/EMP_RIDHI_FIFTEEN
        public IQueryable<EMP_RIDHI_FIFTEENTH> GetEMP_RIDHI_FIFTEENTH()
        {
            return db.EMP_RIDHI_FIFTEENTH;
        }

        // GET: api/EMP_RIDHI_FIFTEEN/5
        [ResponseType(typeof(EMP_RIDHI_FIFTEENTH))]
        public IHttpActionResult GetEMP_RIDHI_FIFTEENTH(int id)
        {
            EMP_RIDHI_FIFTEENTH eMP_RIDHI_FIFTEENTH = db.EMP_RIDHI_FIFTEENTH.Find(id);
            if (eMP_RIDHI_FIFTEENTH == null)
            {
                return NotFound();
            }

            return Ok(eMP_RIDHI_FIFTEENTH);
        }

        // PUT: api/EMP_RIDHI_FIFTEEN/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEMP_RIDHI_FIFTEENTH(int id, EMP_RIDHI_FIFTEENTH eMP_RIDHI_FIFTEENTH)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eMP_RIDHI_FIFTEENTH.EMPId)
            {
                return BadRequest();
            }

            db.Entry(eMP_RIDHI_FIFTEENTH).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EMP_RIDHI_FIFTEENTHExists(id))
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

        // POST: api/EMP_RIDHI_FIFTEEN
        [ResponseType(typeof(EMP_RIDHI_FIFTEENTH))]
        public IHttpActionResult PostEMP_RIDHI_FIFTEENTH(EMP_RIDHI_FIFTEENTH eMP_RIDHI_FIFTEENTH)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EMP_RIDHI_FIFTEENTH.Add(eMP_RIDHI_FIFTEENTH);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = eMP_RIDHI_FIFTEENTH.EMPId }, eMP_RIDHI_FIFTEENTH);
        }

        // DELETE: api/EMP_RIDHI_FIFTEEN/5
        [ResponseType(typeof(EMP_RIDHI_FIFTEENTH))]
        public IHttpActionResult DeleteEMP_RIDHI_FIFTEENTH(int id)
        {
            EMP_RIDHI_FIFTEENTH eMP_RIDHI_FIFTEENTH = db.EMP_RIDHI_FIFTEENTH.Find(id);
            if (eMP_RIDHI_FIFTEENTH == null)
            {
                return NotFound();
            }

            db.EMP_RIDHI_FIFTEENTH.Remove(eMP_RIDHI_FIFTEENTH);
            db.SaveChanges();

            return Ok(eMP_RIDHI_FIFTEENTH);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EMP_RIDHI_FIFTEENTHExists(int id)
        {
            return db.EMP_RIDHI_FIFTEENTH.Count(e => e.EMPId == id) > 0;
        }
    }
}