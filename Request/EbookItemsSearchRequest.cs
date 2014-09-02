using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.ebook.items.search
    /// </summary>
    public class EbookItemsSearchRequest : ITopRequest<EbookItemsSearchResponse>
    {
        /// <summary>
        /// 书库ID
        /// </summary>
        public Nullable<long> EbookLibId { get; set; }

        /// <summary>
        /// 当前页码，不可为空、0和负数。
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页的大小，不可为空、0和负数。最大为30，如果超过30，则取默认的20。
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.ebook.items.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("ebook_lib_id", this.EbookLibId);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ebook_lib_id", this.EbookLibId);
            RequestValidator.ValidateRequired("page_no", this.PageNo);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
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
