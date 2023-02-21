using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.OData;
using lavomaticApp.Dal;

namespace lavomaticApp.Controllers
{
    public class LaundriesController : ODataController
    {
        private lavomaticDbEntities db = new lavomaticDbEntities();

        // GET: odata/Laundries
        [EnableQuery]
        public IQueryable<Laundry> GetLaundries()
        {
            return db.Laundries;
        }

        // GET: odata/Laundries(5)
        [EnableQuery]
        public SingleResult<Laundry> GetLaundry([FromODataUri] long key)
        {
            return SingleResult.Create(db.Laundries.Where(laundry => laundry.Id == key));
        }

        // PUT: odata/Laundries(5)
        public IHttpActionResult Put([FromODataUri] long key, Delta<Laundry> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Laundry laundry = db.Laundries.Find(key);
            if (laundry == null)
            {
                return NotFound();
            }

            patch.Put(laundry);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LaundryExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(laundry);
        }

        // POST: odata/Laundries
        public IHttpActionResult Post(Laundry laundry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Laundries.Add(laundry);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (LaundryExists(laundry.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Created(laundry);
        }

        // PATCH: odata/Laundries(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] long key, Delta<Laundry> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Laundry laundry = db.Laundries.Find(key);
            if (laundry == null)
            {
                return NotFound();
            }

            patch.Patch(laundry);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LaundryExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(laundry);
        }

        // DELETE: odata/Laundries(5)
        public IHttpActionResult Delete([FromODataUri] long key)
        {
            Laundry laundry = db.Laundries.Find(key);
            if (laundry == null)
            {
                return NotFound();
            }

            db.Laundries.Remove(laundry);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/Laundries(5)/Dryer
        [EnableQuery]
        public SingleResult<Dryer> GetDryer([FromODataUri] long key)
        {
            return SingleResult.Create(db.Laundries.Where(m => m.Id == key).Select(m => m.Dryer));
        }

        // GET: odata/Laundries(5)/LaundryExt
        [EnableQuery]
        public SingleResult<LaundryExt> GetLaundryExt([FromODataUri] long key)
        {
            return SingleResult.Create(db.Laundries.Where(m => m.Id == key).Select(m => m.LaundryExt));
        }

        // GET: odata/Laundries(5)/Washer
        [EnableQuery]
        public SingleResult<Washer> GetWasher([FromODataUri] long key)
        {
            return SingleResult.Create(db.Laundries.Where(m => m.Id == key).Select(m => m.Washer));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LaundryExists(long key)
        {
            return db.Laundries.Count(e => e.Id == key) > 0;
        }
    }
}
