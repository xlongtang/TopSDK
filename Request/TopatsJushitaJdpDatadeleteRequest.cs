using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.topats.jushita.jdp.datadelete
    /// </summary>
    public class TopatsJushitaJdpDatadeleteRequest : ITopRequest<TopatsJushitaJdpDatadeleteResponse>
    {
        /// <summary>
        /// 删除数据时间段的结束修改时间，格式为：yyyy-MM-dd HH:mm:ss，结束时间必须为前天的23:59:59秒以前，根据是业务的modified时间
        /// </summary>
        public Nullable<DateTime> EndModified { get; set; }

        /// <summary>
        /// 删除数据时间段的起始修改时间，格式为：yyyy-MM-dd HH:mm:ss,根据是业务的modified时间
        /// </summary>
        public Nullable<DateTime> StartModified { get; set; }

        /// <summary>
        /// 推送的数据类型，可选值为：tb_trade(淘宝交易)，tb_item(淘宝商品)，tb_refund(淘宝退款)，fx_trade(分销订单)，tm_refund(天猫退款)，同时删除多种类型以分号分隔，如："tb_trade;tb_item;tb_refund;fx_trade;tm_refund"
        /// </summary>
        public string SyncType { get; set; }

        /// <summary>
        /// 用户昵称，不填表示删除所有用户的数据。
        /// </summary>
        public string UserNick { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.topats.jushita.jdp.datadelete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_modified", this.EndModified);
            parameters.Add("start_modified", this.StartModified);
            parameters.Add("sync_type", this.SyncType);
            parameters.Add("user_nick", this.UserNick);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("end_modified", this.EndModified);
            RequestValidator.ValidateRequired("start_modified", this.StartModified);
            RequestValidator.ValidateRequired("sync_type", this.SyncType);
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
