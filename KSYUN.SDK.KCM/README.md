# CSharp API SDK for namespace KSYUN.SDK.KCM classname KsyunKcmClient 


- Build date: 2019-06-12 11:49
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

Class Test {
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

Class Test {
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


        JObject _body = new JObject();

        HttpClientResponse res = client.DescribeCertificates(JObject _body );
        JObject data = res.data;
        IRestResponse response = res.response;
        Console.WriteLine(data);
    }
}

```

- Params
    - _body
        - Type -> JObject
        - Struct  
         
        ```json
        {
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

Class Test {
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


        JObject _query = new JObject();
        JObject _body = new JObject();

        HttpClientResponse res = client.CreateCertificate(JObject _query , JObject _body );
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
            "action": {
                "type": "string",
                "enum": [
                    "CreateCertificate"
                ],
                "default": "CreateCertificate"
            },
            "version": {
                "type": "string",
                "default": "2016-03-04"
            }
        }
        ```
        - Default
        
        ```json
        {
            "version": "2016-03-04"
        }
        ```
        - Constant
        
        ```json
        {
            "action": "CreateCertificate"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DeleteCertificate(JObject _query );
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

### ModifyCertificate

- Example

```c#
using KSYUN.SDK.KCM;
using Newtonsoft.Json.Linq;
using RestSharp;

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.ModifyCertificate(JObject _query );
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

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //application/json
        {}

        //------------------------------------------------

        ```
