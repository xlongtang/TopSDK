using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.udp.shop.get
    /// </summary>
    public class UdpShopGetRequest : ITopRequest<UdpShopGetResponse>
    {
        /// <summary>
        /// 地区ID(参阅地区编号)
        /// </summary>
        public Nullable<long> Area { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public Nullable<DateTime> BeginTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 指标ID(参阅指标编号)
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 备用
        /// </summary>
        public string Parameters { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.udp.shop.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("area", this.Area);
            parameters.Add("begin_time", this.BeginTime);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("fields", this.Fields);
            parameters.Add("parameters", this.Parameters);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("area", this.Area);
            RequestValidator.ValidateRequired("begin_time", this.BeginTime);
            RequestValidator.ValidateRequired("end_time", this.EndTime);
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateMaxListSize("fields", this.Fields, 10);
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
