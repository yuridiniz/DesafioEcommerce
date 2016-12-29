using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEcommerce.MundipaggApi.Model
{
    public class TransactionModel : ITransactionSender
    {
        public List<CreditCardTransaction> CreditCardTransactionCollection { get; set; }

        public Order Order { get; set; }

        public TransactionModel()
        {
            CreditCardTransactionCollection = new List<CreditCardTransaction>();
        }
    }
}
