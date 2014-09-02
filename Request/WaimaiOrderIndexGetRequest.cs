using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.waimai.order.index.get
    /// </summary>
    public class WaimaiOrderIndexGetRequest : ITopRequest<WaimaiOrderIndexGetResponse>
    {
        /// <summary>
        /// 订单创建时间的结束时间,格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// 获取最近一定秒数的订单
        /// </summary>
        public Nullable<long> Interval { get; set; }

        /// <summary>
        /// 订单状态 待确认订单2 , 退款中订单4 , 已发货12 关闭20 交易成功21
        /// </summary>
        public Nullable<long> OrderStatus { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        public Nullable<long> OrderType { get; set; }

        /// <summary>
        /// 页码<br /> 支持的最大列表长度为：100
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 返回记录数，超过200按200条返回数据<br /> 支持最大值为：200<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 外卖分店ID
        /// </summary>
        public Nullable<long> ShopId { get; set; }

        /// <summary>
        /// 订单创建时间的起点时间,格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string StartTime { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.waimai.order.index.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_time", this.EndTime);
            parameters.Add("interval", this.Interval);
            parameters.Add("order_status", this.OrderStatus);
            parameters.Add("order_type", this.OrderType);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("shop_id", this.ShopId);
            parameters.Add("start_time", this.StartTime);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 200);
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
