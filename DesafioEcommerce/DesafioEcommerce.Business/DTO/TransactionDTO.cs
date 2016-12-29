using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEcommerce.Business.DTO
{
    public class TransactionDTO
    {
        public List<CreditCardTransactionDTO> CreditCardTransactionCollection { get; set; }

        public OrderDTO Order { get; set; }

        public TransactionDTO()
        {
            CreditCardTransactionCollection = new List<CreditCardTransactionDTO>();
        }
    }
}
