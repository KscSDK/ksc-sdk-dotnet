using System;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using System.Web;
using System.Linq;

namespace KSYUN.SDK.KCM.HttpClient.Signature
{
    public class AwsV4
    {
        protected string ak;
        protected string sk;
        protected string region;
        protected string service;
        protected string method;
        protected string uri;
        protected Dictionary<string, string> headers;
        protected string query;
        protected string body;
        private readonly SHA256 _sha256;
        public AwsV4(string _ak, string _sk, string _region, string _service, string _method, string _uri, Dictionary<string, string> _headers, string _query, string _body)
        {
            ak = _ak;
            sk = _sk;
            region = _region;
            service = _service;
            method = _method;
            uri = _uri;
            headers = _headers;
            query = _query;
            body = _body;
            _sha256 = SHA256.Create();
        }
        private string ToHexString(byte[] array)
        {
            var hex = new StringBuilder(array.Length * 2);
            foreach (byte b in array)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }
        private byte[] sign(byte[] key, string data)
        {
            var hashAlgorithm = new HMACSHA256(key);
            return hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(data));
        }
        private string hexEncodeHash(byte[] bytesToHash)
        {
            var result = _sha256.ComputeHash(bytesToHash);
            return ToHexString(result);
        }
        private string hexEncodeHash(string text)
        {
            var result = _sha256.ComputeHash(Encoding.UTF8.GetBytes(text.ToString()));
            return ToHexString(result);
        }
        private string createCanonicalURI(string uri)
        {
            if (uri.StartsWith("/"))
            {
                return uri;
            }
            else
            {
                return String.Concat("/", uri);
            }
        }
        public string toStartHex(string _data, bool fenge)
        {
            var bytes = Encoding.GetEncoding("utf-8").GetBytes(_data);
            string str = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                str += string.Format("{0:X}", bytes[i]);
                if (fenge && (i != bytes.Length - 1))
                {
                    str += string.Format("{0}", ",");
                }
            }
            return str.ToLower();
        }
        public string getCanonicalQueryParams(string query)
        {
            var querystring = HttpUtility.ParseQueryString(query);
            var keys = querystring.AllKeys;
            Array.Sort(keys, (a, b) =>
            {
                return String.Compare(toStartHex(a, false), toStartHex(b, false));
            });
            // Query params must be escaped in upper case (i.e. "%2C", not "%2c").
            var queryParams = keys.Select(key => $"{Uri.EscapeDataString(key)}={Uri.EscapeDataString(querystring[key])}");
            var canonicalQueryParams = string.Join("&", queryParams);
            return canonicalQueryParams;
        }
        private string computeSignature(string SK, string SubTime, string Region, string Service, string SignString, string AWS4_REQUEST)
        {
            byte[] kDate = sign(Encoding.UTF8.GetBytes("AWS4" + SK), SubTime);
            byte[] kRegion = sign(kDate, Region);
            byte[] kService = sign(kRegion, Service);
            byte[] kSigning = sign(kService, AWS4_REQUEST);
            return ToHexString(sign(kSigning, SignString));
        }
        private string canonicalHeader(Dictionary<string, string> Headers, string[] SignedHeaders)
        {
            List<string> canonical = new List<string>();
            foreach (string header in SignedHeaders)
            {
                canonical.Add(header + ":" + Headers[header]);
            }
            return String.Join("\n", canonical.ToArray()) + "\n";
        }
        private Dictionary<string, string> transHeaders(Dictionary<string, string> Headers)
        {
            Dictionary<String, String> res = new Dictionary<string, string>();
            foreach (string header in Headers.Keys)
            {
                res.Add(header.ToLowerInvariant().Trim(), Headers[header].Trim());
            }
            return res;
        }
        public struct SignerStruct
        {
            public string Authorization;
            public string Time;
        }
        public SignerStruct Signer()
        {
            string AWS4_REQUEST = "aws4_request";
            string Algorithm = "AWS4-HMAC-SHA256";

            var t = DateTimeOffset.UtcNow;

            string Time = t.ToString("yyyyMMddTHHmmssZ");
            // Time = "20190514T030223Z";

            string SubTime = Time.Substring(0, 8);

            string CredentialScope = String.Join("/", new string[] { SubTime, region, service, AWS4_REQUEST });

            Dictionary<string, string> AllHeaders = transHeaders(headers);
            if (AllHeaders.ContainsKey("x-amz-date"))
            {
                AllHeaders.Remove("x-amz-date");
            }
            AllHeaders.Add("x-amz-date", Time);

            string[] SignedHeaders = new string[AllHeaders.Keys.Count];
            AllHeaders.Keys.CopyTo(SignedHeaders, 0);

            if (Array.IndexOf(SignedHeaders, "host") < 0)
            {
                throw new System.ArgumentException("headers host must exist", "original");
            }

            Array.Sort(SignedHeaders, (a, b) =>
            {
                return String.Compare(a, b);
            });

            string CanonicalSignedHeaders = String.Join(";", SignedHeaders);

            string CanonicalRequest = String.Join("\n", new string[]{
                method.ToUpperInvariant(),
                createCanonicalURI(uri),
                getCanonicalQueryParams(query),
                canonicalHeader(AllHeaders, SignedHeaders),
                CanonicalSignedHeaders,
                hexEncodeHash(body)
            });


            string SignString = String.Join("\n", new string[]{
                Algorithm,
                Time,
                CredentialScope,
                hexEncodeHash(CanonicalRequest)
            });

            string Signature = computeSignature(
                sk,
                SubTime,
                region,
                service,
                SignString,
                AWS4_REQUEST
            );

            string Authorization = String.Join(", ", new string[]{
                Algorithm + " Credential=" + ak + "/" + CredentialScope,
                "SignedHeaders=" + CanonicalSignedHeaders,
                "Signature=" + Signature,
            });

            SignerStruct res = new SignerStruct();

            res.Authorization = Authorization;
            res.Time = Time;

            return res;
        }
    }
}