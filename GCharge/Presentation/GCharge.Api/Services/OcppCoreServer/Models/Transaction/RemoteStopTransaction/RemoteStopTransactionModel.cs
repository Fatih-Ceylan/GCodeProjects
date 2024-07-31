using Newtonsoft.Json;

namespace GCharge.Api.Services.OcppCoreServer.Models.Transaction.RemoteStopTransaction
{
    public class RemoteStopTransactionModel
    {
        [JsonProperty("connectorId")]
        public int ConnectorId { get; set; }

        [JsonProperty("idTag")]
        public string IdTag { get; set; }
    }
}
