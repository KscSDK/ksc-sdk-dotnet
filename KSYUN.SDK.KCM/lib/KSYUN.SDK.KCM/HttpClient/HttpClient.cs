using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using KSYUN.SDK.KCM.HttpClient.Signature;
using System;
using System.Web;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Text;
namespace KSYUN.SDK.KCM.HttpClient
{
    public struct HttpClientResponse
    {
        public IRestResponse response;
        public JObject data;
    }
    public class HttpClientCore
    {
        public UriBuilder address;
        public Method method;
        public string methodString;
        public Dictionary<string, string> headers;
        public string queries;
        public JToken requestBodies;

        public string contentType;
        public string authType;

        public string AK;
        public string SK;
        public string Service;
        public string Region;
        public string payload;
        public RestClient client;
        public HttpClientCore(string _address, string _method, JObject _headers, JObject _params, JObject _queries, JObject _requestBodies)
        {
            var _objRequestBodies = _requestBodies as JToken;
            HttpClientCoreMethod(_address, _method, _headers, _params, _queries, _objRequestBodies);
        }
        public HttpClientCore(string _address, string _method, JObject _headers, JObject _params, JObject _queries, JArray _requestBodies)
        {
            var _objRequestBodies = _requestBodies as JToken;
            HttpClientCoreMethod(_address, _method, _headers, _params, _queries, _objRequestBodies);
        }
        public HttpClientCore(string _address, string _method, JObject _headers, JObject _params, JObject _queries, JValue _requestBodies)
        {
            var _objRequestBodies = _requestBodies as JToken;
            HttpClientCoreMethod(_address, _method, _headers, _params, _queries, _objRequestBodies);
        }
        public void HttpClientCoreMethod(string _address, string _method, JObject _headers, JObject _params, JObject _queries, JToken _requestBodies)
        {
            methodString = _method;
            method = methodGenerator(_method);
            queries = queriesGenerator(_queries);
            address = addressGenerator(_address, _params, _queries);
            headers = headersGenerator(_headers);
            reInitHeaders();
            requestBodies = _requestBodies;
            contentType = "urlencoded";
            payload = "";
            authType = "";
            AK = "";
            SK = "";
            Service = "";
            Region = "";
            client = new RestClient();
        }
        private JObject _flatten(JObject _res, JObject _data, string _key)
        {
            foreach (var item in _data)
            {
                string _innerKey = item.Key.ToString();
                string _newkey = _key != "" ? _key + "." + _innerKey : _innerKey;

                if (item.Value.Type == JTokenType.Array)
                {
                    JArray _array = item.Value as JArray;
                    _flatten(_res, _array, _newkey);
                }
                else if (item.Value.Type == JTokenType.Object)
                {
                    JObject _obj = item.Value as JObject;
                    _flatten(_res, _obj, _newkey);
                }
                else
                {
                    JToken _token = item.Value as JToken;
                    _flatten(_res, _token, _newkey);
                }

            }
            return _res;
        }
        private JObject _flatten(JObject _res, JArray _data, string _key)
        {
            int i = 0;
            foreach (var item in _data.Children())
            {
                i++;
                string _innerKey = i.ToString();
                string _newkey = _key != "" ? _key + "." + _innerKey : _innerKey;

                if (item.Type == JTokenType.Array)
                {
                    JArray _array = item as JArray;
                    _flatten(_res, _array, _newkey);
                }
                else if (item.Type == JTokenType.Object)
                {
                    JObject _obj = item as JObject;
                    _flatten(_res, _obj, _newkey);
                }
                else
                {
                    JToken _token = item as JToken;
                    _flatten(_res, _token, _newkey);
                }
            }
            return _res;
        }
        private JObject _flatten(JObject _res, JToken _data, string _key)
        {
            _res.Add(_key, _data);
            return _res;
        }
        private JObject flatten(JObject _data)
        {
            JObject res = _flatten(new JObject(), _data, "");
            return res;
        }

        private JToken flatten(JToken _data)
        {
            if (_data.Type == JTokenType.Object)
            {
                JObject res = flatten(_data as JObject);
                return  res as JToken;
            }
            else
            {
                JObject res =  new JObject(new JProperty("data", _data));
                return res as JToken;
            }
        }
        public void setAwsAuthType(string _ak, string _sk, string _service, string _region)
        {
            authType = "awsv4";
            AK = _ak;
            SK = _sk;
            Service = _service;
            Region = _region;
        }
        public void setContentType(string _contentType)
        {
            contentType = _contentType;
        }
        private string objectToQuerystring(JObject _data)
        {
            Dictionary<string, string> res = _data.ToObject<Dictionary<string, string>>();
            NameValueCollection parameters = new NameValueCollection(res.Count);
            foreach (var k in res)
            {
                parameters.Add(k.Key, k.Value);
            }
            return ToQueryString(parameters);
        }
        private string queriesGenerator(JObject _query)
        {
            return objectToQuerystring(flatten(_query));
        }
        private Method methodGenerator(string _method)
        {
            _method = _method.ToUpperInvariant();
            if (_method == "GET")
            {
                return Method.GET;
            }
            else if (_method == "POST")
            {
                return Method.POST;
            }
            else if (_method == "PUT")
            {
                return Method.PUT;
            }
            else if (_method == "DELETE")
            {
                return Method.DELETE;
            }
            else if (_method == "HEAD")
            {
                return Method.HEAD;
            }
            else if (_method == "OPTIONS")
            {
                return Method.OPTIONS;
            }
            else if (_method == "PATCH")
            {
                return Method.PATCH;
            }
            else if (_method == "MERGE")
            {
                return Method.MERGE;
            }
            else if (_method == "COPY")
            {
                return Method.COPY;
            }
            else
            {
                return Method.GET;
            }
        }
        private Dictionary<string, string> headersGenerator(JObject _headers)
        {
            Dictionary<string, string> res = _headers.ToObject<Dictionary<string, string>>();
            return res;
        }
        private void reAddHeader(string key, string value, bool keep)
        {
            var i_value = "";
            foreach (var item in headers)
            {
                if (item.Key.ToLower() == key.ToLower())
                {
                    headers.Remove(item.Key);
                    i_value = item.Value;
                }
            }
            if (i_value != "" && keep == true)
            {
                headers.Add(key, i_value);
            }
            else
            {
                headers.Add(key, value);
            }
        }
        private void reAddHeader(string key, string value)
        {
            reAddHeader(key, value, false);
        }
        private void reInitHeaders()
        {
            reAddHeader("X-KSC-From", "CSharp-SDK");
            reAddHeader("Accept", "application/json");
            reAddHeader("Host", address.Host, true);
        }
        private string RegexReadTerm(Match m, JObject _parameters)
        {
            string value = m.Groups[1].Value;

            string res = value;
            if (_parameters.ContainsKey(value))
            {
                res = _parameters[value].ToString();
            }

            return res;
        }
        private string formdataGenerator(JToken _data)
        {
            Dictionary<string, string> res = (_data as JObject).ToObject<Dictionary<string, string>>();
            MultipartFormDataContent form = new MultipartFormDataContent();
            foreach (var k in res)
            {
                // Console.WriteLine(k.Value+k.Key);
                form.Add(new StringContent(k.Value), k.Key);
            }
            reAddHeader("Content-Type", form.Headers.ContentType.ToString());
            var _payload = form.ReadAsStringAsync().Result.ToString();
            reAddHeader("Content-Length", _payload.Length.ToString());
            return _payload;
        }
        private string urlencodedGenerator(JToken _data)
        {
            reAddHeader("Content-Type", "application/x-www-form-urlencoded");
            var _payload = objectToQuerystring(_data as JObject);
            reAddHeader("Content-Length", _payload.Length.ToString());
            return _payload;
        }
        private string jsonGenerator(JToken _data)
        {
            var _payload = "";
            reAddHeader("Content-Type", "application/json");

            if(_data.Type != JTokenType.Array && _data.Type != JTokenType.Object){
                _payload = _data.ToString();
                return _payload;
            }
            if (_data.Type == JTokenType.Object && requestBodies.HasValues == false)
            {
                _payload = "";
            }
            else
            {
                _payload = _data.ToString();
            }
            reAddHeader("Content-Length", _payload.Length.ToString());
            return _payload;
        }
        private void payloadGenerator()
        {
            if(method == Method.GET){
                return;
            }
            if (contentType == "json")
            {
                payload = jsonGenerator(requestBodies);
            }
            else if (contentType == "formdata")
            {
                payload = formdataGenerator(flatten(requestBodies));
            }
            else if (contentType == "urlencoded")
            {
                payload = urlencodedGenerator(flatten(requestBodies));
            }else {
                var _payload = requestBodies.ToString();
                reAddHeader("Content-Length", _payload.Length.ToString());
                payload = _payload;
            }
        }
        public string ToQueryString(NameValueCollection nvc)
        {
            if (nvc == null) return string.Empty;

            StringBuilder sb = new StringBuilder();

            foreach (string key in nvc.Keys)
            {
                if (string.IsNullOrWhiteSpace(key)) continue;

                string[] values = nvc.GetValues(key);
                if (values == null) continue;

                foreach (string value in values)
                {
                    sb.Append(sb.Length == 0 ? "" : "&");
                    sb.AppendFormat("{0}={1}", Uri.EscapeDataString(key), Uri.EscapeDataString(value));
                }
            }

            return sb.ToString();
        }
        private UriBuilder addressGenerator(string _address, JObject _parameters, JObject _queries)
        {
            Regex myRegex = new Regex(@"{(.*?)}");

            _address = myRegex.Replace(_address, match => RegexReadTerm(match, _parameters));

            // Console.WriteLine(_address);

            UriBuilder uriBuilder = new UriBuilder(_address);

            uriBuilder.Query = queries;

            return uriBuilder;
        }
        private void attachedAuth()
        {
            if (authType == "awsv4")
            {
                // Console.WriteLine("=============");
                // Console.WriteLine(Region);
                // Console.WriteLine(Service);
                // Console.WriteLine(methodString);
                // Console.WriteLine(address.Path);
                // Console.WriteLine(headers.Keys.ToString());
                // Console.WriteLine(queries.ToString());
                // Console.WriteLine(payload);
                // Console.WriteLine("=============");
                AwsV4 Sign = new AwsV4(
                    AK,
                    SK,
                    Region,
                    Service,
                    methodString.ToUpper(),
                    address.Path,
                    headers,
                    queries,
                    payload
                );
                AwsV4.SignerStruct aws = Sign.Signer();
                reAddHeader("Authorization", aws.Authorization);
                reAddHeader("X-Amz-Date", aws.Time);
            }
        }
        public HttpClientResponse request()
        {
            IRestRequest request = new RestRequest(address.ToString(), method);
            request.Timeout = 6000;
            payloadGenerator();
            attachedAuth();
            foreach (var header in headers)
            {
                // Console.WriteLine(header.Key + "=" + header.Value);
                request.AddHeader(header.Key, header.Value);
            }

            request.AddParameter("", payload, ParameterType.RequestBody);

            var response = client.Execute(request);
            var res = new HttpClientResponse();
            res.response = response;

            if (!response.IsSuccessful)
            {
                throw new System.SystemException("request error status : " + response.StatusCode + "; messages : " + response.ErrorMessage + "; data : " + response.Content);
            }
            res.data = JObject.Parse(response.Content);
            return res;
        }
    }
}