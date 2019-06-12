using KSYUN.SDK.EIP.JSONValid;
using Manatee.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using Manatee.Json.Serialization;
using Manatee.Json.Schema;
using System;

namespace KSYUN.SDK.EIP.Model.ModifyAddress.query
{
    public class ModifyAddressqueryModel
    {
        public JsonSchema _schema;
        public ModifyAddressqueryModel()
        {
            JsonSerializer serializer = new JsonSerializer();
            JsonValue json = JsonValue.Parse("{\"type\":\"object\",\"properties\":{\"Action\":{\"type\":\"string\",\"description\":\"Action 更新弹性IP配置\",\"enum\":[\"ModifyAddress\"],\"default\":\"ModifyAddress\"},\"Version\":{\"type\":\"string\",\"description\":\"Action版本\",\"enum\":[\"2016-03-04\"],\"default\":\"2016-03-04\"},\"AllocationId\":{\"type\":\"string\"},\"BandWidth\":{\"type\":\"integer\"}},\"required\":[\"Version\"]}");
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