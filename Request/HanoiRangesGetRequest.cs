using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hanoi.ranges.get
    /// </summary>
    public class HanoiRangesGetRequest : ITopRequest<HanoiRangesGetResponse>
    {
        /// <summary>
        /// 分页时需要用。默认第一页。
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// 根据档案ID查询下面的值域信息
        /// </summary>
        public Nullable<long> DocumentId { get; set; }

        /// <summary>
        /// 属性的唯一标识
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 取值范围的Key。可以和Document_ID搭配使用。
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 分页时 每页显示的条数。最小1 最大30 默认10页
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hanoi.ranges.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("current_page", this.CurrentPage);
            parameters.Add("document_id", this.DocumentId);
            parameters.Add("id", this.Id);
            parameters.Add("key", this.Key);
            parameters.Add("page_size", this.PageSize);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("current_page", this.CurrentPage, 2147483647);
            RequestValidator.ValidateMinValue("current_page", this.CurrentPage, 1);
            RequestValidator.ValidateRequired("document_id", this.DocumentId);
            RequestValidator.ValidateMaxValue("document_id", this.DocumentId, 9223372036854775807);
            RequestValidator.ValidateMinValue("document_id", this.DocumentId, 1);
            RequestValidator.ValidateMaxValue("id", this.Id, 9223372036854775807);
            RequestValidator.ValidateMinValue("id", this.Id, 1);
            RequestValidator.ValidateMaxLength("key", this.Key, 50);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 30);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
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
