using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEcommerce.Business.DTO
{
    public class PurchaseDTO
    {
        public int AmountInCents { get; set; }
        public Guid CreditCardBrandId { get; set; }
        public Guid ProductId { get; set; }
        public string CreditCardNumber { get; set; }
        public string CreditCardOperation { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public string HolderName { get; set; }
        public int InstallmentCount { get; set; }
        public string OrderReference { get; set; }
        public string SecurityCode { get; set; }
    }
}
