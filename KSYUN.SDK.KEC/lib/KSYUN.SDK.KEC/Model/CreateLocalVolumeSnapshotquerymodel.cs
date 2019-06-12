using KSYUN.SDK.KEC.JSONValid;
using Manatee.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using Manatee.Json.Serialization;
using Manatee.Json.Schema;
using System;

namespace KSYUN.SDK.KEC.Model.CreateLocalVolumeSnapshot.query
{
    public class CreateLocalVolumeSnapshotqueryModel
    {
        public JsonSchema _schema;
        public CreateLocalVolumeSnapshotqueryModel()
        {
            JsonSerializer serializer = new JsonSerializer();
            JsonValue json = JsonValue.Parse("{\"type\":\"object\",\"properties\":{\"Action\":{\"type\":\"string\",\"description\":\"Action 创建本地盘快照\",\"enum\":[\"CreateLocalVolumeSnapshot\"],\"default\":\"CreateLocalVolumeSnapshot\"},\"Version\":{\"type\":\"string\",\"description\":\"Action Version\",\"enum\":[\"2016-03-04\"],\"default\":\"2016-03-04\"},\"LocalVolumeId\":{\"type\":\"string\"},\"LocalVolumeSnapshotName\":{\"type\":\"string\"},\"LocalVolumeSnapshotDesc\":{\"type\":\"string\"}},\"required\":[\"Action\",\"Version\"]}");
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