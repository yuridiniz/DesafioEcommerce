using DesafioEcommerce.Business.DTO;
using DesafioEcommerce.Business.Util;
using DesafioEcommerce.DAL;
using DesafioEcommerce.Model;
using DesafioEcommerce.MundipaggApi;
using DesafioEcommerce.MundipaggApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEcommerce.Business
{
    public class TransactionBusiness
    {
        /// <summary>
        /// Realiza a compra e um produto
        /// </summary>
        public CreditCardTransactionResultDTO Purchase(string merchantKey, PurchaseDTO purchaseDTO)
        {
            var productDal = new ProductDAL();
            var brandsDal = new BrandDAL();
            var transactionDal = new TransacaoDAL();

            var brand = brandsDal.GetById(purchaseDTO.CreditCardBrandId);
            var product = productDal.GetById(purchaseDTO.ProductId);

            var creditCard = new CreditCard();
            creditCard.CreditCardBrand = brand != null ? brand.Valor : null;
            creditCard.CreditCardNumber = purchaseDTO.CreditCardNumber;
            creditCard.ExpMonth = purchaseDTO.ExpMonth;
            creditCard.ExpYear = purchaseDTO.ExpYear;
            creditCard.HolderName = purchaseDTO.HolderName;
            creditCard.SecurityCode = purchaseDTO.SecurityCode;

            var creditCardTransaction = new CreditCardTransaction();
            creditCardTransaction.AmountInCents = (int) (product.Price * 100);
            creditCardTransaction.InstallmentCount = 1;
            creditCardTransaction.CreditCard = creditCard;

            var transactionModel = new TransactionModel();
            transactionModel.Order = new Order();

            transactionModel.CreditCardTransactionCollection.Add(creditCardTransaction);

            var transactionEntity = new Transaction();
            transactionEntity.ProductId = purchaseDTO.ProductId;
            transactionEntity.OrderPrice = product.Price;
            transactionDal.Insert(transactionEntity);

            transactionModel.Order.OrderReference = transactionEntity.Id.ToString();

            var mundipaggResult = MundipaggTransaction.CreditCard(merchantKey, transactionModel);

            var creditCardTransacationResult = new CreditCardTransactionResultDTO();

            if (mundipaggResult == null)
            {
                creditCardTransacationResult.Success = false;
                creditCardTransacationResult.Messages.Add("Ocorreu um erro inexperado ao processar a transação, a compra não pode ser realizada, tente novamente");

            } else if(mundipaggResult.ErrorReport != null)
            {
                creditCardTransacationResult.Success = false;
                creditCardTransacationResult.Messages = mundipaggResult.ErrorReport.ErrorItemCollection.Select(p => p.Description).ToList();
            } else
            {
                creditCardTransacationResult.Success = true;
                creditCardTransacationResult.Messages.Add("Compra realizada com sucesso!");
            }

            return creditCardTransacationResult;
        }
    }
}
