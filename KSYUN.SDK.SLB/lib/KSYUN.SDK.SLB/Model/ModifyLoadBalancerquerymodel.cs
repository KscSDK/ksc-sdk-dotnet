using KSYUN.SDK.SLB.JSONValid;
using Manatee.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using Manatee.Json.Serialization;
using Manatee.Json.Schema;
using System;

namespace KSYUN.SDK.SLB.Model.ModifyLoadBalancer.query
{
    public class ModifyLoadBalancerqueryModel
    {
        public JsonSchema _schema;
        public ModifyLoadBalancerqueryModel()
        {
            JsonSerializer serializer = new JsonSerializer();
            JsonValue json = JsonValue.Parse("{\"type\":\"object\",\"properties\":{\"Action\":{\"type\":\"string\",\"enum\":[\"ModifyLoadBalancer\"],\"default\":\"ModifyLoadBalancer\"},\"Version\":{\"type\":\"string\",\"default\":\"2016-03-04\"},\"LoadBalancerId\":{\"type\":\"string\"},\"LoadBalancerName\":{\"type\":\"string\"},\"LoadBalancerState\":{\"type\":\"string\",\"default\":\"start\"}},\"required\":[\"Action\"]}");
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