using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hotel.order.get
    /// </summary>
    public class HotelOrderGetRequest : ITopRequest<HotelOrderGetResponse>
    {
        /// <summary>
        /// 是否需要返回该订单的入住人列表。可选值：true，false。
        /// </summary>
        public Nullable<bool> NeedGuest { get; set; }

        /// <summary>
        /// 是否显示买家留言，可选值true、false
        /// </summary>
        public Nullable<bool> NeedMessage { get; set; }

        /// <summary>
        /// 酒店订单oid，必须为数字。oid，tid必须传一项，同时传递的情况下，作为查询条件的优先级由高到低依次为oid，tid。
        /// </summary>
        public Nullable<long> Oid { get; set; }

        /// <summary>
        /// 淘宝订单tid，必须为数字。oid，tid必须传一项，同时传递的情况下，作为查询条件的优先级由高到低依次为oid，tid。
        /// </summary>
        public Nullable<long> Tid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hotel.order.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("need_guest", this.NeedGuest);
            parameters.Add("need_message", this.NeedMessage);
            parameters.Add("oid", this.Oid);
            parameters.Add("tid", this.Tid);
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
