using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.rds.db.get
    /// </summary>
    public class RdsDbGetRequest : ITopRequest<RdsDbGetResponse>
    {
        /// <summary>
        /// 数据库状态，默认值1
        /// </summary>
        public Nullable<long> DbStatus { get; set; }

        /// <summary>
        /// rds的实例名
        /// </summary>
        public string InstanceName { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.rds.db.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("db_status", this.DbStatus);
            parameters.Add("instance_name", this.InstanceName);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("db_status", this.DbStatus, 3);
            RequestValidator.ValidateMinValue("db_status", this.DbStatus, 0);
            RequestValidator.ValidateRequired("instance_name", this.InstanceName);
            RequestValidator.ValidateMaxLength("instance_name", this.InstanceName, 30);
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
