using KSYUN.SDK.KEC.JSONValid;
using Manatee.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using Manatee.Json.Serialization;
using Manatee.Json.Schema;
using System;

namespace KSYUN.SDK.KEC.Model.ModifyInstanceImage.query
{
    public class ModifyInstanceImagequeryModel
    {
        public JsonSchema _schema;
        public ModifyInstanceImagequeryModel()
        {
            JsonSerializer serializer = new JsonSerializer();
            JsonValue json = JsonValue.Parse("{\"type\":\"object\",\"properties\":{\"Action\":{\"type\":\"string\",\"description\":\"Action 更换或者重新安装实例操作系统\",\"enum\":[\"ModifyInstanceImage\"],\"default\":\"ModifyInstanceImage\"},\"Version\":{\"type\":\"string\",\"description\":\"Action Version\",\"enum\":[\"2016-03-04\"],\"default\":\"2016-03-04\"},\"InstanceId\":{\"type\":\"string\",\"description\":\"待更换或者重新安装操作系统的实例ID\"},\"ImageId\":{\"type\":\"string\",\"description\":\"待更换的镜像ID；如果缺省，表明无需改变镜像，只需重新安装实例的操作系统。\"},\"SystemDisk\":{\"type\":\"object\",\"description\":\"云主机系统盘配置参数。若不指定该参数，则按照系统默认值进行分配\",\"properties\":{\"DiskType\":{\"type\":\"string\"},\"DiskSize\":{\"type\":\"integer\"}}},\"InstancePassword\":{\"type\":\"string\",\"description\":\"实例开机密码\"},\"KeepImageLogin\":{\"type\":\"boolean\",\"description\":\"保留镜像设置登录\",\"default\":false}},\"required\":[\"Action\",\"Version\"]}");
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