# CSharp API SDK for namespace KSYUN.SDK.VPC classname KsyunVpcClient 


- Build date: 2019-08-15 10:03
## Installation

Use .NET CLI

    dotnet add package 'KSYUN.SDK.VPC'


## Usage
```c#
using KSYUN.SDK.VPC;
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
   server: "vpc"
```

## Authentication
> use aws signature v4

## Configuration
```c#
using KSYUN.SDK.VPC;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";

        KsyunVpcClient client = new KsyunVpcClient(
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
*KsyunVpcClient* | [**CreateVpc**](#CreateVpc) | **get** / | 
*KsyunVpcClient* | [**DeleteVpc**](#DeleteVpc) | **get** / | 
*KsyunVpcClient* | [**ModifyVpc**](#ModifyVpc) | **get** / | 
*KsyunVpcClient* | [**DescribeVpcs**](#DescribeVpcs) | **get** / | 
*KsyunVpcClient* | [**CreateSubnet**](#CreateSubnet) | **get** / | 
*KsyunVpcClient* | [**DeleteSubnet**](#DeleteSubnet) | **get** / | 
*KsyunVpcClient* | [**ModifySubnet**](#ModifySubnet) | **get** / | 
*KsyunVpcClient* | [**DescribeSubnets**](#DescribeSubnets) | **get** / | 
*KsyunVpcClient* | [**AssociateNetworkAcl**](#AssociateNetworkAcl) | **get** / | 
*KsyunVpcClient* | [**DisassociateNetworkAcl**](#DisassociateNetworkAcl) | **get** / | 
*KsyunVpcClient* | [**DescribeSubnetAvailableAddresses**](#DescribeSubnetAvailableAddresses) | **get** / | 
*KsyunVpcClient* | [**DescribeSubnetAllocatedIpAddresses**](#DescribeSubnetAllocatedIpAddresses) | **get** / | 
*KsyunVpcClient* | [**CreateRoute**](#CreateRoute) | **get** / | 
*KsyunVpcClient* | [**DeleteRoute**](#DeleteRoute) | **get** / | 
*KsyunVpcClient* | [**DescribeRoutes**](#DescribeRoutes) | **get** / | 
*KsyunVpcClient* | [**CreateNetworkAcl**](#CreateNetworkAcl) | **get** / | 
*KsyunVpcClient* | [**DeleteNetworkAcl**](#DeleteNetworkAcl) | **get** / | 
*KsyunVpcClient* | [**ModifyNetworkAcl**](#ModifyNetworkAcl) | **get** / | 
*KsyunVpcClient* | [**CreateNetworkAclEntry**](#CreateNetworkAclEntry) | **get** / | 
*KsyunVpcClient* | [**DeleteNetworkAclEntry**](#DeleteNetworkAclEntry) | **get** / | 
*KsyunVpcClient* | [**ModifyNetworkAclEntry**](#ModifyNetworkAclEntry) | **get** / | 
*KsyunVpcClient* | [**DescribeNetworkAcls**](#DescribeNetworkAcls) | **get** / | 
*KsyunVpcClient* | [**CreateSecurityGroup**](#CreateSecurityGroup) | **get** / | 
*KsyunVpcClient* | [**DeleteSecurityGroup**](#DeleteSecurityGroup) | **get** / | 
*KsyunVpcClient* | [**ModifySecurityGroup**](#ModifySecurityGroup) | **get** / | 
*KsyunVpcClient* | [**AuthorizeSecurityGroupEntry**](#AuthorizeSecurityGroupEntry) | **get** / | 
*KsyunVpcClient* | [**RevokeSecurityGroupEntry**](#RevokeSecurityGroupEntry) | **get** / | 
*KsyunVpcClient* | [**ModifySecurityGroupEntry**](#ModifySecurityGroupEntry) | **get** / | 
*KsyunVpcClient* | [**DescribeSecurityGroups**](#DescribeSecurityGroups) | **get** / | 
*KsyunVpcClient* | [**DescribeInternetGateways**](#DescribeInternetGateways) | **get** / | 
*KsyunVpcClient* | [**DescribeNetworkInterfaces**](#DescribeNetworkInterfaces) | **get** / | 
*KsyunVpcClient* | [**CreateNat**](#CreateNat) | **get** / | 
*KsyunVpcClient* | [**DeleteNat**](#DeleteNat) | **get** / | 
*KsyunVpcClient* | [**ModifyNat**](#ModifyNat) | **get** / | 
*KsyunVpcClient* | [**DescribeNats**](#DescribeNats) | **get** / | 
*KsyunVpcClient* | [**AssociateNat**](#AssociateNat) | **get** / | 
*KsyunVpcClient* | [**DisassociateNat**](#DisassociateNat) | **get** / | 
*KsyunVpcClient* | [**CreateVpcPeeringConnection**](#CreateVpcPeeringConnection) | **get** / | 
*KsyunVpcClient* | [**AcceptVpcPeeringConnection**](#AcceptVpcPeeringConnection) | **get** / | 
*KsyunVpcClient* | [**RejectVpcPeeringConnection**](#RejectVpcPeeringConnection) | **get** / | 
*KsyunVpcClient* | [**DeleteVpcPeeringConnection**](#DeleteVpcPeeringConnection) | **get** / | 
*KsyunVpcClient* | [**ModifyVpcPeeringConnection**](#ModifyVpcPeeringConnection) | **get** / | 
*KsyunVpcClient* | [**DescribeVpcPeeringConnections**](#DescribeVpcPeeringConnections) | **get** / | 
*KsyunVpcClient* | [**AddNatIp**](#AddNatIp) | **get** / | 
*KsyunVpcClient* | [**DeleteNatIp**](#DeleteNatIp) | **get** / | 
*KsyunVpcClient* | [**AssociateDirectConnectGateway**](#AssociateDirectConnectGateway) | **get** / | 
*KsyunVpcClient* | [**DisassociateDirectConnectGateway**](#DisassociateDirectConnectGateway) | **get** / | 
*KsyunVpcClient* | [**AssociateVpnGateway**](#AssociateVpnGateway) | **get** / | 
*KsyunVpcClient* | [**DisassociateVpnGateway**](#DisassociateVpnGateway) | **get** / | 
*KsyunVpcClient* | [**DescribeAvailabilityZones**](#DescribeAvailabilityZones) | **get** / | 
*KsyunVpcClient* | [**DescribeDirectConnects**](#DescribeDirectConnects) | **get** / | 
*KsyunVpcClient* | [**CreateDirectConnectInterface**](#CreateDirectConnectInterface) | **get** / | 
*KsyunVpcClient* | [**ModifyDirectConnectInterface**](#ModifyDirectConnectInterface) | **get** / | 
*KsyunVpcClient* | [**DeleteDirectConnectInterface**](#DeleteDirectConnectInterface) | **get** / | 
*KsyunVpcClient* | [**DescribeDirectConnectInterfaces**](#DescribeDirectConnectInterfaces) | **get** / | 
*KsyunVpcClient* | [**CreateDirectConnectGateway**](#CreateDirectConnectGateway) | **get** / | 
*KsyunVpcClient* | [**ModifyDirectConnectGateway**](#ModifyDirectConnectGateway) | **get** / | 
*KsyunVpcClient* | [**DeleteDirectConnectGateway**](#DeleteDirectConnectGateway) | **get** / | 
*KsyunVpcClient* | [**DescribeDirectConnectGateways**](#DescribeDirectConnectGateways) | **get** / | 
*KsyunVpcClient* | [**AttachDirectConnectGateway**](#AttachDirectConnectGateway) | **get** / | 
*KsyunVpcClient* | [**DetachDirectConnectGateway**](#DetachDirectConnectGateway) | **get** / | 
*KsyunVpcClient* | [**CreateVpnGateway**](#CreateVpnGateway) | **get** / | 
*KsyunVpcClient* | [**ModifyVpnGateway**](#ModifyVpnGateway) | **get** / | 
*KsyunVpcClient* | [**DeleteVpnGateway**](#DeleteVpnGateway) | **get** / | 
*KsyunVpcClient* | [**DescribeVpnGateways**](#DescribeVpnGateways) | **get** / | 
*KsyunVpcClient* | [**CreateVpnTunnel**](#CreateVpnTunnel) | **post** / | 
*KsyunVpcClient* | [**ModifyVpnTunnel**](#ModifyVpnTunnel) | **get** / | 
*KsyunVpcClient* | [**DeleteVpnTunnel**](#DeleteVpnTunnel) | **get** / | 
*KsyunVpcClient* | [**DescribeVpnTunnels**](#DescribeVpnTunnels) | **get** / | 
*KsyunVpcClient* | [**CreateCustomerGateway**](#CreateCustomerGateway) | **get** / | 
*KsyunVpcClient* | [**ModifyCustomerGateway**](#ModifyCustomerGateway) | **get** / | 
*KsyunVpcClient* | [**DeleteCustomerGateway**](#DeleteCustomerGateway) | **get** / | 
*KsyunVpcClient* | [**DescribeCustomerGateways**](#DescribeCustomerGateways) | **get** / | 
*KsyunVpcClient* | [**DescribeTunnels**](#DescribeTunnels) | **get** / | 
*KsyunVpcClient* | [**ModifyTunnel**](#ModifyTunnel) | **get** / | 
*KsyunVpcClient* | [**AssociateSubnet**](#AssociateSubnet) | **get** / | 
*KsyunVpcClient* | [**DisassociateSubnet**](#DisassociateSubnet) | **get** / | 
*KsyunVpcClient* | [**AssociateRemoteCidr**](#AssociateRemoteCidr) | **get** / | 
*KsyunVpcClient* | [**DisassociateRemoteCidr**](#DisassociateRemoteCidr) | **get** / | 

## Method Info




### CreateVpc

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _CreateVpc_query = new JObject();

            

        HttpClientResponse CreateVpc_res = client.CreateVpc(_CreateVpc_query);
        JObject CreateVpc_data = CreateVpc_res.data;
        IRestResponse CreateVpc_response = CreateVpc_res.response;
        Console.WriteLine(CreateVpc_data);
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
                        "CreateVpc"
                    ],
                    "default": "CreateVpc"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "VpcName": {
                    "type": "string"
                },
                "CidrBlock": {
                    "type": "string"
                },
                "IsDefault": {
                    "type": "boolean"
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
            "Action": "CreateVpc"
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
        //application/xml
        {
            "properties": {
                "Vpc": {
                    "type": "object",
                    "properties": {
                        "CidrBlock": {
                            "type": "string"
                        },
                        "CreateTime": {
                            "type": "string"
                        },
                        "IsDefault": {
                            "type": "boolean"
                        },
                        "VpcName": {
                            "type": "string"
                        },
                        "VpcId": {
                            "type": "string"
                        }
                    }
                },
                "RequestId": {
                    "type": "string"
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //application/xml
        {}

        //------------------------------------------------

        ```



### DeleteVpc

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DeleteVpc_query = new JObject();

            

        HttpClientResponse DeleteVpc_res = client.DeleteVpc(_DeleteVpc_query);
        JObject DeleteVpc_data = DeleteVpc_res.data;
        IRestResponse DeleteVpc_response = DeleteVpc_res.response;
        Console.WriteLine(DeleteVpc_data);
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
                        "DeleteVpc"
                    ],
                    "default": "DeleteVpc"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "VpcId": {
                    "type": "string"
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
            "Action": "DeleteVpc"
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
        //application/xml
        {
            "properties": {
                "Return": {
                    "type": "boolean"
                },
                "RequestId": {
                    "type": "string"
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //application/xml
        {}

        //------------------------------------------------

        ```



### ModifyVpc

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _ModifyVpc_query = new JObject();

            

        HttpClientResponse ModifyVpc_res = client.ModifyVpc(_ModifyVpc_query);
        JObject ModifyVpc_data = ModifyVpc_res.data;
        IRestResponse ModifyVpc_response = ModifyVpc_res.response;
        Console.WriteLine(ModifyVpc_data);
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
                        "ModifyVpc"
                    ],
                    "default": "ModifyVpc"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "VpcName": {
                    "type": "string"
                },
                "VpcId": {
                    "type": "string"
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
            "Action": "ModifyVpc"
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
        //application/xml
        {
            "properties": {
                "Return": {
                    "type": "boolean"
                },
                "RequestId": {
                    "type": "string"
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //application/xml
        {}

        //------------------------------------------------

        ```



### DescribeVpcs

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DescribeVpcs_query = new JObject();

            

        HttpClientResponse DescribeVpcs_res = client.DescribeVpcs(_DescribeVpcs_query);
        JObject DescribeVpcs_data = DescribeVpcs_res.data;
        IRestResponse DescribeVpcs_response = DescribeVpcs_res.response;
        Console.WriteLine(DescribeVpcs_data);
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
                        "DescribeVpcs"
                    ],
                    "default": "DescribeVpcs"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "VpcId": {
                    "type": "string"
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
            "Action": "DescribeVpcs"
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
        //application/xml
        {
            "properties": {
                "VpcSet": {
                    "type": "array",
                    "items": {
                        "type": "object",
                        "properties": {
                            "CreateTime": {
                                "type": "string"
                            },
                            "VpcName": {
                                "type": "string"
                            },
                            "VpcId": {
                                "type": "string"
                            },
                            "CidrBlock": {
                                "type": "string"
                            },
                            "IsDefault": {
                                "type": "boolean"
                            }
                        }
                    }
                },
                "RequestId": {
                    "type": "string"
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //application/xml
        {}

        //------------------------------------------------

        ```



### CreateSubnet

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _CreateSubnet_query = new JObject();

            

        HttpClientResponse CreateSubnet_res = client.CreateSubnet(_CreateSubnet_query);
        JObject CreateSubnet_data = CreateSubnet_res.data;
        IRestResponse CreateSubnet_response = CreateSubnet_res.response;
        Console.WriteLine(CreateSubnet_data);
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
                        "CreateSubnet"
                    ],
                    "default": "CreateSubnet"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "AvailabilityZone": {
                    "type": "string"
                },
                "SubnetName": {
                    "type": "string"
                },
                "CidrBlock": {
                    "type": "string"
                },
                "SubnetType": {
                    "type": "string"
                },
                "DhcpIpFrom": {
                    "type": "string"
                },
                "DhcpIpTo": {
                    "type": "string"
                },
                "GatewayIp": {
                    "type": "string"
                },
                "VpcId": {
                    "type": "string"
                },
                "Dns1": {
                    "type": "string"
                },
                "Dns2": {
                    "type": "string"
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
            "Action": "CreateSubnet"
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
        //application/xml
        {
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "Subnet": {
                    "type": "object",
                    "properties": {
                        "CreateTime": {
                            "type": "string"
                        },
                        "VpcId": {
                            "type": "string"
                        },
                        "SubnetId": {
                            "type": "string"
                        },
                        "SubnetType": {
                            "type": "string"
                        },
                        "SubnetName": {
                            "type": "string"
                        },
                        "CidrBlock": {
                            "type": "string"
                        },
                        "DhcpIpFrom": {
                            "type": "string"
                        },
                        "DhcpIpTo": {
                            "type": "string"
                        },
                        "GatewayIp": {
                            "type": "string"
                        },
                        "Dns1": {
                            "type": "string"
                        },
                        "Dns2": {
                            "type": "string"
                        },
                        "NetworkAclId": {
                            "type": "string"
                        },
                        "NatId": {
                            "type": "string"
                        },
                        "AvailbleIPNumber": {
                            "type": "string"
                        },
                        "AvailabilityZoneName": {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### DeleteSubnet

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DeleteSubnet_query = new JObject();

            

        HttpClientResponse DeleteSubnet_res = client.DeleteSubnet(_DeleteSubnet_query);
        JObject DeleteSubnet_data = DeleteSubnet_res.data;
        IRestResponse DeleteSubnet_response = DeleteSubnet_res.response;
        Console.WriteLine(DeleteSubnet_data);
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
                        "DeleteSubnet"
                    ],
                    "default": "DeleteSubnet"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "SubnetId": {
                    "type": "string"
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
            "Action": "DeleteSubnet"
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
        //application/xml
        {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### ModifySubnet

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _ModifySubnet_query = new JObject();

            

        HttpClientResponse ModifySubnet_res = client.ModifySubnet(_ModifySubnet_query);
        JObject ModifySubnet_data = ModifySubnet_res.data;
        IRestResponse ModifySubnet_response = ModifySubnet_res.response;
        Console.WriteLine(ModifySubnet_data);
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
                        "ModifySubnet"
                    ],
                    "default": "ModifySubnet"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "SubnetId": {
                    "type": "string"
                },
                "SubnetName": {
                    "type": "string"
                },
                "Dns1": {
                    "type": "string"
                },
                "Dns2": {
                    "type": "string"
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
            "Action": "ModifySubnet"
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
        //application/xml
        {
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "Subnet": {
                    "type": "object",
                    "properties": {
                        "CreateTime": {
                            "type": "string"
                        },
                        "VpcId": {
                            "type": "string"
                        },
                        "SubnetId": {
                            "type": "string"
                        },
                        "SubnetType": {
                            "type": "string"
                        },
                        "SubnetName": {
                            "type": "string"
                        },
                        "CidrBlock": {
                            "type": "string"
                        },
                        "DhcpIpFrom": {
                            "type": "string"
                        },
                        "DhcpIpTo": {
                            "type": "string"
                        },
                        "GatewayIp": {
                            "type": "string"
                        },
                        "Dns1": {
                            "type": "string"
                        },
                        "Dns2": {
                            "type": "string"
                        },
                        "NetworkAclId": {
                            "type": "string"
                        },
                        "NatId": {
                            "type": "string"
                        },
                        "AvailbleIPNumber": {
                            "type": "string"
                        },
                        "AvailabilityZoneName": {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### DescribeSubnets

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DescribeSubnets_query = new JObject();

            

        HttpClientResponse DescribeSubnets_res = client.DescribeSubnets(_DescribeSubnets_query);
        JObject DescribeSubnets_data = DescribeSubnets_res.data;
        IRestResponse DescribeSubnets_response = DescribeSubnets_res.response;
        Console.WriteLine(DescribeSubnets_data);
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
                        "DescribeSubnets"
                    ],
                    "default": "DescribeSubnets"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "SubnetId": {
                    "type": "string"
                },
                "Filter": {
                    "type": "string"
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
            "Action": "DescribeSubnets"
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
        //application/xml
        {
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "SubnetSet": {
                    "type": "array",
                    "items": {
                        "type": "object",
                        "properties": {
                            "CreateTime": {
                                "type": "string"
                            },
                            "VpcId": {
                                "type": "string"
                            },
                            "SubnetId": {
                                "type": "string"
                            },
                            "SubnetType": {
                                "type": "string"
                            },
                            "SubnetName": {
                                "type": "string"
                            },
                            "CidrBlock": {
                                "type": "string"
                            },
                            "DhcpIpFrom": {
                                "type": "string"
                            },
                            "DhcpIpTo": {
                                "type": "string"
                            },
                            "GatewayIp": {
                                "type": "string"
                            },
                            "Dns1": {
                                "type": "string"
                            },
                            "Dns2": {
                                "type": "string"
                            },
                            "NetworkAclId": {
                                "type": "string"
                            },
                            "NatId": {
                                "type": "string"
                            },
                            "AvailbleIPNumber": {
                                "type": "string"
                            },
                            "AvailabilityZoneName": {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### AssociateNetworkAcl

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _AssociateNetworkAcl_query = new JObject();

            

        HttpClientResponse AssociateNetworkAcl_res = client.AssociateNetworkAcl(_AssociateNetworkAcl_query);
        JObject AssociateNetworkAcl_data = AssociateNetworkAcl_res.data;
        IRestResponse AssociateNetworkAcl_response = AssociateNetworkAcl_res.response;
        Console.WriteLine(AssociateNetworkAcl_data);
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
                        "AssociateNetworkAcl"
                    ],
                    "default": "AssociateNetworkAcl"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "SubnetId": {
                    "type": "string"
                },
                "NetworkAclId": {
                    "type": "string"
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
            "Action": "AssociateNetworkAcl"
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
        //application/xml
        {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### DisassociateNetworkAcl

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DisassociateNetworkAcl_query = new JObject();

            

        HttpClientResponse DisassociateNetworkAcl_res = client.DisassociateNetworkAcl(_DisassociateNetworkAcl_query);
        JObject DisassociateNetworkAcl_data = DisassociateNetworkAcl_res.data;
        IRestResponse DisassociateNetworkAcl_response = DisassociateNetworkAcl_res.response;
        Console.WriteLine(DisassociateNetworkAcl_data);
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
                        "DisassociateNetworkAcl"
                    ],
                    "default": "DisassociateNetworkAcl"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "SubnetId": {
                    "type": "string"
                },
                "NetworkAclId": {
                    "type": "string"
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
            "Action": "DisassociateNetworkAcl"
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
        //application/xml
        {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### DescribeSubnetAvailableAddresses

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DescribeSubnetAvailableAddresses_query = new JObject();

            

        HttpClientResponse DescribeSubnetAvailableAddresses_res = client.DescribeSubnetAvailableAddresses(_DescribeSubnetAvailableAddresses_query);
        JObject DescribeSubnetAvailableAddresses_data = DescribeSubnetAvailableAddresses_res.data;
        IRestResponse DescribeSubnetAvailableAddresses_response = DescribeSubnetAvailableAddresses_res.response;
        Console.WriteLine(DescribeSubnetAvailableAddresses_data);
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
                        "DescribeSubnetAvailableAddresses"
                    ],
                    "default": "DescribeSubnetAvailableAddresses"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "Filter": {
                    "type": "string"
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
            "Action": "DescribeSubnetAvailableAddresses"
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
        //application/xml
        {
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "AvailableIpAddress": {
                    "type": "boolean"
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //application/xml
        {}

        //------------------------------------------------

        ```



### DescribeSubnetAllocatedIpAddresses

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DescribeSubnetAllocatedIpAddresses_query = new JObject();

            

        HttpClientResponse DescribeSubnetAllocatedIpAddresses_res = client.DescribeSubnetAllocatedIpAddresses(_DescribeSubnetAllocatedIpAddresses_query);
        JObject DescribeSubnetAllocatedIpAddresses_data = DescribeSubnetAllocatedIpAddresses_res.data;
        IRestResponse DescribeSubnetAllocatedIpAddresses_response = DescribeSubnetAllocatedIpAddresses_res.response;
        Console.WriteLine(DescribeSubnetAllocatedIpAddresses_data);
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
                        "DescribeSubnetAllocatedIpAddresses"
                    ],
                    "default": "DescribeSubnetAllocatedIpAddresses"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "Filter": {
                    "type": "string"
                },
                "MaxResults": {
                    "type": "integer"
                },
                "NextToken": {
                    "type": "string"
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
            "Action": "DescribeSubnetAllocatedIpAddresses"
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
        //application/xml
        {
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "AllocatedIpAddress": {
                    "type": "boolean"
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //application/xml
        {}

        //------------------------------------------------

        ```



### CreateRoute

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _CreateRoute_query = new JObject();

            

        HttpClientResponse CreateRoute_res = client.CreateRoute(_CreateRoute_query);
        JObject CreateRoute_data = CreateRoute_res.data;
        IRestResponse CreateRoute_response = CreateRoute_res.response;
        Console.WriteLine(CreateRoute_data);
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
                        "CreateRoute"
                    ],
                    "default": "CreateRoute"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "VpcId": {
                    "type": "string"
                },
                "DestinationCidrBlock": {
                    "type": "string"
                },
                "RouteType": {
                    "type": "string",
                    "default": "InternetGateway"
                },
                "TunnelId": {
                    "type": "string"
                },
                "InstanceId": {
                    "type": "string"
                },
                "VpcPeeringConnectionId": {
                    "type": "string"
                },
                "DirectConnectGatewayId": {
                    "type": "string"
                },
                "VpnTunnelId": {
                    "type": "string"
                }
            }
        }
        ```
        - Default
        
        ```json
        {
            "Version": "2016-03-04",
            "RouteType": "InternetGateway"
        }
        ```
        - Constant
        
        ```json
        {
            "Action": "CreateRoute"
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
        //application/xml
        {
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "RouteId": {
                    "type": "string"
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //application/xml
        {}

        //------------------------------------------------

        ```



### DeleteRoute

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DeleteRoute_query = new JObject();

            

        HttpClientResponse DeleteRoute_res = client.DeleteRoute(_DeleteRoute_query);
        JObject DeleteRoute_data = DeleteRoute_res.data;
        IRestResponse DeleteRoute_response = DeleteRoute_res.response;
        Console.WriteLine(DeleteRoute_data);
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
                        "DeleteRoute"
                    ],
                    "default": "DeleteRoute"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "RouteId": {
                    "type": "string"
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
            "Action": "DeleteRoute"
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
        //application/xml
        {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### DescribeRoutes

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DescribeRoutes_query = new JObject();

            

        HttpClientResponse DescribeRoutes_res = client.DescribeRoutes(_DescribeRoutes_query);
        JObject DescribeRoutes_data = DescribeRoutes_res.data;
        IRestResponse DescribeRoutes_response = DescribeRoutes_res.response;
        Console.WriteLine(DescribeRoutes_data);
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
                        "DescribeRoutes"
                    ],
                    "default": "DescribeRoutes"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "RouteId": {
                    "type": "string"
                },
                "Filter": {
                    "type": "string"
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
            "Action": "DescribeRoutes"
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
        //application/xml
        {
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "RouteSet": {
                    "type": "array",
                    "items": {
                        "type": "object",
                        "properties": {
                            "CreateTime": {
                                "type": "string"
                            },
                            "VpcId": {
                                "type": "string"
                            },
                            "RouteId": {
                                "type": "string"
                            },
                            "DestinationCidrBlock": {
                                "type": "string"
                            },
                            "RouteType": {
                                "type": "string"
                            },
                            "NextHopSet": {
                                "type": "array",
                                "items": {
                                    "type": "object",
                                    "properties": {
                                        "GatewayId": {
                                            "type": "string"
                                        },
                                        "GatewayName": {
                                            "type": "string"
                                        }
                                    }
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### CreateNetworkAcl

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _CreateNetworkAcl_query = new JObject();

            

        HttpClientResponse CreateNetworkAcl_res = client.CreateNetworkAcl(_CreateNetworkAcl_query);
        JObject CreateNetworkAcl_data = CreateNetworkAcl_res.data;
        IRestResponse CreateNetworkAcl_response = CreateNetworkAcl_res.response;
        Console.WriteLine(CreateNetworkAcl_data);
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
                        "CreateNetworkAcl"
                    ],
                    "default": "CreateNetworkAcl"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "VpcId": {
                    "type": "string"
                },
                "NetworkAclName": {
                    "type": "string"
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
            "Action": "CreateNetworkAcl"
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
        //application/xml
        {
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "NetworkAcl": {
                    "type": "object",
                    "properties": {
                        "CreateTime": {
                            "type": "string"
                        },
                        "VpcId": {
                            "type": "string"
                        },
                        "NetworkAclName": {
                            "type": "string"
                        },
                        "NetworkAclId": {
                            "type": "string"
                        },
                        "NetworkAclEntrySet": {
                            "type": "object",
                            "properties": {
                                "GatewayId": {
                                    "type": "string"
                                },
                                "GatewayName": {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### DeleteNetworkAcl

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DeleteNetworkAcl_query = new JObject();

            

        HttpClientResponse DeleteNetworkAcl_res = client.DeleteNetworkAcl(_DeleteNetworkAcl_query);
        JObject DeleteNetworkAcl_data = DeleteNetworkAcl_res.data;
        IRestResponse DeleteNetworkAcl_response = DeleteNetworkAcl_res.response;
        Console.WriteLine(DeleteNetworkAcl_data);
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
                        "DeleteNetworkAcl"
                    ],
                    "default": "DeleteNetworkAcl"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "NetworkAclId": {
                    "type": "string"
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
            "Action": "DeleteNetworkAcl"
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
        //application/xml
        {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### ModifyNetworkAcl

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _ModifyNetworkAcl_query = new JObject();

            

        HttpClientResponse ModifyNetworkAcl_res = client.ModifyNetworkAcl(_ModifyNetworkAcl_query);
        JObject ModifyNetworkAcl_data = ModifyNetworkAcl_res.data;
        IRestResponse ModifyNetworkAcl_response = ModifyNetworkAcl_res.response;
        Console.WriteLine(ModifyNetworkAcl_data);
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
                        "ModifyNetworkAcl"
                    ],
                    "default": "ModifyNetworkAcl"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "NetworkAclName": {
                    "type": "string"
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
            "Action": "ModifyNetworkAcl"
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
        //application/xml
        {
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "NetworkAcl": {
                    "type": "object",
                    "properties": {
                        "CreateTime": {
                            "type": "string"
                        },
                        "VpcId": {
                            "type": "string"
                        },
                        "NetworkAclName": {
                            "type": "string"
                        },
                        "NetworkAclId": {
                            "type": "string"
                        },
                        "NetworkAclEntrySet": {
                            "type": "object",
                            "properties": {
                                "GatewayId": {
                                    "type": "string"
                                },
                                "GatewayName": {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### CreateNetworkAclEntry

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _CreateNetworkAclEntry_query = new JObject();

            

        HttpClientResponse CreateNetworkAclEntry_res = client.CreateNetworkAclEntry(_CreateNetworkAclEntry_query);
        JObject CreateNetworkAclEntry_data = CreateNetworkAclEntry_res.data;
        IRestResponse CreateNetworkAclEntry_response = CreateNetworkAclEntry_res.response;
        Console.WriteLine(CreateNetworkAclEntry_data);
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
                        "CreateNetworkAclEntry"
                    ],
                    "default": "CreateNetworkAclEntry"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "Description": {
                    "type": "string"
                },
                "NetworkAclId": {
                    "type": "string"
                },
                "CidrBlock": {
                    "type": "string"
                },
                "RuleNumber": {
                    "type": "integer"
                },
                "Direction": {
                    "type": "string"
                },
                "RuleAction": {
                    "type": "string"
                },
                "Protocol": {
                    "type": "string"
                },
                "IcmpType": {
                    "type": "integer"
                },
                "PortRangeFrom": {
                    "type": "integer"
                },
                "PortRangeTo": {
                    "type": "integer"
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
            "Action": "CreateNetworkAclEntry"
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
        //application/xml
        {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### DeleteNetworkAclEntry

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DeleteNetworkAclEntry_query = new JObject();

            

        HttpClientResponse DeleteNetworkAclEntry_res = client.DeleteNetworkAclEntry(_DeleteNetworkAclEntry_query);
        JObject DeleteNetworkAclEntry_data = DeleteNetworkAclEntry_res.data;
        IRestResponse DeleteNetworkAclEntry_response = DeleteNetworkAclEntry_res.response;
        Console.WriteLine(DeleteNetworkAclEntry_data);
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
                        "DeleteNetworkAclEntry"
                    ],
                    "default": "DeleteNetworkAclEntry"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "NetworkAclEntryId": {
                    "type": "string"
                },
                "NetworkAclId": {
                    "type": "string"
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
            "Action": "DeleteNetworkAclEntry"
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
        //application/xml
        {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### ModifyNetworkAclEntry

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _ModifyNetworkAclEntry_query = new JObject();

            

        HttpClientResponse ModifyNetworkAclEntry_res = client.ModifyNetworkAclEntry(_ModifyNetworkAclEntry_query);
        JObject ModifyNetworkAclEntry_data = ModifyNetworkAclEntry_res.data;
        IRestResponse ModifyNetworkAclEntry_response = ModifyNetworkAclEntry_res.response;
        Console.WriteLine(ModifyNetworkAclEntry_data);
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
                        "ModifyNetworkAclEntry"
                    ],
                    "default": "ModifyNetworkAclEntry"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "NetworkAclName": {
                    "type": "string"
                },
                "NetworkAclId": {
                    "type": "string"
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
            "Action": "ModifyNetworkAclEntry"
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
        //application/xml
        {
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "NetworkAcl": {
                    "type": "object",
                    "properties": {
                        "CreateTime": {
                            "type": "string"
                        },
                        "VpcId": {
                            "type": "string"
                        },
                        "NetworkAclName": {
                            "type": "string"
                        },
                        "NetworkAclId": {
                            "type": "string"
                        },
                        "NetworkAclEntrySet": {
                            "type": "object",
                            "properties": {
                                "GatewayId": {
                                    "type": "string"
                                },
                                "GatewayName": {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### DescribeNetworkAcls

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DescribeNetworkAcls_query = new JObject();

            

        HttpClientResponse DescribeNetworkAcls_res = client.DescribeNetworkAcls(_DescribeNetworkAcls_query);
        JObject DescribeNetworkAcls_data = DescribeNetworkAcls_res.data;
        IRestResponse DescribeNetworkAcls_response = DescribeNetworkAcls_res.response;
        Console.WriteLine(DescribeNetworkAcls_data);
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
                        "DescribeNetworkAcls"
                    ],
                    "default": "DescribeNetworkAcls"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "NetworkAclId": {
                    "type": "string"
                },
                "Filter": {
                    "type": "string"
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
            "Action": "DescribeNetworkAcls"
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
        //application/xml
        {
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "NetworkAcl": {
                    "type": "array",
                    "items": {
                        "type": "object",
                        "properties": {
                            "CreateTime": {
                                "type": "string"
                            },
                            "VpcId": {
                                "type": "string"
                            },
                            "NetworkAclName": {
                                "type": "string"
                            },
                            "NetworkAclId": {
                                "type": "string"
                            },
                            "NetworkAclEntrySet": {
                                "type": "object",
                                "properties": {
                                    "GatewayId": {
                                        "type": "string"
                                    },
                                    "GatewayName": {
                                        "type": "string"
                                    }
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### CreateSecurityGroup

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _CreateSecurityGroup_query = new JObject();

            

        HttpClientResponse CreateSecurityGroup_res = client.CreateSecurityGroup(_CreateSecurityGroup_query);
        JObject CreateSecurityGroup_data = CreateSecurityGroup_res.data;
        IRestResponse CreateSecurityGroup_response = CreateSecurityGroup_res.response;
        Console.WriteLine(CreateSecurityGroup_data);
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
                        "CreateSecurityGroup"
                    ],
                    "default": "CreateSecurityGroup"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "VpcId": {
                    "type": "string"
                },
                "SecurityGroupName": {
                    "type": "string",
                    "default": "Ksc_SecurityGroup"
                }
            }
        }
        ```
        - Default
        
        ```json
        {
            "Version": "2016-03-04",
            "SecurityGroupName": "Ksc_SecurityGroup"
        }
        ```
        - Constant
        
        ```json
        {
            "Action": "CreateSecurityGroup"
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
        //application/xml
        {
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "SecurityGroup": {
                    "type": "object",
                    "properties": {
                        "CreateTime": {
                            "type": "string"
                        },
                        "VpcId": {
                            "type": "string"
                        },
                        "SecurityGroupName": {
                            "type": "string"
                        },
                        "SecurityGroupId": {
                            "type": "string"
                        },
                        "SecurityGroupType": {
                            "type": "string"
                        },
                        "SecurityGroupEntrySet": {
                            "type": "array",
                            "items": {
                                "type": "object",
                                "properties": {
                                    "Description": {
                                        "type": "string"
                                    },
                                    "SecurityGroupEntryId": {
                                        "type": "string"
                                    },
                                    "CidrBlock": {
                                        "type": "string"
                                    },
                                    "Direction": {
                                        "type": "string"
                                    },
                                    "Protocol": {
                                        "type": "string"
                                    },
                                    "IcmpType": {
                                        "type": "integer"
                                    },
                                    "IcmpCode": {
                                        "type": "integer"
                                    },
                                    "PortRangeFrom": {
                                        "type": "integer"
                                    },
                                    "PortRangeTo": {
                                        "type": "integer"
                                    }
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### DeleteSecurityGroup

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DeleteSecurityGroup_query = new JObject();

            

        HttpClientResponse DeleteSecurityGroup_res = client.DeleteSecurityGroup(_DeleteSecurityGroup_query);
        JObject DeleteSecurityGroup_data = DeleteSecurityGroup_res.data;
        IRestResponse DeleteSecurityGroup_response = DeleteSecurityGroup_res.response;
        Console.WriteLine(DeleteSecurityGroup_data);
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
                        "DeleteSecurityGroup"
                    ],
                    "default": "DeleteSecurityGroup"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "NetworkAclId": {
                    "type": "string"
                },
                "NetworkAclEntryId": {
                    "type": "string"
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
            "Action": "DeleteSecurityGroup"
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
        //application/xml
        {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### ModifySecurityGroup

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _ModifySecurityGroup_query = new JObject();

            

        HttpClientResponse ModifySecurityGroup_res = client.ModifySecurityGroup(_ModifySecurityGroup_query);
        JObject ModifySecurityGroup_data = ModifySecurityGroup_res.data;
        IRestResponse ModifySecurityGroup_response = ModifySecurityGroup_res.response;
        Console.WriteLine(ModifySecurityGroup_data);
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
                        "ModifySecurityGroup"
                    ],
                    "default": "ModifySecurityGroup"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "SecurityGroupId": {
                    "type": "string"
                },
                "SecurityGroupName": {
                    "type": "string"
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
            "Action": "ModifySecurityGroup"
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
        //application/xml
        {
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "SecurityGroup": {
                    "type": "object",
                    "properties": {
                        "CreateTime": {
                            "type": "string"
                        },
                        "VpcId": {
                            "type": "string"
                        },
                        "SecurityGroupName": {
                            "type": "string"
                        },
                        "SecurityGroupId": {
                            "type": "string"
                        },
                        "SecurityGroupType": {
                            "type": "string"
                        },
                        "SecurityGroupEntrySet": {
                            "type": "array",
                            "items": {
                                "type": "object",
                                "properties": {
                                    "Description": {
                                        "type": "string"
                                    },
                                    "SecurityGroupEntryId": {
                                        "type": "string"
                                    },
                                    "CidrBlock": {
                                        "type": "string"
                                    },
                                    "Direction": {
                                        "type": "string"
                                    },
                                    "Protocol": {
                                        "type": "string"
                                    },
                                    "IcmpType": {
                                        "type": "integer"
                                    },
                                    "IcmpCode": {
                                        "type": "integer"
                                    },
                                    "PortRangeFrom": {
                                        "type": "integer"
                                    },
                                    "PortRangeTo": {
                                        "type": "integer"
                                    }
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### AuthorizeSecurityGroupEntry

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _AuthorizeSecurityGroupEntry_query = new JObject();

            

        HttpClientResponse AuthorizeSecurityGroupEntry_res = client.AuthorizeSecurityGroupEntry(_AuthorizeSecurityGroupEntry_query);
        JObject AuthorizeSecurityGroupEntry_data = AuthorizeSecurityGroupEntry_res.data;
        IRestResponse AuthorizeSecurityGroupEntry_response = AuthorizeSecurityGroupEntry_res.response;
        Console.WriteLine(AuthorizeSecurityGroupEntry_data);
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
                        "AuthorizeSecurityGroupEntry"
                    ],
                    "default": "AuthorizeSecurityGroupEntry"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "SecurityGroupId": {
                    "type": "string"
                },
                "CidrBlock": {
                    "type": "string"
                },
                "Description": {
                    "type": "string"
                },
                "Direction": {
                    "type": "string"
                },
                "Protocol": {
                    "type": "string"
                },
                "IcmpType": {
                    "type": "integer"
                },
                "IcmpCode": {
                    "type": "integer"
                },
                "PortRangeFrom": {
                    "type": "integer"
                },
                "PortRangeTo": {
                    "type": "integer"
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
            "Action": "AuthorizeSecurityGroupEntry"
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
        //application/xml
        {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### RevokeSecurityGroupEntry

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _RevokeSecurityGroupEntry_query = new JObject();

            

        HttpClientResponse RevokeSecurityGroupEntry_res = client.RevokeSecurityGroupEntry(_RevokeSecurityGroupEntry_query);
        JObject RevokeSecurityGroupEntry_data = RevokeSecurityGroupEntry_res.data;
        IRestResponse RevokeSecurityGroupEntry_response = RevokeSecurityGroupEntry_res.response;
        Console.WriteLine(RevokeSecurityGroupEntry_data);
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
                        "RevokeSecurityGroupEntry"
                    ],
                    "default": "RevokeSecurityGroupEntry"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "SecurityGroupId": {
                    "type": "string"
                },
                "SecurityGroupEntryId": {
                    "type": "string"
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
            "Action": "RevokeSecurityGroupEntry"
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
        //application/xml
        {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### ModifySecurityGroupEntry

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _ModifySecurityGroupEntry_query = new JObject();

            

        HttpClientResponse ModifySecurityGroupEntry_res = client.ModifySecurityGroupEntry(_ModifySecurityGroupEntry_query);
        JObject ModifySecurityGroupEntry_data = ModifySecurityGroupEntry_res.data;
        IRestResponse ModifySecurityGroupEntry_response = ModifySecurityGroupEntry_res.response;
        Console.WriteLine(ModifySecurityGroupEntry_data);
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
                        "ModifySecurityGroupEntry"
                    ],
                    "default": "ModifySecurityGroupEntry"
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
            "Action": "ModifySecurityGroupEntry"
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



### DescribeSecurityGroups

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DescribeSecurityGroups_query = new JObject();

            

        HttpClientResponse DescribeSecurityGroups_res = client.DescribeSecurityGroups(_DescribeSecurityGroups_query);
        JObject DescribeSecurityGroups_data = DescribeSecurityGroups_res.data;
        IRestResponse DescribeSecurityGroups_response = DescribeSecurityGroups_res.response;
        Console.WriteLine(DescribeSecurityGroups_data);
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
                        "DescribeSecurityGroups"
                    ],
                    "default": "DescribeSecurityGroups"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "SecurityGroupId": {
                    "type": "string"
                },
                "Filter": {
                    "type": "string"
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
            "Action": "DescribeSecurityGroups"
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
        //application/xml
        {
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "SecurityGroupSet": {
                    "type": "array",
                    "items": {
                        "type": "object",
                        "properties": {
                            "CreateTime": {
                                "type": "string"
                            },
                            "VpcId": {
                                "type": "string"
                            },
                            "SecurityGroupName": {
                                "type": "string"
                            },
                            "SecurityGroupId": {
                                "type": "string"
                            },
                            "SecurityGroupType": {
                                "type": "string"
                            },
                            "SecurityGroupEntrySet": {
                                "type": "array",
                                "items": {
                                    "type": "object",
                                    "properties": {
                                        "Description": {
                                            "type": "string"
                                        },
                                        "SecurityGroupEntryId": {
                                            "type": "string"
                                        },
                                        "CidrBlock": {
                                            "type": "string"
                                        },
                                        "Direction": {
                                            "type": "string"
                                        },
                                        "Protocol": {
                                            "type": "string"
                                        },
                                        "IcmpType": {
                                            "type": "integer"
                                        },
                                        "IcmpCode": {
                                            "type": "integer"
                                        },
                                        "PortRangeFrom": {
                                            "type": "integer"
                                        },
                                        "PortRangeTo": {
                                            "type": "integer"
                                        }
                                    }
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### DescribeInternetGateways

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DescribeInternetGateways_query = new JObject();

            

        HttpClientResponse DescribeInternetGateways_res = client.DescribeInternetGateways(_DescribeInternetGateways_query);
        JObject DescribeInternetGateways_data = DescribeInternetGateways_res.data;
        IRestResponse DescribeInternetGateways_response = DescribeInternetGateways_res.response;
        Console.WriteLine(DescribeInternetGateways_data);
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
                        "DescribeInternetGateways"
                    ],
                    "default": "DescribeInternetGateways"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "InternetGatewayId": {
                    "type": "string"
                },
                "Filter": {
                    "type": "string"
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
            "Action": "DescribeInternetGateways"
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
        //application/xml
        {
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "InternetGatewaySet": {
                    "type": "object",
                    "properties": {
                        "CreateTime": {
                            "type": "string"
                        },
                        "VpcId": {
                            "type": "string"
                        },
                        "InternetGatewayId": {
                            "type": "string"
                        },
                        "InternetGatewayName": {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### DescribeNetworkInterfaces

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DescribeNetworkInterfaces_query = new JObject();

            

        HttpClientResponse DescribeNetworkInterfaces_res = client.DescribeNetworkInterfaces(_DescribeNetworkInterfaces_query);
        JObject DescribeNetworkInterfaces_data = DescribeNetworkInterfaces_res.data;
        IRestResponse DescribeNetworkInterfaces_response = DescribeNetworkInterfaces_res.response;
        Console.WriteLine(DescribeNetworkInterfaces_data);
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
                        "DescribeNetworkInterfaces"
                    ],
                    "default": "DescribeNetworkInterfaces"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "NetworkInterfaceId": {
                    "type": "string"
                },
                "Filter": {
                    "type": "string"
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
            "Action": "DescribeNetworkInterfaces"
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
        //application/xml
        {
            "properties": {
                "RequestId": {
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
                            "SecurityGroupSet": {
                                "type": "object",
                                "properties": {
                                    "SecurityGroupId": {
                                        "type": "string"
                                    },
                                    "SecurityGroupName": {
                                        "type": "string"
                                    }
                                }
                            },
                            "InstanceId": {
                                "type": "string"
                            },
                            "InstanceType": {
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
                    }
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //application/xml
        {}

        //------------------------------------------------

        ```



### CreateNat

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _CreateNat_query = new JObject();

            

        HttpClientResponse CreateNat_res = client.CreateNat(_CreateNat_query);
        JObject CreateNat_data = CreateNat_res.data;
        IRestResponse CreateNat_response = CreateNat_res.response;
        Console.WriteLine(CreateNat_data);
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
                        "CreateNat"
                    ],
                    "default": "CreateNat"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "VpcId": {
                    "type": "string"
                },
                "NatName": {
                    "type": "string",
                    "default": "Ksc_Nat"
                },
                "NatMode": {
                    "type": "string"
                },
                "NatType": {
                    "type": "string"
                },
                "NatIpNumber": {
                    "type": "integer",
                    "default": 1
                },
                "BandWidth": {
                    "type": "integer"
                },
                "ChargeType": {
                    "type": "string"
                },
                "PurchaseTime": {
                    "type": "integer"
                }
            }
        }
        ```
        - Default
        
        ```json
        {
            "Version": "2016-03-04",
            "NatName": "Ksc_Nat",
            "NatIpNumber": 1
        }
        ```
        - Constant
        
        ```json
        {
            "Action": "CreateNat"
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
        //application/xml
        {
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "Nat": {
                    "type": "object",
                    "properties": {
                        "CreateTime": {
                            "type": "string"
                        },
                        "VpcId": {
                            "type": "string"
                        },
                        "NatId": {
                            "type": "string"
                        },
                        "NatName": {
                            "type": "string"
                        },
                        "NatMode": {
                            "type": "string"
                        },
                        "NatType": {
                            "type": "string"
                        },
                        "NatIpSet": {
                            "type": "object",
                            "properties": {
                                "NatIp": {
                                    "type": "string"
                                }
                            }
                        },
                        "NatIpNumber": {
                            "type": "integer"
                        },
                        "BandWidth": {
                            "type": "integer"
                        },
                        "AssociateNatSet": {
                            "type": "array",
                            "items": {
                                "type": "object",
                                "properties": {
                                    "SubnetId": {
                                        "type": "string"
                                    },
                                    "NatIp": {
                                        "type": "string"
                                    }
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### DeleteNat

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DeleteNat_query = new JObject();

            

        HttpClientResponse DeleteNat_res = client.DeleteNat(_DeleteNat_query);
        JObject DeleteNat_data = DeleteNat_res.data;
        IRestResponse DeleteNat_response = DeleteNat_res.response;
        Console.WriteLine(DeleteNat_data);
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
                        "DeleteNat"
                    ],
                    "default": "DeleteNat"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "NatId": {
                    "type": "string"
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
            "Action": "DeleteNat"
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
        //application/xml
        {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### ModifyNat

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _ModifyNat_query = new JObject();

            

        HttpClientResponse ModifyNat_res = client.ModifyNat(_ModifyNat_query);
        JObject ModifyNat_data = ModifyNat_res.data;
        IRestResponse ModifyNat_response = ModifyNat_res.response;
        Console.WriteLine(ModifyNat_data);
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
                        "ModifyNat"
                    ],
                    "default": "ModifyNat"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "NatId": {
                    "type": "string"
                },
                "BandWidth": {
                    "type": "string"
                },
                "NatName": {
                    "type": "string"
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
            "Action": "ModifyNat"
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
        //application/xml
        {
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "Nat": {
                    "type": "object",
                    "properties": {
                        "CreateTime": {
                            "type": "string"
                        },
                        "VpcId": {
                            "type": "string"
                        },
                        "NatId": {
                            "type": "string"
                        },
                        "NatName": {
                            "type": "string"
                        },
                        "NatMode": {
                            "type": "string"
                        },
                        "NatType": {
                            "type": "string"
                        },
                        "NatIpSet": {
                            "type": "object",
                            "properties": {
                                "NatIp": {
                                    "type": "string"
                                }
                            }
                        },
                        "NatIpNumber": {
                            "type": "integer"
                        },
                        "BandWidth": {
                            "type": "integer"
                        },
                        "AssociateNatSet": {
                            "type": "array",
                            "items": {
                                "type": "object",
                                "properties": {
                                    "SubnetId": {
                                        "type": "string"
                                    },
                                    "NatIp": {
                                        "type": "string"
                                    }
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### DescribeNats

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DescribeNats_query = new JObject();

            

        HttpClientResponse DescribeNats_res = client.DescribeNats(_DescribeNats_query);
        JObject DescribeNats_data = DescribeNats_res.data;
        IRestResponse DescribeNats_response = DescribeNats_res.response;
        Console.WriteLine(DescribeNats_data);
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
                        "DescribeNats"
                    ],
                    "default": "DescribeNats"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "NatId": {
                    "type": "string"
                },
                "Filter": {
                    "type": "string"
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
            "Action": "DescribeNats"
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
        //application/xml
        {
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "NatSet": {
                    "type": "array",
                    "items": {
                        "type": "object",
                        "properties": {
                            "CreateTime": {
                                "type": "string"
                            },
                            "VpcId": {
                                "type": "string"
                            },
                            "NatId": {
                                "type": "string"
                            },
                            "NatName": {
                                "type": "string"
                            },
                            "NatMode": {
                                "type": "string"
                            },
                            "NatType": {
                                "type": "string"
                            },
                            "NatIpSet": {
                                "type": "object",
                                "properties": {
                                    "NatIp": {
                                        "type": "string"
                                    }
                                }
                            },
                            "NatIpNumber": {
                                "type": "integer"
                            },
                            "BandWidth": {
                                "type": "integer"
                            },
                            "AssociateNatSet": {
                                "type": "array",
                                "items": {
                                    "type": "object",
                                    "properties": {
                                        "SubnetId": {
                                            "type": "string"
                                        },
                                        "NatIp": {
                                            "type": "string"
                                        }
                                    }
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### AssociateNat

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _AssociateNat_query = new JObject();

            

        HttpClientResponse AssociateNat_res = client.AssociateNat(_AssociateNat_query);
        JObject AssociateNat_data = AssociateNat_res.data;
        IRestResponse AssociateNat_response = AssociateNat_res.response;
        Console.WriteLine(AssociateNat_data);
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
                        "AssociateNat"
                    ],
                    "default": "AssociateNat"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "NatId": {
                    "type": "string"
                },
                "SubnetId": {
                    "type": "string"
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
            "Action": "AssociateNat"
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
        //application/xml
        {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### DisassociateNat

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DisassociateNat_query = new JObject();

            

        HttpClientResponse DisassociateNat_res = client.DisassociateNat(_DisassociateNat_query);
        JObject DisassociateNat_data = DisassociateNat_res.data;
        IRestResponse DisassociateNat_response = DisassociateNat_res.response;
        Console.WriteLine(DisassociateNat_data);
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
                        "DisassociateNat"
                    ],
                    "default": "DisassociateNat"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "NatId": {
                    "type": "string"
                },
                "SubnetId": {
                    "type": "string"
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
            "Action": "DisassociateNat"
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
        //application/xml
        {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### CreateVpcPeeringConnection

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _CreateVpcPeeringConnection_query = new JObject();

            

        HttpClientResponse CreateVpcPeeringConnection_res = client.CreateVpcPeeringConnection(_CreateVpcPeeringConnection_query);
        JObject CreateVpcPeeringConnection_data = CreateVpcPeeringConnection_res.data;
        IRestResponse CreateVpcPeeringConnection_response = CreateVpcPeeringConnection_res.response;
        Console.WriteLine(CreateVpcPeeringConnection_data);
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
                        "CreateVpcPeeringConnection"
                    ],
                    "default": "CreateVpcPeeringConnection"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "VpcId": {
                    "type": "string"
                },
                "Region": {
                    "type": "string"
                },
                "PeerAccountId": {
                    "type": "string"
                },
                "PeerRegion": {
                    "type": "string"
                },
                "PeerVpcId": {
                    "type": "string"
                },
                "PeeringName": {
                    "type": "string"
                },
                "BandWidth": {
                    "type": "integer"
                },
                "ChargeType": {
                    "type": "string"
                },
                "ProjectId": {
                    "type": "string"
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
            "Action": "CreateVpcPeeringConnection"
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
        //application/xml
        {
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "VpcPeeringConnection": {
                    "type": "object",
                    "properties": {
                        "CreateTime": {
                            "type": "string"
                        },
                        "RequesterVpcInfo": {
                            "type": "object",
                            "properties": {
                                "AccountId": {
                                    "type": "string"
                                },
                                "Region": {
                                    "type": "string"
                                },
                                "VpcId": {
                                    "type": "string"
                                },
                                "VpcName": {
                                    "type": "string"
                                },
                                "CidrBlock": {
                                    "type": "string"
                                },
                                "VpcPeeringConnectionId": {
                                    "type": "string"
                                }
                            }
                        },
                        "AccepterVpcInfo": {
                            "type": "object",
                            "properties": {
                                "AccountId": {
                                    "type": "string"
                                },
                                "Region": {
                                    "type": "string"
                                },
                                "VpcId": {
                                    "type": "string"
                                },
                                "VpcName": {
                                    "type": "string"
                                },
                                "CidrBlock": {
                                    "type": "string"
                                },
                                "VpcPeeringConnectionId": {
                                    "type": "string"
                                }
                            }
                        },
                        "VpcPeeringConnectionType": {
                            "type": "string"
                        },
                        "PeeringName": {
                            "type": "string"
                        },
                        "State": {
                            "type": "string"
                        },
                        "BandWidth": {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### AcceptVpcPeeringConnection

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _AcceptVpcPeeringConnection_query = new JObject();

            

        HttpClientResponse AcceptVpcPeeringConnection_res = client.AcceptVpcPeeringConnection(_AcceptVpcPeeringConnection_query);
        JObject AcceptVpcPeeringConnection_data = AcceptVpcPeeringConnection_res.data;
        IRestResponse AcceptVpcPeeringConnection_response = AcceptVpcPeeringConnection_res.response;
        Console.WriteLine(AcceptVpcPeeringConnection_data);
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
                        "AcceptVpcPeeringConnection"
                    ],
                    "default": "AcceptVpcPeeringConnection"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "VpcPeeringConnectionId": {
                    "type": "string"
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
            "Action": "AcceptVpcPeeringConnection"
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
        //application/xml
        {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### RejectVpcPeeringConnection

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _RejectVpcPeeringConnection_query = new JObject();

            

        HttpClientResponse RejectVpcPeeringConnection_res = client.RejectVpcPeeringConnection(_RejectVpcPeeringConnection_query);
        JObject RejectVpcPeeringConnection_data = RejectVpcPeeringConnection_res.data;
        IRestResponse RejectVpcPeeringConnection_response = RejectVpcPeeringConnection_res.response;
        Console.WriteLine(RejectVpcPeeringConnection_data);
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
                        "RejectVpcPeeringConnection"
                    ],
                    "default": "RejectVpcPeeringConnection"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "VpcPeeringConnectionId": {
                    "type": "string"
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
            "Action": "RejectVpcPeeringConnection"
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
        //application/xml
        {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### DeleteVpcPeeringConnection

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DeleteVpcPeeringConnection_query = new JObject();

            

        HttpClientResponse DeleteVpcPeeringConnection_res = client.DeleteVpcPeeringConnection(_DeleteVpcPeeringConnection_query);
        JObject DeleteVpcPeeringConnection_data = DeleteVpcPeeringConnection_res.data;
        IRestResponse DeleteVpcPeeringConnection_response = DeleteVpcPeeringConnection_res.response;
        Console.WriteLine(DeleteVpcPeeringConnection_data);
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
                        "DeleteVpcPeeringConnection"
                    ],
                    "default": "DeleteVpcPeeringConnection"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "VpcPeeringConnectionId": {
                    "type": "string"
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
            "Action": "DeleteVpcPeeringConnection"
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
        //application/xml
        {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### ModifyVpcPeeringConnection

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _ModifyVpcPeeringConnection_query = new JObject();

            

        HttpClientResponse ModifyVpcPeeringConnection_res = client.ModifyVpcPeeringConnection(_ModifyVpcPeeringConnection_query);
        JObject ModifyVpcPeeringConnection_data = ModifyVpcPeeringConnection_res.data;
        IRestResponse ModifyVpcPeeringConnection_response = ModifyVpcPeeringConnection_res.response;
        Console.WriteLine(ModifyVpcPeeringConnection_data);
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
                        "ModifyVpcPeeringConnection"
                    ],
                    "default": "ModifyVpcPeeringConnection"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "VpcPeeringConnectionId": {
                    "type": "string"
                },
                "PeeringName": {
                    "type": "string"
                },
                "BandWidth": {
                    "type": "integer"
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
            "Action": "ModifyVpcPeeringConnection"
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
        //application/xml
        {
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "VpcPeeringConnection": {
                    "type": "object",
                    "properties": {
                        "CreateTime": {
                            "type": "string"
                        },
                        "RequesterVpcInfo": {
                            "type": "object",
                            "properties": {
                                "AccountId": {
                                    "type": "string"
                                },
                                "Region": {
                                    "type": "string"
                                },
                                "VpcId": {
                                    "type": "string"
                                },
                                "VpcName": {
                                    "type": "string"
                                },
                                "CidrBlock": {
                                    "type": "string"
                                },
                                "VpcPeeringConnectionId": {
                                    "type": "string"
                                }
                            }
                        },
                        "AccepterVpcInfo": {
                            "type": "object",
                            "properties": {
                                "AccountId": {
                                    "type": "string"
                                },
                                "Region": {
                                    "type": "string"
                                },
                                "VpcId": {
                                    "type": "string"
                                },
                                "VpcName": {
                                    "type": "string"
                                },
                                "CidrBlock": {
                                    "type": "string"
                                },
                                "VpcPeeringConnectionId": {
                                    "type": "string"
                                }
                            }
                        },
                        "VpcPeeringConnectionType": {
                            "type": "string"
                        },
                        "PeeringName": {
                            "type": "string"
                        },
                        "State": {
                            "type": "string"
                        },
                        "BandWidth": {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### DescribeVpcPeeringConnections

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DescribeVpcPeeringConnections_query = new JObject();

            

        HttpClientResponse DescribeVpcPeeringConnections_res = client.DescribeVpcPeeringConnections(_DescribeVpcPeeringConnections_query);
        JObject DescribeVpcPeeringConnections_data = DescribeVpcPeeringConnections_res.data;
        IRestResponse DescribeVpcPeeringConnections_response = DescribeVpcPeeringConnections_res.response;
        Console.WriteLine(DescribeVpcPeeringConnections_data);
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
                        "DescribeVpcPeeringConnections"
                    ],
                    "default": "DescribeVpcPeeringConnections"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "VpcPeeringConnectionId": {
                    "type": "string"
                },
                "Filter": {
                    "type": "string"
                },
                "MaxResults": {
                    "type": "integer"
                },
                "NextToken": {
                    "type": "string"
                },
                "ProjectId": {
                    "type": "string"
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
            "Action": "DescribeVpcPeeringConnections"
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
        //application/xml
        {
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "VpcPeeringConnectionSet": {
                    "type": "array",
                    "items": {
                        "type": "object",
                        "properties": {
                            "CreateTime": {
                                "type": "string"
                            },
                            "RequesterVpcInfo": {
                                "type": "object",
                                "properties": {
                                    "AccountId": {
                                        "type": "string"
                                    },
                                    "Region": {
                                        "type": "string"
                                    },
                                    "VpcId": {
                                        "type": "string"
                                    },
                                    "VpcName": {
                                        "type": "string"
                                    },
                                    "CidrBlock": {
                                        "type": "string"
                                    },
                                    "VpcPeeringConnectionId": {
                                        "type": "string"
                                    }
                                }
                            },
                            "AccepterVpcInfo": {
                                "type": "object",
                                "properties": {
                                    "AccountId": {
                                        "type": "string"
                                    },
                                    "Region": {
                                        "type": "string"
                                    },
                                    "VpcId": {
                                        "type": "string"
                                    },
                                    "VpcName": {
                                        "type": "string"
                                    },
                                    "CidrBlock": {
                                        "type": "string"
                                    },
                                    "VpcPeeringConnectionId": {
                                        "type": "string"
                                    }
                                }
                            },
                            "VpcPeeringConnectionType": {
                                "type": "string"
                            },
                            "PeeringName": {
                                "type": "string"
                            },
                            "State": {
                                "type": "string"
                            },
                            "BandWidth": {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### AddNatIp

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _AddNatIp_query = new JObject();

            

        HttpClientResponse AddNatIp_res = client.AddNatIp(_AddNatIp_query);
        JObject AddNatIp_data = AddNatIp_res.data;
        IRestResponse AddNatIp_response = AddNatIp_res.response;
        Console.WriteLine(AddNatIp_data);
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
                        "AddNatIp"
                    ],
                    "default": "AddNatIp"
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
            "Action": "AddNatIp"
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



### DeleteNatIp

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DeleteNatIp_query = new JObject();

            

        HttpClientResponse DeleteNatIp_res = client.DeleteNatIp(_DeleteNatIp_query);
        JObject DeleteNatIp_data = DeleteNatIp_res.data;
        IRestResponse DeleteNatIp_response = DeleteNatIp_res.response;
        Console.WriteLine(DeleteNatIp_data);
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
                        "DeleteNatIp"
                    ],
                    "default": "DeleteNatIp"
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
            "Action": "DeleteNatIp"
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



### AssociateDirectConnectGateway

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _AssociateDirectConnectGateway_query = new JObject();

            

        HttpClientResponse AssociateDirectConnectGateway_res = client.AssociateDirectConnectGateway(_AssociateDirectConnectGateway_query);
        JObject AssociateDirectConnectGateway_data = AssociateDirectConnectGateway_res.data;
        IRestResponse AssociateDirectConnectGateway_response = AssociateDirectConnectGateway_res.response;
        Console.WriteLine(AssociateDirectConnectGateway_data);
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
                        "AssociateDirectConnectGateway"
                    ],
                    "default": "AssociateDirectConnectGateway"
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
            "Action": "AssociateDirectConnectGateway"
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



### DisassociateDirectConnectGateway

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DisassociateDirectConnectGateway_query = new JObject();

            

        HttpClientResponse DisassociateDirectConnectGateway_res = client.DisassociateDirectConnectGateway(_DisassociateDirectConnectGateway_query);
        JObject DisassociateDirectConnectGateway_data = DisassociateDirectConnectGateway_res.data;
        IRestResponse DisassociateDirectConnectGateway_response = DisassociateDirectConnectGateway_res.response;
        Console.WriteLine(DisassociateDirectConnectGateway_data);
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
                        "DisassociateDirectConnectGateway"
                    ],
                    "default": "DisassociateDirectConnectGateway"
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
            "Action": "DisassociateDirectConnectGateway"
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



### AssociateVpnGateway

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _AssociateVpnGateway_query = new JObject();

            

        HttpClientResponse AssociateVpnGateway_res = client.AssociateVpnGateway(_AssociateVpnGateway_query);
        JObject AssociateVpnGateway_data = AssociateVpnGateway_res.data;
        IRestResponse AssociateVpnGateway_response = AssociateVpnGateway_res.response;
        Console.WriteLine(AssociateVpnGateway_data);
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
                        "AssociateVpnGateway"
                    ],
                    "default": "AssociateVpnGateway"
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
            "Action": "AssociateVpnGateway"
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



### DisassociateVpnGateway

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DisassociateVpnGateway_query = new JObject();

            

        HttpClientResponse DisassociateVpnGateway_res = client.DisassociateVpnGateway(_DisassociateVpnGateway_query);
        JObject DisassociateVpnGateway_data = DisassociateVpnGateway_res.data;
        IRestResponse DisassociateVpnGateway_response = DisassociateVpnGateway_res.response;
        Console.WriteLine(DisassociateVpnGateway_data);
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
                        "DisassociateVpnGateway"
                    ],
                    "default": "DisassociateVpnGateway"
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
            "Action": "DisassociateVpnGateway"
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



### DescribeAvailabilityZones

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DescribeAvailabilityZones_query = new JObject();

            

        HttpClientResponse DescribeAvailabilityZones_res = client.DescribeAvailabilityZones(_DescribeAvailabilityZones_query);
        JObject DescribeAvailabilityZones_data = DescribeAvailabilityZones_res.data;
        IRestResponse DescribeAvailabilityZones_response = DescribeAvailabilityZones_res.response;
        Console.WriteLine(DescribeAvailabilityZones_data);
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
                        "DescribeAvailabilityZones"
                    ],
                    "default": "DescribeAvailabilityZones"
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
            "Action": "DescribeAvailabilityZones"
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



### DescribeDirectConnects

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DescribeDirectConnects_query = new JObject();

            

        HttpClientResponse DescribeDirectConnects_res = client.DescribeDirectConnects(_DescribeDirectConnects_query);
        JObject DescribeDirectConnects_data = DescribeDirectConnects_res.data;
        IRestResponse DescribeDirectConnects_response = DescribeDirectConnects_res.response;
        Console.WriteLine(DescribeDirectConnects_data);
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
                        "DescribeDirectConnects"
                    ],
                    "default": "DescribeDirectConnects"
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
            "Action": "DescribeDirectConnects"
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



### CreateDirectConnectInterface

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _CreateDirectConnectInterface_query = new JObject();

            

        HttpClientResponse CreateDirectConnectInterface_res = client.CreateDirectConnectInterface(_CreateDirectConnectInterface_query);
        JObject CreateDirectConnectInterface_data = CreateDirectConnectInterface_res.data;
        IRestResponse CreateDirectConnectInterface_response = CreateDirectConnectInterface_res.response;
        Console.WriteLine(CreateDirectConnectInterface_data);
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
                        "CreateDirectConnectInterface"
                    ],
                    "default": "CreateDirectConnectInterface"
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
            "Action": "CreateDirectConnectInterface"
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



### ModifyDirectConnectInterface

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _ModifyDirectConnectInterface_query = new JObject();

            

        HttpClientResponse ModifyDirectConnectInterface_res = client.ModifyDirectConnectInterface(_ModifyDirectConnectInterface_query);
        JObject ModifyDirectConnectInterface_data = ModifyDirectConnectInterface_res.data;
        IRestResponse ModifyDirectConnectInterface_response = ModifyDirectConnectInterface_res.response;
        Console.WriteLine(ModifyDirectConnectInterface_data);
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
                        "ModifyDirectConnectInterface"
                    ],
                    "default": "ModifyDirectConnectInterface"
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
            "Action": "ModifyDirectConnectInterface"
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



### DeleteDirectConnectInterface

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DeleteDirectConnectInterface_query = new JObject();

            

        HttpClientResponse DeleteDirectConnectInterface_res = client.DeleteDirectConnectInterface(_DeleteDirectConnectInterface_query);
        JObject DeleteDirectConnectInterface_data = DeleteDirectConnectInterface_res.data;
        IRestResponse DeleteDirectConnectInterface_response = DeleteDirectConnectInterface_res.response;
        Console.WriteLine(DeleteDirectConnectInterface_data);
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
                        "DeleteDirectConnectInterface"
                    ],
                    "default": "DeleteDirectConnectInterface"
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
            "Action": "DeleteDirectConnectInterface"
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



### DescribeDirectConnectInterfaces

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DescribeDirectConnectInterfaces_query = new JObject();

            

        HttpClientResponse DescribeDirectConnectInterfaces_res = client.DescribeDirectConnectInterfaces(_DescribeDirectConnectInterfaces_query);
        JObject DescribeDirectConnectInterfaces_data = DescribeDirectConnectInterfaces_res.data;
        IRestResponse DescribeDirectConnectInterfaces_response = DescribeDirectConnectInterfaces_res.response;
        Console.WriteLine(DescribeDirectConnectInterfaces_data);
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
                        "DescribeDirectConnectInterfaces"
                    ],
                    "default": "DescribeDirectConnectInterfaces"
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
            "Action": "DescribeDirectConnectInterfaces"
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



### CreateDirectConnectGateway

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _CreateDirectConnectGateway_query = new JObject();

            

        HttpClientResponse CreateDirectConnectGateway_res = client.CreateDirectConnectGateway(_CreateDirectConnectGateway_query);
        JObject CreateDirectConnectGateway_data = CreateDirectConnectGateway_res.data;
        IRestResponse CreateDirectConnectGateway_response = CreateDirectConnectGateway_res.response;
        Console.WriteLine(CreateDirectConnectGateway_data);
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
                        "CreateDirectConnectGateway"
                    ],
                    "default": "CreateDirectConnectGateway"
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
            "Action": "CreateDirectConnectGateway"
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



### ModifyDirectConnectGateway

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _ModifyDirectConnectGateway_query = new JObject();

            

        HttpClientResponse ModifyDirectConnectGateway_res = client.ModifyDirectConnectGateway(_ModifyDirectConnectGateway_query);
        JObject ModifyDirectConnectGateway_data = ModifyDirectConnectGateway_res.data;
        IRestResponse ModifyDirectConnectGateway_response = ModifyDirectConnectGateway_res.response;
        Console.WriteLine(ModifyDirectConnectGateway_data);
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
                        "ModifyDirectConnectGateway"
                    ],
                    "default": "ModifyDirectConnectGateway"
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
            "Action": "ModifyDirectConnectGateway"
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



### DeleteDirectConnectGateway

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DeleteDirectConnectGateway_query = new JObject();

            

        HttpClientResponse DeleteDirectConnectGateway_res = client.DeleteDirectConnectGateway(_DeleteDirectConnectGateway_query);
        JObject DeleteDirectConnectGateway_data = DeleteDirectConnectGateway_res.data;
        IRestResponse DeleteDirectConnectGateway_response = DeleteDirectConnectGateway_res.response;
        Console.WriteLine(DeleteDirectConnectGateway_data);
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
                        "DeleteDirectConnectGateway"
                    ],
                    "default": "DeleteDirectConnectGateway"
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
            "Action": "DeleteDirectConnectGateway"
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



### DescribeDirectConnectGateways

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DescribeDirectConnectGateways_query = new JObject();

            

        HttpClientResponse DescribeDirectConnectGateways_res = client.DescribeDirectConnectGateways(_DescribeDirectConnectGateways_query);
        JObject DescribeDirectConnectGateways_data = DescribeDirectConnectGateways_res.data;
        IRestResponse DescribeDirectConnectGateways_response = DescribeDirectConnectGateways_res.response;
        Console.WriteLine(DescribeDirectConnectGateways_data);
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
                        "DescribeDirectConnectGateways"
                    ],
                    "default": "DescribeDirectConnectGateways"
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
            "Action": "DescribeDirectConnectGateways"
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



### AttachDirectConnectGateway

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _AttachDirectConnectGateway_query = new JObject();

            

        HttpClientResponse AttachDirectConnectGateway_res = client.AttachDirectConnectGateway(_AttachDirectConnectGateway_query);
        JObject AttachDirectConnectGateway_data = AttachDirectConnectGateway_res.data;
        IRestResponse AttachDirectConnectGateway_response = AttachDirectConnectGateway_res.response;
        Console.WriteLine(AttachDirectConnectGateway_data);
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
                        "AttachDirectConnectGateway"
                    ],
                    "default": "AttachDirectConnectGateway"
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
            "Action": "AttachDirectConnectGateway"
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



### DetachDirectConnectGateway

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DetachDirectConnectGateway_query = new JObject();

            

        HttpClientResponse DetachDirectConnectGateway_res = client.DetachDirectConnectGateway(_DetachDirectConnectGateway_query);
        JObject DetachDirectConnectGateway_data = DetachDirectConnectGateway_res.data;
        IRestResponse DetachDirectConnectGateway_response = DetachDirectConnectGateway_res.response;
        Console.WriteLine(DetachDirectConnectGateway_data);
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
                        "DetachDirectConnectGateway"
                    ],
                    "default": "DetachDirectConnectGateway"
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
            "Action": "DetachDirectConnectGateway"
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



### CreateVpnGateway

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _CreateVpnGateway_query = new JObject();

            

        HttpClientResponse CreateVpnGateway_res = client.CreateVpnGateway(_CreateVpnGateway_query);
        JObject CreateVpnGateway_data = CreateVpnGateway_res.data;
        IRestResponse CreateVpnGateway_response = CreateVpnGateway_res.response;
        Console.WriteLine(CreateVpnGateway_data);
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
                        "CreateVpnGateway"
                    ],
                    "default": "CreateVpnGateway"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "VpnGatewayName": {
                    "type": "string",
                    "default": "Ksc_Vpn"
                },
                "BandWidth": {
                    "type": "integer"
                },
                "VpcId": {
                    "type": "string"
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
        }
        ```
        - Default
        
        ```json
        {
            "Version": "2016-03-04",
            "VpnGatewayName": "Ksc_Vpn"
        }
        ```
        - Constant
        
        ```json
        {
            "Action": "CreateVpnGateway"
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
        //application/xml
        {
            "properties": {
                "RequestId": {
                    "type": "string"
                },
                "VpnGateway": {
                    "type": "object",
                    "properties": {
                        "CreateTime": {
                            "type": "string"
                        },
                        "VpnGatewayId": {
                            "type": "string"
                        },
                        "VpnGatewayName": {
                            "type": "string",
                            "default": "Ksc_Vpn_Gw"
                        },
                        "BandWidth": {
                            "type": "integer"
                        },
                        "VpcId": {
                            "type": "string"
                        },
                        "GatewayAddress": {
                            "type": "string"
                        },
                        "HaGatewayAddress": {
                            "type": "string"
                        },
                        "RemoteCidrSet": {
                            "type": "array",
                            "items": {
                                "type": "object",
                                "properties": {
                                    "CidrBlock": {
                                        "type": "string"
                                    }
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### ModifyVpnGateway

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _ModifyVpnGateway_query = new JObject();

            

        HttpClientResponse ModifyVpnGateway_res = client.ModifyVpnGateway(_ModifyVpnGateway_query);
        JObject ModifyVpnGateway_data = ModifyVpnGateway_res.data;
        IRestResponse ModifyVpnGateway_response = ModifyVpnGateway_res.response;
        Console.WriteLine(ModifyVpnGateway_data);
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
                        "ModifyVpnGateway"
                    ],
                    "default": "ModifyVpnGateway"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "VpnGatewayId": {
                    "type": "string"
                },
                "VpnGatewayName": {
                    "type": "string"
                },
                "BandWidth": {
                    "type": "integer"
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
            "Action": "ModifyVpnGateway"
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
        //application/xml
        {
            "properties": {
                "Return": {
                    "type": "boolean"
                },
                "RequestId": {
                    "type": "string"
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //application/xml
        {}

        //------------------------------------------------

        ```



### DeleteVpnGateway

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DeleteVpnGateway_query = new JObject();

            

        HttpClientResponse DeleteVpnGateway_res = client.DeleteVpnGateway(_DeleteVpnGateway_query);
        JObject DeleteVpnGateway_data = DeleteVpnGateway_res.data;
        IRestResponse DeleteVpnGateway_response = DeleteVpnGateway_res.response;
        Console.WriteLine(DeleteVpnGateway_data);
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
                        "DeleteVpnGateway"
                    ],
                    "default": "DeleteVpnGateway"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "VpnGatewayId": {
                    "type": "string"
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
            "Action": "DeleteVpnGateway"
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
        //application/xml
        {
            "properties": {
                "Return": {
                    "type": "boolean"
                },
                "RequestId": {
                    "type": "string"
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //application/xml
        {}

        //------------------------------------------------

        ```



### DescribeVpnGateways

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DescribeVpnGateways_query = new JObject();

            

        HttpClientResponse DescribeVpnGateways_res = client.DescribeVpnGateways(_DescribeVpnGateways_query);
        JObject DescribeVpnGateways_data = DescribeVpnGateways_res.data;
        IRestResponse DescribeVpnGateways_response = DescribeVpnGateways_res.response;
        Console.WriteLine(DescribeVpnGateways_data);
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
                        "DescribeVpnGateways"
                    ],
                    "default": "DescribeVpnGateways"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "VpnGatewayId": {
                    "type": "string"
                },
                "Filter": {
                    "type": "string"
                },
                "ProjectId": {
                    "type": "string"
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
            "Action": "DescribeVpnGateways"
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
        //application/xml
        {
            "properties": {
                "Return": {
                    "type": "boolean"
                },
                "VpnGatewaySet": {
                    "type": "array",
                    "items": {
                        "type": "object",
                        "properties": {
                            "CreateTime": {
                                "type": "string"
                            },
                            "VpnGatewayId": {
                                "type": "string"
                            },
                            "VpnGatewayName": {
                                "type": "string",
                                "default": "Ksc_Vpn_Gw"
                            },
                            "BandWidth": {
                                "type": "integer"
                            },
                            "VpcId": {
                                "type": "string"
                            },
                            "GatewayAddress": {
                                "type": "string"
                            },
                            "HaGatewayAddress": {
                                "type": "string"
                            },
                            "RemoteCidrSet": {
                                "type": "array",
                                "items": {
                                    "type": "object",
                                    "properties": {
                                        "CidrBlock": {
                                            "type": "string"
                                        }
                                    }
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### CreateVpnTunnel

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _CreateVpnTunnel_query = new JObject();

            
        JObject _CreateVpnTunnel_body = new JObject();

            

        HttpClientResponse CreateVpnTunnel_res = client.CreateVpnTunnel(_CreateVpnTunnel_query,_CreateVpnTunnel_body);
        JObject CreateVpnTunnel_data = CreateVpnTunnel_res.data;
        IRestResponse CreateVpnTunnel_response = CreateVpnTunnel_res.response;
        Console.WriteLine(CreateVpnTunnel_data);
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
                        "CreateVpnTunnel"
                    ],
                    "default": "CreateVpnTunnel"
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
            "Action": "CreateVpnTunnel"
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
                "VpnTunnelName": {
                    "type": "string",
                    "default": "Ksc_vpn_tunnel"
                },
                "Type": {
                    "type": "string"
                },
                "VpnGreIp": {
                    "type": "string"
                },
                "HaVpnGreIp": {
                    "type": "string"
                },
                "CustomerGreIp": {
                    "type": "string"
                },
                "HaCustomerGreIp": {
                    "type": "string"
                },
                "CustomerGatewayId": {
                    "type": "string"
                },
                "PreSharedKey": {
                    "type": "string"
                },
                "IkeAuthenAlgorithm": {
                    "type": "string",
                    "default": "md5"
                },
                "IkeDHGroup": {
                    "type": "integer",
                    "default": 1
                },
                "IkeEncryAlgorithm": {
                    "type": "string",
                    "default": "aes"
                },
                "IpsecEncryAlgorithm": {
                    "type": "string",
                    "default": "esp-aes"
                },
                "IpsecAuthenAlgorithm": {
                    "type": "string",
                    "default": "esp-sha-hmac"
                },
                "IpsecLifetimeTraffic": {
                    "type": "integer"
                },
                "IpsecLifetimeSecond": {
                    "type": "integer"
                }
            }
        }
        ```
        - Default
        
        ```json
        {
            "VpnTunnelName": "Ksc_vpn_tunnel",
            "IkeAuthenAlgorithm": "md5",
            "IkeDHGroup": 1,
            "IkeEncryAlgorithm": "aes",
            "IpsecEncryAlgorithm": "esp-aes",
            "IpsecAuthenAlgorithm": "esp-sha-hmac"
        }
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
        //application/xml
        {
            "properties": {
                "Return": {
                    "type": "boolean"
                },
                "VpnTunnel": {
                    "type": "object",
                    "properties": {
                        "CreateTime": {
                            "type": "string"
                        },
                        "State": {
                            "type": "string"
                        },
                        "Type": {
                            "type": "string"
                        },
                        "VpnTunnelId": {
                            "type": "string"
                        },
                        "VpnGreIp": {
                            "type": "string"
                        },
                        "CustomerGreIp": {
                            "type": "string"
                        },
                        "HaVpnGreIp": {
                            "type": "string"
                        },
                        "HaCustomerGreIp": {
                            "type": "string"
                        },
                        "VpnGatewayId": {
                            "type": "string"
                        },
                        "CustomerGatewayId": {
                            "type": "string"
                        },
                        "VpnTunnelName": {
                            "type": "string",
                            "default": "Ksc_vpn_tunnel"
                        },
                        "PreSharedKey": {
                            "type": "string"
                        },
                        "IkeAuthenAlgorithm": {
                            "type": "string",
                            "default": "md5"
                        },
                        "IkeDhGroup": {
                            "type": "string",
                            "default": 1
                        },
                        "IkeEncryAlgorithm": {
                            "type": "string",
                            "default": "aes"
                        },
                        "IpsecEncryAlgorithm": {
                            "type": "string",
                            "default": "esp-aes"
                        },
                        "IpsecAuthenAlgorithm": {
                            "type": "string",
                            "default": "esp-sha-hmac"
                        },
                        "IpsecLifetimeTraffic": {
                            "type": "integer"
                        },
                        "IpsecLifetimeSecond": {
                            "type": "integer"
                        },
                        "ExtraCidrSet": {
                            "type": "array",
                            "items": {
                                "type": "object",
                                "properties": {
                                    "CidrBlock": {
                                        "type": "string"
                                    }
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### ModifyVpnTunnel

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _ModifyVpnTunnel_query = new JObject();

            

        HttpClientResponse ModifyVpnTunnel_res = client.ModifyVpnTunnel(_ModifyVpnTunnel_query);
        JObject ModifyVpnTunnel_data = ModifyVpnTunnel_res.data;
        IRestResponse ModifyVpnTunnel_response = ModifyVpnTunnel_res.response;
        Console.WriteLine(ModifyVpnTunnel_data);
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
                        "ModifyVpnTunnel"
                    ],
                    "default": "ModifyVpnTunnel"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "VpnTunnelId": {
                    "type": "string"
                },
                "VpnTunnelName": {
                    "type": "string"
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
            "Action": "ModifyVpnTunnel"
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
        //application/xml
        {
            "properties": {
                "Return": {
                    "type": "boolean"
                },
                "RequestId": {
                    "type": "string"
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //application/xml
        {}

        //------------------------------------------------

        ```



### DeleteVpnTunnel

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DeleteVpnTunnel_query = new JObject();

            

        HttpClientResponse DeleteVpnTunnel_res = client.DeleteVpnTunnel(_DeleteVpnTunnel_query);
        JObject DeleteVpnTunnel_data = DeleteVpnTunnel_res.data;
        IRestResponse DeleteVpnTunnel_response = DeleteVpnTunnel_res.response;
        Console.WriteLine(DeleteVpnTunnel_data);
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
                        "DeleteVpnTunnel"
                    ],
                    "default": "DeleteVpnTunnel"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "VpnTunnelId": {
                    "type": "string"
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
            "Action": "DeleteVpnTunnel"
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
        //application/xml
        {
            "properties": {
                "Return": {
                    "type": "boolean"
                },
                "RequestId": {
                    "type": "string"
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //application/xml
        {}

        //------------------------------------------------

        ```



### DescribeVpnTunnels

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DescribeVpnTunnels_query = new JObject();

            

        HttpClientResponse DescribeVpnTunnels_res = client.DescribeVpnTunnels(_DescribeVpnTunnels_query);
        JObject DescribeVpnTunnels_data = DescribeVpnTunnels_res.data;
        IRestResponse DescribeVpnTunnels_response = DescribeVpnTunnels_res.response;
        Console.WriteLine(DescribeVpnTunnels_data);
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
                        "DescribeVpnTunnels"
                    ],
                    "default": "DescribeVpnTunnels"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "VpnTunnelId": {
                    "type": "string"
                },
                "Filter": {
                    "type": "string"
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
            "Action": "DescribeVpnTunnels"
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
        //application/xml
        {
            "properties": {
                "Return": {
                    "type": "boolean"
                },
                "VpnTunnelSet": {
                    "type": "array",
                    "items": {
                        "type": "object",
                        "properties": {
                            "CreateTime": {
                                "type": "string"
                            },
                            "State": {
                                "type": "string"
                            },
                            "Type": {
                                "type": "string"
                            },
                            "VpnTunnelId": {
                                "type": "string"
                            },
                            "VpnGreIp": {
                                "type": "string"
                            },
                            "CustomerGreIp": {
                                "type": "string"
                            },
                            "HaVpnGreIp": {
                                "type": "string"
                            },
                            "HaCustomerGreIp": {
                                "type": "string"
                            },
                            "VpnGatewayId": {
                                "type": "string"
                            },
                            "CustomerGatewayId": {
                                "type": "string"
                            },
                            "VpnTunnelName": {
                                "type": "string",
                                "default": "Ksc_vpn_tunnel"
                            },
                            "PreSharedKey": {
                                "type": "string"
                            },
                            "IkeAuthenAlgorithm": {
                                "type": "string",
                                "default": "md5"
                            },
                            "IkeDhGroup": {
                                "type": "string",
                                "default": 1
                            },
                            "IkeEncryAlgorithm": {
                                "type": "string",
                                "default": "aes"
                            },
                            "IpsecEncryAlgorithm": {
                                "type": "string",
                                "default": "esp-aes"
                            },
                            "IpsecAuthenAlgorithm": {
                                "type": "string",
                                "default": "esp-sha-hmac"
                            },
                            "IpsecLifetimeTraffic": {
                                "type": "integer"
                            },
                            "IpsecLifetimeSecond": {
                                "type": "integer"
                            },
                            "ExtraCidrSet": {
                                "type": "array",
                                "items": {
                                    "type": "object",
                                    "properties": {
                                        "CidrBlock": {
                                            "type": "string"
                                        }
                                    }
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### CreateCustomerGateway

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _CreateCustomerGateway_query = new JObject();

            

        HttpClientResponse CreateCustomerGateway_res = client.CreateCustomerGateway(_CreateCustomerGateway_query);
        JObject CreateCustomerGateway_data = CreateCustomerGateway_res.data;
        IRestResponse CreateCustomerGateway_response = CreateCustomerGateway_res.response;
        Console.WriteLine(CreateCustomerGateway_data);
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
                        "CreateCustomerGateway"
                    ],
                    "default": "CreateCustomerGateway"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "CustomerGatewayAddress": {
                    "type": "string"
                },
                "HaCustomerGatewayAddress": {
                    "type": "string"
                },
                "CustomerGatewayName": {
                    "type": "string"
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
            "Action": "CreateCustomerGateway"
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
        //application/xml
        {
            "properties": {
                "Return": {
                    "type": "boolean"
                },
                "CustomerGateway": {
                    "type": "object",
                    "properties": {
                        "CreateTime": {
                            "type": "string"
                        },
                        "CustomerGatewayId": {
                            "type": "string"
                        },
                        "CustomerGatewayAddress": {
                            "type": "string"
                        },
                        "HaCustomerGatewayAddress": {
                            "type": "string"
                        },
                        "CustomerGatewayName": {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### ModifyCustomerGateway

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _ModifyCustomerGateway_query = new JObject();

            

        HttpClientResponse ModifyCustomerGateway_res = client.ModifyCustomerGateway(_ModifyCustomerGateway_query);
        JObject ModifyCustomerGateway_data = ModifyCustomerGateway_res.data;
        IRestResponse ModifyCustomerGateway_response = ModifyCustomerGateway_res.response;
        Console.WriteLine(ModifyCustomerGateway_data);
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
                        "ModifyCustomerGateway"
                    ],
                    "default": "ModifyCustomerGateway"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "CustomerGatewayId": {
                    "type": "string"
                },
                "CustomerGatewayName": {
                    "type": "string"
                },
                "CustomerGatewayAddress": {
                    "type": "string"
                },
                "HaCustomerGatewayAddress": {
                    "type": "string"
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
            "Action": "ModifyCustomerGateway"
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
        //application/xml
        {
            "properties": {
                "Return": {
                    "type": "boolean"
                },
                "RequestId": {
                    "type": "string"
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //application/xml
        {}

        //------------------------------------------------

        ```



### DeleteCustomerGateway

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DeleteCustomerGateway_query = new JObject();

            

        HttpClientResponse DeleteCustomerGateway_res = client.DeleteCustomerGateway(_DeleteCustomerGateway_query);
        JObject DeleteCustomerGateway_data = DeleteCustomerGateway_res.data;
        IRestResponse DeleteCustomerGateway_response = DeleteCustomerGateway_res.response;
        Console.WriteLine(DeleteCustomerGateway_data);
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
                        "DeleteCustomerGateway"
                    ],
                    "default": "DeleteCustomerGateway"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "CustomerGatewayId": {
                    "type": "string"
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
            "Action": "DeleteCustomerGateway"
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
        //application/xml
        {
            "properties": {
                "Return": {
                    "type": "boolean"
                },
                "RequestId": {
                    "type": "string"
                }
            }
        }  

        //------------------------------------------------

        ```
        - Example #例子是json 格式 , C# 中为 JObject 类型
            
        ```json
        //application/xml
        {}

        //------------------------------------------------

        ```



### DescribeCustomerGateways

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DescribeCustomerGateways_query = new JObject();

            

        HttpClientResponse DescribeCustomerGateways_res = client.DescribeCustomerGateways(_DescribeCustomerGateways_query);
        JObject DescribeCustomerGateways_data = DescribeCustomerGateways_res.data;
        IRestResponse DescribeCustomerGateways_response = DescribeCustomerGateways_res.response;
        Console.WriteLine(DescribeCustomerGateways_data);
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
                        "DescribeCustomerGateways"
                    ],
                    "default": "DescribeCustomerGateways"
                },
                "Version": {
                    "type": "string",
                    "default": "2016-03-04"
                },
                "CustomerGatewayId": {
                    "type": "string"
                },
                "Filter": {
                    "type": "string"
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
            "Action": "DescribeCustomerGateways"
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
        //application/xml
        {
            "properties": {
                "Return": {
                    "type": "boolean"
                },
                "CustomerGateway": {
                    "type": "array",
                    "items": {
                        "type": "object",
                        "properties": {
                            "CreateTime": {
                                "type": "string"
                            },
                            "CustomerGatewayId": {
                                "type": "string"
                            },
                            "CustomerGatewayAddress": {
                                "type": "string"
                            },
                            "HaCustomerGatewayAddress": {
                                "type": "string"
                            },
                            "CustomerGatewayName": {
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
        //application/xml
        {}

        //------------------------------------------------

        ```



### DescribeTunnels

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DescribeTunnels_query = new JObject();

            

        HttpClientResponse DescribeTunnels_res = client.DescribeTunnels(_DescribeTunnels_query);
        JObject DescribeTunnels_data = DescribeTunnels_res.data;
        IRestResponse DescribeTunnels_response = DescribeTunnels_res.response;
        Console.WriteLine(DescribeTunnels_data);
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
                        "DescribeTunnels"
                    ],
                    "default": "DescribeTunnels"
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
            "Action": "DescribeTunnels"
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



### ModifyTunnel

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _ModifyTunnel_query = new JObject();

            

        HttpClientResponse ModifyTunnel_res = client.ModifyTunnel(_ModifyTunnel_query);
        JObject ModifyTunnel_data = ModifyTunnel_res.data;
        IRestResponse ModifyTunnel_response = ModifyTunnel_res.response;
        Console.WriteLine(ModifyTunnel_data);
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
                        "ModifyTunnel"
                    ],
                    "default": "ModifyTunnel"
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
            "Action": "ModifyTunnel"
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



### AssociateSubnet

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _AssociateSubnet_query = new JObject();

            

        HttpClientResponse AssociateSubnet_res = client.AssociateSubnet(_AssociateSubnet_query);
        JObject AssociateSubnet_data = AssociateSubnet_res.data;
        IRestResponse AssociateSubnet_response = AssociateSubnet_res.response;
        Console.WriteLine(AssociateSubnet_data);
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
                        "AssociateSubnet"
                    ],
                    "default": "AssociateSubnet"
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
            "Action": "AssociateSubnet"
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



### DisassociateSubnet

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DisassociateSubnet_query = new JObject();

            

        HttpClientResponse DisassociateSubnet_res = client.DisassociateSubnet(_DisassociateSubnet_query);
        JObject DisassociateSubnet_data = DisassociateSubnet_res.data;
        IRestResponse DisassociateSubnet_response = DisassociateSubnet_res.response;
        Console.WriteLine(DisassociateSubnet_data);
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
                        "DisassociateSubnet"
                    ],
                    "default": "DisassociateSubnet"
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
            "Action": "DisassociateSubnet"
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



### AssociateRemoteCidr

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _AssociateRemoteCidr_query = new JObject();

            

        HttpClientResponse AssociateRemoteCidr_res = client.AssociateRemoteCidr(_AssociateRemoteCidr_query);
        JObject AssociateRemoteCidr_data = AssociateRemoteCidr_res.data;
        IRestResponse AssociateRemoteCidr_response = AssociateRemoteCidr_res.response;
        Console.WriteLine(AssociateRemoteCidr_data);
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
                        "AssociateRemoteCidr"
                    ],
                    "default": "AssociateRemoteCidr"
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
            "Action": "AssociateRemoteCidr"
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



### DisassociateRemoteCidr

- Example

```c#
using KSYUN.SDK.VPC;
using Newtonsoft.Json.Linq;
using RestSharp;

class Test {
    static void Main()
    {
        string _region = "xxx";
        string _protocol = "xxx";
        string _ak = "xxx";
        string _sk = "xxx";


        KsyunVpcClient client = new KsyunVpcClient(
        _region,
        _protocol,
        _ak,
        _sk
        );


        JObject _DisassociateRemoteCidr_query = new JObject();

            

        HttpClientResponse DisassociateRemoteCidr_res = client.DisassociateRemoteCidr(_DisassociateRemoteCidr_query);
        JObject DisassociateRemoteCidr_data = DisassociateRemoteCidr_res.data;
        IRestResponse DisassociateRemoteCidr_response = DisassociateRemoteCidr_res.response;
        Console.WriteLine(DisassociateRemoteCidr_data);
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
                        "DisassociateRemoteCidr"
                    ],
                    "default": "DisassociateRemoteCidr"
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
            "Action": "DisassociateRemoteCidr"
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
