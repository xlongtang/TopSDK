using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hanoi.datatemplate.detail.delete
    /// </summary>
    public class HanoiDatatemplateDetailDeleteRequest : ITopRequest<HanoiDatatemplateDetailDeleteResponse>
    {
        /// <summary>
        /// appName
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// Long类型数组的JSON格式
        /// </summary>
        public string DataTemplateDetailIds { get; set; }

        /// <summary>
        /// id:数据模板唯一标识
        /// </summary>
        public string DataTemplateVo { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hanoi.datatemplate.detail.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_name", this.AppName);
            parameters.Add("data_template_detail_ids", this.DataTemplateDetailIds);
            parameters.Add("data_template_vo", this.DataTemplateVo);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("app_name", this.AppName);
            RequestValidator.ValidateRequired("data_template_detail_ids", this.DataTemplateDetailIds);
            RequestValidator.ValidateRequired("data_template_vo", this.DataTemplateVo);
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
