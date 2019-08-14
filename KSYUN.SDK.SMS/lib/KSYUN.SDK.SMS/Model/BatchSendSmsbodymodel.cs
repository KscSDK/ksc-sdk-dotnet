using KSYUN.SDK.SMS.JSONValid;
using Manatee.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using Manatee.Json.Serialization;
using Manatee.Json.Schema;
using System;

namespace KSYUN.SDK.SMS.Model.BatchSendSms.body
{
    public class BatchSendSmsbodyModel
    {
        public JsonSchema _schema;
        public BatchSendSmsbodyModel()
        {
            JsonSerializer serializer = new JsonSerializer();
            JsonValue json = JsonValue.Parse("{\"type\":\"object\",\"properties\":{\"Mobile\":{\"type\":\"string\"},\"SignName\":{\"type\":\"string\"},\"TplId\":{\"type\":\"string\"},\"TplParams\":{\"type\":\"string\"},\"Content\":{\"type\":\"string\"},\"SmsType\":{\"type\":\"string\"}}}");
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