using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.item.desc.modules.get
    /// </summary>
    public class TmallItemDescModulesGetRequest : ITopRequest<TmallItemDescModulesGetResponse>
    {
        /// <summary>
        /// 叶子类目id
        /// </summary>
        public Nullable<long> CatId { get; set; }

        /// <summary>
        /// 商家主帐号id
        /// </summary>
        public Nullable<long> UsrId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.item.desc.modules.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cat_id", this.CatId);
            parameters.Add("usr_id", this.UsrId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cat_id", this.CatId);
            RequestValidator.ValidateRequired("usr_id", this.UsrId);
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
