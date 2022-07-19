using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

namespace StarChart.Controllers
{
    [Route("")]
    [ApiController()]
    public class CelestialObjectController : ControllerBase
    {
        private ApplicationDbContext _context { get; set; }

        public CelestialObjectController(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }
    }
}
