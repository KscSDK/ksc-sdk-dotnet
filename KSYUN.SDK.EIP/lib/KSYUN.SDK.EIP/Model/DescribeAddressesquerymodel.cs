using KSYUN.SDK.EIP.JSONValid;
using Manatee.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using Manatee.Json.Serialization;
using Manatee.Json.Schema;
using System;

namespace KSYUN.SDK.EIP.Model.DescribeAddresses.query
{
    public class DescribeAddressesqueryModel
    {
        public JsonSchema _schema;
        public DescribeAddressesqueryModel()
        {
            JsonSerializer serializer = new JsonSerializer();
            JsonValue json = JsonValue.Parse("{\"type\":\"object\",\"properties\":{\"Action\":{\"type\":\"string\",\"description\":\"Action 查询弹性IP\",\"enum\":[\"DescribeAddresses\"],\"default\":\"DescribeAddresses\"},\"Version\":{\"type\":\"string\",\"description\":\"Action版本\",\"enum\":[\"2016-03-04\"],\"default\":\"2016-03-04\"},\"AllocationId\":{\"type\":\"array\",\"items\":{\"type\":\"string\"}},\"ProjectId\":{\"type\":\"array\",\"items\":{\"type\":\"string\"}},\"Filter\":{\"type\":\"array\",\"items\":{\"type\":\"string\"}},\"MaxResults\":{\"type\":\"integer\",\"maximum\":1000,\"minimum\":5},\"NextToken\":{\"type\":\"string\"}},\"required\":[\"Version\"]}");
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