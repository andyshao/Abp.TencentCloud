﻿using JetBrains.Annotations;
using EasyAbp.Abp.TencentCloud.Common.Models;

namespace EasyAbp.Abp.TencentCloud.CloudLive.Statistics.Model
{
    public sealed class DescribeStreamPlayInfoListRequest : CommonRequest
    {
        public DescribeStreamPlayInfoListRequest(string startTime,
            string endTime,
            [CanBeNull] string playDomain = null,
            [CanBeNull] string streamName = null,
            [CanBeNull] string appName = null)
        {
            SetAction("DescribeStreamPlayInfoList");
            SetVersion("2018-08-01");

            SetRequestBody(new
            {
                StartTime = startTime,
                EndTime = endTime,
                PlayDomain = playDomain,
                StreamName = streamName,
                AppName = appName
            });
        }
    }
}