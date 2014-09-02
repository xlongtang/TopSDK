using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sellercats.list.update
    /// </summary>
    public class SellercatsListUpdateRequest : ITopRequest<SellercatsListUpdateResponse>
    {
        /// <summary>
        /// 卖家自定义类目编号
        /// </summary>
        public Nullable<long> Cid { get; set; }

        /// <summary>
        /// 卖家自定义类目名称。不超过20个字符
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 链接图片URL地址
        /// </summary>
        public string PictUrl { get; set; }

        /// <summary>
        /// 该类目在页面上的排序位置,取值范围:大于零的整数
        /// </summary>
        public Nullable<long> SortOrder { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sellercats.list.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cid", this.Cid);
            parameters.Add("name", this.Name);
            parameters.Add("pict_url", this.PictUrl);
            parameters.Add("sort_order", this.SortOrder);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cid", this.Cid);
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
