using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hanoi.template.update
    /// </summary>
    public class HanoiTemplateUpdateRequest : ITopRequest<HanoiTemplateUpdateResponse>
    {
        /// <summary>
        /// 认证信息
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 所使用的数据模板
        /// </summary>
        public Nullable<long> DataTemplateId { get; set; }

        /// <summary>
        /// 模板的描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 模板的表达式
        /// </summary>
        public string Expression { get; set; }

        /// <summary>
        /// 模板上次更新时间
        /// </summary>
        public Nullable<DateTime> GmtModified { get; set; }

        /// <summary>
        /// 需要更新的模板id
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 模板的名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 模板的开放策略，默认为false，不开放
        /// </summary>
        public Nullable<bool> Open { get; set; }

        /// <summary>
        /// 设置表达式中参数的类型。ParaVO对象的json格式
        /// </summary>
        public string ParaList { get; set; }

        /// <summary>
        /// 模板的源模板id，0表示没有源模板
        /// </summary>
        public Nullable<long> SourceTemplateId { get; set; }

        /// <summary>
        /// 模板的编码
        /// </summary>
        public string TemplateCode { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hanoi.template.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_name", this.AppName);
            parameters.Add("data_template_id", this.DataTemplateId);
            parameters.Add("description", this.Description);
            parameters.Add("expression", this.Expression);
            parameters.Add("gmt_modified", this.GmtModified);
            parameters.Add("id", this.Id);
            parameters.Add("name", this.Name);
            parameters.Add("open", this.Open);
            parameters.Add("para_list", this.ParaList);
            parameters.Add("source_template_id", this.SourceTemplateId);
            parameters.Add("template_code", this.TemplateCode);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("app_name", this.AppName);
            RequestValidator.ValidateRequired("gmt_modified", this.GmtModified);
            RequestValidator.ValidateRequired("id", this.Id);
            RequestValidator.ValidateMaxLength("template_code", this.TemplateCode, 50);
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
