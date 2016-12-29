using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEcommerce.MundipaggApi.Model
{
    public class CreditCardTransaction
    {
        public int AmountInCents { get; set; }

        public int InstallmentCount { get; set; }

        public CreditCard CreditCard { get; set; }
        public string CreditCardOperation { get; set; }
    }
}
