using KSYUN.SDK.VPC.JSONValid;
using Manatee.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using Manatee.Json.Serialization;
using Manatee.Json.Schema;
using System;

namespace KSYUN.SDK.VPC.Model.CreateNat.query
{
    public class CreateNatqueryModel
    {
        public JsonSchema _schema;
        public CreateNatqueryModel()
        {
            JsonSerializer serializer = new JsonSerializer();
            JsonValue json = JsonValue.Parse("{\"type\":\"object\",\"properties\":{\"Action\":{\"type\":\"string\",\"enum\":[\"CreateNat\"],\"default\":\"CreateNat\"},\"Version\":{\"type\":\"string\",\"default\":\"2016-03-04\"},\"VpcId\":{\"type\":\"string\"},\"NatName\":{\"type\":\"string\",\"default\":\"Ksc_Nat\"},\"NatMode\":{\"type\":\"string\"},\"NatType\":{\"type\":\"string\"},\"NatIpNumber\":{\"type\":\"integer\",\"default\":1},\"BandWidth\":{\"type\":\"integer\"},\"ChargeType\":{\"type\":\"string\"},\"PurchaseTime\":{\"type\":\"integer\"}}}");
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