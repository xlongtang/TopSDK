using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hanoi.datatemplate.detail.query
    /// </summary>
    public class HanoiDatatemplateDetailQueryRequest : ITopRequest<HanoiDatatemplateDetailQueryResponse>
    {
        /// <summary>
        /// appName
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// attrId(Long):AttributeVO的唯一标识<br/>  templateId(Long):数据模板的唯一标识<br/>  name(String):数据模板详情的名称<br/>  id(Long):根据模板唯一标识去查询<br/>  pageSize:分页大小（最大值30）<br/>  currentPage:当前页码<br/>  needRetPage(Boolean 默认False):是否返回总条数<br/>  justQueryParamNotInput（Boolean 默认False）:是否只查询每天如PK的详情列表<br/>
        /// </summary>
        public string Parameter { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hanoi.datatemplate.detail.query";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_name", this.AppName);
            parameters.Add("parameter", this.Parameter);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("app_name", this.AppName);
            RequestValidator.ValidateRequired("parameter", this.Parameter);
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
