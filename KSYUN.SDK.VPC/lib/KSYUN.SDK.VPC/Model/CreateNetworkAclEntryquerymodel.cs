using KSYUN.SDK.VPC.JSONValid;
using Manatee.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using Manatee.Json.Serialization;
using Manatee.Json.Schema;
using System;

namespace KSYUN.SDK.VPC.Model.CreateNetworkAclEntry.query
{
    public class CreateNetworkAclEntryqueryModel
    {
        public JsonSchema _schema;
        public CreateNetworkAclEntryqueryModel()
        {
            JsonSerializer serializer = new JsonSerializer();
            JsonValue json = JsonValue.Parse("{\"type\":\"object\",\"properties\":{\"Action\":{\"type\":\"string\",\"enum\":[\"CreateNetworkAclEntry\"],\"default\":\"CreateNetworkAclEntry\"},\"Version\":{\"type\":\"string\",\"default\":\"2016-03-04\"},\"Description\":{\"type\":\"string\"},\"NetworkAclId\":{\"type\":\"string\"},\"CidrBlock\":{\"type\":\"string\"},\"RuleNumber\":{\"type\":\"integer\"},\"Direction\":{\"type\":\"string\"},\"RuleAction\":{\"type\":\"string\"},\"Protocol\":{\"type\":\"string\"},\"IcmpType\":{\"type\":\"integer\"},\"PortRangeFrom\":{\"type\":\"integer\"},\"PortRangeTo\":{\"type\":\"integer\"}}}");
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