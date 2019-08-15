using KSYUN.SDK.SMS;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using KSYUN.SDK.SMS.HttpClient;
using KSYUN.SDK.SMS.HttpClient.Signature;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using RestSharp;

namespace KSYUN.SDK.SMS
{
    class Test {
        static void Main()
        {
            string _region = "xxx";
            string _protocol = "xxx";
            string _ak = "xxx";
            string _sk = "xxx";


            KsyunSMSClient client = new KsyunSMSClient(
            _region,
            _protocol,
            _ak,
            _sk
            );

            
            JObject _SendSms_query = new JObject();

                    
            JObject _SendSms_body = new JObject();
            JObject TplParams = new JObject();
            TplParams.Add("模板变量key", "模板变量值");

            // 手机号: 国内 11位数字，例如 1xxxxxxxx。国际 : +国家代号手机号码，例如 +861xxxxxxxx
            _SendSms_body.Add("Mobile", "1xxxxxxxx");
            //   签名名称 , 短信控制台页面可以查看
            _SendSms_body.Add("SignName", "test");
            //   模板ID
            _SendSms_body.Add("TplId", "test");
            //   { "模板变量key": "模板变量值" } 中英文字符，不含特殊符号【】
            _SendSms_body.Add("TplParams", TplParams.ToString());
            //   金山云账号为合作账号,该参数必填(TplId, TplParams无需传值)，需单独联系客服开通
            _SendSms_body.Add("Content", "sms content");
            // 1验证码, 2 通知 ，3营销类短信
            _SendSms_body.Add("SmsType", 1);

            Console.WriteLine(_SendSms_body.ToString());
                    

            HttpClientResponse SendSms_res = client.SendSms(_SendSms_query,_SendSms_body);
            JObject SendSms_data = SendSms_res.data;
            IRestResponse SendSms_response = SendSms_res.response;
            Console.WriteLine(SendSms_data);
            
            
            JObject _BatchSendSms_query = new JObject();

                    
            JObject _BatchSendSms_body = new JObject();

                    
            JObject _BatchSendSmsTplParams = new JObject();
            _BatchSendSmsTplParams.Add("模板变量key", "模板变量值");

            // 多个手机号,逗号分隔:, 国内 11位数字，例如 1xxxxxxxx。国际 : +国家代号手机号码，例如 +861xxxxxxxx
            _BatchSendSms_body.Add("Mobile", "1xxxxxxxx,1xxxxxxxx");
            //   签名名称 , 短信控制台页面可以查看
            _BatchSendSms_body.Add("SignName", "test");
            //   模板ID
            _BatchSendSms_body.Add("TplId", "test");
            //   { "模板变量key": "模板变量值" } 中英文字符，不含特殊符号【】
            _BatchSendSms_body.Add("TplParams", _BatchSendSmsTplParams.ToString());
            //   金山云账号为合作账号,该参数必填(TplId, TplParams无需传值)，需单独联系客服开通
            _BatchSendSms_body.Add("Content", "sms content");
            // 1验证码, 2 通知 ，3营销类短信
            _BatchSendSms_body.Add("SmsType", 1);

            Console.WriteLine(_BatchSendSms_body.ToString());
            HttpClientResponse BatchSendSms_res = client.BatchSendSms(_BatchSendSms_query,_BatchSendSms_body);
            JObject BatchSendSms_data = BatchSendSms_res.data;
            IRestResponse BatchSendSms_response = BatchSendSms_res.response;
            Console.WriteLine(BatchSendSms_data);
            
        }
    }

}