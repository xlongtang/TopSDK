using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hanoi.types.get
    /// </summary>
    public class HanoiTypesGetRequest : ITopRequest<HanoiTypesGetResponse>
    {
        /// <summary>
        /// 分页时需要用。默认第一页。
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// 类型的唯一标识
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 类型的名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 分页时 每页显示的条数。最小1 最大30 默认10页
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hanoi.types.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("current_page", this.CurrentPage);
            parameters.Add("id", this.Id);
            parameters.Add("name", this.Name);
            parameters.Add("page_size", this.PageSize);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("current_page", this.CurrentPage, 2147483647);
            RequestValidator.ValidateMinValue("current_page", this.CurrentPage, 1);
            RequestValidator.ValidateMaxValue("id", this.Id, 9223372036854775807);
            RequestValidator.ValidateMinValue("id", this.Id, 1);
            RequestValidator.ValidateMaxLength("name", this.Name, 50);
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
