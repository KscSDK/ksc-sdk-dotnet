using KSYUN.SDK.SLB.JSONValid;
using Manatee.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using Manatee.Json.Serialization;
using Manatee.Json.Schema;
using System;

namespace KSYUN.SDK.SLB.Model.DescribeLoadBalancerAcls.query
{
    public class DescribeLoadBalancerAclsqueryModel
    {
        public JsonSchema _schema;
        public DescribeLoadBalancerAclsqueryModel()
        {
            JsonSerializer serializer = new JsonSerializer();
            JsonValue json = JsonValue.Parse("{\"type\":\"object\",\"properties\":{\"Action\":{\"type\":\"string\",\"enum\":[\"DescribeLoadBalancerAcls\"],\"default\":\"DescribeLoadBalancerAcls\"},\"Version\":{\"type\":\"string\",\"default\":\"2016-03-04\"},\"LoadBalancerAclId\":{\"type\":\"string\"},\"Filter\":{\"items\":{\"type\":\"object\",\"properties\":{\"Name\":{\"type\":\"string\"},\"Values\":{\"type\":\"string\"}}}},\"MaxResults\":{\"type\":\"integer\"},\"NextToken\":{\"type\":\"string\"}}}");
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