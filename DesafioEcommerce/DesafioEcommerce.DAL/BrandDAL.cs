using DesafioEcommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DesafioEcommerce.DAL
{
    public class BrandDAL : BaseDAL<Brand>
    {
        protected override DbSet<Brand> GetCollection()
        {
            return DbContext.Brands;
        }

        /// <summary>
        /// Obtém todas as bandeiras ordenadas por descricao
        /// </summary>
        /// <returns></returns>
        public new IQueryable<Brand> GetAll()
        {
            return base.GetAll().OrderBy(p => p.Descricao);
        }

    }
}
