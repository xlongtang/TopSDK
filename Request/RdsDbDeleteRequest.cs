using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.rds.db.delete
    /// </summary>
    public class RdsDbDeleteRequest : ITopRequest<RdsDbDeleteResponse>
    {
        /// <summary>
        /// 数据库的name，可以通过 taobao.rds.db.get 获取
        /// </summary>
        public string DbName { get; set; }

        /// <summary>
        /// rds的实例名
        /// </summary>
        public string InstanceName { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.rds.db.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("db_name", this.DbName);
            parameters.Add("instance_name", this.InstanceName);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("db_name", this.DbName);
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
