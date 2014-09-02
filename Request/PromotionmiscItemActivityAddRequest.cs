using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.promotionmisc.item.activity.add
    /// </summary>
    public class PromotionmiscItemActivityAddRequest : ITopRequest<PromotionmiscItemActivityAddResponse>
    {
        /// <summary>
        /// 减多少钱。当is_decrease_money为true时，该值才有意义。注意：该值单位为分，即100表示1元。<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> DecreaseAmount { get; set; }

        /// <summary>
        /// 折扣值。当is_discount为true时，该值才有意义。注意：800表示8折。<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> DiscountRate { get; set; }

        /// <summary>
        /// 活动结束时间。
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 是否有减钱行为。
        /// </summary>
        public Nullable<bool> IsDecreaseMoney { get; set; }

        /// <summary>
        /// 是否有打折行为。
        /// </summary>
        public Nullable<bool> IsDiscount { get; set; }

        /// <summary>
        /// 是否指定用户标签。
        /// </summary>
        public Nullable<bool> IsUserTag { get; set; }

        /// <summary>
        /// 活动名称，超过5个汉字时，商品详情中显示的优惠名称为：卖家优惠。<br /> 支持最大长度为：32<br /> 支持的最大列表长度为：32
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 活动范围：0表示全部参与； 1表示部分商品参与。<br /> 支持最大值为：1<br /> 支持最小值为：0<br /> 支持的最大列表长度为：1
        /// </summary>
        public Nullable<long> ParticipateRange { get; set; }

        /// <summary>
        /// 活动开始时间。
        /// </summary>
        public Nullable<DateTime> StartTime { get; set; }

        /// <summary>
        /// 用户标签。当is_user_tag为true时，该值才有意义。
        /// </summary>
        public string UserTag { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.promotionmisc.item.activity.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("decrease_amount", this.DecreaseAmount);
            parameters.Add("discount_rate", this.DiscountRate);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("is_decrease_money", this.IsDecreaseMoney);
            parameters.Add("is_discount", this.IsDiscount);
            parameters.Add("is_user_tag", this.IsUserTag);
            parameters.Add("name", this.Name);
            parameters.Add("participate_range", this.ParticipateRange);
            parameters.Add("start_time", this.StartTime);
            parameters.Add("user_tag", this.UserTag);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("decrease_amount", this.DecreaseAmount, 0);
            RequestValidator.ValidateMinValue("discount_rate", this.DiscountRate, 0);
            RequestValidator.ValidateRequired("end_time", this.EndTime);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 32);
            RequestValidator.ValidateRequired("participate_range", this.ParticipateRange);
            RequestValidator.ValidateMaxValue("participate_range", this.ParticipateRange, 1);
            RequestValidator.ValidateMinValue("participate_range", this.ParticipateRange, 0);
            RequestValidator.ValidateRequired("start_time", this.StartTime);
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
