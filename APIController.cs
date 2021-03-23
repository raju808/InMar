using InMarAPI.Models;
using InMarAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace InMarAPI.Controllers
{
    public class APIController : ApiController
    {
        private OfferService offerService;
        public APIController(OfferService _offerService)
        {
            offerService = _offerService;
        }


        [HttpGet]
        public IEnumerable<Products> Get()
        {
            var result = offerService.GetAllProducts();
            return result;
        }

        // GET: api/API/5
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody]Products value)
        {
            offerService.addProduct(value.ProductName, value.Price, value.Description);
        }

        // PUT: api/API/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/API/5
        public void Delete(int id)
        {
        }
    }
}
