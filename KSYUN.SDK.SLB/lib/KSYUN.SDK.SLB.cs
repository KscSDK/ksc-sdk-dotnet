using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using KSYUN.SDK.SLB.HttpClient;
using KSYUN.SDK.SLB.HttpClient.Signature;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using RestSharp;


using KSYUN.SDK.SLB.Model.CreateLoadBalancer.query;
using KSYUN.SDK.SLB.Model.DeleteLoadBalancer.query;
using KSYUN.SDK.SLB.Model.ModifyLoadBalancer.query;
using KSYUN.SDK.SLB.Model.DescribeLoadBalancers.query;
using KSYUN.SDK.SLB.Model.CreateListeners.query;
using KSYUN.SDK.SLB.Model.ModifyListeners.query;
using KSYUN.SDK.SLB.Model.DeleteListeners.query;
using KSYUN.SDK.SLB.Model.DescribeListeners.query;
using KSYUN.SDK.SLB.Model.ConfigureHealthCheck.query;
using KSYUN.SDK.SLB.Model.ModifyHealthCheck.query;
using KSYUN.SDK.SLB.Model.DeleteHealthCheck.query;
using KSYUN.SDK.SLB.Model.DescribeHealthChecks.query;
using KSYUN.SDK.SLB.Model.RegisterInstancesWithListener.query;
using KSYUN.SDK.SLB.Model.ModifyInstancesWithListener.query;
using KSYUN.SDK.SLB.Model.DeregisterInstancesFromListener.query;
using KSYUN.SDK.SLB.Model.DescribeInstancesWithListener.query;
using KSYUN.SDK.SLB.Model.CreateLoadBalancerAcl.query;
using KSYUN.SDK.SLB.Model.DeleteLoadBalancerAcl.query;
using KSYUN.SDK.SLB.Model.ModifyLoadBalancerAcl.query;
using KSYUN.SDK.SLB.Model.DescribeLoadBalancerAcls.query;
using KSYUN.SDK.SLB.Model.CreateLoadBalancerAclEntry.query;
using KSYUN.SDK.SLB.Model.DeleteLoadBalancerAclEntry.query;
using KSYUN.SDK.SLB.Model.AssociateLoadBalancerAcl.query;
using KSYUN.SDK.SLB.Model.DisassociateLoadBalancerAcl.query;

namespace KSYUN.SDK.SLB
{
    public class KsyunSlbClient
    {
        public string baseurl;
        public string region;
        public string protocol;
        public string server;
        public string ak;
        public string sk;
        public KsyunSlbClient (
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
            server = "slb";
            _parameters.Add("server","slb");
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


        public HttpClientResponse CreateLoadBalancer(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"CreateLoadBalancer\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new CreateLoadBalancerqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DeleteLoadBalancer(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"DeleteLoadBalancer\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DeleteLoadBalancerqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyLoadBalancer(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\",\"LoadBalancerState\":\"start\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ModifyLoadBalancer\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyLoadBalancerqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeLoadBalancers(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\",\"State\":\"associate\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeLoadBalancers\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeLoadBalancersqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse CreateListeners(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\",\"ListenerState\":\"stat\",\"ListenerName\":\"ksc_listener\",\"ListenerProtocol\":\"HTTP\",\"Method\":\"RoundRobin\",\"SessionState\":\"start\",\"SessionPersistencePeriod\":3600,\"CookieType\":\"ImplantCookie\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"CreateListeners\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new CreateListenersqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyListeners(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\",\"ListenerState\":\"start\",\"SessionState\":\"start\",\"Method\":\"RoundRobin\",\"CookieType\":\"ImplantCookie\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ModifyListeners\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyListenersqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DeleteListeners(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"DeleteListeners\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DeleteListenersqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeListeners(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"DescribeListeners\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeListenersqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ConfigureHealthCheck(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\",\"HealthCheckState\":\"start\",\"IsDefaultHostName\":true}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ConfigureHealthCheck\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ConfigureHealthCheckqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyHealthCheck(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\",\"HealthCheckState\":\"start\",\"IsDefaultHostName\":true}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ModifyHealthCheck\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyHealthCheckqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DeleteHealthCheck(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"DeleteHealthCheck\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DeleteHealthCheckqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeHealthChecks(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"DescribeHealthChecks\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeHealthChecksqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse RegisterInstancesWithListener(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"RegisterInstancesWithListener\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new RegisterInstancesWithListenerqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyInstancesWithListener(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"ModifyInstancesWithListener\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyInstancesWithListenerqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DeregisterInstancesFromListener(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"DeregisterInstancesFromListener\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DeregisterInstancesFromListenerqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeInstancesWithListener(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"DescribeInstancesWithListener\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeInstancesWithListenerqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse CreateLoadBalancerAcl(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\",\"LoadBalancerAclName\":\"Ksc_LoadBalancerAcl\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"CreateLoadBalancerAcl\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new CreateLoadBalancerAclqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DeleteLoadBalancerAcl(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"DeleteLoadBalancerAcl\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DeleteLoadBalancerAclqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyLoadBalancerAcl(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"ModifyLoadBalancerAcl\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyLoadBalancerAclqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeLoadBalancerAcls(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"DescribeLoadBalancerAcls\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeLoadBalancerAclsqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse CreateLoadBalancerAclEntry(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"Version\":\"2016-03-04\",\"RuleAction\":\"allow\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"CreateLoadBalancerAclEntry\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new CreateLoadBalancerAclEntryqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DeleteLoadBalancerAclEntry(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"DeleteLoadBalancerAclEntry\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DeleteLoadBalancerAclEntryqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse AssociateLoadBalancerAcl(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"AssociateLoadBalancerAcl\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new AssociateLoadBalancerAclqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DisassociateLoadBalancerAcl(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"DisassociateLoadBalancerAcl\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DisassociateLoadBalancerAclqueryModel();
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