using DesafioEcommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DesafioEcommerce.DAL
{
    public class ProductDAL : BaseDAL<Product>
    {
        protected override DbSet<Product> GetCollection()
        {
            return DbContext.Products;
        }

        /// <summary>
        /// Obtém todos os produtos ordenados por nome
        /// </summary>
        /// <returns></returns>
        public new IQueryable<Product> GetAll()
        {
            return base.GetAll().OrderBy(p => p.Name);
        }
    }
}
