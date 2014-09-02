using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.promotion.coupon.sns.send
    /// </summary>
    public class PromotionCouponSnsSendRequest : ITopRequest<PromotionCouponSnsSendResponse>
    {
        /// <summary>
        /// 买家昵称用半角','号分割
        /// </summary>
        public string BuyerNick { get; set; }

        /// <summary>
        /// 优惠券的id
        /// </summary>
        public Nullable<long> CouponId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.promotion.coupon.sns.send";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("buyer_nick", this.BuyerNick);
            parameters.Add("coupon_id", this.CouponId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("buyer_nick", this.BuyerNick);
            RequestValidator.ValidateMaxListSize("buyer_nick", this.BuyerNick, 100);
            RequestValidator.ValidateRequired("coupon_id", this.CouponId);
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
