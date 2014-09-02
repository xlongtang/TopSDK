using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hanoi.action.get.single
    /// </summary>
    public class HanoiActionGetSingleRequest : ITopRequest<HanoiActionGetSingleResponse>
    {
        /// <summary>
        /// action的code
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// action的id
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// action的name
        /// </summary>
        public string Name { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hanoi.action.get.single";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("action_code", this.ActionCode);
            parameters.Add("id", this.Id);
            parameters.Add("name", this.Name);
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
