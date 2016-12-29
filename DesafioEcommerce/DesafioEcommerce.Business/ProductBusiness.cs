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
    public class ProductBusiness
    {
        /// <summary>
        /// Obtém todos os produtos na base
        /// </summary>
        /// <returns></returns>
        public List<ProductDTO> GetAllProducts()
        {
            var productDal = new ProductDAL();
            var listProducts = productDal.GetAll().ToList();

            var lstDTO = CustomMapper.Map<Product, ProductDTO>(listProducts);

            return lstDTO;
        }

        /// <summary>
        /// Obtém um produto por Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProductDTO GetProduct(Guid id)
        {
            var productDal = new ProductDAL();
            var product = productDal.GetById(id);

            var dto = CustomMapper.Map<Product, ProductDTO>(product);

            return dto;
        }
    }
}
