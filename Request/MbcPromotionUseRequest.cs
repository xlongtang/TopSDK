using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.mbc.promotion.use
    /// </summary>
    public class MbcPromotionUseRequest : ITopRequest<MbcPromotionUseResponse>
    {
        /// <summary>
        /// 实际金额单位(分)
        /// </summary>
        public Nullable<long> ActualFee { get; set; }

        /// <summary>
        /// 优惠金额单位(分)
        /// </summary>
        public Nullable<long> DiscountFee { get; set; }

        /// <summary>
        /// 有效结束时间
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 外部流水号，  promotion_type+outer_no 唯一
        /// </summary>
        public string OuterNo { get; set; }

        /// <summary>
        /// 权益ID
        /// </summary>
        public string PromotionId { get; set; }

        /// <summary>
        /// 权限类型
        /// </summary>
        public Nullable<long> PromotionType { get; set; }

        /// <summary>
        /// 有效开始时间
        /// </summary>
        public Nullable<DateTime> StartTime { get; set; }

        /// <summary>
        /// 交易总金额单位(分)
        /// </summary>
        public Nullable<long> TotalFee { get; set; }

        /// <summary>
        /// 使用时间
        /// </summary>
        public Nullable<DateTime> UseTime { get; set; }

        /// <summary>
        /// 买家淘宝ID
        /// </summary>
        public Nullable<long> UserId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.mbc.promotion.use";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("actual_fee", this.ActualFee);
            parameters.Add("discount_fee", this.DiscountFee);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("outer_no", this.OuterNo);
            parameters.Add("promotion_id", this.PromotionId);
            parameters.Add("promotion_type", this.PromotionType);
            parameters.Add("start_time", this.StartTime);
            parameters.Add("total_fee", this.TotalFee);
            parameters.Add("use_time", this.UseTime);
            parameters.Add("user_id", this.UserId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("actual_fee", this.ActualFee);
            RequestValidator.ValidateRequired("discount_fee", this.DiscountFee);
            RequestValidator.ValidateRequired("outer_no", this.OuterNo);
            RequestValidator.ValidateRequired("promotion_id", this.PromotionId);
            RequestValidator.ValidateRequired("promotion_type", this.PromotionType);
            RequestValidator.ValidateRequired("total_fee", this.TotalFee);
            RequestValidator.ValidateRequired("use_time", this.UseTime);
            RequestValidator.ValidateRequired("user_id", this.UserId);
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
