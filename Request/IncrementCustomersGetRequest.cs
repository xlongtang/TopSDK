using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.increment.customers.get
    /// </summary>
    public class IncrementCustomersGetRequest : ITopRequest<IncrementCustomersGetResponse>
    {
        /// <summary>
        /// 需要返回的字段。可填写的字段参见AppCustomer中的返回字段。如：nick,created,status,type,subscriptions。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 查询用户的昵称。当为空时通过分页方式查询appkey开通的所有用户,最多填入20个昵称。
        /// </summary>
        public string Nicks { get; set; }

        /// <summary>
        /// 分页查询时，查询的页码。此参数只有nicks为空时起作用。
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 分布查询时，页的大小。此参数只有当nicks为空时起作用。
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 查询用户开通的功能。值可为get,notify和syn分别表示增量api取消息，主动发送消息和同步数据功能。这三个值不分次序。在查询时，type里面的参数会根据应用订阅的类型进行相应的过虑。如应用只订阅主动通知，则默认值过滤后为get,notify，如果应用只订阅数据同步服务，默认值过滤后为syn。
        /// </summary>
        public string Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.increment.customers.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("nicks", this.Nicks);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxListSize("nicks", this.Nicks, 20);
            RequestValidator.ValidateMinValue("page_no", this.PageNo, 0);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 200);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 0);
            RequestValidator.ValidateMaxListSize("type", this.Type, 3);
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
