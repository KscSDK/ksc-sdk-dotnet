# CSharp API SDK for namespace KSYUN.SDK.KCM classname KsyunKcmClient 


- Build date: 2019-08-15 10:03
## Installation

Use .NET CLI

    dotnet add package 'KSYUN.SDK.KCM'


## Usage
```c#
using KSYUN.SDK.KCM;
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
   server: "kcm"
```

## Authentication
> use aws signature v4

## Configuration
```c#
using KSYUN.SDK.KCM;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";

        KsyunKcmClient client = new KsyunKcmClient(
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
*KsyunKcmClient* | [**DescribeCertificates**](#DescribeCertificates) | **post** / | 
*KsyunKcmClient* | [**CreateCertificate**](#CreateCertificate) | **post** / | 
*KsyunKcmClient* | [**DeleteCertificate**](#DeleteCertificate) | **get** / | 
*KsyunKcmClient* | [**ModifyCertificate**](#ModifyCertificate) | **get** / | 

## Method Info




### DescribeCertificates

- Example

```c#
using KSYUN.SDK.KCM;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunKcmClient client = new KsyunKcmClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DescribeCertificates_body = new JObject();

            

        HttpClientResponse DescribeCertificates_res = client.DescribeCertificates(_DescribeCertificates_body);
        JObject DescribeCertificates_data = DescribeCertificates_res.data;
        IRestResponse DescribeCertificates_response = DescribeCertificates_res.response;
        Console.WriteLine(DescribeCertificates_data);
    }
}

```

- Params
    - _body
        - Type -> JObject
        - Struct  
         
        ```json
        {
            "type": "object",
            "properties": {
                "Action": {
                    "type": "string",
                    "enum": [
                        "DescribeCertificates"
                    ],
                    "default": "DescribeCertificates"
                },
                "CertificateId": {
                    "type": "string"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
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
            "Action": "DescribeCertificates"
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
            "type": "object",
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "Certificate": {
                    "type": "object",
                    "properties": {
                        "CertificateName": {
                            "type": "string"
                        },
                        "CertificateId": {
                            "type": "string"
                        },
                        "Enable": {
                            "type": "string"
                        },
                        "IssueDomain": {
                            "type": "string"
                        },
                        "IssueTime": {
                            "type": "string"
                        },
                        "ExpirationTime": {
                            "type": "string"
                        },
                        "CertificateContent": {
                            "type": "string"
                        },
                        "CertificateType": {
                            "type": "string"
                        },
                        "ConfigDomainNames": {
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



### CreateCertificate

- Example

```c#
using KSYUN.SDK.KCM;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunKcmClient client = new KsyunKcmClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _CreateCertificate_query = new JObject();

            
        JObject _CreateCertificate_body = new JObject();

            

        HttpClientResponse CreateCertificate_res = client.CreateCertificate(_CreateCertificate_query,_CreateCertificate_body);
        JObject CreateCertificate_data = CreateCertificate_res.data;
        IRestResponse CreateCertificate_response = CreateCertificate_res.response;
        Console.WriteLine(CreateCertificate_data);
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
                        "CreateCertificate"
                    ],
                    "default": "CreateCertificate"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
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
            "Action": "CreateCertificate"
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
                "CertificateName": {
                    "type": "string"
                },
                "PrivateKey": {
                    "type": "string"
                },
                "PublicKey": {
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
                "CertificateSet": {
                    "type": "object",
                    "properties": {
                        "CertificateName": {
                            "type": "string"
                        },
                        "CertificateId": {
                            "type": "string"
                        },
                        "Enable": {
                            "type": "string"
                        },
                        "IssueDomain": {
                            "type": "string"
                        },
                        "IssueTime": {
                            "type": "string"
                        },
                        "ExpirationTime": {
                            "type": "string"
                        },
                        "CertificateContent": {
                            "type": "string"
                        },
                        "CertificateType": {
                            "type": "string"
                        },
                        "ConfigDomainNames": {
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



### DeleteCertificate

- Example

```c#
using KSYUN.SDK.KCM;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunKcmClient client = new KsyunKcmClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DeleteCertificate_query = new JObject();

            

        HttpClientResponse DeleteCertificate_res = client.DeleteCertificate(_DeleteCertificate_query);
        JObject DeleteCertificate_data = DeleteCertificate_res.data;
        IRestResponse DeleteCertificate_response = DeleteCertificate_res.response;
        Console.WriteLine(DeleteCertificate_data);
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
                        "DeleteCertificate"
                    ],
                    "default": "DeleteCertificate"
                },
                "CertificateId": {
                    "type": "string"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
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
            "Action": "DeleteCertificate"
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
            "type": "object",
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "Return": {
                    "type": "boolean"
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



### ModifyCertificate

- Example

```c#
using KSYUN.SDK.KCM;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunKcmClient client = new KsyunKcmClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _ModifyCertificate_query = new JObject();

            

        HttpClientResponse ModifyCertificate_res = client.ModifyCertificate(_ModifyCertificate_query);
        JObject ModifyCertificate_data = ModifyCertificate_res.data;
        IRestResponse ModifyCertificate_response = ModifyCertificate_res.response;
        Console.WriteLine(ModifyCertificate_data);
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
                        "ModifyCertificate"
                    ],
                    "default": "ModifyCertificate"
                },
                "CertificateId": {
                    "type": "string"
                },
                "CertificateName": {
                    "type": "string"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
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
            "Action": "ModifyCertificate"
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
            "type": "object",
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "Certificate": {
                    "type": "object",
                    "properties": {
                        "CertificateName": {
                            "type": "string"
                        },
                        "CertificateId": {
                            "type": "string"
                        },
                        "Enable": {
                            "type": "string"
                        },
                        "IssueDomain": {
                            "type": "string"
                        },
                        "IssueTime": {
                            "type": "string"
                        },
                        "ExpirationTime": {
                            "type": "string"
                        },
                        "CertificateContent": {
                            "type": "string"
                        },
                        "CertificateType": {
                            "type": "string"
                        },
                        "ConfigDomainNames": {
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
