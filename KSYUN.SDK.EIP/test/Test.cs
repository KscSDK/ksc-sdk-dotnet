using KSYUN.SDK.EIP;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using KSYUN.SDK.EIP.HttpClient;
using KSYUN.SDK.EIP.HttpClient.Signature;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using RestSharp;

namespace KSYUN.SDK.EIP
{
    class Test{
        static void Main()
        {
            string _region = "cn-beijing-6";
            string _protocol = "https";
            string _ak = "xxx";
            string _sk = "xx";

            KsyunEipClient client = new KsyunEipClient(_region,_protocol,_ak,_sk);

            JObject ss = new JObject();
            JArray dd = new JArray();
            JObject sddd = new JObject();
            sddd.Add("ssss","sss");
            dd.Add("sss");
            dd.Add(sddd);
            ss.Add("sdd",dd);
            ss.Add("AllocationId","dd");
            ss.Add("BandWidth",12);
            HttpClientResponse res = client.GetLines(ss);
            Console.WriteLine(res.data);

        }
    }
}