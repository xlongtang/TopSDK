using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.adgroup.update
    /// </summary>
    public class SimbaAdgroupUpdateRequest : ITopRequest<SimbaAdgroupUpdateResponse>
    {
        /// <summary>
        /// 推广组Id
        /// </summary>
        public Nullable<long> AdgroupId { get; set; }

        /// <summary>
        /// 默认出价，单位是分，不能小于5<br /> 支持最小值为：5
        /// </summary>
        public Nullable<long> DefaultPrice { get; set; }

        /// <summary>
        /// 主人昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 非搜索出价，单位是分，不能小于5，如果use_nonseatch_default_price为使用默认出价，则此nonsearch_max_price字段传入的数据不起作用，商品将使用默认非搜索出价<br /> 支持最小值为：5
        /// </summary>
        public Nullable<long> NonsearchMaxPrice { get; set; }

        /// <summary>
        /// 用户设置的上下线状态 offline-下线(暂停竞价)； online-上线；默认为online
        /// </summary>
        public string OnlineStatus { get; set; }

        /// <summary>
        /// 非搜索是否使用默认出价，false-不用；true-使用；默认为true;
        /// </summary>
        public Nullable<bool> UseNonsearchDefaultPrice { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.adgroup.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("adgroup_id", this.AdgroupId);
            parameters.Add("default_price", this.DefaultPrice);
            parameters.Add("nick", this.Nick);
            parameters.Add("nonsearch_max_price", this.NonsearchMaxPrice);
            parameters.Add("online_status", this.OnlineStatus);
            parameters.Add("use_nonsearch_default_price", this.UseNonsearchDefaultPrice);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("adgroup_id", this.AdgroupId);
            RequestValidator.ValidateMinValue("default_price", this.DefaultPrice, 5);
            RequestValidator.ValidateMinValue("nonsearch_max_price", this.NonsearchMaxPrice, 5);
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
