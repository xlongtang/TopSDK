using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.traderate.impr.imprwords.get
    /// </summary>
    public class TraderateImprImprwordsGetRequest : ITopRequest<TraderateImprImprwordsGetResponse>
    {
        /// <summary>
        /// 淘宝叶子类目id
        /// </summary>
        public Nullable<long> CatLeafId { get; set; }

        /// <summary>
        /// 淘宝一级类目id
        /// </summary>
        public Nullable<long> CatRootId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.traderate.impr.imprwords.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cat_leaf_id", this.CatLeafId);
            parameters.Add("cat_root_id", this.CatRootId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cat_root_id", this.CatRootId);
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
