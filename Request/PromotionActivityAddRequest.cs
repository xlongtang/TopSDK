using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.promotion.activity.add
    /// </summary>
    public class PromotionActivityAddRequest : ITopRequest<PromotionActivityAddResponse>
    {
        /// <summary>
        /// 优惠券总领用数量
        /// </summary>
        public Nullable<long> CouponCount { get; set; }

        /// <summary>
        /// 优惠券的id，唯一标识这个优惠券
        /// </summary>
        public Nullable<long> CouponId { get; set; }

        /// <summary>
        /// 每个人最多领用数量，0代表不限
        /// </summary>
        public Nullable<long> PersonLimitCount { get; set; }

        /// <summary>
        /// 是否将该活动优惠券同步到淘券市场  1（不同步）  2（同步）
        /// </summary>
        public Nullable<long> UploadToTaoquan { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.promotion.activity.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("coupon_count", this.CouponCount);
            parameters.Add("coupon_id", this.CouponId);
            parameters.Add("person_limit_count", this.PersonLimitCount);
            parameters.Add("upload_to_taoquan", this.UploadToTaoquan);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("coupon_count", this.CouponCount);
            RequestValidator.ValidateMaxValue("coupon_count", this.CouponCount, 999999);
            RequestValidator.ValidateMinValue("coupon_count", this.CouponCount, 1);
            RequestValidator.ValidateRequired("coupon_id", this.CouponId);
            RequestValidator.ValidateRequired("person_limit_count", this.PersonLimitCount);
            RequestValidator.ValidateMaxValue("person_limit_count", this.PersonLimitCount, 5);
            RequestValidator.ValidateMinValue("person_limit_count", this.PersonLimitCount, 0);
            RequestValidator.ValidateMaxValue("upload_to_taoquan", this.UploadToTaoquan, 2);
            RequestValidator.ValidateMinValue("upload_to_taoquan", this.UploadToTaoquan, 1);
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
