using KSYUN.SDK.KEC.JSONValid;
using Manatee.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using Manatee.Json.Serialization;
using Manatee.Json.Schema;
using System;

namespace KSYUN.SDK.KEC.Model.ModifyInstanceType.query
{
    public class ModifyInstanceTypequeryModel
    {
        public JsonSchema _schema;
        public ModifyInstanceTypequeryModel()
        {
            JsonSerializer serializer = new JsonSerializer();
            JsonValue json = JsonValue.Parse("{\"type\":\"object\",\"properties\":{\"Action\":{\"type\":\"string\",\"description\":\"Action 升级实例套餐类型\",\"enum\":[\"ModifyInstanceType\"],\"default\":\"ModifyInstanceType\"},\"Version\":{\"type\":\"string\",\"description\":\"Action Version\",\"enum\":[\"2016-03-04\"],\"default\":\"2016-03-04\"},\"InstanceId\":{\"type\":\"string\",\"description\":\"待升级套餐类型的实例ID\"},\"InstanceType\":{\"type\":\"string\",\"description\":\"实例套餐类型\"},\"DataDiskGb\":{\"type\":\"integer\",\"description\":\"数据卷容量，单位GB，数据卷只能扩容或者保持不变，且不能低于 实例套餐类型定义 的最小值\"}},\"required\":[\"Action\",\"Version\"]}");
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