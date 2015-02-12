using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.promotion.coupons.get
    /// </summary>
    public class PromotionCouponsGetRequest : ITopRequest<PromotionCouponsGetResponse>
    {
        /// <summary>
        /// 优惠券的id，唯一标识这个优惠券
        /// </summary>
        public Nullable<long> CouponId { get; set; }

        /// <summary>
        /// 优惠券的面额，必须是3，5，10，20，50,100
        /// </summary>
        public Nullable<long> Denominations { get; set; }

        /// <summary>
        /// 优惠券的截止日期
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 查询的页号，结果集是分页返回的，每页20条
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.promotion.coupons.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("coupon_id", this.CouponId);
            parameters.Add("denominations", this.Denominations);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("denominations", this.Denominations, 100);
            RequestValidator.ValidateMinValue("denominations", this.Denominations, 3);
            RequestValidator.ValidateMinValue("page_no", this.PageNo, 1);
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
