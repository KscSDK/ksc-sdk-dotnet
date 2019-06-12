# CSharp API SDK for namespace KSYUN.SDK.EIP classname KsyunEipClient 


- Build date: 2019-06-12 10:46
## Installation

Use .NET CLI

    dotnet add package 'KSYUN.SDK.EIP'


## Usage
```c#
using KSYUN.SDK.EIP;
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
   server: "eip"
```

## Authentication
> use aws signature v4

## Configuration
```c#
using KSYUN.SDK.EIP;

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
*KsyunEipClient* | [**RegionList**](#RegionList) | **get** / | 
*KsyunEipClient* | [**GetLines**](#GetLines) | **get** / | 
*KsyunEipClient* | [**AllocateAddress**](#AllocateAddress) | **get** / | 
*KsyunEipClient* | [**ReleaseAddress**](#ReleaseAddress) | **get** / | 
*KsyunEipClient* | [**AssociateAddress**](#AssociateAddress) | **get** / | 
*KsyunEipClient* | [**DisassociateAddress**](#DisassociateAddress) | **get** / | 
*KsyunEipClient* | [**DescribeAddresses**](#DescribeAddresses) | **get** / | 
*KsyunEipClient* | [**ModifyAddress**](#ModifyAddress) | **get** / | 

## Method Info


### RegionList

- Example

```c#
using KSYUN.SDK.EIP;
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

        HttpClientResponse res = client.RegionList(JObject _query );
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
                    "RegionList"
                ],
                "default": "RegionList"
            },
            "Version": {
                "type": "string",
                "default": "2016-03-04"
            }
        }
        ```
        - Default
        
        ```json
        {
            "Version": "2016-03-04"
        }
        ```
        - Constant
        
        ```json
        {
            "Action": "RegionList"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {}                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        ```

### GetLines

- Example

```c#
using KSYUN.SDK.EIP;
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

        HttpClientResponse res = client.GetLines(JObject _query );
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
                "description": "Action 获取用户可选链路信息",
                "enum": [
                    "GetLines"
                ],
                "default": "GetLines"
            },
            "Version": {
                "type": "string",
                "description": "Action版本",
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
            "Action": "GetLines",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //application/json
        {
            "RequestId": {
                "type": "string"
            },
            "LineSet": {
                "type": "array",
                "items": {
                    "type": "object",
                    "properties": {
                        "LineName": {
                            "type": "string"
                        },
                        "LineId": {
                            "type": "string"
                        },
                        "LineType": {
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
        //application/json
        {}

        //------------------------------------------------

        ```

### AllocateAddress

- Example

```c#
using KSYUN.SDK.EIP;
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

        HttpClientResponse res = client.AllocateAddress(JObject _query );
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
                "description": "Action 创建弹性IP",
                "enum": [
                    "AllocateAddress"
                ],
                "default": "AllocateAddress"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "LineId": {
                "type": "string"
            },
            "BandWidth": {
                "type": "integer"
            },
            "ChargeType": {
                "type": "string"
            },
            "PurchaseTime": {
                "type": "integer"
            },
            "ProjectId": {
                "type": "string"
            }
        }
        ```
        - Required  
        ```json
        [
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
            "Action": "AllocateAddress",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //application/json
        {
            "PublicIp": {
                "type": "string"
            },
            "AllocationId": {
                "type": "string"
            },
            "RequestId": {
                "type": "string"
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //application/json
        {}

        //------------------------------------------------

        ```

### ReleaseAddress

- Example

```c#
using KSYUN.SDK.EIP;
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

        HttpClientResponse res = client.ReleaseAddress(JObject _query );
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
                "description": "Action 删除EIP",
                "enum": [
                    "ReleaseAddress"
                ],
                "default": "ReleaseAddress"
            },
            "Version": {
                "type": "string",
                "description": "Action版本",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "AllocationId": {
                "type": "string"
            }
        }
        ```
        - Required  
        ```json
        [
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
            "Action": "ReleaseAddress",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //application/json
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
        //application/json
        {}

        //------------------------------------------------

        ```

### AssociateAddress

- Example

```c#
using KSYUN.SDK.EIP;
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

        HttpClientResponse res = client.AssociateAddress(JObject _query );
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
                "description": "Action 绑定弹性IP",
                "enum": [
                    "AssociateAddress"
                ],
                "default": "AssociateAddress"
            },
            "Version": {
                "type": "string",
                "description": "Action Version",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "AllocationId": {
                "type": "string"
            },
            "InstanceType": {
                "type": "string"
            },
            "InstanceId": {
                "type": "string"
            },
            "NetworkInterfaceId": {
                "type": "string"
            }
        }
        ```
        - Required  
        ```json
        [
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
            "Action": "AssociateAddress",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //application/json
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
        //application/json
        {}

        //------------------------------------------------

        ```

### DisassociateAddress

- Example

```c#
using KSYUN.SDK.EIP;
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

        HttpClientResponse res = client.DisassociateAddress(JObject _query );
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
                "description": "Action 解绑弹性IP",
                "enum": [
                    "DisassociateAddress"
                ],
                "default": "DisassociateAddress"
            },
            "Version": {
                "type": "string",
                "description": "Action版本",
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
            "Action": "DisassociateAddress",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        ```

### DescribeAddresses

- Example

```c#
using KSYUN.SDK.EIP;
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

        HttpClientResponse res = client.DescribeAddresses(JObject _query );
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
                "description": "Action 查询弹性IP",
                "enum": [
                    "DescribeAddresses"
                ],
                "default": "DescribeAddresses"
            },
            "Version": {
                "type": "string",
                "description": "Action版本",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "AllocationId": {
                "type": "array",
                "items": {
                    "type": "string"
                }
            },
            "ProjectId": {
                "type": "array",
                "items": {
                    "type": "string"
                }
            },
            "Filter": {
                "type": "array",
                "items": {
                    "type": "string"
                }
            },
            "MaxResults": {
                "type": "integer",
                "maximum": 1000,
                "minimum": 5
            },
            "NextToken": {
                "type": "string"
            }
        }
        ```
        - Required  
        ```json
        [
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
            "Action": "DescribeAddresses",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //application/json
        {
            "RequestId": {
                "type": "string"
            },
            "AddressesSet": {
                "type": "array",
                "items": {
                    "type": "object",
                    "properties": {
                        "CreateTime": {
                            "type": "string"
                        },
                        "ProjectId": {
                            "type": "string"
                        },
                        "PublicIp": {
                            "type": "string"
                        },
                        "AllocationId": {
                            "type": "string"
                        },
                        "State": {
                            "type": "string"
                        },
                        "LineId": {
                            "type": "string"
                        },
                        "BandWidth": {
                            "type": "integer"
                        },
                        "InstanceType": {
                            "type": "string"
                        },
                        "InstanceId": {
                            "type": "string"
                        },
                        "NetworkInterfaceId": {
                            "type": "string"
                        },
                        "InternetGatewayId": {
                            "type": "string"
                        },
                        "BandWidthShareId": {
                            "type": "string"
                        },
                        "IsBandWidthShare": {
                            "type": "boolean"
                        }
                    }
                }
            },
            "NextToken": {
                "type": "string"
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //application/json
        {}

        //------------------------------------------------

        ```

### ModifyAddress

- Example

```c#
using KSYUN.SDK.EIP;
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

        HttpClientResponse res = client.ModifyAddress(JObject _query );
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
                "description": "Action 更新弹性IP配置",
                "enum": [
                    "ModifyAddress"
                ],
                "default": "ModifyAddress"
            },
            "Version": {
                "type": "string",
                "description": "Action版本",
                "enum": [
                    "2016-03-04"
                ],
                "default": "2016-03-04"
            },
            "AllocationId": {
                "type": "string"
            },
            "BandWidth": {
                "type": "integer"
            }
        }
        ```
        - Required  
        ```json
        [
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
            "Action": "ModifyAddress",
            "Version": "2016-03-04"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Version": "2016-03-04"
        }                
        ```    
- Return
    - 200
        - Type -> JObject
        - Struct
        
        ```json
        //application/json
        {
            "RequestId": {
                "type": "string"
            },
            "Address": {
                "type": "array",
                "items": {
                    "type": "object",
                    "properties": {
                        "CreateTime": {
                            "type": "string"
                        },
                        "ProjectId": {
                            "type": "string"
                        },
                        "PublicIp": {
                            "type": "string"
                        },
                        "AllocationId": {
                            "type": "string"
                        },
                        "State": {
                            "type": "string"
                        },
                        "LineId": {
                            "type": "string"
                        },
                        "BandWidth": {
                            "type": "integer"
                        },
                        "InstanceType": {
                            "type": "string"
                        },
                        "InstanceId": {
                            "type": "string"
                        },
                        "NetworkInterfaceId": {
                            "type": "string"
                        },
                        "InternetGatewayId": {
                            "type": "string"
                        },
                        "BandWidthShareId": {
                            "type": "string"
                        },
                        "IsBandWidthShare": {
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
        //application/json
        {}

        //------------------------------------------------

        ```
