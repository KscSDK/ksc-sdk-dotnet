using KSYUN.SDK.KEC.JSONValid;
using Manatee.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using Manatee.Json.Serialization;
using Manatee.Json.Schema;
using System;

namespace KSYUN.SDK.KEC.Model.DescribeInstanceTypeConfigs.query
{
    public class DescribeInstanceTypeConfigsqueryModel
    {
        public JsonSchema _schema;
        public DescribeInstanceTypeConfigsqueryModel()
        {
            JsonSerializer serializer = new JsonSerializer();
            JsonValue json = JsonValue.Parse("{\"type\":\"object\",\"properties\":{\"Action\":{\"type\":\"string\",\"description\":\"Action 查询机型套餐\",\"enum\":[\"DescribeInstanceTypeConfigs\"],\"default\":\"DescribeInstanceTypeConfigs\"},\"Version\":{\"type\":\"string\",\"description\":\"Action Version\",\"enum\":[\"2016-03-04\"],\"default\":\"2016-03-04\"},\"filter\":{\"type\":\"array\",\"items\":{\"type\":\"string\"}}},\"required\":[\"Action\",\"Version\"]}");
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