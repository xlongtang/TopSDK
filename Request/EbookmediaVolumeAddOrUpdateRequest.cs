using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.ebookmedia.volume.add.or.update
    /// </summary>
    public class EbookmediaVolumeAddOrUpdateRequest : ITopRequest<EbookmediaVolumeAddOrUpdateResponse>
    {
        /// <summary>
        /// 商品数字ID
        /// </summary>
        public Nullable<long> AuctionId { get; set; }

        /// <summary>
        /// 卷信息简介。不能超过2000个字符<br /> 支持最大长度为：2000<br /> 支持的最大列表长度为：2000
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 卷序号ID。此序号ID必须按照数字顺序添加，不能跳过，若有重复则覆盖原来的卷信息,序号不能超过50
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        /// <summary>
        /// 电子书卷标题，不能超过30个字符<br /> 支持最大长度为：30<br /> 支持的最大列表长度为：30
        /// </summary>
        public string Title { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.ebookmedia.volume.add.or.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("auction_id", this.AuctionId);
            parameters.Add("desc", this.Desc);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("title", this.Title);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("auction_id", this.AuctionId);
            RequestValidator.ValidateMaxLength("desc", this.Desc, 2000);
            RequestValidator.ValidateRequired("order_id", this.OrderId);
            RequestValidator.ValidateRequired("title", this.Title);
            RequestValidator.ValidateMaxLength("title", this.Title, 30);
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
