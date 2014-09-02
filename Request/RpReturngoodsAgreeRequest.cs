using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.rp.returngoods.agree
    /// </summary>
    public class RpReturngoodsAgreeRequest : ITopRequest<RpReturngoodsAgreeResponse>
    {
        /// <summary>
        /// 卖家提供的退货地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 卖家手机
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 卖家姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 卖家提供的退货地址的邮编
        /// </summary>
        public string Post { get; set; }

        /// <summary>
        /// 退款编号
        /// </summary>
        public Nullable<long> RefundId { get; set; }

        /// <summary>
        /// 卖家退货留言
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 卖家座机
        /// </summary>
        public string Tel { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.rp.returngoods.agree";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("address", this.Address);
            parameters.Add("mobile", this.Mobile);
            parameters.Add("name", this.Name);
            parameters.Add("post", this.Post);
            parameters.Add("refund_id", this.RefundId);
            parameters.Add("remark", this.Remark);
            parameters.Add("tel", this.Tel);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("address", this.Address);
            RequestValidator.ValidateRequired("mobile", this.Mobile);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateRequired("post", this.Post);
            RequestValidator.ValidateRequired("refund_id", this.RefundId);
            RequestValidator.ValidateRequired("tel", this.Tel);
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
