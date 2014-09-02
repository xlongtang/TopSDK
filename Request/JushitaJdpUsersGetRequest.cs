using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jushita.jdp.users.get
    /// </summary>
    public class JushitaJdpUsersGetRequest : ITopRequest<JushitaJdpUsersGetResponse>
    {
        /// <summary>
        /// 此参数一般不用传，用于查询最后更改时间在某个时间段内的用户
        /// </summary>
        public Nullable<DateTime> EndModified { get; set; }

        /// <summary>
        /// 当前页数
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页记录数，默认200
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 此参数一般不用传，用于查询最后更改时间在某个时间段内的用户
        /// </summary>
        public Nullable<DateTime> StartModified { get; set; }

        /// <summary>
        /// 如果传了user_id表示单条查询
        /// </summary>
        public Nullable<long> UserId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.jushita.jdp.users.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_modified", this.EndModified);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_modified", this.StartModified);
            parameters.Add("user_id", this.UserId);
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
