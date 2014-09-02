using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.caipiao.shop.info.input
    /// </summary>
    public class CaipiaoShopInfoInputRequest : ITopRequest<CaipiaoShopInfoInputResponse>
    {
        /// <summary>
        /// 活动结束时间，格式需严格遵守yyyy-MM-dd HH:mm:ss，不可为空
        /// </summary>
        public string ActEndDate { get; set; }

        /// <summary>
        /// 活动开始时间，格式需严格遵守yyyy-MM-dd HH:mm:ss，不可为空
        /// </summary>
        public string ActStartDate { get; set; }

        /// <summary>
        /// 赠送类型：0-满就送；1-好评送；2-分享送；3-游戏送；4-收藏送，不可为空
        /// </summary>
        public Nullable<long> PresentType { get; set; }

        /// <summary>
        /// 店铺参加的送彩票活动描述
        /// </summary>
        public string ShopDesc { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺类目编号，不可为空
        /// </summary>
        public Nullable<long> ShopType { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.caipiao.shop.info.input";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("act_end_date", this.ActEndDate);
            parameters.Add("act_start_date", this.ActStartDate);
            parameters.Add("present_type", this.PresentType);
            parameters.Add("shop_desc", this.ShopDesc);
            parameters.Add("shop_name", this.ShopName);
            parameters.Add("shop_type", this.ShopType);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("act_end_date", this.ActEndDate);
            RequestValidator.ValidateRequired("act_start_date", this.ActStartDate);
            RequestValidator.ValidateRequired("present_type", this.PresentType);
            RequestValidator.ValidateRequired("shop_type", this.ShopType);
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
