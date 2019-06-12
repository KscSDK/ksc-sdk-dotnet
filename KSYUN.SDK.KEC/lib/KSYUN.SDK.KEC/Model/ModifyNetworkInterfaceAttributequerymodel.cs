using KSYUN.SDK.KEC.JSONValid;
using Manatee.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using Manatee.Json.Serialization;
using Manatee.Json.Schema;
using System;

namespace KSYUN.SDK.KEC.Model.ModifyNetworkInterfaceAttribute.query
{
    public class ModifyNetworkInterfaceAttributequeryModel
    {
        public JsonSchema _schema;
        public ModifyNetworkInterfaceAttributequeryModel()
        {
            JsonSerializer serializer = new JsonSerializer();
            JsonValue json = JsonValue.Parse("{\"type\":\"object\",\"properties\":{\"Action\":{\"type\":\"string\",\"description\":\"Action 修改网络接口属性信息\",\"enum\":[\"ModifyNetworkInterfaceAttribute\"],\"default\":\"ModifyNetworkInterfaceAttribute\"},\"Version\":{\"type\":\"string\",\"description\":\"Action Version\",\"enum\":[\"2016-03-04\"],\"default\":\"2016-03-04\"},\"InstanceId\":{\"type\":\"string\"},\"NetworkInterfaceId\":{\"type\":\"string\"},\"SecurityGroupId\":{\"type\":\"string\"},\"SubnetId\":{\"type\":\"string\"},\"PrivateIpAddress\":{\"type\":\"string\"},\"DNS1\":{\"type\":\"string\"},\"DNS2\":{\"type\":\"string\"}},\"required\":[\"Action\",\"Version\"]}");
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