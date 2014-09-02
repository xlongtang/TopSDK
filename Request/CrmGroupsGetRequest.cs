using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.groups.get
    /// </summary>
    public class CrmGroupsGetRequest : ITopRequest<CrmGroupsGetResponse>
    {
        /// <summary>
        /// 显示第几页的分组，如果输入的页码大于总共的页码数，例如总共10页，但是current_page的值为11，则返回空白页，最小页码为1<br /> 支持最大值为：1000000<br /> 支持最小值为：1<br /> 支持的最大列表长度为：3
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// 每页显示的记录数，其最大值不能超过100条，最小值为1，默认20条<br /> 支持最大值为：100<br /> 支持最小值为：1<br /> 支持的最大列表长度为：3
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.groups.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("current_page", this.CurrentPage);
            parameters.Add("page_size", this.PageSize);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("current_page", this.CurrentPage);
            RequestValidator.ValidateMaxValue("current_page", this.CurrentPage, 1000000);
            RequestValidator.ValidateMinValue("current_page", this.CurrentPage, 1);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 100);
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
