using APIfun.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIfun.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MarriottFoodController : ControllerBase
    {
        private IFoodRepository _foodRepository;
        public MarriottFoodController(IFoodRepository temp)
        {
            _foodRepository = temp;
        }
        [HttpGet]
        public IEnumerable<MarriottFood> Get()
        {
            var foodData = _foodRepository.Foods.ToArray();
            return foodData;
        }
    }
}
