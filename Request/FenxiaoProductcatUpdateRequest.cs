using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.productcat.update
    /// </summary>
    public class FenxiaoProductcatUpdateRequest : ITopRequest<FenxiaoProductcatUpdateResponse>
    {
        /// <summary>
        /// 代销默认采购价比例，注意：100.00%，则输入为10000
        /// </summary>
        public Nullable<long> AgentCostPercent { get; set; }

        /// <summary>
        /// 经销默认采购价比例，注意：100.00%，则输入为10000
        /// </summary>
        public Nullable<long> DealerCostPercent { get; set; }

        /// <summary>
        /// 产品线名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 产品线ID
        /// </summary>
        public Nullable<long> ProductLineId { get; set; }

        /// <summary>
        /// 最高零售价比例，注意：100.00%，则输入为10000
        /// </summary>
        public Nullable<long> RetailHighPercent { get; set; }

        /// <summary>
        /// 最低零售价比例，注意：100.00%，则输入为10000
        /// </summary>
        public Nullable<long> RetailLowPercent { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.productcat.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_cost_percent", this.AgentCostPercent);
            parameters.Add("dealer_cost_percent", this.DealerCostPercent);
            parameters.Add("name", this.Name);
            parameters.Add("product_line_id", this.ProductLineId);
            parameters.Add("retail_high_percent", this.RetailHighPercent);
            parameters.Add("retail_low_percent", this.RetailLowPercent);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("agent_cost_percent", this.AgentCostPercent, 99999);
            RequestValidator.ValidateMinValue("agent_cost_percent", this.AgentCostPercent, 100);
            RequestValidator.ValidateMaxValue("dealer_cost_percent", this.DealerCostPercent, 99999);
            RequestValidator.ValidateMinValue("dealer_cost_percent", this.DealerCostPercent, 100);
            RequestValidator.ValidateMaxLength("name", this.Name, 10);
            RequestValidator.ValidateRequired("product_line_id", this.ProductLineId);
            RequestValidator.ValidateMaxValue("retail_high_percent", this.RetailHighPercent, 99999);
            RequestValidator.ValidateMinValue("retail_high_percent", this.RetailHighPercent, 100);
            RequestValidator.ValidateMaxValue("retail_low_percent", this.RetailLowPercent, 99999);
            RequestValidator.ValidateMinValue("retail_low_percent", this.RetailLowPercent, 100);
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
