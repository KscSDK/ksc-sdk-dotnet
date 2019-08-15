using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using KSYUN.SDK.SMS.HttpClient;
using KSYUN.SDK.SMS.HttpClient.Signature;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using RestSharp;


using KSYUN.SDK.SMS.Model.SendSms.query;
using KSYUN.SDK.SMS.Model.SendSms.body;
using KSYUN.SDK.SMS.Model.BatchSendSms.query;
using KSYUN.SDK.SMS.Model.BatchSendSms.body;

namespace KSYUN.SDK.SMS
{
    public class KsyunSMSClient
    {
        public string baseurl;
        public string region;
        public string protocol;
        public string server;
        public string ak;
        public string sk;
        public KsyunSMSClient (
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
            server = "ksms";
            _parameters.Add("server","ksms");
            Regex myRegex = new Regex(@"{(.*?)}");
            baseurl = myRegex.Replace(@"{protocol}://{server}.api.ksyun.com", match => RegexReadTerm(match, _parameters));
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


        public HttpClientResponse SendSms(JObject _query,JObject _body)
        {
            string _url = baseurl + "/";
            string _method = "post";
            var _params = new JObject();
            var _headers = new JObject();
            var _cookie = new JObject();

            
            string _query_default_string = "{\"Version\":\"2019-05-01\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"SendSms\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new SendSmsqueryModel();
            var _queryvalid = _queryModel.validtor(_query as JToken);

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

            var _bodyModel = new SendSmsbodyModel();
            var _bodyvalid = _bodyModel.validtor(_body as JToken);

            if(_bodyvalid.status != true){
               throw new System.ArgumentException(_bodyvalid.message); 
            }



            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);

            _instance.setContentType("urlencoded");

            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
        public HttpClientResponse BatchSendSms(JObject _query,JObject _body)
        {
            string _url = baseurl + "/";
            string _method = "post";
            var _params = new JObject();
            var _headers = new JObject();
            var _cookie = new JObject();

            
            string _query_default_string = "{\"Version\":\"2019-05-01\"}";
            JObject _query_default = JObject.Parse(_query_default_string);
            _query_default.Merge(_query);
            _query = _query_default;

            string _query_fixed_string = "{\"Action\":\"BatchSendSms\"}";
            JObject _query_fixed = JObject.Parse(_query_fixed_string);
            _query.Merge(_query_fixed);

            var _queryModel = new BatchSendSmsqueryModel();
            var _queryvalid = _queryModel.validtor(_query as JToken);

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

            var _bodyModel = new BatchSendSmsbodyModel();
            var _bodyvalid = _bodyModel.validtor(_body as JToken);

            if(_bodyvalid.status != true){
               throw new System.ArgumentException(_bodyvalid.message); 
            }



            HttpClientCore _instance = new HttpClientCore(_url, _method, _headers, _params, _query, _body);

            _instance.setContentType("urlencoded");

            _instance.setAwsAuthType(ak, sk, server, region);
            return _instance.request();
        }
    }
}