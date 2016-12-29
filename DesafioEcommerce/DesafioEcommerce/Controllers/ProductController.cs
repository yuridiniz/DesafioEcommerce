using DesafioEcommerce.Business;
using DesafioEcommerce.Business.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DesafioEcommerce.Controllers
{
    public class ProductController : ApiController
    {
        [Route("api/products")]
        public IEnumerable<ProductDTO> Get()
        {
            var productBusiness = new ProductBusiness();
            var products = productBusiness.GetAllProducts();
            return products;
        }

        [Route("api/products/{id}")]
        public ProductDTO Get(Guid id)
        {
            var productBusiness = new ProductBusiness();
            var product = productBusiness.GetProduct(id);
            return product;
        }
    }
}
