using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.trademonitor.get
    /// </summary>
    public class FenxiaoTrademonitorGetRequest : ITopRequest<FenxiaoTrademonitorGetResponse>
    {
        /// <summary>
        /// 经销商的淘宝账号
        /// </summary>
        public string DistributorNick { get; set; }

        /// <summary>
        /// 结束时间 格式 yyyy-MM-dd HH:mm:ss.支持到秒的查询。若不传时分秒，默认为0时0分0秒。
        /// </summary>
        public Nullable<DateTime> EndCreated { get; set; }

        /// <summary>
        /// 多个字段用","分隔。 fields 如果为空：返回所有采购单对象(purchase_orders)字段。 如果不为空：返回指定采购单对象(purchase_orders)字段。例如：trade_monitors.item_title表示只返回item_title
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 页码。（大于0的整数。小于1按1计）
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页条数。（每页条数不超过50条，超过50或小于0均按50计）
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        /// <summary>
        /// 起始时间 格式 yyyy-MM-dd HH:mm:ss.支持到秒的查询。若不传时分秒，默认为0时0分0秒。
        /// </summary>
        public Nullable<DateTime> StartCreated { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.trademonitor.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("distributor_nick", this.DistributorNick);
            parameters.Add("end_created", this.EndCreated);
            parameters.Add("fields", this.Fields);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("start_created", this.StartCreated);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
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
