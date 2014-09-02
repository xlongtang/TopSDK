using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.adgroup.catmatch.update
    /// </summary>
    public class SimbaAdgroupCatmatchUpdateRequest : ITopRequest<SimbaAdgroupCatmatchUpdateResponse>
    {
        /// <summary>
        /// 推广组Id
        /// </summary>
        public Nullable<long> AdgroupId { get; set; }

        /// <summary>
        /// 类目出价Id
        /// </summary>
        public Nullable<long> CatmatchId { get; set; }

        /// <summary>
        /// 类目出价，单位为分，不能小于5。如果use_default_price字段为使用默认出价，则此max_price字段所传入的值不起作用。商品将会使用默认出价。<br /> 支持最小值为：5
        /// </summary>
        public Nullable<long> MaxPrice { get; set; }

        /// <summary>
        /// 主人昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 是否启用类目出价； offline-不启用 online-启用,如果此字段状态为offline时，则max_price,use_default_price字段值不起作用
        /// </summary>
        public string OnlineStatus { get; set; }

        /// <summary>
        /// 是否使用推广组默认出价false为不使用，true为使用
        /// </summary>
        public Nullable<bool> UseDefaultPrice { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.adgroup.catmatch.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("adgroup_id", this.AdgroupId);
            parameters.Add("catmatch_id", this.CatmatchId);
            parameters.Add("max_price", this.MaxPrice);
            parameters.Add("nick", this.Nick);
            parameters.Add("online_status", this.OnlineStatus);
            parameters.Add("use_default_price", this.UseDefaultPrice);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("adgroup_id", this.AdgroupId);
            RequestValidator.ValidateRequired("catmatch_id", this.CatmatchId);
            RequestValidator.ValidateRequired("max_price", this.MaxPrice);
            RequestValidator.ValidateMinValue("max_price", this.MaxPrice, 5);
            RequestValidator.ValidateRequired("online_status", this.OnlineStatus);
            RequestValidator.ValidateRequired("use_default_price", this.UseDefaultPrice);
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
