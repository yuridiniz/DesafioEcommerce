using DesafioEcommerce.Business;
using DesafioEcommerce.Business.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;

namespace DesafioEcommerce.Controllers
{
    public class TransactionController : ApiController
    {
        [Route("api/transaction/")]
        [HttpPost]
        public CreditCardTransactionResultDTO Buy(PurchaseDTO purchase)
        {
            var transactionBusiness = new TransactionBusiness();
            var merchantKey = WebConfigurationManager.AppSettings["MPMerchantKey"];

            return transactionBusiness.Purchase(merchantKey, purchase);
        }
    }
}
