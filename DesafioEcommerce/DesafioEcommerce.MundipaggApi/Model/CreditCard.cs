using System;

namespace DesafioEcommerce.MundipaggApi.Model
{
    public class CreditCard
    {
        public string CreditCardBrand { get; set; }

        public string CreditCardNumber { get; set; }

        public int ExpMonth { get; set; }

        public int ExpYear { get; set; }

        public string HolderName { get; set; }

        public string SecurityCode { get; set; }


    }
}