using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.item.sizemapping.template.create
    /// </summary>
    public class TmallItemSizemappingTemplateCreateRequest : ITopRequest<TmallItemSizemappingTemplateCreateResponse>
    {
        /// <summary>
        /// 尺码表模板内容，格式为"尺码值:维度名称:数值,尺码值:维度名称:数值"。其中，数值的单位，长度单位为厘米（cm），体重单位为公斤（kg）。尺码值，维度数据不能包含数字，特殊字符。数值为0-999.9的数字，且最多一位小数。
        /// </summary>
        public string TemplateContent { get; set; }

        /// <summary>
        /// 尺码表模板名称
        /// </summary>
        public string TemplateName { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.item.sizemapping.template.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("template_content", this.TemplateContent);
            parameters.Add("template_name", this.TemplateName);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("template_content", this.TemplateContent);
            RequestValidator.ValidateMaxLength("template_content", this.TemplateContent, 8000);
            RequestValidator.ValidateRequired("template_name", this.TemplateName);
            RequestValidator.ValidateMaxLength("template_name", this.TemplateName, 20);
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
