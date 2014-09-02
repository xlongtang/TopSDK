using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.waimai.shop.businessrules.update
    /// </summary>
    public class WaimaiShopBusinessrulesUpdateRequest : ITopRequest<WaimaiShopBusinessrulesUpdateResponse>
    {
        /// <summary>
        /// 配送范围地图标注
        /// </summary>
        public string AreaRange { get; set; }

        /// <summary>
        /// 配送费
        /// </summary>
        public string DeliveryAmount { get; set; }

        /// <summary>
        /// 配送范围文字说明
        /// </summary>
        public string DeliveryArea { get; set; }

        /// <summary>
        /// 配送时间
        /// </summary>
        public string DeliveryTime { get; set; }

        /// <summary>
        /// 送货预留时间
        /// </summary>
        public Nullable<long> EarlyMinutes { get; set; }

        /// <summary>
        /// 满多少就免配送费
        /// </summary>
        public string FullAmount { get; set; }

        /// <summary>
        /// 起送金额
        /// </summary>
        public string MinimumAmount { get; set; }

        /// <summary>
        /// 外卖商家电话
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        public Nullable<long> Shopid { get; set; }

        /// <summary>
        /// 支持预定, 当天：1，三天内：3，七天内：7
        /// </summary>
        public Nullable<long> SupportDays { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.waimai.shop.businessrules.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("area_range", this.AreaRange);
            parameters.Add("delivery_amount", this.DeliveryAmount);
            parameters.Add("delivery_area", this.DeliveryArea);
            parameters.Add("delivery_time", this.DeliveryTime);
            parameters.Add("early_minutes", this.EarlyMinutes);
            parameters.Add("full_amount", this.FullAmount);
            parameters.Add("minimum_amount", this.MinimumAmount);
            parameters.Add("mobile", this.Mobile);
            parameters.Add("shopid", this.Shopid);
            parameters.Add("support_days", this.SupportDays);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("area_range", this.AreaRange);
            RequestValidator.ValidateRequired("delivery_amount", this.DeliveryAmount);
            RequestValidator.ValidateRequired("delivery_area", this.DeliveryArea);
            RequestValidator.ValidateRequired("delivery_time", this.DeliveryTime);
            RequestValidator.ValidateRequired("early_minutes", this.EarlyMinutes);
            RequestValidator.ValidateRequired("full_amount", this.FullAmount);
            RequestValidator.ValidateRequired("minimum_amount", this.MinimumAmount);
            RequestValidator.ValidateRequired("mobile", this.Mobile);
            RequestValidator.ValidateRequired("shopid", this.Shopid);
            RequestValidator.ValidateRequired("support_days", this.SupportDays);
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
