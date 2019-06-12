# CSharp API SDK for namespace KSYUN.SDK.SLB classname KsyunSlbClient 


- Build date: 2019-06-12 10:46
## Installation

Use .NET CLI

    dotnet add package 'KSYUN.SDK.SLB'


## Usage
```c#
using KSYUN.SDK.SLB;
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
   server: "slb"
```

## Authentication
> use aws signature v4

## Configuration
```c#
using KSYUN.SDK.SLB;

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
*KsyunSlbClient* | [**CreateLoadBalancer**](#CreateLoadBalancer) | **get** / | 
*KsyunSlbClient* | [**DeleteLoadBalancer**](#DeleteLoadBalancer) | **get** / | 
*KsyunSlbClient* | [**ModifyLoadBalancer**](#ModifyLoadBalancer) | **get** / | 
*KsyunSlbClient* | [**DescribeLoadBalancers**](#DescribeLoadBalancers) | **get** / | 
*KsyunSlbClient* | [**CreateListeners**](#CreateListeners) | **get** / | 
*KsyunSlbClient* | [**ModifyListeners**](#ModifyListeners) | **get** / | 
*KsyunSlbClient* | [**DeleteListeners**](#DeleteListeners) | **get** / | 
*KsyunSlbClient* | [**DescribeListeners**](#DescribeListeners) | **get** / | 
*KsyunSlbClient* | [**ConfigureHealthCheck**](#ConfigureHealthCheck) | **get** / | 
*KsyunSlbClient* | [**ModifyHealthCheck**](#ModifyHealthCheck) | **get** / | 
*KsyunSlbClient* | [**DeleteHealthCheck**](#DeleteHealthCheck) | **get** / | 
*KsyunSlbClient* | [**DescribeHealthChecks**](#DescribeHealthChecks) | **get** / | 
*KsyunSlbClient* | [**RegisterInstancesWithListener**](#RegisterInstancesWithListener) | **get** / | 
*KsyunSlbClient* | [**ModifyInstancesWithListener**](#ModifyInstancesWithListener) | **get** / | 
*KsyunSlbClient* | [**DeregisterInstancesFromListener**](#DeregisterInstancesFromListener) | **get** / | 
*KsyunSlbClient* | [**DescribeInstancesWithListener**](#DescribeInstancesWithListener) | **get** / | 
*KsyunSlbClient* | [**CreateLoadBalancerAcl**](#CreateLoadBalancerAcl) | **get** / | 
*KsyunSlbClient* | [**DeleteLoadBalancerAcl**](#DeleteLoadBalancerAcl) | **get** / | 
*KsyunSlbClient* | [**ModifyLoadBalancerAcl**](#ModifyLoadBalancerAcl) | **get** / | 
*KsyunSlbClient* | [**DescribeLoadBalancerAcls**](#DescribeLoadBalancerAcls) | **get** / | 
*KsyunSlbClient* | [**CreateLoadBalancerAclEntry**](#CreateLoadBalancerAclEntry) | **get** / | 
*KsyunSlbClient* | [**DeleteLoadBalancerAclEntry**](#DeleteLoadBalancerAclEntry) | **get** / | 
*KsyunSlbClient* | [**AssociateLoadBalancerAcl**](#AssociateLoadBalancerAcl) | **get** / | 
*KsyunSlbClient* | [**DisassociateLoadBalancerAcl**](#DisassociateLoadBalancerAcl) | **get** / | 

## Method Info


### CreateLoadBalancer

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.CreateLoadBalancer(JObject _query );
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
                    "CreateLoadBalancer"
                ],
                "default": "CreateLoadBalancer"
            },
            "Version": {
                "type": "string",
                "default": "2016-03-04"
            },
            "VpcId": {
                "type": "string"
            },
            "LoadBalancerName": {
                "type": "string"
            },
            "Type": {
                "type": "string"
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
            "Action"
        ]
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
            "Action": "CreateLoadBalancer"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "CreateLoadBalancer"
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
            "LoadBalancerDescriptions": {
                "type": "object",
                "properties": {
                    "CreateTime": {
                        "type": "string",
                        "format": "date-time"
                    },
                    "LoadBalancerName": {
                        "type": "object",
                        "properties": {
                            "CreateTime": {
                                "type": "string",
                                "format": "date-time"
                            },
                            "LoadBalancerName": {
                                "type": "string"
                            },
                            "VpcId": {
                                "type": "string"
                            },
                            "Type": {
                                "type": "string",
                                "default": "public"
                            },
                            "SubnetId": {
                                "type": "string"
                            },
                            "PublicIp": {
                                "type": "string"
                            },
                            "State": {
                                "type": "string",
                                "default": "associate"
                            },
                            "LoadBalancerState": {
                                "type": "string",
                                "default": "start"
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
        //application/json
        {}

        //------------------------------------------------

        ```

### DeleteLoadBalancer

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.DeleteLoadBalancer(JObject _query );
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
                    "DeleteLoadBalancer"
                ],
                "default": "DeleteLoadBalancer"
            },
            "LoadBalancerId": {
                "type": "string"
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
            "Action": "DeleteLoadBalancer"
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

### ModifyLoadBalancer

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.ModifyLoadBalancer(JObject _query );
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
                    "ModifyLoadBalancer"
                ],
                "default": "ModifyLoadBalancer"
            },
            "Version": {
                "type": "string",
                "default": "2016-03-04"
            },
            "LoadBalancerId": {
                "type": "string"
            },
            "LoadBalancerName": {
                "type": "string"
            },
            "LoadBalancerState": {
                "type": "string",
                "default": "start"
            }
        }
        ```
        - Required  
        ```json
        [
            "Action"
        ]
        ```
        - Default
        
        ```json
        {
            "Version": "2016-03-04",
            "LoadBalancerState": "start"
        }
        ```
        - Constant
        
        ```json
        {
            "Action": "ModifyLoadBalancer"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "ModifyLoadBalancer"
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
            "LoadBalancerDescription": {
                "type": "object",
                "properties": {
                    "CreateTime": {
                        "type": "string",
                        "format": "date-time"
                    },
                    "LoadBalancerName": {
                        "type": "string"
                    },
                    "VpcId": {
                        "type": "string"
                    },
                    "Type": {
                        "type": "string",
                        "default": "public"
                    },
                    "SubnetId": {
                        "type": "string"
                    },
                    "PublicIp": {
                        "type": "string"
                    },
                    "State": {
                        "type": "string",
                        "default": "associate"
                    },
                    "LoadBalancerState": {
                        "type": "string",
                        "default": "start"
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

### DescribeLoadBalancers

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.DescribeLoadBalancers(JObject _query );
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
                    "DescribeLoadBalancers"
                ],
                "default": "DescribeLoadBalancers"
            },
            "LoadBalancerId": {
                "type": "string"
            },
            "Version": {
                "type": "string",
                "default": "2016-03-04"
            },
            "State": {
                "type": "string",
                "default": "associate"
            },
            "Filter": {
                "type": "array",
                "items": {
                    "type": "object",
                    "properties": {
                        "Name": {
                            "type": "string"
                        },
                        "Values": {
                            "type": "string"
                        }
                    }
                }
            }
        }
        ```
        - Required  
        ```json
        [
            "Action"
        ]
        ```
        - Default
        
        ```json
        {
            "Version": "2016-03-04",
            "State": "associate"
        }
        ```
        - Constant
        
        ```json
        {
            "Action": "DescribeLoadBalancers"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {
            "Action": "DescribeLoadBalancers"
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
            "LoadBalancerDescription": {
                "type": "object",
                "properties": {
                    "CreateTime": {
                        "type": "string",
                        "format": "date-time"
                    },
                    "LoadBalancerName": {
                        "type": "string"
                    },
                    "VpcId": {
                        "type": "string"
                    },
                    "Type": {
                        "type": "string",
                        "default": "public"
                    },
                    "SubnetId": {
                        "type": "string"
                    },
                    "PublicIp": {
                        "type": "string"
                    },
                    "State": {
                        "type": "string",
                        "default": "associate"
                    },
                    "LoadBalancerState": {
                        "type": "string",
                        "default": "start"
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

### CreateListeners

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.CreateListeners(JObject _query );
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
                    "CreateListeners"
                ],
                "default": "CreateListeners"
            },
            "Version": {
                "type": "string",
                "default": "2016-03-04"
            },
            "LoadBalancerId": {
                "type": "string"
            },
            "ListenerState": {
                "type": "string",
                "default": "stat"
            },
            "ListenerName": {
                "type": "string",
                "default": "ksc_listener"
            },
            "ListenerProtocol": {
                "type": "string",
                "default": "HTTP"
            },
            "CertificateId": {
                "type": "string"
            },
            "ListenerPort": {
                "type": "integer"
            },
            "Method": {
                "type": "string",
                "default": "RoundRobin"
            },
            "SessionState": {
                "type": "string",
                "default": "start"
            },
            "SessionPersistencePeriod": {
                "type": "integer",
                "default": 3600
            },
            "CookieType": {
                "type": "string",
                "default": "ImplantCookie"
            },
            "CookieName": {
                "type": "string"
            }
        }
        ```
        - Default
        
        ```json
        {
            "Version": "2016-03-04",
            "ListenerState": "stat",
            "ListenerName": "ksc_listener",
            "ListenerProtocol": "HTTP",
            "Method": "RoundRobin",
            "SessionState": "start",
            "SessionPersistencePeriod": 3600,
            "CookieType": "ImplantCookie"
        }
        ```
        - Constant
        
        ```json
        {
            "Action": "CreateListeners"
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
        //application/json
        {
            "CreateTime": {
                "type": "string"
            },
            "LoadBalancerId": {
                "type": "string"
            },
            "ListenerName": {
                "type": "string"
            },
            "ListenerId": {
                "type": "string"
            },
            "ListenerState": {
                "type": "string",
                "default": "start"
            },
            "CertificateId": {
                "type": "string"
            },
            "ListenerProtocol": {
                "type": "string"
            },
            "ListenerPort": {
                "type": "integer"
            },
            "Method": {
                "type": "string",
                "default": "RoundRobin"
            },
            "HealthCheck": {
                "type": "object",
                "properties": {
                    "HealthCheckId": {
                        "type": "string"
                    },
                    "HealthCheckState": {
                        "type": "string",
                        "default": "start"
                    },
                    "HealthyThreshold": {
                        "type": "integer"
                    },
                    "Interval": {
                        "type": "integer"
                    },
                    "Timeout": {
                        "type": "integer"
                    },
                    "UnhealthyThreshold": {
                        "type": "integer"
                    }
                }
            },
            "Session": {
                "type": "object",
                "properties": {
                    "SessionState": {
                        "type": "string",
                        "default": "start"
                    },
                    "CookieExpirationPeriod": {
                        "type": "integer"
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

### ModifyListeners

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.ModifyListeners(JObject _query );
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
                    "ModifyListeners"
                ],
                "default": "ModifyListeners"
            },
            "ListenerId": {
                "type": "string"
            },
            "CertificateId": {
                "type": "string"
            },
            "Version": {
                "type": "string",
                "default": "2016-03-04"
            },
            "ListenerName": {
                "type": "string"
            },
            "ListenerState": {
                "type": "string",
                "default": "start"
            },
            "SessionState": {
                "type": "string",
                "default": "start"
            },
            "Method": {
                "type": "string",
                "default": "RoundRobin"
            },
            "SessionPersistencePeriod": {
                "type": "integer"
            },
            "CookieType": {
                "type": "string",
                "default": "ImplantCookie"
            },
            "CookieName": {
                "type": "string"
            }
        }
        ```
        - Default
        
        ```json
        {
            "Version": "2016-03-04",
            "ListenerState": "start",
            "SessionState": "start",
            "Method": "RoundRobin",
            "CookieType": "ImplantCookie"
        }
        ```
        - Constant
        
        ```json
        {
            "Action": "ModifyListeners"
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
        //application/json
        {
            "RequestId": {
                "type": "string"
            },
            "Listener": {
                "type": "object",
                "properties": {
                    "CreateTime": {
                        "type": "string"
                    },
                    "LoadBalancerId": {
                        "type": "string"
                    },
                    "ListenerName": {
                        "type": "string"
                    },
                    "ListenerId": {
                        "type": "string"
                    },
                    "ListenerState": {
                        "type": "string",
                        "default": "start"
                    },
                    "CertificateId": {
                        "type": "string"
                    },
                    "ListenerProtocol": {
                        "type": "string"
                    },
                    "ListenerPort": {
                        "type": "integer"
                    },
                    "Method": {
                        "type": "string",
                        "default": "RoundRobin"
                    },
                    "HealthCheck": {
                        "type": "object",
                        "properties": {
                            "HealthCheckId": {
                                "type": "string"
                            },
                            "HealthCheckState": {
                                "type": "string",
                                "default": "start"
                            },
                            "HealthyThreshold": {
                                "type": "integer"
                            },
                            "Interval": {
                                "type": "integer"
                            },
                            "Timeout": {
                                "type": "integer"
                            },
                            "UnhealthyThreshold": {
                                "type": "integer"
                            }
                        }
                    },
                    "Session": {
                        "type": "object",
                        "properties": {
                            "SessionState": {
                                "type": "string",
                                "default": "start"
                            },
                            "CookieExpirationPeriod": {
                                "type": "integer"
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
        //application/json
        {}

        //------------------------------------------------

        ```

### DeleteListeners

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.DeleteListeners(JObject _query );
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
                    "DeleteListeners"
                ],
                "default": "DeleteListeners"
            },
            "ListenerId": {
                "type": "string"
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
            "Action": "DeleteListeners"
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

### DescribeListeners

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.DescribeListeners(JObject _query );
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
                    "DescribeListeners"
                ],
                "default": "DescribeListeners"
            },
            "Version": {
                "type": "string",
                "default": "2016-03-04"
            },
            "ListenerId": {
                "type": "string"
            },
            "Filter": {
                "type": "array",
                "items": {
                    "type": "object",
                    "properties": {
                        "Name": {
                            "type": "string"
                        },
                        "Values": {
                            "type": "string"
                        }
                    }
                }
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
            "Action": "DescribeListeners"
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
        //application/json
        {
            "RequestId": {
                "type": "string"
            },
            "ListenerSet": {
                "type": "object",
                "properties": {
                    "CreateTime": {
                        "type": "string"
                    },
                    "LoadBalancerId": {
                        "type": "string"
                    },
                    "ListenerName": {
                        "type": "string"
                    },
                    "ListenerId": {
                        "type": "string"
                    },
                    "ListenerState": {
                        "type": "string",
                        "default": "start"
                    },
                    "CertificateId": {
                        "type": "string"
                    },
                    "ListenerProtocol": {
                        "type": "string"
                    },
                    "ListenerPort": {
                        "type": "integer"
                    },
                    "Method": {
                        "type": "string",
                        "default": "RoundRobin"
                    },
                    "HealthCheck": {
                        "type": "object",
                        "properties": {
                            "HealthCheckId": {
                                "type": "string"
                            },
                            "HealthCheckState": {
                                "type": "string",
                                "default": "start"
                            },
                            "HealthyThreshold": {
                                "type": "integer"
                            },
                            "Interval": {
                                "type": "integer"
                            },
                            "Timeout": {
                                "type": "integer"
                            },
                            "UnhealthyThreshold": {
                                "type": "integer"
                            }
                        }
                    },
                    "Session": {
                        "type": "object",
                        "properties": {
                            "SessionState": {
                                "type": "string",
                                "default": "start"
                            },
                            "CookieExpirationPeriod": {
                                "type": "integer"
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
        //application/json
        {}

        //------------------------------------------------

        ```

### ConfigureHealthCheck

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.ConfigureHealthCheck(JObject _query );
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
                    "ConfigureHealthCheck"
                ],
                "default": "ConfigureHealthCheck"
            },
            "Version": {
                "type": "string",
                "default": "2016-03-04"
            },
            "ListenerId": {
                "type": "string"
            },
            "HealthCheckState": {
                "type": "string",
                "default": "start"
            },
            "HealthyThreshold": {
                "type": "integer"
            },
            "Interval": {
                "type": "integer"
            },
            "Timeout": {
                "type": "integer"
            },
            "UnhealthyThreshold": {
                "type": "integer"
            },
            "UrlPath": {
                "type": "string"
            },
            "IsDefaultHostName": {
                "type": "boolean",
                "default": true
            },
            "HostName": {
                "type": "string"
            }
        }
        ```
        - Default
        
        ```json
        {
            "Version": "2016-03-04",
            "HealthCheckState": "start",
            "IsDefaultHostName": true
        }
        ```
        - Constant
        
        ```json
        {
            "Action": "ConfigureHealthCheck"
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
        //application/json
        {
            "RequestId": {
                "type": "string"
            },
            "HealthCheck": {
                "type": "object",
                "properties": {
                    "HealthCheckId": {
                        "type": "string"
                    },
                    "HealthCheckState": {
                        "type": "string",
                        "default": "start"
                    },
                    "HealthyThreshold": {
                        "type": "integer"
                    },
                    "Interval": {
                        "type": "integer"
                    },
                    "Timeout": {
                        "type": "integer"
                    },
                    "UnhealthyThreshold": {
                        "type": "integer"
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

### ModifyHealthCheck

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.ModifyHealthCheck(JObject _query );
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
                    "ModifyHealthCheck"
                ],
                "default": "ModifyHealthCheck"
            },
            "Version": {
                "type": "string",
                "default": "2016-03-04"
            },
            "HealthCheckId": {
                "type": "string"
            },
            "HealthCheckState": {
                "type": "string",
                "default": "start"
            },
            "HealthyThreshold": {
                "type": "integer"
            },
            "Interval": {
                "type": "integer"
            },
            "Timeout": {
                "type": "integer"
            },
            "UnhealthyThreshold": {
                "type": "integer"
            },
            "UrlPath": {
                "type": "string"
            },
            "IsDefaultHostName": {
                "type": "boolean",
                "default": true
            },
            "HostName": {
                "type": "string"
            }
        }
        ```
        - Default
        
        ```json
        {
            "Version": "2016-03-04",
            "HealthCheckState": "start",
            "IsDefaultHostName": true
        }
        ```
        - Constant
        
        ```json
        {
            "Action": "ModifyHealthCheck"
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
        //application/json
        {
            "RequestId": {
                "type": "string"
            },
            "HealthCheck": {
                "type": "object",
                "properties": {
                    "HealthCheckId": {
                        "type": "string"
                    },
                    "HealthCheckState": {
                        "type": "string",
                        "default": "start"
                    },
                    "HealthyThreshold": {
                        "type": "integer"
                    },
                    "Interval": {
                        "type": "integer"
                    },
                    "Timeout": {
                        "type": "integer"
                    },
                    "UnhealthyThreshold": {
                        "type": "integer"
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

### DeleteHealthCheck

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.DeleteHealthCheck(JObject _query );
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
                    "DeleteHealthCheck"
                ],
                "default": "DeleteHealthCheck"
            },
            "Version": {
                "type": "string",
                "default": "2016-03-04"
            },
            "HealthCheckId": {
                "type": "string"
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
            "Action": "DeleteHealthCheck"
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

### DescribeHealthChecks

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.DescribeHealthChecks(JObject _query );
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
                    "DescribeHealthChecks"
                ],
                "default": "DescribeHealthChecks"
            },
            "Version": {
                "type": "string",
                "default": "2016-03-04"
            },
            "HealthCheckId": {
                "type": "string"
            },
            "Filter": {
                "type": "array",
                "items": {
                    "type": "object",
                    "properties": {
                        "Name": {
                            "type": "string"
                        },
                        "Values": {
                            "type": "string"
                        }
                    }
                }
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
            "Action": "DescribeHealthChecks"
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
        //application/json
        {
            "RequestId": {
                "type": "string"
            },
            "HealthCheckSet": {
                "type": "object",
                "properties": {
                    "HealthCheckId": {
                        "type": "string"
                    },
                    "HealthCheckState": {
                        "type": "string",
                        "default": "start"
                    },
                    "HealthyThreshold": {
                        "type": "integer"
                    },
                    "Interval": {
                        "type": "integer"
                    },
                    "Timeout": {
                        "type": "integer"
                    },
                    "UnhealthyThreshold": {
                        "type": "integer"
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

### RegisterInstancesWithListener

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.RegisterInstancesWithListener(JObject _query );
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
                    "RegisterInstancesWithListener"
                ],
                "default": "RegisterInstancesWithListener"
            },
            "Version": {
                "type": "string",
                "default": "2016-03-04"
            },
            "ListenerId": {
                "type": "string"
            },
            "RealServerIp": {
                "type": "string"
            },
            "RealServerPort": {
                "type": "integer"
            },
            "RealServerType": {
                "type": "string"
            },
            "InstanceId": {
                "type": "string"
            },
            "Weight": {
                "type": "integer"
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
            "Action": "RegisterInstancesWithListener"
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
        //application/json
        {
            "RequestId": {
                "type": "string"
            },
            "RealServer": {
                "type": "object",
                "properties": {
                    "RegisterId": {
                        "type": "string"
                    },
                    "RealServerIp": {
                        "type": "string"
                    },
                    "RealServerPort": {
                        "type": "integer"
                    },
                    "RealServerType": {
                        "type": "string"
                    },
                    "InstanceId": {
                        "type": "string"
                    },
                    "RealServerState": {
                        "type": "string",
                        "default": "healthy"
                    },
                    "Weight": {
                        "type": "integer"
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

### ModifyInstancesWithListener

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.ModifyInstancesWithListener(JObject _query );
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
                    "ModifyInstancesWithListener"
                ],
                "default": "ModifyInstancesWithListener"
            },
            "Version": {
                "type": "string",
                "default": "2016-03-04"
            },
            "RegisterId": {
                "type": "string"
            },
            "RealServerPort": {
                "type": "integer"
            },
            "Weight": {
                "type": "integer"
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
            "Action": "ModifyInstancesWithListener"
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
        //application/json
        {
            "RequestId": {
                "type": "string"
            },
            "RealServer": {
                "type": "object",
                "properties": {
                    "RegisterId": {
                        "type": "string"
                    },
                    "RealServerIp": {
                        "type": "string"
                    },
                    "RealServerPort": {
                        "type": "integer"
                    },
                    "RealServerType": {
                        "type": "string"
                    },
                    "InstanceId": {
                        "type": "string"
                    },
                    "RealServerState": {
                        "type": "string",
                        "default": "healthy"
                    },
                    "Weight": {
                        "type": "integer"
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

### DeregisterInstancesFromListener

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.DeregisterInstancesFromListener(JObject _query );
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
                    "DeregisterInstancesFromListener"
                ],
                "default": "DeregisterInstancesFromListener"
            },
            "Version": {
                "type": "string",
                "default": "2016-03-04"
            },
            "RegisterId": {
                "type": "string"
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
            "Action": "DeregisterInstancesFromListener"
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

### DescribeInstancesWithListener

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.DescribeInstancesWithListener(JObject _query );
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
                    "DescribeInstancesWithListener"
                ],
                "default": "DescribeInstancesWithListener"
            },
            "Version": {
                "type": "string",
                "default": "2016-03-04"
            },
            "RegisterId": {
                "type": "string"
            },
            "Filter": {
                "type": "array",
                "items": {
                    "type": "object",
                    "properties": {
                        "Name": {
                            "type": "string"
                        },
                        "Values": {
                            "type": "string"
                        }
                    }
                }
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
            "Action": "DescribeInstancesWithListener"
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
        //application/json
        {
            "RequestId": {
                "type": "string"
            },
            "RealServerSet": {
                "type": "object",
                "properties": {
                    "RegisterId": {
                        "type": "string"
                    },
                    "RealServerIp": {
                        "type": "string"
                    },
                    "RealServerPort": {
                        "type": "integer"
                    },
                    "RealServerType": {
                        "type": "string"
                    },
                    "InstanceId": {
                        "type": "string"
                    },
                    "RealServerState": {
                        "type": "string",
                        "default": "healthy"
                    },
                    "Weight": {
                        "type": "integer"
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

### CreateLoadBalancerAcl

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.CreateLoadBalancerAcl(JObject _query );
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
                    "CreateLoadBalancerAcl"
                ],
                "default": "CreateLoadBalancerAcl"
            },
            "Version": {
                "type": "string",
                "default": "2016-03-04"
            },
            "LoadBalancerAclName": {
                "type": "string",
                "default": "Ksc_LoadBalancerAcl"
            }
        }
        ```
        - Default
        
        ```json
        {
            "Version": "2016-03-04",
            "LoadBalancerAclName": "Ksc_LoadBalancerAcl"
        }
        ```
        - Constant
        
        ```json
        {
            "Action": "CreateLoadBalancerAcl"
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
        //application/json
        {
            "RequestId": {
                "type": "string"
            },
            "LoadBalancerAcl": {
                "type": "object",
                "properties": {
                    "CreateTime": {
                        "type": "string"
                    },
                    "LoadBalancerAclName": {
                        "type": "string"
                    },
                    "LoadBalancerAclId": {
                        "type": "string"
                    },
                    "LoadBalancerAclEntrySet": {
                        "type": "object",
                        "properties": {
                            "LoadBalancerAclId": {
                                "type": "string"
                            },
                            "LoadBalancerAclEntryId": {
                                "type": "string"
                            },
                            "CidrBlock": {
                                "type": "string"
                            },
                            "RuleNumber": {
                                "type": "integer"
                            },
                            "RuleAction": {
                                "type": "string",
                                "default": "allow"
                            },
                            "Protocol": {
                                "type": "string"
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
        //application/json
        {}

        //------------------------------------------------

        ```

### DeleteLoadBalancerAcl

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.DeleteLoadBalancerAcl(JObject _query );
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
                    "DeleteLoadBalancerAcl"
                ],
                "default": "DeleteLoadBalancerAcl"
            },
            "Version": {
                "type": "string",
                "default": "2016-03-04"
            },
            "LoadBalancerAclId": {
                "type": "string"
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
            "Action": "DeleteLoadBalancerAcl"
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

### ModifyLoadBalancerAcl

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.ModifyLoadBalancerAcl(JObject _query );
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
                    "ModifyLoadBalancerAcl"
                ],
                "default": "ModifyLoadBalancerAcl"
            },
            "Version": {
                "type": "string",
                "default": "2016-03-04"
            },
            "LoadBalancerAclId": {
                "type": "string"
            },
            "LoadBalancerAclName": {
                "type": "string"
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
            "Action": "ModifyLoadBalancerAcl"
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
        //application/json
        {
            "RequestId": {
                "type": "string"
            },
            "LoadBalancerAcl": {
                "type": "object",
                "properties": {
                    "CreateTime": {
                        "type": "string"
                    },
                    "LoadBalancerAclName": {
                        "type": "string"
                    },
                    "LoadBalancerAclId": {
                        "type": "string"
                    },
                    "LoadBalancerAclEntrySet": {
                        "type": "object",
                        "properties": {
                            "LoadBalancerAclId": {
                                "type": "string"
                            },
                            "LoadBalancerAclEntryId": {
                                "type": "string"
                            },
                            "CidrBlock": {
                                "type": "string"
                            },
                            "RuleNumber": {
                                "type": "integer"
                            },
                            "RuleAction": {
                                "type": "string",
                                "default": "allow"
                            },
                            "Protocol": {
                                "type": "string"
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
        //application/json
        {}

        //------------------------------------------------

        ```

### DescribeLoadBalancerAcls

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.DescribeLoadBalancerAcls(JObject _query );
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
                    "DescribeLoadBalancerAcls"
                ],
                "default": "DescribeLoadBalancerAcls"
            },
            "Version": {
                "type": "string",
                "default": "2016-03-04"
            },
            "LoadBalancerAclId": {
                "type": "string"
            },
            "Filter": {
                "items": {
                    "type": "object",
                    "properties": {
                        "Name": {
                            "type": "string"
                        },
                        "Values": {
                            "type": "string"
                        }
                    }
                }
            },
            "MaxResults": {
                "type": "integer"
            },
            "NextToken": {
                "type": "string"
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
            "Action": "DescribeLoadBalancerAcls"
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
        //application/json
        {
            "RequestId": {
                "type": "string"
            },
            "LoadBalancerAcl": {
                "type": "object",
                "properties": {
                    "CreateTime": {
                        "type": "string"
                    },
                    "LoadBalancerAclName": {
                        "type": "string"
                    },
                    "LoadBalancerAclId": {
                        "type": "string"
                    },
                    "LoadBalancerAclEntrySet": {
                        "type": "object",
                        "properties": {
                            "LoadBalancerAclId": {
                                "type": "string"
                            },
                            "LoadBalancerAclEntryId": {
                                "type": "string"
                            },
                            "CidrBlock": {
                                "type": "string"
                            },
                            "RuleNumber": {
                                "type": "integer"
                            },
                            "RuleAction": {
                                "type": "string",
                                "default": "allow"
                            },
                            "Protocol": {
                                "type": "string"
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
        //application/json
        {}

        //------------------------------------------------

        ```

### CreateLoadBalancerAclEntry

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.CreateLoadBalancerAclEntry(JObject _query );
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
                    "CreateLoadBalancerAclEntry"
                ],
                "default": "CreateLoadBalancerAclEntry"
            },
            "Version": {
                "type": "string",
                "default": "2016-03-04"
            },
            "LoadBalancerAclId": {
                "type": "string"
            },
            "CidrBlock": {
                "type": "string"
            },
            "RuleNumber": {
                "type": "integer"
            },
            "RuleAction": {
                "type": "string",
                "default": "allow"
            },
            "Protocol": {
                "type": "string"
            }
        }
        ```
        - Default
        
        ```json
        {
            "Version": "2016-03-04",
            "RuleAction": "allow"
        }
        ```
        - Constant
        
        ```json
        {
            "Action": "CreateLoadBalancerAclEntry"
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
        //application/json
        {
            "RequestId": {
                "type": "string"
            },
            "LoadBalancerAclEntry": {
                "type": "object",
                "properties": {
                    "LoadBalancerAclId": {
                        "type": "string"
                    },
                    "LoadBalancerAclEntryId": {
                        "type": "string"
                    },
                    "CidrBlock": {
                        "type": "string"
                    },
                    "RuleNumber": {
                        "type": "integer"
                    },
                    "RuleAction": {
                        "type": "string",
                        "default": "allow"
                    },
                    "Protocol": {
                        "type": "string"
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

### DeleteLoadBalancerAclEntry

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.DeleteLoadBalancerAclEntry(JObject _query );
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
                    "DeleteLoadBalancerAclEntry"
                ],
                "default": "DeleteLoadBalancerAclEntry"
            },
            "Version": {
                "type": "string",
                "default": "2016-03-04"
            },
            "LoadBalancerAclId": {
                "type": "string"
            },
            "LoadBalancerAclEntryId": {
                "type": "string"
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
            "Action": "DeleteLoadBalancerAclEntry"
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

### AssociateLoadBalancerAcl

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.AssociateLoadBalancerAcl(JObject _query );
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
                    "AssociateLoadBalancerAcl"
                ],
                "default": "AssociateLoadBalancerAcl"
            },
            "Version": {
                "type": "string",
                "default": "2016-03-04"
            },
            "LoadBalancerAclId": {
                "type": "string"
            },
            "ListenerId": {
                "type": "string"
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
            "Action": "AssociateLoadBalancerAcl"
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

### DisassociateLoadBalancerAcl

- Example

```c#
using KSYUN.SDK.SLB;
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

        HttpClientResponse res = client.DisassociateLoadBalancerAcl(JObject _query );
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
                    "DisassociateLoadBalancerAcl"
                ],
                "default": "DisassociateLoadBalancerAcl"
            },
            "Version": {
                "type": "string",
                "default": "2016-03-04"
            },
            "ListenerId": {
                "type": "string"
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
            "Action": "DisassociateLoadBalancerAcl"
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
