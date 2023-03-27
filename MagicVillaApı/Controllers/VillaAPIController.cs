using MagicVillaApı.Models;
using MagicVillaAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace MagicVillaApı.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return VillaStore.villaList;
        }

        [HttpGet("{id:int}")]
        public VillaDTO? GetVilla(int id)
        {
            return VillaStore.villaList.FirstOrDefault(vl => vl.Id == id);
        }
    }
}
