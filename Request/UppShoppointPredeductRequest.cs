using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.upp.shoppoint.prededuct
    /// </summary>
    public class UppShoppointPredeductRequest : ITopRequest<UppShoppointPredeductResponse>
    {
        /// <summary>
        /// 业务扩展信息 ，用于ISV描述积分记录的具体业务信息。  禁止含有“:”或“;”或“~”禁用字符 或者淘宝违禁词库中的其他字符。<br /> 支持最大长度为：30<br /> 支持的最大列表长度为：30
        /// </summary>
        public string BusinessInfo { get; set; }

        /// <summary>
        /// 处理的店铺积分数量
        /// </summary>
        public Nullable<long> PointNum { get; set; }

        /// <summary>
        /// 卖家家nick
        /// </summary>
        public string SellerNick { get; set; }

        /// <summary>
        /// 业务发生的时间
        /// </summary>
        public Nullable<DateTime> TransactionTime { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.upp.shoppoint.prededuct";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("business_info", this.BusinessInfo);
            parameters.Add("point_num", this.PointNum);
            parameters.Add("seller_nick", this.SellerNick);
            parameters.Add("transaction_time", this.TransactionTime);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("business_info", this.BusinessInfo);
            RequestValidator.ValidateMaxLength("business_info", this.BusinessInfo, 30);
            RequestValidator.ValidateRequired("point_num", this.PointNum);
            RequestValidator.ValidateRequired("seller_nick", this.SellerNick);
            RequestValidator.ValidateRequired("transaction_time", this.TransactionTime);
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
