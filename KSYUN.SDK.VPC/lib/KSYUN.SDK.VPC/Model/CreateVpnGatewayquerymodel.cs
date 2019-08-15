using KSYUN.SDK.VPC.JSONValid;
using Manatee.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using Manatee.Json.Serialization;
using Manatee.Json.Schema;
using System;

namespace KSYUN.SDK.VPC.Model.CreateVpnGateway.query
{
    public class CreateVpnGatewayqueryModel
    {
        public JsonSchema _schema;
        public CreateVpnGatewayqueryModel()
        {
            JsonSerializer serializer = new JsonSerializer();
            JsonValue json = JsonValue.Parse("{\"type\":\"object\",\"properties\":{\"Action\":{\"type\":\"string\",\"enum\":[\"CreateVpnGateway\"],\"default\":\"CreateVpnGateway\"},\"Version\":{\"type\":\"string\",\"default\":\"2016-03-04\"},\"VpnGatewayName\":{\"type\":\"string\",\"default\":\"Ksc_Vpn\"},\"BandWidth\":{\"type\":\"integer\"},\"VpcId\":{\"type\":\"string\"},\"ChargeType\":{\"type\":\"string\"},\"PurchaseTime\":{\"type\":\"integer\"},\"ProjectId\":{\"type\":\"string\"}}}");
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