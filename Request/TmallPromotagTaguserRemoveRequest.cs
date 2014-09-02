using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.promotag.taguser.remove
    /// </summary>
    public class TmallPromotagTaguserRemoveRequest : ITopRequest<TmallPromotagTaguserRemoveResponse>
    {
        /// <summary>
        /// 买家昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 标签ID
        /// </summary>
        public Nullable<long> TagId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.promotag.taguser.remove";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("nick", this.Nick);
            parameters.Add("tag_id", this.TagId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("nick", this.Nick);
            RequestValidator.ValidateRequired("tag_id", this.TagId);
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
