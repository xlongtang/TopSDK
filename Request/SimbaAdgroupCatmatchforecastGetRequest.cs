using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.adgroup.catmatchforecast.get
    /// </summary>
    public class SimbaAdgroupCatmatchforecastGetRequest : ITopRequest<SimbaAdgroupCatmatchforecastGetResponse>
    {
        /// <summary>
        /// 推广组ID
        /// </summary>
        public Nullable<long> AdgroupId { get; set; }

        /// <summary>
        /// 类目出价,出价范围在5-9999之间,单位分
        /// </summary>
        public Nullable<long> CatmatchPrice { get; set; }

        /// <summary>
        /// 主人昵称
        /// </summary>
        public string Nick { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.adgroup.catmatchforecast.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("adgroup_id", this.AdgroupId);
            parameters.Add("catmatch_price", this.CatmatchPrice);
            parameters.Add("nick", this.Nick);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("adgroup_id", this.AdgroupId);
            RequestValidator.ValidateRequired("catmatch_price", this.CatmatchPrice);
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
