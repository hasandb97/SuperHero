using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace SuperHero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {

        private static List<SuperHero> MyHeroes = new List<SuperHero> {
        new SuperHero
            {
            Id = 1 ,
                Name="Ali" ,
                LastName = "ansari" ,
                FirstName = "mamad" ,
                Place = "nover"
            }
        };


        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
              return Ok(MyHeroes);
        }


        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            MyHeroes.Add(hero);
            return Ok(MyHeroes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetHeroById(int id)
        {
            var result = MyHeroes.Find(p => p.Id == id);
            if( result == null )
            {
                return BadRequest("Hero not found");
            }
            return Ok(result);
        }













    }
}
