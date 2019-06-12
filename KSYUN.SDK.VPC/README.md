# CSharp API SDK for namespace KSYUN.SDK.VPC classname KsyunVpcClient 


- Build date: 2019-06-12 11:49
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

Class Test {
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.CreateVpc(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DeleteVpc(JObject _query );
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
            "Return": {
                "type": "boolean"
            },
            "RequestId": {
                "type": "string"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.ModifyVpc(JObject _query );
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
            "Return": {
                "type": "boolean"
            },
            "RequestId": {
                "type": "string"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeVpcs(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.CreateSubnet(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DeleteSubnet(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.ModifySubnet(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeSubnets(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.AssociateNetworkAcl(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DisassociateNetworkAcl(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeSubnetAvailableAddresses(JObject _query );
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
            "RequestId": {
                "type": "string"
            },
            "AvailableIpAddress": {
                "type": "boolean"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeSubnetAllocatedIpAddresses(JObject _query );
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
            "RequestId": {
                "type": "string"
            },
            "AllocatedIpAddress": {
                "type": "boolean"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.CreateRoute(JObject _query );
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
            "RequestId": {
                "type": "string"
            },
            "RouteId": {
                "type": "string"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DeleteRoute(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeRoutes(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.CreateNetworkAcl(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DeleteNetworkAcl(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.ModifyNetworkAcl(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.CreateNetworkAclEntry(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DeleteNetworkAclEntry(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.ModifyNetworkAclEntry(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeNetworkAcls(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.CreateSecurityGroup(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DeleteSecurityGroup(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.ModifySecurityGroup(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.AuthorizeSecurityGroupEntry(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.RevokeSecurityGroupEntry(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.ModifySecurityGroupEntry(JObject _query );
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
                    "ModifySecurityGroupEntry"
                ],
                "default": "ModifySecurityGroupEntry"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeSecurityGroups(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeInternetGateways(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeNetworkInterfaces(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.CreateNat(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DeleteNat(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.ModifyNat(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeNats(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.AssociateNat(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DisassociateNat(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.CreateVpcPeeringConnection(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.AcceptVpcPeeringConnection(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.RejectVpcPeeringConnection(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DeleteVpcPeeringConnection(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.ModifyVpcPeeringConnection(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeVpcPeeringConnections(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.AddNatIp(JObject _query );
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
                    "AddNatIp"
                ],
                "default": "AddNatIp"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DeleteNatIp(JObject _query );
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
                    "DeleteNatIp"
                ],
                "default": "DeleteNatIp"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.AssociateDirectConnectGateway(JObject _query );
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
                    "AssociateDirectConnectGateway"
                ],
                "default": "AssociateDirectConnectGateway"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DisassociateDirectConnectGateway(JObject _query );
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
                    "DisassociateDirectConnectGateway"
                ],
                "default": "DisassociateDirectConnectGateway"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.AssociateVpnGateway(JObject _query );
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
                    "AssociateVpnGateway"
                ],
                "default": "AssociateVpnGateway"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DisassociateVpnGateway(JObject _query );
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
                    "DisassociateVpnGateway"
                ],
                "default": "DisassociateVpnGateway"
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

Class Test {
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeDirectConnects(JObject _query );
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
                    "DescribeDirectConnects"
                ],
                "default": "DescribeDirectConnects"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.CreateDirectConnectInterface(JObject _query );
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
                    "CreateDirectConnectInterface"
                ],
                "default": "CreateDirectConnectInterface"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.ModifyDirectConnectInterface(JObject _query );
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
                    "ModifyDirectConnectInterface"
                ],
                "default": "ModifyDirectConnectInterface"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DeleteDirectConnectInterface(JObject _query );
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
                    "DeleteDirectConnectInterface"
                ],
                "default": "DeleteDirectConnectInterface"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeDirectConnectInterfaces(JObject _query );
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
                    "DescribeDirectConnectInterfaces"
                ],
                "default": "DescribeDirectConnectInterfaces"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.CreateDirectConnectGateway(JObject _query );
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
                    "CreateDirectConnectGateway"
                ],
                "default": "CreateDirectConnectGateway"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.ModifyDirectConnectGateway(JObject _query );
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
                    "ModifyDirectConnectGateway"
                ],
                "default": "ModifyDirectConnectGateway"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DeleteDirectConnectGateway(JObject _query );
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
                    "DeleteDirectConnectGateway"
                ],
                "default": "DeleteDirectConnectGateway"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeDirectConnectGateways(JObject _query );
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
                    "DescribeDirectConnectGateways"
                ],
                "default": "DescribeDirectConnectGateways"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.AttachDirectConnectGateway(JObject _query );
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
                    "AttachDirectConnectGateway"
                ],
                "default": "AttachDirectConnectGateway"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DetachDirectConnectGateway(JObject _query );
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
                    "DetachDirectConnectGateway"
                ],
                "default": "DetachDirectConnectGateway"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.CreateVpnGateway(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.ModifyVpnGateway(JObject _query );
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
            "Return": {
                "type": "boolean"
            },
            "RequestId": {
                "type": "string"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DeleteVpnGateway(JObject _query );
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
            "Return": {
                "type": "boolean"
            },
            "RequestId": {
                "type": "string"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeVpnGateways(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();
        JObject _body = new JObject();

        HttpClientResponse res = client.CreateVpnTunnel(JObject _query , JObject _body );
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
                    "CreateVpnTunnel"
                ],
                "default": "CreateVpnTunnel"
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
            "action": "CreateVpnTunnel"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.ModifyVpnTunnel(JObject _query );
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
            "Return": {
                "type": "boolean"
            },
            "RequestId": {
                "type": "string"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DeleteVpnTunnel(JObject _query );
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
            "Return": {
                "type": "boolean"
            },
            "RequestId": {
                "type": "string"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeVpnTunnels(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.CreateCustomerGateway(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.ModifyCustomerGateway(JObject _query );
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
            "Return": {
                "type": "boolean"
            },
            "RequestId": {
                "type": "string"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DeleteCustomerGateway(JObject _query );
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
            "Return": {
                "type": "boolean"
            },
            "RequestId": {
                "type": "string"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeCustomerGateways(JObject _query );
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DescribeTunnels(JObject _query );
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
                    "DescribeTunnels"
                ],
                "default": "DescribeTunnels"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.ModifyTunnel(JObject _query );
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
                    "ModifyTunnel"
                ],
                "default": "ModifyTunnel"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.AssociateSubnet(JObject _query );
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
                    "AssociateSubnet"
                ],
                "default": "AssociateSubnet"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DisassociateSubnet(JObject _query );
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
                    "DisassociateSubnet"
                ],
                "default": "DisassociateSubnet"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.AssociateRemoteCidr(JObject _query );
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
                    "AssociateRemoteCidr"
                ],
                "default": "AssociateRemoteCidr"
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

Class Test {
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


        JObject _query = new JObject();

        HttpClientResponse res = client.DisassociateRemoteCidr(JObject _query );
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
                    "DisassociateRemoteCidr"
                ],
                "default": "DisassociateRemoteCidr"
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
