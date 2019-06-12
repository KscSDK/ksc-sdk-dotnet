using KSYUN.SDK.SLB.JSONValid;
using Manatee.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using Manatee.Json.Serialization;
using Manatee.Json.Schema;
using System;

namespace KSYUN.SDK.SLB.Model.ConfigureHealthCheck.query
{
    public class ConfigureHealthCheckqueryModel
    {
        public JsonSchema _schema;
        public ConfigureHealthCheckqueryModel()
        {
            JsonSerializer serializer = new JsonSerializer();
            JsonValue json = JsonValue.Parse("{\"type\":\"object\",\"properties\":{\"Action\":{\"type\":\"string\",\"enum\":[\"ConfigureHealthCheck\"],\"default\":\"ConfigureHealthCheck\"},\"Version\":{\"type\":\"string\",\"default\":\"2016-03-04\"},\"ListenerId\":{\"type\":\"string\"},\"HealthCheckState\":{\"type\":\"string\",\"default\":\"start\"},\"HealthyThreshold\":{\"type\":\"integer\"},\"Interval\":{\"type\":\"integer\"},\"Timeout\":{\"type\":\"integer\"},\"UnhealthyThreshold\":{\"type\":\"integer\"},\"UrlPath\":{\"type\":\"string\"},\"IsDefaultHostName\":{\"type\":\"boolean\",\"default\":true},\"HostName\":{\"type\":\"string\"}}}");
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