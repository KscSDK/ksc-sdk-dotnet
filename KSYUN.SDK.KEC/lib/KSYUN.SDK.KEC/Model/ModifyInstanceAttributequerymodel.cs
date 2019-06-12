using KSYUN.SDK.KEC.JSONValid;
using Manatee.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using Manatee.Json.Serialization;
using Manatee.Json.Schema;
using System;

namespace KSYUN.SDK.KEC.Model.ModifyInstanceAttribute.query
{
    public class ModifyInstanceAttributequeryModel
    {
        public JsonSchema _schema;
        public ModifyInstanceAttributequeryModel()
        {
            JsonSerializer serializer = new JsonSerializer();
            JsonValue json = JsonValue.Parse("{\"type\":\"object\",\"properties\":{\"Action\":{\"type\":\"string\",\"description\":\"Action 修改实例属性信息\",\"enum\":[\"ModifyInstanceAttribute\"],\"default\":\"ModifyInstanceAttribute\"},\"Version\":{\"type\":\"string\",\"description\":\"Action Version\",\"enum\":[\"2016-03-04\"],\"default\":\"2016-03-04\"},\"InstanceId\":{\"type\":\"string\",\"description\":\"待修改属性的实例ID\"},\"InstanceName\":{\"type\":\"string\",\"description\":\"实例名称，修改实例名称不需要关闭实例\"},\"InstancePassword\":{\"type\":\"string\",\"description\":\"实例开机密码，修改实例开机密码需要关闭实例\"}},\"required\":[\"Action\",\"Version\"]}");
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