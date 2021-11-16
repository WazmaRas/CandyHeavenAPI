using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyHeavenAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : Controller
    {
        [HttpGet]
        public IEnumerable<Models.ProductModel> GetProducts() 
        {
            return Data.ProductManager.GetProductList();
        }

      
    }
}
