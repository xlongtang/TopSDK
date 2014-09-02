using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hanoi.attributes.get
    /// </summary>
    public class HanoiAttributesGetRequest : ITopRequest<HanoiAttributesGetResponse>
    {
        /// <summary>
        /// 属性编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 分页时需要用。默认第一页。
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// 属性的唯一标识
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 是否支持模糊查询
        /// </summary>
        public Nullable<bool> IndistinctQuery { get; set; }

        /// <summary>
        /// 分页时 每页显示的条数。最小1 最大30 默认10页
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 属性名称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Top 的访问权限。按位与。1：可读，2：可写，4：可规则计算。如可读且可写的权限值为3。
        /// </summary>
        public Nullable<long> TopAccess { get; set; }

        /// <summary>
        /// 类型 唯一标识
        /// </summary>
        public Nullable<long> TypeId { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        public string TypeName { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hanoi.attributes.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("code", this.Code);
            parameters.Add("current_page", this.CurrentPage);
            parameters.Add("id", this.Id);
            parameters.Add("indistinct_query", this.IndistinctQuery);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("title", this.Title);
            parameters.Add("top_access", this.TopAccess);
            parameters.Add("type_id", this.TypeId);
            parameters.Add("type_name", this.TypeName);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("code", this.Code, 50);
            RequestValidator.ValidateMaxValue("current_page", this.CurrentPage, 2147483647);
            RequestValidator.ValidateMinValue("current_page", this.CurrentPage, 1);
            RequestValidator.ValidateMaxValue("id", this.Id, 9223372036854775807);
            RequestValidator.ValidateMinValue("id", this.Id, 1);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 30);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
            RequestValidator.ValidateMaxLength("title", this.Title, 50);
            RequestValidator.ValidateMaxValue("top_access", this.TopAccess, 7);
            RequestValidator.ValidateMinValue("top_access", this.TopAccess, 0);
            RequestValidator.ValidateMaxValue("type_id", this.TypeId, 9223372036854775807);
            RequestValidator.ValidateMinValue("type_id", this.TypeId, 1);
            RequestValidator.ValidateMaxLength("type_name", this.TypeName, 50);
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
