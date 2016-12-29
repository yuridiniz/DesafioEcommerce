using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEcommerce.Business.DTO
{
    public class CreditCardTransactionResultDTO
    {
        public bool Success { get; set; }

        public List<string> Messages { get; set; }

        public CreditCardTransactionResultDTO()
        {
            Messages = new List<string>();
        }
    }
}

