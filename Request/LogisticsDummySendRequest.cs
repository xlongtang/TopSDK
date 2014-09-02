using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.logistics.dummy.send
    /// </summary>
    public class LogisticsDummySendRequest : ITopRequest<LogisticsDummySendResponse>
    {
        /// <summary>
        /// feature参数格式<br>  范例: identCode=tid1:识别码1,识别码2|tid2:识别码3;machineCode=tid3:3C机器号A,3C机器号B<br>  identCode为识别码的KEY,machineCode为3C的KEY,多个key之间用”;”分隔<br>  “tid1:识别码1,识别码2|tid2:识别码3”为identCode对应的value。  "|"不同商品间的分隔符。<br>  例1商品和2商品，之间就用"|"分开。<br>  TID就是商品代表的子订单号，对应taobao.trade.fullinfo.get 接口获得的oid字段。(通过OID可以唯一定位到当前商品上)<br>  ":"TID和具体传入参数间的分隔符。冒号前表示TID,之后代表该商品的参数属性。<br>  "," 属性间分隔符。（对应商品数量，当存在一个商品的数量超过1个时，用逗号分开）。<br>  具体:当订单中A商品的数量为2个，其中手机串号分别为"12345","67890"。<br>  参数格式：identCode=TIDA:12345,67890。  TIDA对应了A宝贝，冒号后用逗号分隔的"12345","67890".说明本订单A宝贝的数量为2，值分别为"12345","67890"。<br>  当存在"|"时，就说明订单中存在多个商品，商品间用"|"分隔了开来。|"之后的内容含义同上。
        /// </summary>
        public string Feature { get; set; }

        /// <summary>
        /// 商家的IP地址
        /// </summary>
        public string SellerIp { get; set; }

        /// <summary>
        /// 淘宝交易ID
        /// </summary>
        public Nullable<long> Tid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.logistics.dummy.send";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("feature", this.Feature);
            parameters.Add("seller_ip", this.SellerIp);
            parameters.Add("tid", this.Tid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("tid", this.Tid);
        }

        #endregion

        public void AddOtherParameter(string key, string value)
        {
            if (this.otherParameters == null)
            {
                this.otherParameters = new TopDictionary();
            }
            this.otherParameters.Add(key, value);
        }
    }
}
