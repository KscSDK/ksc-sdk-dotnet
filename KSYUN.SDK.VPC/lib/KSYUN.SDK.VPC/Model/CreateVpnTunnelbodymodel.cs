using KSYUN.SDK.VPC.JSONValid;
using Manatee.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using Manatee.Json.Serialization;
using Manatee.Json.Schema;
using System;

namespace KSYUN.SDK.VPC.Model.CreateVpnTunnel.body
{
    public class CreateVpnTunnelbodyModel
    {
        public JsonSchema _schema;
        public CreateVpnTunnelbodyModel()
        {
            JsonSerializer serializer = new JsonSerializer();
            JsonValue json = JsonValue.Parse("{\"type\":\"object\",\"properties\":{\"VpnTunnelName\":{\"type\":\"string\",\"default\":\"Ksc_vpn_tunnel\"},\"Type\":{\"type\":\"string\"},\"VpnGreIp\":{\"type\":\"string\"},\"HaVpnGreIp\":{\"type\":\"string\"},\"CustomerGreIp\":{\"type\":\"string\"},\"HaCustomerGreIp\":{\"type\":\"string\"},\"CustomerGatewayId\":{\"type\":\"string\"},\"PreSharedKey\":{\"type\":\"string\"},\"IkeAuthenAlgorithm\":{\"type\":\"string\",\"default\":\"md5\"},\"IkeDHGroup\":{\"type\":\"integer\",\"default\":1},\"IkeEncryAlgorithm\":{\"type\":\"string\",\"default\":\"aes\"},\"IpsecEncryAlgorithm\":{\"type\":\"string\",\"default\":\"esp-aes\"},\"IpsecAuthenAlgorithm\":{\"type\":\"string\",\"default\":\"esp-sha-hmac\"},\"IpsecLifetimeTraffic\":{\"type\":\"integer\"},\"IpsecLifetimeSecond\":{\"type\":\"integer\"}}}");
            _schema = serializer.Deserialize<JsonSchema>(json);
        }
        public JSONValidStruct validtor(JToken data)
        {
            JSONValidStruct _JSONValidStruct = new JSONValidStruct();

            JsonSerializer serializer = new JsonSerializer();

            JsonSchemaOptions.OutputFormat = SchemaValidationOutputFormat.List;

            JsonValue jsonvalue = JsonValue.Parse(data.ToString());

            SchemaValidationResults Results = _schema.Validate(jsonvalue);

            _JSONValidStruct.status = Results.IsValid;
            _JSONValidStruct.message = Results.ToJson(serializer).ToString();
            _JSONValidStruct.result = Results;

            return _JSONValidStruct;
        }
    }
}