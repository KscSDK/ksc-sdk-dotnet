# CSharp API SDK for namespace KSYUN.SDK.SMS classname KsyunSMSClient 


- Build date: 2019-08-15 10:12
## Installation

Use .NET CLI

    dotnet add package 'KSYUN.SDK.SMS'


## Usage
```c#
using KSYUN.SDK.SMS;
```

## Dependency
```c#
using Newtonsoft.Json.Linq; //[JSON](https://www.newtonsoft.com/json/help/html/N_Newtonsoft_Json_Serialization.htm)
using RestSharp; //[Rest Request](https://github.com/restsharp/RestSharp/wiki/Usage-way)
using Manatee.Json; //[Schema Valid](https://gregsdennis.github.io/Manatee.Json/usage/schema.html)
```


## Documentation for API Endpoints
```bash
URL: {protocol}://{server}.api.ksyun.com
Parameters:
   region: 
   protocol: http | https
Constants:# no need setting
   server: "ksms"
```

## Authentication
> use aws signature v4

## Configuration
```c#
using KSYUN.SDK.SMS;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";

        KsyunSMSClient client = new KsyunSMSClient(
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
*KsyunSMSClient* | [**SendSms**](#SendSms) | **post** / | 
*KsyunSMSClient* | [**BatchSendSms**](#BatchSendSms) | **post** / | 

## Method Info




### SendSms

- Example

```c#
using KSYUN.SDK.SMS;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunSMSClient client = new KsyunSMSClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _SendSms_query = new JObject();

            
        JObject _SendSms_body = new JObject();

            

        HttpClientResponse SendSms_res = client.SendSms(_SendSms_query,_SendSms_body);
        JObject SendSms_data = SendSms_res.data;
        IRestResponse SendSms_response = SendSms_res.response;
        Console.WriteLine(SendSms_data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "type": "object",
            "properties": {
                "Action": {
                    "type": "string",
                    "enum": [
                        "SendSms"
                    ],
                    "default": "SendSms"
                },
                "Version": {
                    "type": "string",
                    "default": "2019-05-01"
                }
            }
        }
        ```
        - Default
        
        ```json
        {
            "Version": "2019-05-01"
        }
        ```
        - Constant
        
        ```json
        {
            "Action": "SendSms"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {}                
        ``` 
    - _body
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "type": "object",
            "properties": {
                "Mobile": {
                    "type": "string"
                },
                "SignName": {
                    "type": "string"
                },
                "TplId": {
                    "type": "string"
                },
                "TplParams": {
                    "type": "string"
                },
                "Content": {
                    "type": "string"
                },
                "SmsType": {
                    "type": "integer"
                }
            }
        }
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {}
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
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "Sid": {
                    "type": "string"
                },
                "ExtId": {
                    "type": "string"
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



### BatchSendSms

- Example

```c#
using KSYUN.SDK.SMS;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunSMSClient client = new KsyunSMSClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _BatchSendSms_query = new JObject();

            
        JObject _BatchSendSms_body = new JObject();

            

        HttpClientResponse BatchSendSms_res = client.BatchSendSms(_BatchSendSms_query,_BatchSendSms_body);
        JObject BatchSendSms_data = BatchSendSms_res.data;
        IRestResponse BatchSendSms_response = BatchSendSms_res.response;
        Console.WriteLine(BatchSendSms_data);
    }
}

```

- Params
    - _query
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "type": "object",
            "properties": {
                "Action": {
                    "type": "string",
                    "enum": [
                        "BatchSendSms"
                    ],
                    "default": "BatchSendSms"
                },
                "Version": {
                    "type": "string",
                    "default": "2019-05-01"
                }
            }
        }
        ```
        - Default
        
        ```json
        {
            "Version": "2019-05-01"
        }
        ```
        - Constant
        
        ```json
        {
            "Action": "BatchSendSms"
        }
        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
        
        ```json
        {}                
        ``` 
    - _body
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "type": "object",
            "properties": {
                "Mobile": {
                    "type": "string"
                },
                "SignName": {
                    "type": "string"
                },
                "TplId": {
                    "type": "string"
                },
                "TplParams": {
                    "type": "string"
                },
                "Content": {
                    "type": "string"
                },
                "SmsType": {
                    "type": "string"
                }
            }
        }
        ```
        - Default
        
        ```json
        {}
        ```
        - Constant
        
        ```json
        {}
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
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "Sid": {
                    "type": "string"
                },
                "ExtId": {
                    "type": "string"
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
