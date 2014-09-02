using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.insight.catstopwordnew.get
    /// </summary>
    public class SimbaInsightCatstopwordnewGetRequest : ITopRequest<SimbaInsightCatstopwordnewGetResponse>
    {
        /// <summary>
        /// 类目id
        /// </summary>
        public string CatId { get; set; }

        /// <summary>
        /// 表示查询的维度，比如选择click，则查询该类目下点击量最大的词，可供选择的值有：impression, click, cost, ctr, cpc, coverage, transactiontotal, transactionshippingtotal, favtotal, roi
        /// </summary>
        public string Dimension { get; set; }

        /// <summary>
        /// 查询截止时间，格式只能是：yyyy-MM-dd
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// 返回前多少条数据<br /> 支持最大值为：20<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 查询开始时间，格式必须为：yyyy-MM-dd
        /// </summary>
        public string StartDate { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.insight.catstopwordnew.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cat_id", this.CatId);
            parameters.Add("dimension", this.Dimension);
            parameters.Add("end_date", this.EndDate);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_date", this.StartDate);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cat_id", this.CatId);
            RequestValidator.ValidateRequired("dimension", this.Dimension);
            RequestValidator.ValidateRequired("end_date", this.EndDate);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 20);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
            RequestValidator.ValidateRequired("start_date", this.StartDate);
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
