using KSYUN.SDK.EIP.JSONValid;
using Manatee.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using Manatee.Json.Serialization;
using Manatee.Json.Schema;
using System;

namespace KSYUN.SDK.EIP.Model.AllocateAddress.query
{
    public class AllocateAddressqueryModel
    {
        public JsonSchema _schema;
        public AllocateAddressqueryModel()
        {
            JsonSerializer serializer = new JsonSerializer();
            JsonValue json = JsonValue.Parse("{\"type\":\"object\",\"properties\":{\"Action\":{\"type\":\"string\",\"description\":\"Action 创建弹性IP\",\"enum\":[\"AllocateAddress\"],\"default\":\"AllocateAddress\"},\"Version\":{\"type\":\"string\",\"description\":\"Action Version\",\"enum\":[\"2016-03-04\"],\"default\":\"2016-03-04\"},\"LineId\":{\"type\":\"string\"},\"BandWidth\":{\"type\":\"integer\"},\"ChargeType\":{\"type\":\"string\"},\"PurchaseTime\":{\"type\":\"integer\"},\"ProjectId\":{\"type\":\"string\"}},\"required\":[\"Version\"]}");
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