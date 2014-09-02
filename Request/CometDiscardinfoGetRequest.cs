using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.comet.discardinfo.get
    /// </summary>
    public class CometDiscardinfoGetRequest : ITopRequest<CometDiscardinfoGetResponse>
    {
        /// <summary>
        /// 指定截止日志，如果不传则为服务端当前时间
        /// </summary>
        public Nullable<DateTime> End { get; set; }

        /// <summary>
        /// 用户nick
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 指定从那个时间开始找丢弃的消息
        /// </summary>
        public Nullable<DateTime> Start { get; set; }

        /// <summary>
        /// 指定多个消息类型
        /// </summary>
        public string Types { get; set; }

        /// <summary>
        /// 指定查看那个用户的丢弃消息
        /// </summary>
        public Nullable<long> UserId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.comet.discardinfo.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end", this.End);
            parameters.Add("nick", this.Nick);
            parameters.Add("start", this.Start);
            parameters.Add("types", this.Types);
            parameters.Add("user_id", this.UserId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("start", this.Start);
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
