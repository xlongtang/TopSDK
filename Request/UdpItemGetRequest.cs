using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.udp.item.get
    /// </summary>
    public class UdpItemGetRequest : ITopRequest<UdpItemGetResponse>
    {
        /// <summary>
        /// 地区ID
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
        /// 商品ID
        /// </summary>
        public Nullable<long> Itemid { get; set; }

        /// <summary>
        /// 多个宝贝列表
        /// </summary>
        public string Items { get; set; }

        /// <summary>
        /// 排序指标
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// 排序规则
        /// </summary>
        public string OrderRule { get; set; }

        /// <summary>
        /// 查询页码，0为第一页
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 备用
        /// </summary>
        public string Parameters { get; set; }

        /// <summary>
        /// 来源ID
        /// </summary>
        public Nullable<long> Source { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.udp.item.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("area", this.Area);
            parameters.Add("begin_time", this.BeginTime);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("fields", this.Fields);
            parameters.Add("itemid", this.Itemid);
            parameters.Add("items", this.Items);
            parameters.Add("order_by", this.OrderBy);
            parameters.Add("order_rule", this.OrderRule);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("parameters", this.Parameters);
            parameters.Add("source", this.Source);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("begin_time", this.BeginTime);
            RequestValidator.ValidateRequired("end_time", this.EndTime);
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateMaxListSize("fields", this.Fields, 10);
            RequestValidator.ValidateMaxListSize("items", this.Items, 20);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 50);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
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
