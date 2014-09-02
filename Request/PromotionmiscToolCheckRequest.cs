using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.promotionmisc.tool.check
    /// </summary>
    public class PromotionmiscToolCheckRequest : ITopRequest<PromotionmiscToolCheckResponse>
    {
        /// <summary>
        /// 可使用的元数据。PRD审核后，会告诉isv可使用的元数据。
        /// </summary>
        public string MetaAllow { get; set; }

        /// <summary>
        /// 工具ID, taobao.ump.tool.add成功后返回的id。<br /> 支持最小值为：10
        /// </summary>
        public Nullable<long> ToolId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.promotionmisc.tool.check";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("meta_allow", this.MetaAllow);
            parameters.Add("tool_id", this.ToolId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("tool_id", this.ToolId);
            RequestValidator.ValidateMinValue("tool_id", this.ToolId, 10);
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
