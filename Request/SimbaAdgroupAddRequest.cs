using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.adgroup.add
    /// </summary>
    public class SimbaAdgroupAddRequest : ITopRequest<SimbaAdgroupAddResponse>
    {
        /// <summary>
        /// 推广计划Id
        /// </summary>
        public Nullable<long> CampaignId { get; set; }

        /// <summary>
        /// 推广组默认出价，单位为分，不能小于5 不能大于日最高限额
        /// </summary>
        public Nullable<long> DefaultPrice { get; set; }

        /// <summary>
        /// 创意图片地址，必须是商品的图片之一
        /// </summary>
        public string ImgUrl { get; set; }

        /// <summary>
        /// 商品Id
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// 主人昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 创意标题，最多20个汉字
        /// </summary>
        public string Title { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.adgroup.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("campaign_id", this.CampaignId);
            parameters.Add("default_price", this.DefaultPrice);
            parameters.Add("img_url", this.ImgUrl);
            parameters.Add("item_id", this.ItemId);
            parameters.Add("nick", this.Nick);
            parameters.Add("title", this.Title);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("campaign_id", this.CampaignId);
            RequestValidator.ValidateRequired("default_price", this.DefaultPrice);
            RequestValidator.ValidateMinValue("default_price", this.DefaultPrice, 5);
            RequestValidator.ValidateRequired("img_url", this.ImgUrl);
            RequestValidator.ValidateRequired("item_id", this.ItemId);
            RequestValidator.ValidateRequired("title", this.Title);
            RequestValidator.ValidateMaxLength("title", this.Title, 40);
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
