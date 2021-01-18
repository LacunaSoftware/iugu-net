using Newtonsoft.Json;
using System.Collections.Generic;

namespace iugu.net.Response
{
    /// <summary>
    /// Representa a resposta da API para uma requisição de cobrança direta
    /// </summary>
    public class ChargeResponseMessage
    {
        /// <summary>
        /// Erros
        /// </summary>
        [JsonProperty("errors")]
        public Dictionary<string, object> Errors { get; set; }

        /// <summary>
        /// Url do boleto
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Informa se a cobrança foi gerada com sucesso
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// Número da fatura da cobrança
        /// </summary>
        [JsonProperty("invoice_id")]
        public string InvoiceId { get; set; }


        /// <summary>
        /// Mensagem de resposta
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Url do PDF da fatura paga
        /// </summary>
        [JsonProperty("pdf")]
        public string PdfUrl { get; set; }

        /// <summary>
        /// Código LR resultado da cobrança
        /// </summary>
        [JsonProperty("LR")]
        public string LrCode { get; set; }
    }

}
