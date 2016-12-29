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
    public class BrandsController : ApiController
    {
        [Route("api/brands")]
        public IEnumerable<BrandDTO> Get()
        {
            var brandsBusiness = new BrandBusiness();
            var brands = brandsBusiness.GetAllBrands();
            return brands;
        }
    }
}
