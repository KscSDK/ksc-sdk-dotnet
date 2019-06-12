using KSYUN.SDK.KEC.JSONValid;
using Manatee.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using Manatee.Json.Serialization;
using Manatee.Json.Schema;
using System;

namespace KSYUN.SDK.KEC.Model.RunInstances.query
{
    public class RunInstancesqueryModel
    {
        public JsonSchema _schema;
        public RunInstancesqueryModel()
        {
            JsonSerializer serializer = new JsonSerializer();
            JsonValue json = JsonValue.Parse("{\"type\":\"object\",\"properties\":{\"Action\":{\"type\":\"string\",\"description\":\"创建实例\",\"enum\":[\"RunInstances\"],\"default\":\"RunInstances\"},\"Version\":{\"type\":\"string\",\"description\":\"Action版本\",\"enum\":[\"2016-03-04\"],\"default\":\"2016-03-04\"},\"ImageId\":{\"type\":\"string\",\"description\":\"镜像ID\"},\"InstanceType\":{\"type\":\"string\",\"description\":\"实例套餐类型\",\"default\":\"I1.1A\"},\"SystemDisk\":{\"type\":\"object\",\"description\":\"云主机系统盘配置参数。若不指定该参数，则按照系统默认值进行分配\",\"properties\":{\"DiskType\":{\"type\":\"string\"},\"DiskSize\":{\"type\":\"integer\"}}},\"DataDiskGb\":{\"type\":\"integer\",\"description\":\"数据卷容量，单位GB，容量限制依据 实例套餐类型定义 变化\"},\"DataDisk\":{\"type\":\"array\",\"description\":\"数据盘参数\",\"items\":{\"type\":\"object\",\"properties\":{\"DeleteWithInstance\":{\"type\":\"boolean\",\"default\":false},\"Type\":{\"type\":\"string\"},\"Size\":{\"type\":\"integer\"}}}},\"MaxCount\":{\"type\":\"integer\",\"description\":\"最大实例数，当前用户允许创建的最大实例数\"},\"MinCount\":{\"type\":\"integer\",\"description\":\"最小实例数，如果用户指定的实例数大于金山云在本Region所能创建的最大实例数或者小于最小实例数，都不会创建任何实例\"},\"SubnetId\":{\"type\":\"string\",\"description\":\"VPC环境下的子网ID，绑定到主网卡\"},\"InstancePassword\":{\"type\":\"string\",\"description\":\"实例开机密码\"},\"KeepImageLogin\":{\"type\":\"boolean\",\"description\":\"保留镜像设置登录。\",\"default\":false},\"ChargeType\":{\"type\":\"string\",\"description\":\"计费类型，调用时需要明确指定\"},\"PurchaseTime\":{\"type\":\"integer\",\"description\":\"购买时长，单位月 , 当计费类型为Monthly（包年包月）时，有效值1-36；其他计费类型时，强制要求参数值为0\"},\"SecurityGroupId\":{\"type\":\"string\",\"description\":\"实例绑定的安全组，目前仅支持绑定一个安全组\"},\"PrivateIpAddress\":{\"type\":\"string\",\"description\":\"私有IP地址，指定子网IP地址范围内的任意有效值，代表实例的主IP地址，只能选择一个，绑定到主网卡；如果未指定该参数，系统自动从有效地址池中随机选取一个\"},\"InstanceName\":{\"type\":\"string\",\"description\":\"实例名称，如果未指定，则自动生成，形如KSC-IN-[A-Z0-9]{10}\"},\"InstanceNameSuffix\":{\"type\":\"string\",\"description\":\"实例名称后缀，InstanceName参数如果缺省，此参数不生效；当大于1台的批量创建主机，后缀编号自动+1，例如后缀输入5，主机名输入\"host\"，批量3台，则生成的三台主机名分别为：\"host-5\"、\"host-6\"、\"host-7\"；\",\"default\":\"\"},\"SriovNetSupport\":{\"type\":\"boolean\",\"description\":\"联网增强属性\",\"default\":false},\"ProjectId\":{\"type\":\"integer\",\"description\":\"实例所属项目ID\"},\"DataGuardId\":{\"type\":\"string\",\"description\":\"容灾分组ID\"},\"KeyId\":{\"type\":\"array\",\"description\":\"密钥ID\",\"items\":{\"type\":\"string\"}},\"AddressBandWidth\":{\"type\":\"integer\",\"description\":\"弹性IP的带宽 ,购买弹性IP时不可缺省\"},\"LineId\":{\"type\":\"string\",\"description\":\"弹性IP的链路类型的ID\"},\"AddressChargeType\":{\"type\":\"string\",\"description\":\"弹性IP的计费类型\"},\"AddressPurchaseTime\":{\"type\":\"integer\",\"description\":\"弹性IP的购买时长，只有购买包年包月弹性IP时不可缺省。\"},\"AddressProjectId\":{\"type\":\"string\",\"description\":\"弹性IP项目的ID\"}},\"required\":[\"Action\",\"Version\"]}");
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