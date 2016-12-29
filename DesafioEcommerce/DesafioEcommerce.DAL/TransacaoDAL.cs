using DesafioEcommerce.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEcommerce.DAL
{
    public class TransacaoDAL : BaseDAL<Transaction>
    {
        protected override DbSet<Transaction> GetCollection()
        {
            return DbContext.Transacoes;
        }
    }
}
