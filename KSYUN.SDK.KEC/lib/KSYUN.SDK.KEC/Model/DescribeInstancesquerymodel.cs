using KSYUN.SDK.KEC.JSONValid;
using Manatee.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using Manatee.Json.Serialization;
using Manatee.Json.Schema;
using System;

namespace KSYUN.SDK.KEC.Model.DescribeInstances.query
{
    public class DescribeInstancesqueryModel
    {
        public JsonSchema _schema;
        public DescribeInstancesqueryModel()
        {
            JsonSerializer serializer = new JsonSerializer();
            JsonValue json = JsonValue.Parse("{\"type\":\"object\",\"properties\":{\"Action\":{\"type\":\"string\",\"description\":\"Action 描述实例信息\",\"enum\":[\"DescribeInstances\"],\"default\":\"DescribeInstances\"},\"Version\":{\"type\":\"string\",\"description\":\"Action Version\",\"enum\":[\"2016-03-04\"],\"default\":\"2016-03-04\"},\"MaxResults\":{\"type\":\"integer\",\"description\":\"单次调用所返回的最大实例数目，取值为5~1000，超过1000记为1000\"},\"Marker\":{\"type\":\"integer\",\"description\":\"分页标识，单次调用未返回全部实例时，标记下次调用的返回值的起点，默认值是0\"},\"InstanceId\":{\"type\":\"array\",\"items\":{\"type\":\"string\"}},\"ProjectId\":{\"type\":\"array\",\"items\":{\"type\":\"integer\"}},\"Filter\":{\"type\":\"array\",\"items\":{\"type\":\"object\",\"properties\":{\"Name\":{\"type\":\"string\"},\"Value\":{\"type\":\"string\"}}}},\"Sort\":{\"type\":\"array\",\"description\":\"筛选器\",\"items\":{\"type\":\"object\",\"properties\":{\"Name\":{\"type\":\"string\"},\"Value\":{\"type\":\"string\"}}}},\"Search\":{\"type\":\"string\",\"description\":\"搜索条件，模糊匹配\"}},\"required\":[\"Action\",\"Version\"]}");
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