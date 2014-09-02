using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.promotion.coupon.transfer
    /// </summary>
    public class PromotionCouponTransferRequest : ITopRequest<PromotionCouponTransferResponse>
    {
        /// <summary>
        /// 优惠券编号
        /// </summary>
        public Nullable<long> CouponNumber { get; set; }

        /// <summary>
        /// 要赠送的淘宝昵称
        /// </summary>
        public string ReceiveingBuyerName { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.promotion.coupon.transfer";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("coupon_number", this.CouponNumber);
            parameters.Add("receiveing_buyer_name", this.ReceiveingBuyerName);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("coupon_number", this.CouponNumber);
            RequestValidator.ValidateMinValue("coupon_number", this.CouponNumber, 1);
            RequestValidator.ValidateRequired("receiveing_buyer_name", this.ReceiveingBuyerName);
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
