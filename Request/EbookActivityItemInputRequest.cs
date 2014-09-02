using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.ebook.activity.item.input
    /// </summary>
    public class EbookActivityItemInputRequest : ITopRequest<EbookActivityItemInputResponse>
    {
        /// <summary>
        /// 活动Id
        /// </summary>
        public Nullable<long> ActId { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// 商品图片url
        /// </summary>
        public string ItemPicUrl { get; set; }

        /// <summary>
        /// 商品价格，单位：分。
        /// </summary>
        public Nullable<long> ItemPrice { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        public string ItemTitle { get; set; }

        /// <summary>
        /// 实际代扣价格，单位：分。
        /// </summary>
        public Nullable<long> RealPrice { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.ebook.activity.item.input";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("act_id", this.ActId);
            parameters.Add("item_id", this.ItemId);
            parameters.Add("item_pic_url", this.ItemPicUrl);
            parameters.Add("item_price", this.ItemPrice);
            parameters.Add("item_title", this.ItemTitle);
            parameters.Add("real_price", this.RealPrice);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("act_id", this.ActId);
            RequestValidator.ValidateRequired("item_id", this.ItemId);
            RequestValidator.ValidateRequired("item_price", this.ItemPrice);
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
