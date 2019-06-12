using KSYUN.SDK.VPC.JSONValid;
using Manatee.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using Manatee.Json.Serialization;
using Manatee.Json.Schema;
using System;

namespace KSYUN.SDK.VPC.Model.ModifyVpnGateway.query
{
    public class ModifyVpnGatewayqueryModel
    {
        public JsonSchema _schema;
        public ModifyVpnGatewayqueryModel()
        {
            JsonSerializer serializer = new JsonSerializer();
            JsonValue json = JsonValue.Parse("{\"type\":\"object\",\"properties\":{\"Action\":{\"type\":\"string\",\"enum\":[\"ModifyVpnGateway\"],\"default\":\"ModifyVpnGateway\"},\"Version\":{\"type\":\"string\",\"default\":\"2016-03-04\"},\"VpnGatewayId\":{\"type\":\"string\"},\"VpnGatewayName\":{\"type\":\"string\"},\"BandWidth\":{\"type\":\"integer\"}}}");
            _schema = serializer.Deserialize<JsonSchema>(json);
        }
        public JSONValidStruct validtor(JObject data)
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