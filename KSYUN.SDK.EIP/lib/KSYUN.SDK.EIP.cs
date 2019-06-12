using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using KSYUN.SDK.EIP.HttpClient;
using KSYUN.SDK.EIP.HttpClient.Signature;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using RestSharp;


using KSYUN.SDK.EIP.Model.RegionList.query;
using KSYUN.SDK.EIP.Model.GetLines.query;
using KSYUN.SDK.EIP.Model.AllocateAddress.query;
using KSYUN.SDK.EIP.Model.ReleaseAddress.query;
using KSYUN.SDK.EIP.Model.AssociateAddress.query;
using KSYUN.SDK.EIP.Model.DisassociateAddress.query;
using KSYUN.SDK.EIP.Model.DescribeAddresses.query;
using KSYUN.SDK.EIP.Model.ModifyAddress.query;

namespace KSYUN.SDK.EIP
{
    class KsyunEipClient
    {
        public string baseurl;
        public string region;
        public string protocol;
        public string server;
        public string ak;
        public string sk;
        public KsyunEipClient (
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
            server = "eip";
            _parameters.Add("server","eip");
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


        public HttpClientResponse RegionList(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"RegionList\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new RegionListqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse GetLines(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"GetLines\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new GetLinesqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse AllocateAddress(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"AllocateAddress\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new AllocateAddressqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ReleaseAddress(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"ReleaseAddress\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ReleaseAddressqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse AssociateAddress(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"AssociateAddress\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new AssociateAddressqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DisassociateAddress(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"DisassociateAddress\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DisassociateAddressqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DescribeAddresses(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"DescribeAddresses\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DescribeAddressesqueryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyAddress(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"ModifyAddress\",\"Version\":\"2016-03-04\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyAddressqueryModel();
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