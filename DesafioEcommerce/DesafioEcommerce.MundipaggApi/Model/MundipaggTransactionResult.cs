using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEcommerce.MundipaggApi.Model
{
    public class ErrorItem
    {
        public string Description { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorField { get; set; }
        public string SeverityCode { get; set; }
    }

    public class ErrorReport
    {
        public string Category { get; set; }
        public List<ErrorItem> ErrorItemCollection { get; set; }
    }

    public class CreditCardTransactionResult
    {
        public string AcquirerMessage { get; set; }
        public string AcquirerName { get; set; }
        public string AcquirerReturnCode { get; set; }
        public string AffiliationCode { get; set; }
        public int AmountInCents { get; set; }
        public string AuthorizationCode { get; set; }
        public int AuthorizedAmountInCents { get; set; }
        public int CapturedAmountInCents { get; set; }
        public string CapturedDate { get; set; }
        public CreditCard CreditCard { get; set; }
        public string CreditCardOperation { get; set; }
        public string CreditCardTransactionStatus { get; set; }
        public object DueDate { get; set; }
        public object EstablishmentCode { get; set; }
        public int ExternalTime { get; set; }
        public string PaymentMethodName { get; set; }
        public object RefundedAmountInCents { get; set; }
        public bool Success { get; set; }
        public string ThirdPartyAffiliationCode { get; set; }
        public string TransactionIdentifier { get; set; }
        public string TransactionKey { get; set; }
        public string TransactionKeyToAcquirer { get; set; }
        public string TransactionReference { get; set; }
        public string UniqueSequentialNumber { get; set; }
        public object VoidedAmountInCents { get; set; }
    }

    public class OrderResult
    {
        public string CreateDate { get; set; }
        public string OrderKey { get; set; }
        public string OrderReference { get; set; }
    }

    public class MundipaggTransactionResult
    {
        public ErrorReport ErrorReport { get; set; }
        public int InternalTime { get; set; }
        public string MerchantKey { get; set; }
        public string RequestKey { get; set; }
        public string BuyerKey { get; set; }
        public List<CreditCardTransactionResult> CreditCardTransactionResultCollection { get; set; }
        public object OnlineDebitTransactionResult { get; set; }
        public OrderResult OrderResult { get; set; }
    }

}
