using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.udp.juhuasuan.get
    /// </summary>
    public class UdpJuhuasuanGetRequest : ITopRequest<UdpJuhuasuanGetResponse>
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        public Nullable<DateTime> BeginTime { get; set; }

        /// <summary>
        /// 类目编号
        /// </summary>
        public Nullable<long> Catid { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 指标ID(参阅指标编号)
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 2407364
        /// </summary>
        public Nullable<long> Itemid { get; set; }

        /// <summary>
        /// 备用
        /// </summary>
        public string Parameters { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.udp.juhuasuan.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("begin_time", this.BeginTime);
            parameters.Add("catid", this.Catid);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("fields", this.Fields);
            parameters.Add("itemid", this.Itemid);
            parameters.Add("parameters", this.Parameters);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateMaxListSize("fields", this.Fields, 100);
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
