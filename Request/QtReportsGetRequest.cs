using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qt.reports.get
    /// </summary>
    public class QtReportsGetRequest : ITopRequest<QtReportsGetResponse>
    {
        /// <summary>
        /// 查询时间段的结束时间
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 送检者昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 质检类型，目前只支持查询qt_type=11的类型
        /// </summary>
        public Nullable<long> QtType { get; set; }

        /// <summary>
        /// 收费项code
        /// </summary>
        public string ServcieItemCode { get; set; }

        /// <summary>
        /// 质检服务商名<br /> 支持最大长度为：50<br /> 支持的最大列表长度为：50
        /// </summary>
        public string SpName { get; set; }

        /// <summary>
        /// 查询时间段的开始时间
        /// </summary>
        public Nullable<DateTime> StartTime { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.qt.reports.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_time", this.EndTime);
            parameters.Add("nick", this.Nick);
            parameters.Add("qt_type", this.QtType);
            parameters.Add("servcie_item_code", this.ServcieItemCode);
            parameters.Add("sp_name", this.SpName);
            parameters.Add("start_time", this.StartTime);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("nick", this.Nick);
            RequestValidator.ValidateRequired("qt_type", this.QtType);
            RequestValidator.ValidateRequired("servcie_item_code", this.ServcieItemCode);
            RequestValidator.ValidateRequired("sp_name", this.SpName);
            RequestValidator.ValidateMaxLength("sp_name", this.SpName, 50);
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
