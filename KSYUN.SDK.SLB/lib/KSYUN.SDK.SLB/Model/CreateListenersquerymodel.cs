using KSYUN.SDK.SLB.JSONValid;
using Manatee.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using Manatee.Json.Serialization;
using Manatee.Json.Schema;
using System;

namespace KSYUN.SDK.SLB.Model.CreateListeners.query
{
    public class CreateListenersqueryModel
    {
        public JsonSchema _schema;
        public CreateListenersqueryModel()
        {
            JsonSerializer serializer = new JsonSerializer();
            JsonValue json = JsonValue.Parse("{\"type\":\"object\",\"properties\":{\"Action\":{\"type\":\"string\",\"enum\":[\"CreateListeners\"],\"default\":\"CreateListeners\"},\"Version\":{\"type\":\"string\",\"default\":\"2016-03-04\"},\"LoadBalancerId\":{\"type\":\"string\"},\"ListenerState\":{\"type\":\"string\",\"default\":\"stat\"},\"ListenerName\":{\"type\":\"string\",\"default\":\"ksc_listener\"},\"ListenerProtocol\":{\"type\":\"string\",\"default\":\"HTTP\"},\"CertificateId\":{\"type\":\"string\"},\"ListenerPort\":{\"type\":\"integer\"},\"Method\":{\"type\":\"string\",\"default\":\"RoundRobin\"},\"SessionState\":{\"type\":\"string\",\"default\":\"start\"},\"SessionPersistencePeriod\":{\"type\":\"integer\",\"default\":3600},\"CookieType\":{\"type\":\"string\",\"default\":\"ImplantCookie\"},\"CookieName\":{\"type\":\"string\"}}}");
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