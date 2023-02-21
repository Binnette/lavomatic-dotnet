using System.Linq;
using System.Web.Http.OData;
using lavomaticApp.Dal;
using lavomaticApp.Dto;

namespace lavomaticApp.Controllers
{
    public class DtoLaundriesController : ODataController
    {
        private lavomaticDbEntities db = new lavomaticDbEntities();

        // GET: odata/DtoLaundries
        [EnableQuery]
        public IQueryable<DtoLaundry> GetDtoLaundries()
        {
            return db.Laundries.Select(l => new DtoLaundry
            {
                Id = l.Id,
                Na = l.Name,
                La = l.Lat,
                Lo = l.Lon,
                Ho = l.OpenHours,
                Ch = l.WheelChair
            });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
