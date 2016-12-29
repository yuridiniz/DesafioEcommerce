using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEcommerce.Business.DTO
{
    public class CreditCardTransactionDTO
    {
        public int AmountInCents { get; set; }

        public int InstallmentCount { get; set; }

        public CreditCardDTO CreditCard { get; set; }

        public string CreditCardOperation { get; set; }
    }
}
