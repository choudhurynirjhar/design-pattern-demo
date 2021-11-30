using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FactoryMethodPattern.Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LawnmowerCatalogController : ControllerBase
    {
        private readonly Func<string, ILawnmowerCatalogFactory> lawnmowerCatalogAbstractFactory;

        public LawnmowerCatalogController(Func<string, ILawnmowerCatalogFactory> lawnmowerCatalogAbstractFactory)
        {
            this.lawnmowerCatalogAbstractFactory = lawnmowerCatalogAbstractFactory;
        }

        // GET api/<LawnmowerCatalogController>/5
        [HttpGet]
        public IEnumerable<Lawnmower> Get(string manufacturer, string type)
        {
            return lawnmowerCatalogAbstractFactory(manufacturer).CreateCatalog(type).GetLawnmowers();
        }
    }
}
