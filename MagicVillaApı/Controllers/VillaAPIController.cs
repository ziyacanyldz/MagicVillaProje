using MagicVillaApı.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagicVillaApı.Controllers
{
    [ApiController]
    [Route("api/VillaApi")]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Villa> GetVillas()
        {
            return new List<Villa> {
            new Villa{Id=1,Name="Pool View" },
            new Villa{Id=2,Name="Beach View" }
            };
        }
    }
}
