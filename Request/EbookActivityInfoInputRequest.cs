using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.ebook.activity.info.input
    /// </summary>
    public class EbookActivityInfoInputRequest : ITopRequest<EbookActivityInfoInputResponse>
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        public Nullable<long> ActId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        public string ActName { get; set; }

        /// <summary>
        /// 活动类型：0-满就送；1-好评送；2-分享送；3-游戏送；4-收藏送，不可为空
        /// </summary>
        public Nullable<long> ActType { get; set; }

        /// <summary>
        /// 活动条件描述，30个字以内。
        /// </summary>
        public string ConditionDesc { get; set; }

        /// <summary>
        /// 活动结束时间，yyyy-MM-dd HH:mm:ss
        /// </summary>
        public Nullable<DateTime> EndDate { get; set; }

        /// <summary>
        /// 卖家的淘宝账号ID
        /// </summary>
        public Nullable<long> SellerId { get; set; }

        /// <summary>
        /// 卖家店铺名称
        /// </summary>
        public string ShopName { get; set; }

        /// <summary>
        /// 活动开始时间，yyyy-MM-dd HH:mm:ss
        /// </summary>
        public Nullable<DateTime> StartDate { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.ebook.activity.info.input";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("act_id", this.ActId);
            parameters.Add("act_name", this.ActName);
            parameters.Add("act_type", this.ActType);
            parameters.Add("condition_desc", this.ConditionDesc);
            parameters.Add("end_date", this.EndDate);
            parameters.Add("seller_id", this.SellerId);
            parameters.Add("shop_name", this.ShopName);
            parameters.Add("start_date", this.StartDate);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("act_id", this.ActId);
            RequestValidator.ValidateRequired("act_name", this.ActName);
            RequestValidator.ValidateRequired("act_type", this.ActType);
            RequestValidator.ValidateRequired("end_date", this.EndDate);
            RequestValidator.ValidateRequired("seller_id", this.SellerId);
            RequestValidator.ValidateRequired("start_date", this.StartDate);
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
