using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.increment.authorize.message.get
    /// </summary>
    public class IncrementAuthorizeMessageGetRequest : ITopRequest<IncrementAuthorizeMessageGetResponse>
    {
        /// <summary>
        /// 消息的结束时间，消息所对应的操作时间的最大值。和start_modified搭配使用能过滤消通知消息的时间段。不传时：如果设置了start_modified，默认为与start_modified同一天的23:59:59；否则默认为调用接口当天的23:59:59。（格式：yyyy-MM-dd HH:mm:ss）  注意：start_modified和end_modified的日期必须在必须在同一天内，比如：start_modified设置2000-01-01 00:00:00，则end_modified必须设置为2000-01-01这个日期
        /// </summary>
        public Nullable<DateTime> EndModified { get; set; }

        /// <summary>
        /// 消息所属的用户nick，他用型应用必传，自用型不传
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 页码，取值范围:大于零的整数; 默认值:1,即返回第一页数据。
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页条数，取值范围:大于零的整数;最大值:200;默认值:40
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 消息的开始时间，消息所对应的操作时间的最小值和end_modified搭配使用能过滤消通知消息的时间段。不传时：如果设置了end_modified，默认为与 end_modified同一天的00:00:00，否则默认为调用接口当天的00:00:00。（格式：yyyy-MM-dd HH:mm:ss）最早可取6天内的数据。 注意：start_modified和end_modified的日期必须在必须在同一天内，比如：start_modified设置2000-01-01 00:00:00，则end_modified必须设置为2000-01-01这个日期
        /// </summary>
        public Nullable<DateTime> StartModified { get; set; }

        /// <summary>
        /// 指定消息的状态，比如：ItemAdd，如果不填次参数，默认查询所有状态的数据，
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 消息类型，比如：item
        /// </summary>
        public string Topic { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.increment.authorize.message.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_modified", this.EndModified);
            parameters.Add("nick", this.Nick);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_modified", this.StartModified);
            parameters.Add("status", this.Status);
            parameters.Add("topic", this.Topic);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("page_no", this.PageNo, 1);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 200);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
            RequestValidator.ValidateRequired("topic", this.Topic);
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
