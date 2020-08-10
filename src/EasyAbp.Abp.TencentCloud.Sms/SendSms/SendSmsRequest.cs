﻿using EasyAbp.Abp.TencentCloud.Common.Models;

namespace EasyAbp.Abp.TencentCloud.Sms.SendSms
{
    public class SendSmsRequest : CommonRequest
    {
        public SendSmsRequest(
            string nationCode,
            string[] phoneNumberSet,
            string templateId,
            string smsSdkAppid,
            string sign,
            string[] templateParamSet = null,
            string extendCode = null,
            string senderId = null)
        {
            SetAction("SendSms");
            SetVersion("2019-07-11");

            SetRequestBody(new
            {
                NationCode = nationCode,
                PhoneNumberSet = phoneNumberSet,
                TemplateId = templateId,
                SmsSdkAppid = smsSdkAppid,
                Sign = sign,
                TemplateParamSet = templateParamSet,
                ExtendCode = extendCode,
                SenderId = senderId
            });
        }
    }
}