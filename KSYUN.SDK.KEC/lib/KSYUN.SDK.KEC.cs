using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using KSYUN.SDK.KEC.HttpClient;
using KSYUN.SDK.KEC.HttpClient.Signature;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using RestSharp;


using KSYUN.SDK.KEC.Model.RunInstances.query;
using KSYUN.SDK.KEC.Model.StartInstances.query;
using KSYUN.SDK.KEC.Model.StopInstances.query;
using KSYUN.SDK.KEC.Model.RebootInstances.query;
using KSYUN.SDK.KEC.Model.TerminateInstances.query;
using KSYUN.SDK.KEC.Model.ModifyInstanceImage.query;
using KSYUN.SDK.KEC.Model.ModifyInstanceType.query;
using KSYUN.SDK.KEC.Model.ModifyInstanceAttribute.query;
using KSYUN.SDK.KEC.Model.DescribeInstances.query;
using KSYUN.SDK.KEC.Model.DescribeInstanceVnc.query;
using KSYUN.SDK.KEC.Model.DescribeInstanceTypeConfigs.query;
using KSYUN.SDK.KEC.Model.DescribeInstanceFamilys.query;
using KSYUN.SDK.KEC.Model.MonitorInstances.query;
using KSYUN.SDK.KEC.Model.UnmonitorInstances.query;
using KSYUN.SDK.KEC.Model.AttachNetworkInterface.query;
using KSYUN.SDK.KEC.Model.ModifyNetworkInterfaceAttribute.query;
using KSYUN.SDK.KEC.Model.DetachNetworkInterface.query;
using KSYUN.SDK.KEC.Model.CreateImage.query;
using KSYUN.SDK.KEC.Model.DescribeImages.query;
using KSYUN.SDK.KEC.Model.RemoveImages.query;
using KSYUN.SDK.KEC.Model.ModifyImageAttribute.query;
using KSYUN.SDK.KEC.Model.ImportImage.query;
using KSYUN.SDK.KEC.Model.CopyImage.query;
using KSYUN.SDK.KEC.Model.DescribeImageSharePermission.query;
using KSYUN.SDK.KEC.Model.ModifyImageSharePermission.query;
using KSYUN.SDK.KEC.Model.CreateLocalVolumeSnapshot.query;
using KSYUN.SDK.KEC.Model.RollbackLocalVolume.query;
using KSYUN.SDK.KEC.Model.DescribeLocalVolumeSnapshots.query;
using KSYUN.SDK.KEC.Model.DeleteLocalVolumeSnapshot.query;
using KSYUN.SDK.KEC.Model.DescribeLocalVolumes.query;
using KSYUN.SDK.KEC.Model.AttachKey.query;
using KSYUN.SDK.KEC.Model.DetachKey.query;
using KSYUN.SDK.KEC.Model.DescribeRegions.query;
using KSYUN.SDK.KEC.Model.DescribeAvailabilityZones.query;

namespace KSYUN.SDK.KEC
{
    public class KsyunKecClient
    {
        public string baseurl;
        public string region;
        public string protocol;
        public string server;
        public string ak;
        public string sk;
        public KsyunKecClient (
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
            server = "kec";
            _parameters.Add("server","kec");
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


        public HttpClientResponse RunInstances(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"InstanceType\":\"I1.1A\",\"SystemDisk\":{}}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"RunInstances\",\"Version\":\"2016-03-04\",\"SystemDisk\":{}}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new RunInstancesqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse StartInstances(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"StartInstances\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new StartInstancesqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse StopInstances(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"StoppedMode\":\"KeepCharging\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"StopInstances\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new StopInstancesqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse RebootInstances(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"RebootInstances\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new RebootInstancesqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse TerminateInstances(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"TerminateInstances\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new TerminateInstancesqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyInstanceImage(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{\"SystemDisk\":{}}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ModifyInstanceImage\",\"Version\":\"2016-03-04\",\"SystemDisk\":{}}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyInstanceImagequeryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyInstanceType(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ModifyInstanceType\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyInstanceTypequeryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyInstanceAttribute(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ModifyInstanceAttribute\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyInstanceAttributequeryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeInstances(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeInstances\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeInstancesqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeInstanceVnc(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeInstanceVnc\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeInstanceVncqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeInstanceTypeConfigs(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeInstanceTypeConfigs\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeInstanceTypeConfigsqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeInstanceFamilys(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeInstanceFamilys\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeInstanceFamilysqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse MonitorInstances(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"MonitorInstances\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new MonitorInstancesqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse UnmonitorInstances(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"UnmonitorInstances\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new UnmonitorInstancesqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse AttachNetworkInterface(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"AttachNetworkInterface\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new AttachNetworkInterfacequeryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyNetworkInterfaceAttribute(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ModifyNetworkInterfaceAttribute\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyNetworkInterfaceAttributequeryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DetachNetworkInterface(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DetachNetworkInterface\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DetachNetworkInterfacequeryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse CreateImage(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"CreateImage\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new CreateImagequeryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeImages(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeImages\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeImagesqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse RemoveImages(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"RemoveImages\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new RemoveImagesqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyImageAttribute(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ModifyImageAttribute\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyImageAttributequeryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ImportImage(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ImportImage\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ImportImagequeryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse CopyImage(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"CopyImage\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new CopyImagequeryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeImageSharePermission(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeImageSharePermission\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeImageSharePermissionqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyImageSharePermission(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"ModifyImageSharePermission\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyImageSharePermissionqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse CreateLocalVolumeSnapshot(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"CreateLocalVolumeSnapshot\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new CreateLocalVolumeSnapshotqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse RollbackLocalVolume(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"RollbackLocalVolume\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new RollbackLocalVolumequeryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeLocalVolumeSnapshots(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeLocalVolumeSnapshots\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeLocalVolumeSnapshotsqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DeleteLocalVolumeSnapshot(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DeleteLocalVolumeSnapshot\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DeleteLocalVolumeSnapshotqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeLocalVolumes(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeLocalVolumes\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeLocalVolumesqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse AttachKey(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"AttachKey\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new AttachKeyqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DetachKey(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DetachKey\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DetachKeyqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeRegions(JObject _query )
        {
            string _url = baseurl + "/";
            string _method = "get";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _cookie = new JObject();
            JObject _body = new JObject();

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeRegions\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeRegionsqueryModel();
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

            string _query_default_string = "{}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"DescribeAvailabilityZones\",\"Version\":\"2016-03-04\"}";
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
    }
}