# CSharp API SDK for namespace KSYUN.SDK.KEC classname KsyunKecClient 


- Build date: 2019-06-12 10:46
## Installation

Use .NET CLI

    dotnet add package 'KSYUN.SDK.KEC'


## Usage
```c#
using KSYUN.SDK.KEC;
```

## Dependency
```c#
using Newtonsoft.Json.Linq; //[JSON](https://www.newtonsoft.com/json/help/html/N_Newtonsoft_Json_Serialization.htm)
using RestSharp; //[Rest Request](https://github.com/restsharp/RestSharp/wiki/Usage-way)
using Manatee.Json; //[Schema Valid](https://gregsdennis.github.io/Manatee.Json/usage/schema.html)
```


## Documentation for API Endpoints
```bash
URL: {protocol}://{server}.{region}.api.ksyun.com
Parameters:
   region: 
   protocol: http | https
Constants:# no need setting
   server: "kec"
```

## Authentication
> use aws signature v4

## Configuration
```c#
using KSYUN.SDK.KEC;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";

        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );

    }
}


```

## Documentation For Method
Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*KsyunKecClient* | [**RunInstances**](#RunInstances) | **get** / | 
*KsyunKecClient* | [**StartInstances**](#StartInstances) | **get** / | 
*KsyunKecClient* | [**StopInstances**](#StopInstances) | **get** / | 
*KsyunKecClient* | [**RebootInstances**](#RebootInstances) | **get** / | 
*KsyunKecClient* | [**TerminateInstances**](#TerminateInstances) | **get** / | 
*KsyunKecClient* | [**ModifyInstanceImage**](#ModifyInstanceImage) | **get** / | 
*KsyunKecClient* | [**ModifyInstanceType**](#ModifyInstanceType) | **get** / | 
*KsyunKecClient* | [**ModifyInstanceAttribute**](#ModifyInstanceAttribute) | **get** / | 
*KsyunKecClient* | [**DescribeInstances**](#DescribeInstances) | **get** / | 
*KsyunKecClient* | [**DescribeInstanceVnc**](#DescribeInstanceVnc) | **get** / | 
*KsyunKecClient* | [**DescribeInstanceTypeConfigs**](#DescribeInstanceTypeConfigs) | **get** / | 
*KsyunKecClient* | [**DescribeInstanceFamilys**](#DescribeInstanceFamilys) | **get** / | 
*KsyunKecClient* | [**MonitorInstances**](#MonitorInstances) | **get** / | 
*KsyunKecClient* | [**UnmonitorInstances**](#UnmonitorInstances) | **get** / | 
*KsyunKecClient* | [**AttachNetworkInterface**](#AttachNetworkInterface) | **get** / | 
*KsyunKecClient* | [**ModifyNetworkInterfaceAttribute**](#ModifyNetworkInterfaceAttribute) | **get** / | 
*KsyunKecClient* | [**DetachNetworkInterface**](#DetachNetworkInterface) | **get** / | 
*KsyunKecClient* | [**CreateImage**](#CreateImage) | **get** / | 
*KsyunKecClient* | [**DescribeImages**](#DescribeImages) | **get** / | 
*KsyunKecClient* | [**RemoveImages**](#RemoveImages) | **get** / | 
*KsyunKecClient* | [**ModifyImageAttribute**](#ModifyImageAttribute) | **get** / | 
*KsyunKecClient* | [**ImportImage**](#ImportImage) | **get** / | 
*KsyunKecClient* | [**CopyImage**](#CopyImage) | **get** / | 
*KsyunKecClient* | [**DescribeImageSharePermission**](#DescribeImageSharePermission) | **get** / | 
*KsyunKecClient* | [**ModifyImageSharePermission**](#ModifyImageSharePermission) | **get** / | 
*KsyunKecClient* | [**CreateLocalVolumeSnapshot**](#CreateLocalVolumeSnapshot) | **get** / | 
*KsyunKecClient* | [**RollbackLocalVolume**](#RollbackLocalVolume) | **get** / | 
*KsyunKecClient* | [**DescribeLocalVolumeSnapshots**](#DescribeLocalVolumeSnapshots) | **get** / | 
*KsyunKecClient* | [**DeleteLocalVolumeSnapshot**](#DeleteLocalVolumeSnapshot) | **get** / | 
*KsyunKecClient* | [**DescribeLocalVolumes**](#DescribeLocalVolumes) | **get** / | 
*KsyunKecClient* | [**AttachKey**](#AttachKey) | **get** / | 
*KsyunKecClient* | [**DetachKey**](#DetachKey) | **get** / | 
*KsyunKecClient* | [**DescribeRegions**](#DescribeRegions) | **get** / | 
*KsyunKecClient* | [**DescribeAvailabilityZones**](#DescribeAvailabilityZones) | **get** / | 

## Method Info


### RunInstances

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.RunInstances(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "创建实例",
                "enum": [
                    "RunInstances"
                ],
                "default": "RunInstances"
            },
            "Version": {
                "type": "string",
                "description": "Action版本",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "ImageId": {
                "type": "string",
                "description": "镜像ID"
            },
            "InstanceType": {
                "type": "string",
                "description": "实例套餐类型",
                "default": "I1.1A"
            },
            "SystemDisk": {
                "type": "object",
                "description": "云主机系统盘配置参数。若不指定该参数，则按照系统默认值进行分配",
                "properties": {
                    "DiskType": {
                        "type": "string"
                    },
                    "DiskSize": {
                        "type": "integer"
                    }
                }
            },
            "DataDiskGb": {
                "type": "integer",
                "description": "数据卷容量，单位GB，容量限制依据 实例套餐类型定义 变化"
            },
            "DataDisk": {
                "type": "array",
                "description": "数据盘参数",
                "items": {
                    "type": "object",
                    "properties": {
                        "DeleteWithInstance": {
                            "type": "boolean",
                            "default": false
                        },
                        "Type": {
                            "type": "string"
                        },
                        "Size": {
                            "type": "integer"
                        }
                    }
                }
            },
            "MaxCount": {
                "type": "integer",
                "description": "最大实例数，当前用户允许创建的最大实例数"
            },
            "MinCount": {
                "type": "integer",
                "description": "最小实例数，如果用户指定的实例数大于金山云在本Region所能创建的最大实例数或者小于最小实例数，都不会创建任何实例"
            },
            "SubnetId": {
                "type": "string",
                "description": "VPC环境下的子网ID，绑定到主网卡"
            },
            "InstancePassword": {
                "type": "string",
                "description": "实例开机密码"
            },
            "KeepImageLogin": {
                "type": "boolean",
                "description": "保留镜像设置登录。",
                "default": false
            },
            "ChargeType": {
                "type": "string",
                "description": "计费类型，调用时需要明确指定"
            },
            "PurchaseTime": {
                "type": "integer",
                "description": "购买时长，单位月 , 当计费类型为Monthly（包年包月）时，有效值1-36；其他计费类型时，强制要求参数值为0"
            },
            "SecurityGroupId": {
                "type": "string",
                "description": "实例绑定的安全组，目前仅支持绑定一个安全组"
            },
            "PrivateIpAddress": {
                "type": "string",
                "description": "私有IP地址，指定子网IP地址范围内的任意有效值，代表实例的主IP地址，只能选择一个，绑定到主网卡；如果未指定该参数，系统自动从有效地址池中随机选取一个"
            },
            "InstanceName": {
                "type": "string",
                "description": "实例名称，如果未指定，则自动生成，形如KSC-IN-[A-Z0-9]{10}"
            },
            "InstanceNameSuffix": {
                "type": "string",
                "description": "实例名称后缀，InstanceName参数如果缺省，此参数不生效；当大于1台的批量创建主机，后缀编号自动+1，例如后缀输入5，主机名输入\"host\"，批量3台，则生成的三台主机名分别为：\"host-5\"、\"host-6\"、\"host-7\"；",
                "default": ""
            },
            "SriovNetSupport": {
                "type": "boolean",
                "description": "联网增强属性",
                "default": false
            },
            "ProjectId": {
                "type": "integer",
                "description": "实例所属项目ID"
            },
            "DataGuardId": {
                "type": "string",
                "description": "容灾分组ID"
            },
            "KeyId": {
                "type": "array",
                "description": "密钥ID",
                "items": {
                    "type": "string"
                }
            },
            "AddressBandWidth": {
                "type": "integer",
                "description": "弹性IP的带宽 ,购买弹性IP时不可缺省"
            },
            "LineId": {
                "type": "string",
                "description": "弹性IP的链路类型的ID"
            },
            "AddressChargeType": {
                "type": "string",
                "description": "弹性IP的计费类型"
            },
            "AddressPurchaseTime": {
                "type": "integer",
                "description": "弹性IP的购买时长，只有购买包年包月弹性IP时不可缺省。"
            },
            "AddressProjectId": {
                "type": "string",
                "description": "弹性IP项目的ID"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {
            "InstanceType": "I1.1A",
            "SystemDisk": {}
        }
        ```
        - Constant
        
        ```json
        {
            "Action": "RunInstances",
            "Version": "2016-03-04",
            "SystemDisk": {}
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "RunInstances",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "InstancesSet": {
                "type": "array",
                "items": {
                    "type": "object",
                    "properties": {
                        "InstanceId": {
                            "type": "string"
                        },
                        "InstanceName": {
                            "type": "string"
                        },
                        "InstanceConfigure": {
                            "type": "object",
                            "properties": {
                                "VCPU": {
                                    "type": "integer"
                                },
                                "GPU": {
                                    "type": "integer"
                                },
                                "MemoryGb": {
                                    "type": "integer"
                                },
                                "DataDiskGb": {
                                    "type": "integer"
                                },
                                "RootDiskGb": {
                                    "type": "integer"
                                },
                                "DataDiskType": {
                                    "type": "string"
                                }
                            }
                        },
                        "ImageId": {
                            "type": "string"
                        },
                        "InstanceType": {
                            "type": "string"
                        },
                        "InstanceState": {
                            "type": "object",
                            "properties": {
                                "Name": {
                                    "type": "string"
                                }
                            }
                        },
                        "SubnetId": {
                            "type": "string"
                        },
                        "VpcId": {
                            "type": "string"
                        },
                        "PrivateIpAddress": {
                            "type": "string"
                        },
                        "Monitoring": {
                            "type": "object",
                            "properties": {
                                "State": {
                                    "type": "string"
                                }
                            }
                        },
                        "SriovNetSupport": {
                            "type": "boolean"
                        },
                        "CreationDate": {
                            "type": "string"
                        },
                        "NetworkInterfaceSet": {
                            "type": "array",
                            "items": {
                                "type": "object",
                                "properties": {
                                    "NetworkInterfaceId": {
                                        "type": "string"
                                    },
                                    "NetworkInterfaceType": {
                                        "type": "string"
                                    },
                                    "MacAddress": {
                                        "type": "string"
                                    },
                                    "SubnetId": {
                                        "type": "string"
                                    },
                                    "PrivateIpAddress": {
                                        "type": "string"
                                    },
                                    "SecurityGroupSet": {
                                        "type": "array",
                                        "items": {
                                            "type": "object",
                                            "properties": {
                                                "SecurityGroupId": {
                                                    "type": "string"
                                                }
                                            }
                                        }
                                    },
                                    "DNS1": {
                                        "type": "string"
                                    },
                                    "DNS2": {
                                        "type": "string"
                                    }
                                }
                            }
                        },
                        "ProjectId": {
                            "type": "integer"
                        },
                        "ChargeType": {
                            "type": "string"
                        }
                    }
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### StartInstances

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.StartInstances(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 启动实例",
                "enum": [
                    "StartInstances"
                ],
                "default": "StartInstances"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "InstanceId": {
                "type": "array",
                "items": {
                    "type": "string"
                }
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "StartInstances",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "StartInstances",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "InstancesSet": {
                "type": "array",
                "items": {
                    "properties": {
                        "InstanceId": {
                            "type": "string"
                        },
                        "Return": {
                            "type": "string"
                        }
                    }
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### StopInstances

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.StopInstances(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 关闭实例",
                "enum": [
                    "StopInstances"
                ],
                "default": "StopInstances"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "InstanceId": {
                "type": "array",
                "items": {
                    "type": "string"
                }
            },
            "ForceStop": {
                "type": "boolean",
                "description": "强制关闭"
            },
            "StoppedMode": {
                "type": "string",
                "description": "关闭模式",
                "default": "KeepCharging"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {
            "StoppedMode": "KeepCharging"
        }
        ```
        - Constant
        
        ```json
        {
            "Action": "StopInstances",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "StopInstances",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "InstancesSet": {
                "type": "array",
                "items": {
                    "properties": {
                        "InstanceId": {
                            "type": "string"
                        },
                        "Return": {
                            "type": "string"
                        }
                    }
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### RebootInstances

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.RebootInstances(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 重启实例",
                "enum": [
                    "RebootInstances"
                ],
                "default": "RebootInstances"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "InstanceId": {
                "type": "array",
                "items": {
                    "type": "string"
                }
            },
            "ForceReboot": {
                "type": "boolean",
                "description": "强制重启"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "RebootInstances",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "RebootInstances",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "InstancesSet": {
                "type": "array",
                "items": {
                    "properties": {
                        "InstanceId": {
                            "type": "string"
                        },
                        "Return": {
                            "type": "string"
                        }
                    }
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### TerminateInstances

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.TerminateInstances(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 销毁实例",
                "enum": [
                    "TerminateInstances"
                ],
                "default": "TerminateInstances"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "InstanceId": {
                "type": "array",
                "items": {
                    "type": "string"
                }
            },
            "ForceDelete": {
                "type": "boolean",
                "description": "强制删除"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "TerminateInstances",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "TerminateInstances",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "InstancesSet": {
                "type": "array",
                "items": {
                    "properties": {
                        "InstanceId": {
                            "type": "string"
                        },
                        "Return": {
                            "type": "string"
                        }
                    }
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### ModifyInstanceImage

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.ModifyInstanceImage(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 更换或者重新安装实例操作系统",
                "enum": [
                    "ModifyInstanceImage"
                ],
                "default": "ModifyInstanceImage"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "InstanceId": {
                "type": "string",
                "description": "待更换或者重新安装操作系统的实例ID"
            },
            "ImageId": {
                "type": "string",
                "description": "待更换的镜像ID；如果缺省，表明无需改变镜像，只需重新安装实例的操作系统。"
            },
            "SystemDisk": {
                "type": "object",
                "description": "云主机系统盘配置参数。若不指定该参数，则按照系统默认值进行分配",
                "properties": {
                    "DiskType": {
                        "type": "string"
                    },
                    "DiskSize": {
                        "type": "integer"
                    }
                }
            },
            "InstancePassword": {
                "type": "string",
                "description": "实例开机密码"
            },
            "KeepImageLogin": {
                "type": "boolean",
                "description": "保留镜像设置登录",
                "default": false
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {
            "SystemDisk": {}
        }
        ```
        - Constant
        
        ```json
        {
            "Action": "ModifyInstanceImage",
            "Version": "2016-03-04",
            "SystemDisk": {}
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "ModifyInstanceImage",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "InstanceId": {
                "type": "string"
            },
            "Return": {
                "type": "string"
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### ModifyInstanceType

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.ModifyInstanceType(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 升级实例套餐类型",
                "enum": [
                    "ModifyInstanceType"
                ],
                "default": "ModifyInstanceType"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "InstanceId": {
                "type": "string",
                "description": "待升级套餐类型的实例ID"
            },
            "InstanceType": {
                "type": "string",
                "description": "实例套餐类型"
            },
            "DataDiskGb": {
                "type": "integer",
                "description": "数据卷容量，单位GB，数据卷只能扩容或者保持不变，且不能低于 实例套餐类型定义 的最小值"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "ModifyInstanceType",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "ModifyInstanceType",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "InstanceId": {
                "type": "string"
            },
            "Return": {
                "type": "string"
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### ModifyInstanceAttribute

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.ModifyInstanceAttribute(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 修改实例属性信息",
                "enum": [
                    "ModifyInstanceAttribute"
                ],
                "default": "ModifyInstanceAttribute"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "InstanceId": {
                "type": "string",
                "description": "待修改属性的实例ID"
            },
            "InstanceName": {
                "type": "string",
                "description": "实例名称，修改实例名称不需要关闭实例"
            },
            "InstancePassword": {
                "type": "string",
                "description": "实例开机密码，修改实例开机密码需要关闭实例"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "ModifyInstanceAttribute",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "ModifyInstanceAttribute",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "Return": {
                "type": "string"
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### DescribeInstances

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeInstances(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 描述实例信息",
                "enum": [
                    "DescribeInstances"
                ],
                "default": "DescribeInstances"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "MaxResults": {
                "type": "integer",
                "description": "单次调用所返回的最大实例数目，取值为5~1000，超过1000记为1000"
            },
            "Marker": {
                "type": "integer",
                "description": "分页标识，单次调用未返回全部实例时，标记下次调用的返回值的起点，默认值是0"
            },
            "InstanceId": {
                "type": "array",
                "items": {
                    "type": "string"
                }
            },
            "ProjectId": {
                "type": "array",
                "items": {
                    "type": "integer"
                }
            },
            "Filter": {
                "type": "array",
                "items": {
                    "type": "object",
                    "properties": {
                        "Name": {
                            "type": "string"
                        },
                        "Value": {
                            "type": "string"
                        }
                    }
                }
            },
            "Sort": {
                "type": "array",
                "description": "筛选器",
                "items": {
                    "type": "object",
                    "properties": {
                        "Name": {
                            "type": "string"
                        },
                        "Value": {
                            "type": "string"
                        }
                    }
                }
            },
            "Search": {
                "type": "string",
                "description": "搜索条件，模糊匹配"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "DescribeInstances",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "DescribeInstances",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "Marker": {
                "type": "integer"
            },
            "InstanceCount": {
                "type": "integer"
            },
            "InstancesSet": {
                "type": "array",
                "items": {
                    "type": "object",
                    "properties": {
                        "InstanceId": {
                            "type": "string"
                        },
                        "InstanceName": {
                            "type": "string"
                        },
                        "InstanceConfigure": {
                            "type": "object",
                            "properties": {
                                "VCPU": {
                                    "type": "integer"
                                },
                                "GPU": {
                                    "type": "integer"
                                },
                                "MemoryGb": {
                                    "type": "integer"
                                },
                                "DataDiskGb": {
                                    "type": "integer"
                                },
                                "RootDiskGb": {
                                    "type": "integer"
                                },
                                "DataDiskType": {
                                    "type": "string"
                                }
                            }
                        },
                        "ImageId": {
                            "type": "string"
                        },
                        "InstanceType": {
                            "type": "string"
                        },
                        "InstanceState": {
                            "type": "object",
                            "properties": {
                                "Name": {
                                    "type": "string"
                                }
                            }
                        },
                        "SubnetId": {
                            "type": "string"
                        },
                        "VpcId": {
                            "type": "string"
                        },
                        "PrivateIpAddress": {
                            "type": "string"
                        },
                        "Monitoring": {
                            "type": "object",
                            "properties": {
                                "State": {
                                    "type": "string"
                                }
                            }
                        },
                        "SriovNetSupport": {
                            "type": "boolean"
                        },
                        "CreationDate": {
                            "type": "string"
                        },
                        "NetworkInterfaceSet": {
                            "type": "array",
                            "items": {
                                "type": "object",
                                "properties": {
                                    "NetworkInterfaceId": {
                                        "type": "string"
                                    },
                                    "NetworkInterfaceType": {
                                        "type": "string"
                                    },
                                    "MacAddress": {
                                        "type": "string"
                                    },
                                    "SubnetId": {
                                        "type": "string"
                                    },
                                    "PrivateIpAddress": {
                                        "type": "string"
                                    },
                                    "SecurityGroupSet": {
                                        "type": "array",
                                        "items": {
                                            "type": "object",
                                            "properties": {
                                                "SecurityGroupId": {
                                                    "type": "string"
                                                }
                                            }
                                        }
                                    },
                                    "DNS1": {
                                        "type": "string"
                                    },
                                    "DNS2": {
                                        "type": "string"
                                    }
                                }
                            }
                        },
                        "ProjectId": {
                            "type": "integer"
                        },
                        "ChargeType": {
                            "type": "string"
                        }
                    }
                }
            },
            "SystemDisk": {
                "type": "object",
                "description": "云主机系统盘配置参数。若不指定该参数，则按照系统默认值进行分配",
                "properties": {
                    "DiskType": {
                        "type": "string"
                    },
                    "DiskSize": {
                        "type": "integer"
                    }
                }
            },
            "StoppedMode": {
                "type": "string"
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### DescribeInstanceVnc

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeInstanceVnc(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 获取指定实例的VNC信息",
                "enum": [
                    "DescribeInstanceVnc"
                ],
                "default": "DescribeInstanceVnc"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "InstanceId": {
                "type": "string"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "DescribeInstanceVnc",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "DescribeInstanceVnc",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "vncUrl": {
                "type": "string"
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### DescribeInstanceTypeConfigs

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeInstanceTypeConfigs(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 查询机型套餐",
                "enum": [
                    "DescribeInstanceTypeConfigs"
                ],
                "default": "DescribeInstanceTypeConfigs"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "filter": {
                "type": "array",
                "items": {
                    "type": "string"
                }
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "DescribeInstanceTypeConfigs",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "DescribeInstanceTypeConfigs",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "InstanceTypeConfigSet": {
                "type": "array",
                "items": {
                    "properties": {
                        "AvailabilityZoneSet": {
                            "type": "array",
                            "items": {
                                "properties": {
                                    "AzCode": {
                                        "type": "string"
                                    }
                                }
                            }
                        },
                        "InstanceType": {
                            "type": "string"
                        },
                        "InstanceFamily": {
                            "type": "string"
                        },
                        "CPU": {
                            "type": "integer"
                        },
                        "Memory": {
                            "type": "integer"
                        },
                        "DataDiskMax": {
                            "type": "integer"
                        },
                        "DataDiskMin": {
                            "type": "integer"
                        }
                    }
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### DescribeInstanceFamilys

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeInstanceFamilys(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 查询机型配置信息",
                "enum": [
                    "DescribeInstanceFamilys"
                ],
                "default": "DescribeInstanceFamilys"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "DescribeInstanceFamilys",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "DescribeInstanceFamilys",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "InstanceFamilySet": {
                "type": "array",
                "items": {
                    "properties": {
                        "AvailabilityZoneSet": {
                            "type": "array",
                            "items": {
                                "properties": {
                                    "AzCode": {
                                        "type": "string"
                                    }
                                }
                            }
                        },
                        "InstanceFamilyName": {
                            "type": "string"
                        },
                        "InstanceFamily": {
                            "type": "string"
                        }
                    }
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### MonitorInstances

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.MonitorInstances(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "enum": [
                    "MonitorInstances"
                ],
                "default": "MonitorInstances"
            },
            "Version": {
                "type": "string",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "InstanceId": {
                "type": "array",
                "items": {
                    "type": "string"
                }
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "MonitorInstances",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "MonitorInstances",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "InstancesSet": {
                "type": "array",
                "items": {
                    "properties": {
                        "InstanceId": {
                            "type": "string"
                        },
                        "Monitoring": {
                            "type": "object",
                            "properties": {
                                "State": {
                                    "type": "string"
                                }
                            }
                        }
                    }
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### UnmonitorInstances

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.UnmonitorInstances(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "enum": [
                    "UnmonitorInstances"
                ],
                "default": "UnmonitorInstances"
            },
            "Version": {
                "type": "string",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "InstanceId": {
                "type": "array",
                "items": {
                    "type": "string"
                }
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "UnmonitorInstances",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "UnmonitorInstances",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "InstancesSet": {
                "type": "array",
                "items": {
                    "properties": {
                        "InstanceId": {
                            "type": "string"
                        },
                        "Monitoring": {
                            "type": "object",
                            "properties": {
                                "State": {
                                    "type": "string"
                                }
                            }
                        }
                    }
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### AttachNetworkInterface

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.AttachNetworkInterface(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 为主机添加网卡",
                "enum": [
                    "AttachNetworkInterface"
                ],
                "default": "AttachNetworkInterface"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "InstanceId": {
                "type": "string"
            },
            "SecurityGroupId": {
                "type": "array",
                "items": {
                    "type": "string"
                }
            },
            "SubnetId": {
                "type": "string"
            },
            "PrivateIpAddress": {
                "type": "string"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "AttachNetworkInterface",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "AttachNetworkInterface",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "Return": {
                "type": "boolean"
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### ModifyNetworkInterfaceAttribute

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.ModifyNetworkInterfaceAttribute(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 修改网络接口属性信息",
                "enum": [
                    "ModifyNetworkInterfaceAttribute"
                ],
                "default": "ModifyNetworkInterfaceAttribute"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "InstanceId": {
                "type": "string"
            },
            "NetworkInterfaceId": {
                "type": "string"
            },
            "SecurityGroupId": {
                "type": "string"
            },
            "SubnetId": {
                "type": "string"
            },
            "PrivateIpAddress": {
                "type": "string"
            },
            "DNS1": {
                "type": "string"
            },
            "DNS2": {
                "type": "string"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "ModifyNetworkInterfaceAttribute",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "ModifyNetworkInterfaceAttribute",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "Return": {
                "type": "boolean"
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### DetachNetworkInterface

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.DetachNetworkInterface(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 删除主机网络接口",
                "enum": [
                    "DetachNetworkInterface"
                ],
                "default": "DetachNetworkInterface"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "InstanceId": {
                "type": "string"
            },
            "NetworkInterfaceId": {
                "type": "string"
            },
            "Return": {
                "type": "boolean"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "DetachNetworkInterface",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "DetachNetworkInterface",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestID": {
                "type": "string"
            },
            "Return": {
                "type": "boolean"
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### CreateImage

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.CreateImage(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 创建镜像",
                "enum": [
                    "CreateImage"
                ],
                "default": "CreateImage"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "InstanceId": {
                "type": "string"
            },
            "Name": {
                "type": "string"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "CreateImage",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "CreateImage",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "ImageId": {
                "type": "string"
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### DescribeImages

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeImages(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 描述镜像信息",
                "enum": [
                    "DescribeImages"
                ],
                "default": "DescribeImages"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "ImageId": {
                "type": "string"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "DescribeImages",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "DescribeImages",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "ImagesSet": {
                "type": "array",
                "items": {
                    "properties": {
                        "ImageId": {
                            "type": "string"
                        },
                        "Name": {
                            "type": "string"
                        },
                        "ImageState": {
                            "type": "string"
                        },
                        "CreationDate": {
                            "type": "string"
                        },
                        "Platform": {
                            "type": "string"
                        },
                        "IsPublic": {
                            "type": "boolean"
                        },
                        "InstanceId": {
                            "type": "string"
                        },
                        "IsNpe": {
                            "type": "boolean"
                        },
                        "UserCategory": {
                            "type": "string"
                        },
                        "SysDisk": {
                            "type": "integer"
                        },
                        "Progress": {
                            "type": "string"
                        },
                        "ImageSource": {
                            "type": "string"
                        }
                    }
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### RemoveImages

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.RemoveImages(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 删除镜像",
                "enum": [
                    "RemoveImages"
                ],
                "default": "RemoveImages"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "ImageId": {
                "type": "string"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "RemoveImages",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "RemoveImages",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "ReturnSet": {
                "type": "array",
                "items": {
                    "properties": {
                        "ImageId": {
                            "type": "string"
                        },
                        "Return": {
                            "type": "boolean"
                        }
                    }
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### ModifyImageAttribute

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.ModifyImageAttribute(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 修改镜像属性信息",
                "enum": [
                    "ModifyImageAttribute"
                ],
                "default": "ModifyImageAttribute"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "ImageId": {
                "type": "string"
            },
            "Name": {
                "type": "string"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "ModifyImageAttribute",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "ModifyImageAttribute",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "Return": {
                "type": "boolean"
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### ImportImage

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.ImportImage(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 镜像导入",
                "enum": [
                    "ImportImage"
                ],
                "default": "ImportImage"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "ImageName": {
                "type": "string"
            },
            "Architecture": {
                "type": "string"
            },
            "Platform": {
                "type": "string"
            },
            "ImageUrl": {
                "type": "string"
            },
            "ImageFormat": {
                "type": "string"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "ImportImage",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "ImportImage",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "ImageId": {
                "type": "string"
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### CopyImage

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.CopyImage(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 镜像复制",
                "enum": [
                    "CopyImage"
                ],
                "default": "CopyImage"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "ImageId": {
                "type": "array",
                "items": {
                    "type": "string"
                }
            },
            "DestinationRegion": {
                "type": "array",
                "items": {
                    "type": "string"
                }
            },
            "DestinationImageName": {
                "type": "string"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "CopyImage",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "CopyImage",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "Return": {
                "type": "boolean"
            },
            "Message": {
                "type": "string"
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### DescribeImageSharePermission

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeImageSharePermission(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 查看镜像分享信息",
                "enum": [
                    "DescribeImageSharePermission"
                ],
                "default": "DescribeImageSharePermission"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "ImageId": {
                "type": "string"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "DescribeImageSharePermission",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "DescribeImageSharePermission",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "SharePermissionSet": {
                "type": "array",
                "items": {
                    "properties": {
                        "AccountId": {
                            "type": "string"
                        }
                    }
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### ModifyImageSharePermission

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.ModifyImageSharePermission(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 修改镜像分享信息",
                "enum": [
                    "ModifyImageSharePermission"
                ],
                "default": "ModifyImageSharePermission"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "ImageId": {
                "type": "string"
            },
            "AccountId": {
                "type": "array",
                "items": {
                    "type": "string"
                }
            },
            "Permission": {
                "type": "string"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "ModifyImageSharePermission",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "ModifyImageSharePermission",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "Return": {
                "type": "boolean"
            },
            "Message": {
                "type": "string"
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### CreateLocalVolumeSnapshot

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.CreateLocalVolumeSnapshot(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 创建本地盘快照",
                "enum": [
                    "CreateLocalVolumeSnapshot"
                ],
                "default": "CreateLocalVolumeSnapshot"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "LocalVolumeId": {
                "type": "string"
            },
            "LocalVolumeSnapshotName": {
                "type": "string"
            },
            "LocalVolumeSnapshotDesc": {
                "type": "string"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "CreateLocalVolumeSnapshot",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "CreateLocalVolumeSnapshot",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "AutoSnapshotPolicyId": {
                "type": "string"
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### RollbackLocalVolume

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.RollbackLocalVolume(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 回滚快照",
                "enum": [
                    "RollbackLocalVolume"
                ],
                "default": "RollbackLocalVolume"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "LocalVolumeId": {
                "type": "string"
            },
            "LocalVolumeSnapshotId": {
                "type": "string"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "RollbackLocalVolume",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "RollbackLocalVolume",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "Return": {
                "type": "boolean"
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### DescribeLocalVolumeSnapshots

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeLocalVolumeSnapshots(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 查询本地盘快照",
                "enum": [
                    "DescribeLocalVolumeSnapshots"
                ],
                "default": "DescribeLocalVolumeSnapshots"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "LocalVolumeName": {
                "type": "string"
            },
            "InstanceName": {
                "type": "string"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "DescribeLocalVolumeSnapshots",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "DescribeLocalVolumeSnapshots",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "LocalVolumeSnapshotCount": {
                "type": "integer"
            },
            "LocalVolumeSnapshotSet": {
                "type": "array",
                "items": {
                    "properties": {
                        "LocalVolumeSnapshotId": {
                            "type": "string"
                        },
                        "LocalVolumeSnapshotName": {
                            "type": "string"
                        },
                        "LocalVolumeSnapshotDesc": {
                            "type": "string"
                        },
                        "SourceLocalVolumeId": {
                            "type": "string"
                        },
                        "SourceLocalVolumeName": {
                            "type": "string"
                        },
                        "SourceLocalVolumeCategory": {
                            "type": "string"
                        },
                        "SourceLocalVolumeState": {
                            "type": "string"
                        },
                        "State": {
                            "type": "string"
                        },
                        "CreationDate": {
                            "type": "string"
                        },
                        "IntanceId": {
                            "type": "string"
                        },
                        "DiskSize": {
                            "type": "integer"
                        },
                        "SnapshotType": {
                            "type": "string"
                        }
                    }
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### DeleteLocalVolumeSnapshot

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.DeleteLocalVolumeSnapshot(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 删除快照",
                "enum": [
                    "DeleteLocalVolumeSnapshot"
                ],
                "default": "DeleteLocalVolumeSnapshot"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "LocalVolumeSnapshotId": {
                "type": "string"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "DeleteLocalVolumeSnapshot",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "DeleteLocalVolumeSnapshot",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "ReturnSet": {
                "type": "array",
                "items": {
                    "properties": {
                        "LocalVolumeSnapshotId": {
                            "type": "string"
                        },
                        "Return": {
                            "type": "boolean"
                        }
                    }
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### DescribeLocalVolumes

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeLocalVolumes(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 查询本地磁盘",
                "enum": [
                    "DescribeLocalVolumes"
                ],
                "default": "DescribeLocalVolumes"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "InstanceName": {
                "type": "string"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "DescribeLocalVolumes",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "DescribeLocalVolumes",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "Marker": {
                "type": "integer"
            },
            "LocalVolumeCount": {
                "type": "integer"
            },
            "LocalVolumeSet": {
                "type": "array",
                "items": {
                    "properties": {
                        "LocalVolumeId": {
                            "type": "string"
                        },
                        "LocalVolumeName": {
                            "type": "string"
                        },
                        "LocalVolumeState": {
                            "type": "string"
                        },
                        "InstanceId": {
                            "type": "string"
                        },
                        "InstanceName": {
                            "type": "string"
                        },
                        "InstanceState": {
                            "type": "object",
                            "properties": {
                                "Name": {
                                    "type": "string"
                                }
                            }
                        },
                        "LocalVolumeType": {
                            "type": "string"
                        },
                        "LocalVolumeCategory": {
                            "type": "string"
                        },
                        "LocalVolumeSize": {
                            "type": "integer"
                        },
                        "CreationDate": {
                            "type": "string"
                        }
                    }
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### AttachKey

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.AttachKey(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 主机绑定密钥",
                "enum": [
                    "AttachKey"
                ],
                "default": "AttachKey"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "InstanceId": {
                "type": "array",
                "items": {
                    "type": "string"
                }
            },
            "KeyId": {
                "type": "array",
                "description": "密钥ID",
                "items": {
                    "type": "string"
                }
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "AttachKey",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "AttachKey",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "InstancesSet": {
                "type": "array",
                "items": {
                    "properties": {
                        "InstanceId": {
                            "type": "string"
                        },
                        "Return": {
                            "type": "boolean"
                        }
                    }
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### DetachKey

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.DetachKey(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 主机解绑密钥",
                "enum": [
                    "DetachKey"
                ],
                "default": "DetachKey"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "InstanceId": {
                "type": "array",
                "items": {
                    "type": "string"
                }
            },
            "KeyId": {
                "type": "array",
                "description": "密钥ID",
                "items": {
                    "type": "string"
                }
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "DetachKey",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "DetachKey",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "InstancesSet": {
                "type": "array",
                "items": {
                    "properties": {
                        "InstanceId": {
                            "type": "string"
                        },
                        "Return": {
                            "type": "boolean"
                        }
                    }
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### DescribeRegions

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeRegions(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 查询地域列表",
                "enum": [
                    "DescribeRegions"
                ],
                "default": "DescribeRegions"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "RegionSet": {
                "type": "string"
            },
            "RequestId": {
                "type": "string"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "DescribeRegions",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "DescribeRegions",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "ReturnSet": {
                "type": "array",
                "items": {
                    "properties": {
                        "Region": {
                            "type": "string"
                        },
                        "RegionName": {
                            "type": "string"
                        }
                    }
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```

### DescribeAvailabilityZones

- Example

```c#
using KSYUN.SDK.KEC;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        Client client = new Client(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeAvailabilityZones(JObject _query );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "Action": {
                "type": "string",
                "description": "Action 查询可用区列表",
                "enum": [
                    "DescribeAvailabilityZones"
                ],
                "default": "DescribeAvailabilityZones"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "RequestId": {
                "type": "string"
            },
            "AvailabilityZoneSet": {
                "type": "string"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action",
            "Version"
        ]
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {
            "Action": "DescribeAvailabilityZones",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "DescribeAvailabilityZones",
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //json
        {
            "RequestId": {
                "type": "string"
            },
            "AvailabilityZoneSet": {
                "type": "array",
                "items": {
                    "properties": {
                        "AvailabilityZone": {
                            "type": "string"
                        },
                        "Region": {
                            "type": "string"
                        }
                    }
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //json
        {}

        //------------------------------------------------

        ```
