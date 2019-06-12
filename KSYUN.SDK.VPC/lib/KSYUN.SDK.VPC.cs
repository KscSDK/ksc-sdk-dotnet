using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using KSYUN.SDK.VPC.HttpClient;
using KSYUN.SDK.VPC.HttpClient.Signature;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using RestSharp;


using KSYUN.SDK.VPC.Model.CreateVpc.query;
using KSYUN.SDK.VPC.Model.DeleteVpc.query;
using KSYUN.SDK.VPC.Model.ModifyVpc.query;
using KSYUN.SDK.VPC.Model.DescribeVpcs.query;
using KSYUN.SDK.VPC.Model.CreateSubnet.query;
using KSYUN.SDK.VPC.Model.DeleteSubnet.query;
using KSYUN.SDK.VPC.Model.ModifySubnet.query;
using KSYUN.SDK.VPC.Model.DescribeSubnets.query;
using KSYUN.SDK.VPC.Model.AssociateNetworkAcl.query;
using KSYUN.SDK.VPC.Model.DisassociateNetworkAcl.query;
using KSYUN.SDK.VPC.Model.DescribeSubnetAvailableAddresses.query;
using KSYUN.SDK.VPC.Model.DescribeSubnetAllocatedIpAddresses.query;
using KSYUN.SDK.VPC.Model.CreateRoute.query;
using KSYUN.SDK.VPC.Model.DeleteRoute.query;
using KSYUN.SDK.VPC.Model.DescribeRoutes.query;
using KSYUN.SDK.VPC.Model.CreateNetworkAcl.query;
using KSYUN.SDK.VPC.Model.DeleteNetworkAcl.query;
using KSYUN.SDK.VPC.Model.ModifyNetworkAcl.query;
using KSYUN.SDK.VPC.Model.CreateNetworkAclEntry.query;
using KSYUN.SDK.VPC.Model.DeleteNetworkAclEntry.query;
using KSYUN.SDK.VPC.Model.ModifyNetworkAclEntry.query;
using KSYUN.SDK.VPC.Model.DescribeNetworkAcls.query;
using KSYUN.SDK.VPC.Model.CreateSecurityGroup.query;
using KSYUN.SDK.VPC.Model.DeleteSecurityGroup.query;
using KSYUN.SDK.VPC.Model.ModifySecurityGroup.query;
using KSYUN.SDK.VPC.Model.AuthorizeSecurityGroupEntry.query;
using KSYUN.SDK.VPC.Model.RevokeSecurityGroupEntry.query;
using KSYUN.SDK.VPC.Model.ModifySecurityGroupEntry.query;
using KSYUN.SDK.VPC.Model.DescribeSecurityGroups.query;
using KSYUN.SDK.VPC.Model.DescribeInternetGateways.query;
using KSYUN.SDK.VPC.Model.DescribeNetworkInterfaces.query;
using KSYUN.SDK.VPC.Model.CreateNat.query;
using KSYUN.SDK.VPC.Model.DeleteNat.query;
using KSYUN.SDK.VPC.Model.ModifyNat.query;
using KSYUN.SDK.VPC.Model.DescribeNats.query;
using KSYUN.SDK.VPC.Model.AssociateNat.query;
using KSYUN.SDK.VPC.Model.DisassociateNat.query;
using KSYUN.SDK.VPC.Model.CreateVpcPeeringConnection.query;
using KSYUN.SDK.VPC.Model.AcceptVpcPeeringConnection.query;
using KSYUN.SDK.VPC.Model.RejectVpcPeeringConnection.query;
using KSYUN.SDK.VPC.Model.DeleteVpcPeeringConnection.query;
using KSYUN.SDK.VPC.Model.ModifyVpcPeeringConnection.query;
using KSYUN.SDK.VPC.Model.DescribeVpcPeeringConnections.query;
using KSYUN.SDK.VPC.Model.AddNatIp.query;
using KSYUN.SDK.VPC.Model.DeleteNatIp.query;
using KSYUN.SDK.VPC.Model.AssociateDirectConnectGateway.query;
using KSYUN.SDK.VPC.Model.DisassociateDirectConnectGateway.query;
using KSYUN.SDK.VPC.Model.AssociateVpnGateway.query;
using KSYUN.SDK.VPC.Model.DisassociateVpnGateway.query;
using KSYUN.SDK.VPC.Model.DescribeAvailabilityZones.query;
using KSYUN.SDK.VPC.Model.DescribeDirectConnects.query;
using KSYUN.SDK.VPC.Model.CreateDirectConnectInterface.query;
using KSYUN.SDK.VPC.Model.ModifyDirectConnectInterface.query;
using KSYUN.SDK.VPC.Model.DeleteDirectConnectInterface.query;
using KSYUN.SDK.VPC.Model.DescribeDirectConnectInterfaces.query;
using KSYUN.SDK.VPC.Model.CreateDirectConnectGateway.query;
using KSYUN.SDK.VPC.Model.ModifyDirectConnectGateway.query;
using KSYUN.SDK.VPC.Model.DeleteDirectConnectGateway.query;
using KSYUN.SDK.VPC.Model.DescribeDirectConnectGateways.query;
using KSYUN.SDK.VPC.Model.AttachDirectConnectGateway.query;
using KSYUN.SDK.VPC.Model.DetachDirectConnectGateway.query;
using KSYUN.SDK.VPC.Model.CreateVpnGateway.query;
using KSYUN.SDK.VPC.Model.ModifyVpnGateway.query;
using KSYUN.SDK.VPC.Model.DeleteVpnGateway.query;
using KSYUN.SDK.VPC.Model.DescribeVpnGateways.query;
using KSYUN.SDK.VPC.Model.CreateVpnTunnel.query;
using KSYUN.SDK.VPC.Model.CreateVpnTunnel.body;
using KSYUN.SDK.VPC.Model.ModifyVpnTunnel.query;
using KSYUN.SDK.VPC.Model.DeleteVpnTunnel.query;
using KSYUN.SDK.VPC.Model.DescribeVpnTunnels.query;
using KSYUN.SDK.VPC.Model.CreateCustomerGateway.query;
using KSYUN.SDK.VPC.Model.ModifyCustomerGateway.query;
using KSYUN.SDK.VPC.Model.DeleteCustomerGateway.query;
using KSYUN.SDK.VPC.Model.DescribeCustomerGateways.query;
using KSYUN.SDK.VPC.Model.DescribeTunnels.query;
using KSYUN.SDK.VPC.Model.ModifyTunnel.query;
using KSYUN.SDK.VPC.Model.AssociateSubnet.query;
using KSYUN.SDK.VPC.Model.DisassociateSubnet.query;
using KSYUN.SDK.VPC.Model.AssociateRemoteCidr.query;
using KSYUN.SDK.VPC.Model.DisassociateRemoteCidr.query;

namespace KSYUN.SDK.VPC
{
    class KsyunVpcClient
    {
        public string baseurl;
        public string region;
        public string protocol;
        public string server;
        public string ak;
        public string sk;
        public KsyunVpcClient (
        string _region,
        string _protocol,
        string _ak,
        string _sk
        )
        {
            
            Dictionary<string,string> _parameters= new Dictionary<string,string>();
            region = _region;
            _parameters.Add("region",_region);
            protocol = _protocol;
            string[] protocol_enum = new string[] {"http","https"};
            if(Array.IndexOf(protocol_enum, _protocol) < 0){
                throw new System.ArgumentException("_protocol must be One of the " + String.Join(";", protocol_enum));
            }
            _parameters.Add("protocol",_protocol);
            server = "vpc";
            _parameters.Add("server","vpc");
            Regex myRegex = new Regex(@"{(.*?)}");
            baseurl = myRegex.Replace(@"{protocol}://{server}.{region}.api.ksyun.com", match => RegexReadTerm(match, _parameters));
            ak = _ak;
            sk = _sk;
        }
        private string RegexReadTerm(Match m, Dictionary<string,string> _parameters)
        {
            string value = m.Groups[1].Value;

            string res = value;
            if (_parameters.ContainsKey(value))
            {
                res = _parameters[value].ToString();
            }

            return res;
        }


        public HttpClientResponse CreateVpc(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"CreateVpc\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new CreateVpcqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DeleteVpc(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DeleteVpc\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DeleteVpcqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyVpc(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ModifyVpc\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyVpcqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeVpcs(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeVpcs\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeVpcsqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse CreateSubnet(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"CreateSubnet\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new CreateSubnetqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DeleteSubnet(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DeleteSubnet\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DeleteSubnetqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifySubnet(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ModifySubnet\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifySubnetqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeSubnets(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeSubnets\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeSubnetsqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse AssociateNetworkAcl(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"AssociateNetworkAcl\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new AssociateNetworkAclqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DisassociateNetworkAcl(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DisassociateNetworkAcl\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DisassociateNetworkAclqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeSubnetAvailableAddresses(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeSubnetAvailableAddresses\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeSubnetAvailableAddressesqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeSubnetAllocatedIpAddresses(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeSubnetAllocatedIpAddresses\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeSubnetAllocatedIpAddressesqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse CreateRoute(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\",\"RouteType\":\"InternetGateway\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"CreateRoute\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new CreateRoutequeryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DeleteRoute(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DeleteRoute\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DeleteRoutequeryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeRoutes(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeRoutes\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeRoutesqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse CreateNetworkAcl(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"CreateNetworkAcl\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new CreateNetworkAclqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DeleteNetworkAcl(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DeleteNetworkAcl\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DeleteNetworkAclqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyNetworkAcl(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ModifyNetworkAcl\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyNetworkAclqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse CreateNetworkAclEntry(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"CreateNetworkAclEntry\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new CreateNetworkAclEntryqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DeleteNetworkAclEntry(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DeleteNetworkAclEntry\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DeleteNetworkAclEntryqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyNetworkAclEntry(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ModifyNetworkAclEntry\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyNetworkAclEntryqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeNetworkAcls(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeNetworkAcls\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeNetworkAclsqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse CreateSecurityGroup(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\",\"SecurityGroupName\":\"Ksc_SecurityGroup\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"CreateSecurityGroup\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new CreateSecurityGroupqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DeleteSecurityGroup(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DeleteSecurityGroup\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DeleteSecurityGroupqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifySecurityGroup(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ModifySecurityGroup\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifySecurityGroupqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse AuthorizeSecurityGroupEntry(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"AuthorizeSecurityGroupEntry\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new AuthorizeSecurityGroupEntryqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse RevokeSecurityGroupEntry(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"RevokeSecurityGroupEntry\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new RevokeSecurityGroupEntryqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifySecurityGroupEntry(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ModifySecurityGroupEntry\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifySecurityGroupEntryqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeSecurityGroups(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeSecurityGroups\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeSecurityGroupsqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeInternetGateways(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeInternetGateways\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeInternetGatewaysqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeNetworkInterfaces(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeNetworkInterfaces\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeNetworkInterfacesqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse CreateNat(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\",\"NatName\":\"Ksc_Nat\",\"NatIpNumber\":1}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"CreateNat\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new CreateNatqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DeleteNat(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DeleteNat\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DeleteNatqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyNat(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ModifyNat\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyNatqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeNats(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeNats\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeNatsqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse AssociateNat(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"AssociateNat\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new AssociateNatqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DisassociateNat(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DisassociateNat\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DisassociateNatqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse CreateVpcPeeringConnection(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"CreateVpcPeeringConnection\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new CreateVpcPeeringConnectionqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse AcceptVpcPeeringConnection(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"AcceptVpcPeeringConnection\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new AcceptVpcPeeringConnectionqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse RejectVpcPeeringConnection(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"RejectVpcPeeringConnection\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new RejectVpcPeeringConnectionqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DeleteVpcPeeringConnection(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DeleteVpcPeeringConnection\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DeleteVpcPeeringConnectionqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyVpcPeeringConnection(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ModifyVpcPeeringConnection\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyVpcPeeringConnectionqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeVpcPeeringConnections(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeVpcPeeringConnections\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeVpcPeeringConnectionsqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse AddNatIp(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"AddNatIp\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new AddNatIpqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DeleteNatIp(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DeleteNatIp\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DeleteNatIpqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse AssociateDirectConnectGateway(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"AssociateDirectConnectGateway\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new AssociateDirectConnectGatewayqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DisassociateDirectConnectGateway(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DisassociateDirectConnectGateway\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DisassociateDirectConnectGatewayqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse AssociateVpnGateway(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"AssociateVpnGateway\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new AssociateVpnGatewayqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DisassociateVpnGateway(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DisassociateVpnGateway\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DisassociateVpnGatewayqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeAvailabilityZones(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeAvailabilityZones\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeAvailabilityZonesqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeDirectConnects(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeDirectConnects\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeDirectConnectsqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse CreateDirectConnectInterface(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"CreateDirectConnectInterface\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new CreateDirectConnectInterfacequeryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyDirectConnectInterface(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ModifyDirectConnectInterface\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyDirectConnectInterfacequeryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DeleteDirectConnectInterface(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DeleteDirectConnectInterface\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DeleteDirectConnectInterfacequeryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeDirectConnectInterfaces(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeDirectConnectInterfaces\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeDirectConnectInterfacesqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse CreateDirectConnectGateway(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"CreateDirectConnectGateway\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new CreateDirectConnectGatewayqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyDirectConnectGateway(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ModifyDirectConnectGateway\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyDirectConnectGatewayqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DeleteDirectConnectGateway(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DeleteDirectConnectGateway\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DeleteDirectConnectGatewayqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeDirectConnectGateways(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeDirectConnectGateways\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeDirectConnectGatewaysqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse AttachDirectConnectGateway(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"AttachDirectConnectGateway\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new AttachDirectConnectGatewayqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DetachDirectConnectGateway(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DetachDirectConnectGateway\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DetachDirectConnectGatewayqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse CreateVpnGateway(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\",\"VpnGatewayName\":\"Ksc_Vpn\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"CreateVpnGateway\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new CreateVpnGatewayqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyVpnGateway(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ModifyVpnGateway\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyVpnGatewayqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DeleteVpnGateway(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DeleteVpnGateway\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DeleteVpnGatewayqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeVpnGateways(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeVpnGateways\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeVpnGatewaysqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse CreateVpnTunnel(JObject _query , JObject _body )
        {
            string _url = baseurl + "/";
            string _method = "post";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();

            string _query_default_string = "{\"version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"action\":\"CreateVpnTunnel\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new CreateVpnTunnelqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }
            string _body_default_string = "{\"VpnTunnelName\":\"Ksc_vpn_tunnel\",\"IkeAuthenAlgorithm\":\"md5\",\"IkeDHGroup\":1,\"IkeEncryAlgorithm\":\"aes\",\"IpsecEncryAlgorithm\":\"esp-aes\",\"IpsecAuthenAlgorithm\":\"esp-sha-hmac\"}";
            JObject _body_default = JObject.Parse(_body_default_string);
            _body_default.Merge(_body);
            _body = _body_default;

            string _body_fixed_string = "{}";
            JObject _body_fixed = JObject.Parse(_body_fixed_string);
            _body.Merge(_body_fixed);

            var _bodyModel = new CreateVpnTunnelbodyModel();
            var _bodyvalid = _bodyModel.validtor(_body);

            if(_bodyvalid.status != true){
               throw new System.ArgumentException(_bodyvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);

            _instance.setContentType("urlencoded");

            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyVpnTunnel(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ModifyVpnTunnel\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyVpnTunnelqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DeleteVpnTunnel(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DeleteVpnTunnel\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DeleteVpnTunnelqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeVpnTunnels(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeVpnTunnels\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeVpnTunnelsqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse CreateCustomerGateway(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"CreateCustomerGateway\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new CreateCustomerGatewayqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyCustomerGateway(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ModifyCustomerGateway\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyCustomerGatewayqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DeleteCustomerGateway(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DeleteCustomerGateway\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DeleteCustomerGatewayqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeCustomerGateways(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeCustomerGateways\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeCustomerGatewaysqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeTunnels(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeTunnels\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeTunnelsqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyTunnel(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ModifyTunnel\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyTunnelqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse AssociateSubnet(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"AssociateSubnet\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new AssociateSubnetqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DisassociateSubnet(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DisassociateSubnet\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DisassociateSubnetqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse AssociateRemoteCidr(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"AssociateRemoteCidr\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new AssociateRemoteCidrqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DisassociateRemoteCidr(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DisassociateRemoteCidr\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DisassociateRemoteCidrqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
    }
}