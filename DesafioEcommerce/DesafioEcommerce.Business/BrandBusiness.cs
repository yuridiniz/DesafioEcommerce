using DesafioEcommerce.Business.DTO;
using DesafioEcommerce.Business.Util;
using DesafioEcommerce.DAL;
using DesafioEcommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEcommerce.Business
{
    public class BrandBusiness
    {
        /// <summary>
        /// Obtém todos as bandeiras na base
        /// </summary>
        /// <returns></returns>
        public List<BrandDTO> GetAllBrands()
        {
            var brandDal = new BrandDAL();
            var listBrands = brandDal.GetAll().ToList();

            var lstDTO = CustomMapper.Map<Brand, BrandDTO>(listBrands);

            return lstDTO;
        }
    }
}
