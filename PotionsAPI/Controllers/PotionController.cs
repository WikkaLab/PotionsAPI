using Microsoft.AspNetCore.Mvc;

namespace PotionsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PotionController : ControllerBase
    {
        private readonly ILogger<PotionController> _logger;

        public PotionController(ILogger<PotionController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPotions")]
        public IEnumerable<Potion> Get()
        {
            return GetPotions().ToArray();
        }

        private List<Potion> GetPotions()
        {
            List<Potion> potions = new List<Potion>
            {
                new Potion
                {
                    Name = "Flying",
                    Price = 50,
                    EffectDuration = 100
                },
                new Potion
                {
                    Name = "Healing",
                    Price = 10,
                    EffectDuration = 40
                },
                new Potion
                {
                    Name = "Animal friendship",
                    Price = 150,
                    EffectDuration = 240
                }
            };

            return potions;
        }
    }
}