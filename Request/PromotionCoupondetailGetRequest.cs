using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.promotion.coupondetail.get
    /// </summary>
    public class PromotionCoupondetailGetRequest : ITopRequest<PromotionCoupondetailGetResponse>
    {
        /// <summary>
        /// 买家昵称
        /// </summary>
        public string BuyerNick { get; set; }

        /// <summary>
        /// 优惠券的id
        /// </summary>
        public Nullable<long> CouponId { get; set; }

        /// <summary>
        /// 传入优惠券截止时间，即失效时间。查询输入日期向前15天的数据；不传则查询当前日期向前15天的数据。比如查询明天才失效的优惠卷，要传入明天之后15天内的日期，才能查询到该优惠卷。
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 这是一个扩展字段 供版本升级用  当前如果新版本的话 可以传入new字符串
        /// </summary>
        public string ExtendParams { get; set; }

        /// <summary>
        /// 查询的页号，结果集是分页返回的，每页20条
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页行数
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 优惠券使用情况unused：代表未使用using：代表使用中used：代表已使用。必须是unused，using，used
        /// </summary>
        public string State { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.promotion.coupondetail.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("buyer_nick", this.BuyerNick);
            parameters.Add("coupon_id", this.CouponId);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("extend_params", this.ExtendParams);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("state", this.State);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("coupon_id", this.CouponId);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 20);
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
