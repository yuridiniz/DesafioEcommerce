using DesafioEcommerce.MundipaggApi.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEcommerce.MundipaggApi
{
    public class MundipaggTransaction
    {
        private readonly static String URLEndPoint = "https://sandbox.mundipaggone.com";

        /// <summary>
        /// Realiza uma compra utilizando cartão de crédito
        /// </summary>
        /// <param name="transaction"></param>
        public static MundipaggTransactionResult CreditCard(String merchantKey, TransactionModel transaction)
        {
            try {
                var strJson = Post("/Sale", merchantKey, transaction);
                if (String.IsNullOrEmpty(strJson))
                    return null;

                var resultObj = JsonConvert.DeserializeObject<MundipaggTransactionResult>(strJson);
                return resultObj;
            }
            catch(Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Realiza o envio da requisição para efetuar o pagamento
        /// </summary>
        /// <param name="senderObj"></param>
        /// <returns></returns>
        private static String Post(String pathMethod, String merchantKey, ITransactionSender senderObj)
        {
            String result = String.Empty;

            try {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(URLEndPoint + pathMethod);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Accept = "application/json";
                httpWebRequest.Headers.Add("MerchantKey", merchantKey);
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(senderObj);

                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                using (var stream = ex.Response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
            }

            return result;
        }
    }
}
