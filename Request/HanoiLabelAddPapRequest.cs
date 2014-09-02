using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hanoi.label.add.pap
    /// </summary>
    public class HanoiLabelAddPapRequest : ITopRequest<HanoiLabelAddPapResponse>
    {
        /// <summary>
        /// 认证信息
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 针对标签的一个简单描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 标签的编码，用于检索
        /// </summary>
        public string LabelCode { get; set; }

        /// <summary>
        /// 标签的名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 标签是否开放
        /// </summary>
        public Nullable<bool> Open { get; set; }

        /// <summary>
        /// 针对模板表达式中需要设置的参数的一个实例化，List<ParameterVO>对象的json格式
        /// </summary>
        public string Paras { get; set; }

        /// <summary>
        /// 标签的使用场景
        /// </summary>
        public Nullable<long> Scene { get; set; }

        /// <summary>
        /// 标签对应的模板id
        /// </summary>
        public Nullable<long> TemplateId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hanoi.label.add.pap";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_name", this.AppName);
            parameters.Add("description", this.Description);
            parameters.Add("label_code", this.LabelCode);
            parameters.Add("name", this.Name);
            parameters.Add("open", this.Open);
            parameters.Add("paras", this.Paras);
            parameters.Add("scene", this.Scene);
            parameters.Add("template_id", this.TemplateId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("app_name", this.AppName);
            RequestValidator.ValidateRequired("label_code", this.LabelCode);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateRequired("template_id", this.TemplateId);
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
