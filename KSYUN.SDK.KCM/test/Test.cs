using KSYUN.SDK.KCM;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using KSYUN.SDK.KCM.HttpClient;
using KSYUN.SDK.KCM.HttpClient.Signature;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using RestSharp;

namespace KSYUN.SDK.KCM
{
    class Test {
        static void Main()
        {
            string _region = "xxx";
            string _protocol = "xxx";
            string _ak = "xxx";
            string _sk = "xxx";


            KsyunKcmClient client = new KsyunKcmClient(
            _region,
            _protocol,
            _ak,
            _sk
            );

            
            JObject _DescribeCertificates_body = new JObject();

                    

            HttpClientResponse DescribeCertificates_res = client.DescribeCertificates(_DescribeCertificates_body);
            JObject DescribeCertificates_data = DescribeCertificates_res.data;
            IRestResponse DescribeCertificates_response = DescribeCertificates_res.response;
            Console.WriteLine(DescribeCertificates_data);
            
            
            JObject _CreateCertificate_query = new JObject();

                    
            JObject _CreateCertificate_body = new JObject();

                    

            HttpClientResponse CreateCertificate_res = client.CreateCertificate(_CreateCertificate_query,_CreateCertificate_body);
            JObject CreateCertificate_data = CreateCertificate_res.data;
            IRestResponse CreateCertificate_response = CreateCertificate_res.response;
            Console.WriteLine(CreateCertificate_data);
            
            
            JObject _DeleteCertificate_query = new JObject();

                    

            HttpClientResponse DeleteCertificate_res = client.DeleteCertificate(_DeleteCertificate_query);
            JObject DeleteCertificate_data = DeleteCertificate_res.data;
            IRestResponse DeleteCertificate_response = DeleteCertificate_res.response;
            Console.WriteLine(DeleteCertificate_data);
            
            
            JObject _ModifyCertificate_query = new JObject();

                    

            HttpClientResponse ModifyCertificate_res = client.ModifyCertificate(_ModifyCertificate_query);
            JObject ModifyCertificate_data = ModifyCertificate_res.data;
            IRestResponse ModifyCertificate_response = ModifyCertificate_res.response;
            Console.WriteLine(ModifyCertificate_data);
            
        }
    }

}