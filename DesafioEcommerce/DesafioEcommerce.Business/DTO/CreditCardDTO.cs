using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEcommerce.Business.DTO
{
    public class CreditCardDTO
    {
        public string CreditCardBrand { get; set; }

        public string CreditCardNumber { get; set; }

        public int ExpMonth { get; set; }

        public int ExpYear { get; set; }

        public string HolderName { get; set; }

        public string SecurityCode { get; set; }
    }
}
