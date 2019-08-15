using KSYUN.SDK.VPC;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using KSYUN.SDK.VPC.HttpClient;
using KSYUN.SDK.VPC.HttpClient.Signature;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using RestSharp;

namespace KSYUN.SDK.VPC
{
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
            
            
            JObject _DeleteVpc_query = new JObject();

                    

            HttpClientResponse DeleteVpc_res = client.DeleteVpc(_DeleteVpc_query);
            JObject DeleteVpc_data = DeleteVpc_res.data;
            IRestResponse DeleteVpc_response = DeleteVpc_res.response;
            Console.WriteLine(DeleteVpc_data);
            
            
            JObject _ModifyVpc_query = new JObject();

                    

            HttpClientResponse ModifyVpc_res = client.ModifyVpc(_ModifyVpc_query);
            JObject ModifyVpc_data = ModifyVpc_res.data;
            IRestResponse ModifyVpc_response = ModifyVpc_res.response;
            Console.WriteLine(ModifyVpc_data);
            
            
            JObject _DescribeVpcs_query = new JObject();

                    

            HttpClientResponse DescribeVpcs_res = client.DescribeVpcs(_DescribeVpcs_query);
            JObject DescribeVpcs_data = DescribeVpcs_res.data;
            IRestResponse DescribeVpcs_response = DescribeVpcs_res.response;
            Console.WriteLine(DescribeVpcs_data);
            
            
            JObject _CreateSubnet_query = new JObject();

                    

            HttpClientResponse CreateSubnet_res = client.CreateSubnet(_CreateSubnet_query);
            JObject CreateSubnet_data = CreateSubnet_res.data;
            IRestResponse CreateSubnet_response = CreateSubnet_res.response;
            Console.WriteLine(CreateSubnet_data);
            
            
            JObject _DeleteSubnet_query = new JObject();

                    

            HttpClientResponse DeleteSubnet_res = client.DeleteSubnet(_DeleteSubnet_query);
            JObject DeleteSubnet_data = DeleteSubnet_res.data;
            IRestResponse DeleteSubnet_response = DeleteSubnet_res.response;
            Console.WriteLine(DeleteSubnet_data);
            
            
            JObject _ModifySubnet_query = new JObject();

                    

            HttpClientResponse ModifySubnet_res = client.ModifySubnet(_ModifySubnet_query);
            JObject ModifySubnet_data = ModifySubnet_res.data;
            IRestResponse ModifySubnet_response = ModifySubnet_res.response;
            Console.WriteLine(ModifySubnet_data);
            
            
            JObject _DescribeSubnets_query = new JObject();

                    

            HttpClientResponse DescribeSubnets_res = client.DescribeSubnets(_DescribeSubnets_query);
            JObject DescribeSubnets_data = DescribeSubnets_res.data;
            IRestResponse DescribeSubnets_response = DescribeSubnets_res.response;
            Console.WriteLine(DescribeSubnets_data);
            
            
            JObject _AssociateNetworkAcl_query = new JObject();

                    

            HttpClientResponse AssociateNetworkAcl_res = client.AssociateNetworkAcl(_AssociateNetworkAcl_query);
            JObject AssociateNetworkAcl_data = AssociateNetworkAcl_res.data;
            IRestResponse AssociateNetworkAcl_response = AssociateNetworkAcl_res.response;
            Console.WriteLine(AssociateNetworkAcl_data);
            
            
            JObject _DisassociateNetworkAcl_query = new JObject();

                    

            HttpClientResponse DisassociateNetworkAcl_res = client.DisassociateNetworkAcl(_DisassociateNetworkAcl_query);
            JObject DisassociateNetworkAcl_data = DisassociateNetworkAcl_res.data;
            IRestResponse DisassociateNetworkAcl_response = DisassociateNetworkAcl_res.response;
            Console.WriteLine(DisassociateNetworkAcl_data);
            
            
            JObject _DescribeSubnetAvailableAddresses_query = new JObject();

                    

            HttpClientResponse DescribeSubnetAvailableAddresses_res = client.DescribeSubnetAvailableAddresses(_DescribeSubnetAvailableAddresses_query);
            JObject DescribeSubnetAvailableAddresses_data = DescribeSubnetAvailableAddresses_res.data;
            IRestResponse DescribeSubnetAvailableAddresses_response = DescribeSubnetAvailableAddresses_res.response;
            Console.WriteLine(DescribeSubnetAvailableAddresses_data);
            
            
            JObject _DescribeSubnetAllocatedIpAddresses_query = new JObject();

                    

            HttpClientResponse DescribeSubnetAllocatedIpAddresses_res = client.DescribeSubnetAllocatedIpAddresses(_DescribeSubnetAllocatedIpAddresses_query);
            JObject DescribeSubnetAllocatedIpAddresses_data = DescribeSubnetAllocatedIpAddresses_res.data;
            IRestResponse DescribeSubnetAllocatedIpAddresses_response = DescribeSubnetAllocatedIpAddresses_res.response;
            Console.WriteLine(DescribeSubnetAllocatedIpAddresses_data);
            
            
            JObject _CreateRoute_query = new JObject();

                    

            HttpClientResponse CreateRoute_res = client.CreateRoute(_CreateRoute_query);
            JObject CreateRoute_data = CreateRoute_res.data;
            IRestResponse CreateRoute_response = CreateRoute_res.response;
            Console.WriteLine(CreateRoute_data);
            
            
            JObject _DeleteRoute_query = new JObject();

                    

            HttpClientResponse DeleteRoute_res = client.DeleteRoute(_DeleteRoute_query);
            JObject DeleteRoute_data = DeleteRoute_res.data;
            IRestResponse DeleteRoute_response = DeleteRoute_res.response;
            Console.WriteLine(DeleteRoute_data);
            
            
            JObject _DescribeRoutes_query = new JObject();

                    

            HttpClientResponse DescribeRoutes_res = client.DescribeRoutes(_DescribeRoutes_query);
            JObject DescribeRoutes_data = DescribeRoutes_res.data;
            IRestResponse DescribeRoutes_response = DescribeRoutes_res.response;
            Console.WriteLine(DescribeRoutes_data);
            
            
            JObject _CreateNetworkAcl_query = new JObject();

                    

            HttpClientResponse CreateNetworkAcl_res = client.CreateNetworkAcl(_CreateNetworkAcl_query);
            JObject CreateNetworkAcl_data = CreateNetworkAcl_res.data;
            IRestResponse CreateNetworkAcl_response = CreateNetworkAcl_res.response;
            Console.WriteLine(CreateNetworkAcl_data);
            
            
            JObject _DeleteNetworkAcl_query = new JObject();

                    

            HttpClientResponse DeleteNetworkAcl_res = client.DeleteNetworkAcl(_DeleteNetworkAcl_query);
            JObject DeleteNetworkAcl_data = DeleteNetworkAcl_res.data;
            IRestResponse DeleteNetworkAcl_response = DeleteNetworkAcl_res.response;
            Console.WriteLine(DeleteNetworkAcl_data);
            
            
            JObject _ModifyNetworkAcl_query = new JObject();

                    

            HttpClientResponse ModifyNetworkAcl_res = client.ModifyNetworkAcl(_ModifyNetworkAcl_query);
            JObject ModifyNetworkAcl_data = ModifyNetworkAcl_res.data;
            IRestResponse ModifyNetworkAcl_response = ModifyNetworkAcl_res.response;
            Console.WriteLine(ModifyNetworkAcl_data);
            
            
            JObject _CreateNetworkAclEntry_query = new JObject();

                    

            HttpClientResponse CreateNetworkAclEntry_res = client.CreateNetworkAclEntry(_CreateNetworkAclEntry_query);
            JObject CreateNetworkAclEntry_data = CreateNetworkAclEntry_res.data;
            IRestResponse CreateNetworkAclEntry_response = CreateNetworkAclEntry_res.response;
            Console.WriteLine(CreateNetworkAclEntry_data);
            
            
            JObject _DeleteNetworkAclEntry_query = new JObject();

                    

            HttpClientResponse DeleteNetworkAclEntry_res = client.DeleteNetworkAclEntry(_DeleteNetworkAclEntry_query);
            JObject DeleteNetworkAclEntry_data = DeleteNetworkAclEntry_res.data;
            IRestResponse DeleteNetworkAclEntry_response = DeleteNetworkAclEntry_res.response;
            Console.WriteLine(DeleteNetworkAclEntry_data);
            
            
            JObject _ModifyNetworkAclEntry_query = new JObject();

                    

            HttpClientResponse ModifyNetworkAclEntry_res = client.ModifyNetworkAclEntry(_ModifyNetworkAclEntry_query);
            JObject ModifyNetworkAclEntry_data = ModifyNetworkAclEntry_res.data;
            IRestResponse ModifyNetworkAclEntry_response = ModifyNetworkAclEntry_res.response;
            Console.WriteLine(ModifyNetworkAclEntry_data);
            
            
            JObject _DescribeNetworkAcls_query = new JObject();

                    

            HttpClientResponse DescribeNetworkAcls_res = client.DescribeNetworkAcls(_DescribeNetworkAcls_query);
            JObject DescribeNetworkAcls_data = DescribeNetworkAcls_res.data;
            IRestResponse DescribeNetworkAcls_response = DescribeNetworkAcls_res.response;
            Console.WriteLine(DescribeNetworkAcls_data);
            
            
            JObject _CreateSecurityGroup_query = new JObject();

                    

            HttpClientResponse CreateSecurityGroup_res = client.CreateSecurityGroup(_CreateSecurityGroup_query);
            JObject CreateSecurityGroup_data = CreateSecurityGroup_res.data;
            IRestResponse CreateSecurityGroup_response = CreateSecurityGroup_res.response;
            Console.WriteLine(CreateSecurityGroup_data);
            
            
            JObject _DeleteSecurityGroup_query = new JObject();

                    

            HttpClientResponse DeleteSecurityGroup_res = client.DeleteSecurityGroup(_DeleteSecurityGroup_query);
            JObject DeleteSecurityGroup_data = DeleteSecurityGroup_res.data;
            IRestResponse DeleteSecurityGroup_response = DeleteSecurityGroup_res.response;
            Console.WriteLine(DeleteSecurityGroup_data);
            
            
            JObject _ModifySecurityGroup_query = new JObject();

                    

            HttpClientResponse ModifySecurityGroup_res = client.ModifySecurityGroup(_ModifySecurityGroup_query);
            JObject ModifySecurityGroup_data = ModifySecurityGroup_res.data;
            IRestResponse ModifySecurityGroup_response = ModifySecurityGroup_res.response;
            Console.WriteLine(ModifySecurityGroup_data);
            
            
            JObject _AuthorizeSecurityGroupEntry_query = new JObject();

                    

            HttpClientResponse AuthorizeSecurityGroupEntry_res = client.AuthorizeSecurityGroupEntry(_AuthorizeSecurityGroupEntry_query);
            JObject AuthorizeSecurityGroupEntry_data = AuthorizeSecurityGroupEntry_res.data;
            IRestResponse AuthorizeSecurityGroupEntry_response = AuthorizeSecurityGroupEntry_res.response;
            Console.WriteLine(AuthorizeSecurityGroupEntry_data);
            
            
            JObject _RevokeSecurityGroupEntry_query = new JObject();

                    

            HttpClientResponse RevokeSecurityGroupEntry_res = client.RevokeSecurityGroupEntry(_RevokeSecurityGroupEntry_query);
            JObject RevokeSecurityGroupEntry_data = RevokeSecurityGroupEntry_res.data;
            IRestResponse RevokeSecurityGroupEntry_response = RevokeSecurityGroupEntry_res.response;
            Console.WriteLine(RevokeSecurityGroupEntry_data);
            
            
            JObject _ModifySecurityGroupEntry_query = new JObject();

                    

            HttpClientResponse ModifySecurityGroupEntry_res = client.ModifySecurityGroupEntry(_ModifySecurityGroupEntry_query);
            JObject ModifySecurityGroupEntry_data = ModifySecurityGroupEntry_res.data;
            IRestResponse ModifySecurityGroupEntry_response = ModifySecurityGroupEntry_res.response;
            Console.WriteLine(ModifySecurityGroupEntry_data);
            
            
            JObject _DescribeSecurityGroups_query = new JObject();

                    

            HttpClientResponse DescribeSecurityGroups_res = client.DescribeSecurityGroups(_DescribeSecurityGroups_query);
            JObject DescribeSecurityGroups_data = DescribeSecurityGroups_res.data;
            IRestResponse DescribeSecurityGroups_response = DescribeSecurityGroups_res.response;
            Console.WriteLine(DescribeSecurityGroups_data);
            
            
            JObject _DescribeInternetGateways_query = new JObject();

                    

            HttpClientResponse DescribeInternetGateways_res = client.DescribeInternetGateways(_DescribeInternetGateways_query);
            JObject DescribeInternetGateways_data = DescribeInternetGateways_res.data;
            IRestResponse DescribeInternetGateways_response = DescribeInternetGateways_res.response;
            Console.WriteLine(DescribeInternetGateways_data);
            
            
            JObject _DescribeNetworkInterfaces_query = new JObject();

                    

            HttpClientResponse DescribeNetworkInterfaces_res = client.DescribeNetworkInterfaces(_DescribeNetworkInterfaces_query);
            JObject DescribeNetworkInterfaces_data = DescribeNetworkInterfaces_res.data;
            IRestResponse DescribeNetworkInterfaces_response = DescribeNetworkInterfaces_res.response;
            Console.WriteLine(DescribeNetworkInterfaces_data);
            
            
            JObject _CreateNat_query = new JObject();

                    

            HttpClientResponse CreateNat_res = client.CreateNat(_CreateNat_query);
            JObject CreateNat_data = CreateNat_res.data;
            IRestResponse CreateNat_response = CreateNat_res.response;
            Console.WriteLine(CreateNat_data);
            
            
            JObject _DeleteNat_query = new JObject();

                    

            HttpClientResponse DeleteNat_res = client.DeleteNat(_DeleteNat_query);
            JObject DeleteNat_data = DeleteNat_res.data;
            IRestResponse DeleteNat_response = DeleteNat_res.response;
            Console.WriteLine(DeleteNat_data);
            
            
            JObject _ModifyNat_query = new JObject();

                    

            HttpClientResponse ModifyNat_res = client.ModifyNat(_ModifyNat_query);
            JObject ModifyNat_data = ModifyNat_res.data;
            IRestResponse ModifyNat_response = ModifyNat_res.response;
            Console.WriteLine(ModifyNat_data);
            
            
            JObject _DescribeNats_query = new JObject();

                    

            HttpClientResponse DescribeNats_res = client.DescribeNats(_DescribeNats_query);
            JObject DescribeNats_data = DescribeNats_res.data;
            IRestResponse DescribeNats_response = DescribeNats_res.response;
            Console.WriteLine(DescribeNats_data);
            
            
            JObject _AssociateNat_query = new JObject();

                    

            HttpClientResponse AssociateNat_res = client.AssociateNat(_AssociateNat_query);
            JObject AssociateNat_data = AssociateNat_res.data;
            IRestResponse AssociateNat_response = AssociateNat_res.response;
            Console.WriteLine(AssociateNat_data);
            
            
            JObject _DisassociateNat_query = new JObject();

                    

            HttpClientResponse DisassociateNat_res = client.DisassociateNat(_DisassociateNat_query);
            JObject DisassociateNat_data = DisassociateNat_res.data;
            IRestResponse DisassociateNat_response = DisassociateNat_res.response;
            Console.WriteLine(DisassociateNat_data);
            
            
            JObject _CreateVpcPeeringConnection_query = new JObject();

                    

            HttpClientResponse CreateVpcPeeringConnection_res = client.CreateVpcPeeringConnection(_CreateVpcPeeringConnection_query);
            JObject CreateVpcPeeringConnection_data = CreateVpcPeeringConnection_res.data;
            IRestResponse CreateVpcPeeringConnection_response = CreateVpcPeeringConnection_res.response;
            Console.WriteLine(CreateVpcPeeringConnection_data);
            
            
            JObject _AcceptVpcPeeringConnection_query = new JObject();

                    

            HttpClientResponse AcceptVpcPeeringConnection_res = client.AcceptVpcPeeringConnection(_AcceptVpcPeeringConnection_query);
            JObject AcceptVpcPeeringConnection_data = AcceptVpcPeeringConnection_res.data;
            IRestResponse AcceptVpcPeeringConnection_response = AcceptVpcPeeringConnection_res.response;
            Console.WriteLine(AcceptVpcPeeringConnection_data);
            
            
            JObject _RejectVpcPeeringConnection_query = new JObject();

                    

            HttpClientResponse RejectVpcPeeringConnection_res = client.RejectVpcPeeringConnection(_RejectVpcPeeringConnection_query);
            JObject RejectVpcPeeringConnection_data = RejectVpcPeeringConnection_res.data;
            IRestResponse RejectVpcPeeringConnection_response = RejectVpcPeeringConnection_res.response;
            Console.WriteLine(RejectVpcPeeringConnection_data);
            
            
            JObject _DeleteVpcPeeringConnection_query = new JObject();

                    

            HttpClientResponse DeleteVpcPeeringConnection_res = client.DeleteVpcPeeringConnection(_DeleteVpcPeeringConnection_query);
            JObject DeleteVpcPeeringConnection_data = DeleteVpcPeeringConnection_res.data;
            IRestResponse DeleteVpcPeeringConnection_response = DeleteVpcPeeringConnection_res.response;
            Console.WriteLine(DeleteVpcPeeringConnection_data);
            
            
            JObject _ModifyVpcPeeringConnection_query = new JObject();

                    

            HttpClientResponse ModifyVpcPeeringConnection_res = client.ModifyVpcPeeringConnection(_ModifyVpcPeeringConnection_query);
            JObject ModifyVpcPeeringConnection_data = ModifyVpcPeeringConnection_res.data;
            IRestResponse ModifyVpcPeeringConnection_response = ModifyVpcPeeringConnection_res.response;
            Console.WriteLine(ModifyVpcPeeringConnection_data);
            
            
            JObject _DescribeVpcPeeringConnections_query = new JObject();

                    

            HttpClientResponse DescribeVpcPeeringConnections_res = client.DescribeVpcPeeringConnections(_DescribeVpcPeeringConnections_query);
            JObject DescribeVpcPeeringConnections_data = DescribeVpcPeeringConnections_res.data;
            IRestResponse DescribeVpcPeeringConnections_response = DescribeVpcPeeringConnections_res.response;
            Console.WriteLine(DescribeVpcPeeringConnections_data);
            
            
            JObject _AddNatIp_query = new JObject();

                    

            HttpClientResponse AddNatIp_res = client.AddNatIp(_AddNatIp_query);
            JObject AddNatIp_data = AddNatIp_res.data;
            IRestResponse AddNatIp_response = AddNatIp_res.response;
            Console.WriteLine(AddNatIp_data);
            
            
            JObject _DeleteNatIp_query = new JObject();

                    

            HttpClientResponse DeleteNatIp_res = client.DeleteNatIp(_DeleteNatIp_query);
            JObject DeleteNatIp_data = DeleteNatIp_res.data;
            IRestResponse DeleteNatIp_response = DeleteNatIp_res.response;
            Console.WriteLine(DeleteNatIp_data);
            
            
            JObject _AssociateDirectConnectGateway_query = new JObject();

                    

            HttpClientResponse AssociateDirectConnectGateway_res = client.AssociateDirectConnectGateway(_AssociateDirectConnectGateway_query);
            JObject AssociateDirectConnectGateway_data = AssociateDirectConnectGateway_res.data;
            IRestResponse AssociateDirectConnectGateway_response = AssociateDirectConnectGateway_res.response;
            Console.WriteLine(AssociateDirectConnectGateway_data);
            
            
            JObject _DisassociateDirectConnectGateway_query = new JObject();

                    

            HttpClientResponse DisassociateDirectConnectGateway_res = client.DisassociateDirectConnectGateway(_DisassociateDirectConnectGateway_query);
            JObject DisassociateDirectConnectGateway_data = DisassociateDirectConnectGateway_res.data;
            IRestResponse DisassociateDirectConnectGateway_response = DisassociateDirectConnectGateway_res.response;
            Console.WriteLine(DisassociateDirectConnectGateway_data);
            
            
            JObject _AssociateVpnGateway_query = new JObject();

                    

            HttpClientResponse AssociateVpnGateway_res = client.AssociateVpnGateway(_AssociateVpnGateway_query);
            JObject AssociateVpnGateway_data = AssociateVpnGateway_res.data;
            IRestResponse AssociateVpnGateway_response = AssociateVpnGateway_res.response;
            Console.WriteLine(AssociateVpnGateway_data);
            
            
            JObject _DisassociateVpnGateway_query = new JObject();

                    

            HttpClientResponse DisassociateVpnGateway_res = client.DisassociateVpnGateway(_DisassociateVpnGateway_query);
            JObject DisassociateVpnGateway_data = DisassociateVpnGateway_res.data;
            IRestResponse DisassociateVpnGateway_response = DisassociateVpnGateway_res.response;
            Console.WriteLine(DisassociateVpnGateway_data);
            
            
            JObject _DescribeAvailabilityZones_query = new JObject();

                    

            HttpClientResponse DescribeAvailabilityZones_res = client.DescribeAvailabilityZones(_DescribeAvailabilityZones_query);
            JObject DescribeAvailabilityZones_data = DescribeAvailabilityZones_res.data;
            IRestResponse DescribeAvailabilityZones_response = DescribeAvailabilityZones_res.response;
            Console.WriteLine(DescribeAvailabilityZones_data);
            
            
            JObject _DescribeDirectConnects_query = new JObject();

                    

            HttpClientResponse DescribeDirectConnects_res = client.DescribeDirectConnects(_DescribeDirectConnects_query);
            JObject DescribeDirectConnects_data = DescribeDirectConnects_res.data;
            IRestResponse DescribeDirectConnects_response = DescribeDirectConnects_res.response;
            Console.WriteLine(DescribeDirectConnects_data);
            
            
            JObject _CreateDirectConnectInterface_query = new JObject();

                    

            HttpClientResponse CreateDirectConnectInterface_res = client.CreateDirectConnectInterface(_CreateDirectConnectInterface_query);
            JObject CreateDirectConnectInterface_data = CreateDirectConnectInterface_res.data;
            IRestResponse CreateDirectConnectInterface_response = CreateDirectConnectInterface_res.response;
            Console.WriteLine(CreateDirectConnectInterface_data);
            
            
            JObject _ModifyDirectConnectInterface_query = new JObject();

                    

            HttpClientResponse ModifyDirectConnectInterface_res = client.ModifyDirectConnectInterface(_ModifyDirectConnectInterface_query);
            JObject ModifyDirectConnectInterface_data = ModifyDirectConnectInterface_res.data;
            IRestResponse ModifyDirectConnectInterface_response = ModifyDirectConnectInterface_res.response;
            Console.WriteLine(ModifyDirectConnectInterface_data);
            
            
            JObject _DeleteDirectConnectInterface_query = new JObject();

                    

            HttpClientResponse DeleteDirectConnectInterface_res = client.DeleteDirectConnectInterface(_DeleteDirectConnectInterface_query);
            JObject DeleteDirectConnectInterface_data = DeleteDirectConnectInterface_res.data;
            IRestResponse DeleteDirectConnectInterface_response = DeleteDirectConnectInterface_res.response;
            Console.WriteLine(DeleteDirectConnectInterface_data);
            
            
            JObject _DescribeDirectConnectInterfaces_query = new JObject();

                    

            HttpClientResponse DescribeDirectConnectInterfaces_res = client.DescribeDirectConnectInterfaces(_DescribeDirectConnectInterfaces_query);
            JObject DescribeDirectConnectInterfaces_data = DescribeDirectConnectInterfaces_res.data;
            IRestResponse DescribeDirectConnectInterfaces_response = DescribeDirectConnectInterfaces_res.response;
            Console.WriteLine(DescribeDirectConnectInterfaces_data);
            
            
            JObject _CreateDirectConnectGateway_query = new JObject();

                    

            HttpClientResponse CreateDirectConnectGateway_res = client.CreateDirectConnectGateway(_CreateDirectConnectGateway_query);
            JObject CreateDirectConnectGateway_data = CreateDirectConnectGateway_res.data;
            IRestResponse CreateDirectConnectGateway_response = CreateDirectConnectGateway_res.response;
            Console.WriteLine(CreateDirectConnectGateway_data);
            
            
            JObject _ModifyDirectConnectGateway_query = new JObject();

                    

            HttpClientResponse ModifyDirectConnectGateway_res = client.ModifyDirectConnectGateway(_ModifyDirectConnectGateway_query);
            JObject ModifyDirectConnectGateway_data = ModifyDirectConnectGateway_res.data;
            IRestResponse ModifyDirectConnectGateway_response = ModifyDirectConnectGateway_res.response;
            Console.WriteLine(ModifyDirectConnectGateway_data);
            
            
            JObject _DeleteDirectConnectGateway_query = new JObject();

                    

            HttpClientResponse DeleteDirectConnectGateway_res = client.DeleteDirectConnectGateway(_DeleteDirectConnectGateway_query);
            JObject DeleteDirectConnectGateway_data = DeleteDirectConnectGateway_res.data;
            IRestResponse DeleteDirectConnectGateway_response = DeleteDirectConnectGateway_res.response;
            Console.WriteLine(DeleteDirectConnectGateway_data);
            
            
            JObject _DescribeDirectConnectGateways_query = new JObject();

                    

            HttpClientResponse DescribeDirectConnectGateways_res = client.DescribeDirectConnectGateways(_DescribeDirectConnectGateways_query);
            JObject DescribeDirectConnectGateways_data = DescribeDirectConnectGateways_res.data;
            IRestResponse DescribeDirectConnectGateways_response = DescribeDirectConnectGateways_res.response;
            Console.WriteLine(DescribeDirectConnectGateways_data);
            
            
            JObject _AttachDirectConnectGateway_query = new JObject();

                    

            HttpClientResponse AttachDirectConnectGateway_res = client.AttachDirectConnectGateway(_AttachDirectConnectGateway_query);
            JObject AttachDirectConnectGateway_data = AttachDirectConnectGateway_res.data;
            IRestResponse AttachDirectConnectGateway_response = AttachDirectConnectGateway_res.response;
            Console.WriteLine(AttachDirectConnectGateway_data);
            
            
            JObject _DetachDirectConnectGateway_query = new JObject();

                    

            HttpClientResponse DetachDirectConnectGateway_res = client.DetachDirectConnectGateway(_DetachDirectConnectGateway_query);
            JObject DetachDirectConnectGateway_data = DetachDirectConnectGateway_res.data;
            IRestResponse DetachDirectConnectGateway_response = DetachDirectConnectGateway_res.response;
            Console.WriteLine(DetachDirectConnectGateway_data);
            
            
            JObject _CreateVpnGateway_query = new JObject();

                    

            HttpClientResponse CreateVpnGateway_res = client.CreateVpnGateway(_CreateVpnGateway_query);
            JObject CreateVpnGateway_data = CreateVpnGateway_res.data;
            IRestResponse CreateVpnGateway_response = CreateVpnGateway_res.response;
            Console.WriteLine(CreateVpnGateway_data);
            
            
            JObject _ModifyVpnGateway_query = new JObject();

                    

            HttpClientResponse ModifyVpnGateway_res = client.ModifyVpnGateway(_ModifyVpnGateway_query);
            JObject ModifyVpnGateway_data = ModifyVpnGateway_res.data;
            IRestResponse ModifyVpnGateway_response = ModifyVpnGateway_res.response;
            Console.WriteLine(ModifyVpnGateway_data);
            
            
            JObject _DeleteVpnGateway_query = new JObject();

                    

            HttpClientResponse DeleteVpnGateway_res = client.DeleteVpnGateway(_DeleteVpnGateway_query);
            JObject DeleteVpnGateway_data = DeleteVpnGateway_res.data;
            IRestResponse DeleteVpnGateway_response = DeleteVpnGateway_res.response;
            Console.WriteLine(DeleteVpnGateway_data);
            
            
            JObject _DescribeVpnGateways_query = new JObject();

                    

            HttpClientResponse DescribeVpnGateways_res = client.DescribeVpnGateways(_DescribeVpnGateways_query);
            JObject DescribeVpnGateways_data = DescribeVpnGateways_res.data;
            IRestResponse DescribeVpnGateways_response = DescribeVpnGateways_res.response;
            Console.WriteLine(DescribeVpnGateways_data);
            
            
            JObject _CreateVpnTunnel_query = new JObject();

                    
            JObject _CreateVpnTunnel_body = new JObject();

                    

            HttpClientResponse CreateVpnTunnel_res = client.CreateVpnTunnel(_CreateVpnTunnel_query,_CreateVpnTunnel_body);
            JObject CreateVpnTunnel_data = CreateVpnTunnel_res.data;
            IRestResponse CreateVpnTunnel_response = CreateVpnTunnel_res.response;
            Console.WriteLine(CreateVpnTunnel_data);
            
            
            JObject _ModifyVpnTunnel_query = new JObject();

                    

            HttpClientResponse ModifyVpnTunnel_res = client.ModifyVpnTunnel(_ModifyVpnTunnel_query);
            JObject ModifyVpnTunnel_data = ModifyVpnTunnel_res.data;
            IRestResponse ModifyVpnTunnel_response = ModifyVpnTunnel_res.response;
            Console.WriteLine(ModifyVpnTunnel_data);
            
            
            JObject _DeleteVpnTunnel_query = new JObject();

                    

            HttpClientResponse DeleteVpnTunnel_res = client.DeleteVpnTunnel(_DeleteVpnTunnel_query);
            JObject DeleteVpnTunnel_data = DeleteVpnTunnel_res.data;
            IRestResponse DeleteVpnTunnel_response = DeleteVpnTunnel_res.response;
            Console.WriteLine(DeleteVpnTunnel_data);
            
            
            JObject _DescribeVpnTunnels_query = new JObject();

                    

            HttpClientResponse DescribeVpnTunnels_res = client.DescribeVpnTunnels(_DescribeVpnTunnels_query);
            JObject DescribeVpnTunnels_data = DescribeVpnTunnels_res.data;
            IRestResponse DescribeVpnTunnels_response = DescribeVpnTunnels_res.response;
            Console.WriteLine(DescribeVpnTunnels_data);
            
            
            JObject _CreateCustomerGateway_query = new JObject();

                    

            HttpClientResponse CreateCustomerGateway_res = client.CreateCustomerGateway(_CreateCustomerGateway_query);
            JObject CreateCustomerGateway_data = CreateCustomerGateway_res.data;
            IRestResponse CreateCustomerGateway_response = CreateCustomerGateway_res.response;
            Console.WriteLine(CreateCustomerGateway_data);
            
            
            JObject _ModifyCustomerGateway_query = new JObject();

                    

            HttpClientResponse ModifyCustomerGateway_res = client.ModifyCustomerGateway(_ModifyCustomerGateway_query);
            JObject ModifyCustomerGateway_data = ModifyCustomerGateway_res.data;
            IRestResponse ModifyCustomerGateway_response = ModifyCustomerGateway_res.response;
            Console.WriteLine(ModifyCustomerGateway_data);
            
            
            JObject _DeleteCustomerGateway_query = new JObject();

                    

            HttpClientResponse DeleteCustomerGateway_res = client.DeleteCustomerGateway(_DeleteCustomerGateway_query);
            JObject DeleteCustomerGateway_data = DeleteCustomerGateway_res.data;
            IRestResponse DeleteCustomerGateway_response = DeleteCustomerGateway_res.response;
            Console.WriteLine(DeleteCustomerGateway_data);
            
            
            JObject _DescribeCustomerGateways_query = new JObject();

                    

            HttpClientResponse DescribeCustomerGateways_res = client.DescribeCustomerGateways(_DescribeCustomerGateways_query);
            JObject DescribeCustomerGateways_data = DescribeCustomerGateways_res.data;
            IRestResponse DescribeCustomerGateways_response = DescribeCustomerGateways_res.response;
            Console.WriteLine(DescribeCustomerGateways_data);
            
            
            JObject _DescribeTunnels_query = new JObject();

                    

            HttpClientResponse DescribeTunnels_res = client.DescribeTunnels(_DescribeTunnels_query);
            JObject DescribeTunnels_data = DescribeTunnels_res.data;
            IRestResponse DescribeTunnels_response = DescribeTunnels_res.response;
            Console.WriteLine(DescribeTunnels_data);
            
            
            JObject _ModifyTunnel_query = new JObject();

                    

            HttpClientResponse ModifyTunnel_res = client.ModifyTunnel(_ModifyTunnel_query);
            JObject ModifyTunnel_data = ModifyTunnel_res.data;
            IRestResponse ModifyTunnel_response = ModifyTunnel_res.response;
            Console.WriteLine(ModifyTunnel_data);
            
            
            JObject _AssociateSubnet_query = new JObject();

                    

            HttpClientResponse AssociateSubnet_res = client.AssociateSubnet(_AssociateSubnet_query);
            JObject AssociateSubnet_data = AssociateSubnet_res.data;
            IRestResponse AssociateSubnet_response = AssociateSubnet_res.response;
            Console.WriteLine(AssociateSubnet_data);
            
            
            JObject _DisassociateSubnet_query = new JObject();

                    

            HttpClientResponse DisassociateSubnet_res = client.DisassociateSubnet(_DisassociateSubnet_query);
            JObject DisassociateSubnet_data = DisassociateSubnet_res.data;
            IRestResponse DisassociateSubnet_response = DisassociateSubnet_res.response;
            Console.WriteLine(DisassociateSubnet_data);
            
            
            JObject _AssociateRemoteCidr_query = new JObject();

                    

            HttpClientResponse AssociateRemoteCidr_res = client.AssociateRemoteCidr(_AssociateRemoteCidr_query);
            JObject AssociateRemoteCidr_data = AssociateRemoteCidr_res.data;
            IRestResponse AssociateRemoteCidr_response = AssociateRemoteCidr_res.response;
            Console.WriteLine(AssociateRemoteCidr_data);
            
            
            JObject _DisassociateRemoteCidr_query = new JObject();

                    

            HttpClientResponse DisassociateRemoteCidr_res = client.DisassociateRemoteCidr(_DisassociateRemoteCidr_query);
            JObject DisassociateRemoteCidr_data = DisassociateRemoteCidr_res.data;
            IRestResponse DisassociateRemoteCidr_response = DisassociateRemoteCidr_res.response;
            Console.WriteLine(DisassociateRemoteCidr_data);
            
        }
    }

}