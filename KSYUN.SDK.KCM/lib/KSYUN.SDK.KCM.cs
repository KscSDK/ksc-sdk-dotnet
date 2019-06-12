using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using KSYUN.SDK.KCM.HttpClient;
using KSYUN.SDK.KCM.HttpClient.Signature;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using RestSharp;


using KSYUN.SDK.KCM.Model.DescribeCertificates.body;
using KSYUN.SDK.KCM.Model.CreateCertificate.query;
using KSYUN.SDK.KCM.Model.CreateCertificate.body;
using KSYUN.SDK.KCM.Model.DeleteCertificate.query;
using KSYUN.SDK.KCM.Model.ModifyCertificate.query;

namespace KSYUN.SDK.KCM
{
    public class KsyunKcmClient
    {
        public string baseurl;
        public string region;
        public string protocol;
        public string server;
        public string ak;
        public string sk;
        public KsyunKcmClient (
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
            server = "kcm";
            _parameters.Add("server","kcm");
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


        public HttpClientResponse DescribeCertificates(JObject _body )
        {
            string _url = baseurl + "/";
            string _method = "post";
            JObject _params = new JObject();
            JObject _headers = new JObject();
            JObject _query = new JObject();
            JObject _cookie = new JObject();

            string _body_default_string = "{\"Version\":\"2016-03-04\"}";
            JObject _body_default = JObject.Parse(_body_default_string);
            _body_default.Merge(_body);
            _body = _body_default;

            string _body_fixed_string = "{\"Action\":\"DescribeCertificates\"}";
            JObject _body_fixed = JObject.Parse(_body_fixed_string);
            _body.Merge(_body_fixed);

            var _bodyModel = new DescribeCertificatesbodyModel();
            var _bodyvalid = _bodyModel.validtor(_body);

            if(_bodyvalid.status != true){
               throw new System.ArgumentException(_bodyvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);

            _instance.setContentType("urlencoded");

            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse CreateCertificate(JObject _query , JObject _body )
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

            string _query_fixed_string = "{\"action\":\"CreateCertificate\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new CreateCertificatequeryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }
            string _body_default_string = "{}";
            JObject _body_default = JObject.Parse(_body_default_string);
            _body_default.Merge(_body);
            _body = _body_default;

            string _body_fixed_string = "{}";
            JObject _body_fixed = JObject.Parse(_body_fixed_string);
            _body.Merge(_body_fixed);

            var _bodyModel = new CreateCertificatebodyModel();
            var _bodyvalid = _bodyModel.validtor(_body);

            if(_bodyvalid.status != true){
               throw new System.ArgumentException(_bodyvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);

            _instance.setContentType("urlencoded");

            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse DeleteCertificate(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"DeleteCertificate\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new DeleteCertificatequeryModel();
            var _queryvalid = _queryModel.validtor(_query);

            if(_queryvalid.status != true){
               throw new System.ArgumentException(_queryvalid.message); 
            }

            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);


            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse ModifyCertificate(JObject _query )
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

            string _query_fixed_string = "{\"Action\":\"ModifyCertificate\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new ModifyCertificatequeryModel();
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