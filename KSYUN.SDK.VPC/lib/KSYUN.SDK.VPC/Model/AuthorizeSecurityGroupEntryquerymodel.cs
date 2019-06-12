using KSYUN.SDK.VPC.JSONValid;
using Manatee.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using Manatee.Json.Serialization;
using Manatee.Json.Schema;
using System;

namespace KSYUN.SDK.VPC.Model.AuthorizeSecurityGroupEntry.query
{
    public class AuthorizeSecurityGroupEntryqueryModel
    {
        public JsonSchema _schema;
        public AuthorizeSecurityGroupEntryqueryModel()
        {
            JsonSerializer serializer = new JsonSerializer();
            JsonValue json = JsonValue.Parse("{\"type\":\"object\",\"properties\":{\"Action\":{\"type\":\"string\",\"enum\":[\"AuthorizeSecurityGroupEntry\"],\"default\":\"AuthorizeSecurityGroupEntry\"},\"Version\":{\"type\":\"string\",\"default\":\"2016-03-04\"},\"SecurityGroupId\":{\"type\":\"string\"},\"CidrBlock\":{\"type\":\"string\"},\"Description\":{\"type\":\"string\"},\"Direction\":{\"type\":\"string\"},\"Protocol\":{\"type\":\"string\"},\"IcmpType\":{\"type\":\"integer\"},\"IcmpCode\":{\"type\":\"integer\"},\"PortRangeFrom\":{\"type\":\"integer\"},\"PortRangeTo\":{\"type\":\"integer\"}}}");
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