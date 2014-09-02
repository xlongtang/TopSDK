using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.travel.itemsprops.get
    /// </summary>
    public class TravelItemspropsGetRequest : ITopRequest<TravelItemspropsGetResponse>
    {
        /// <summary>
        /// 商品所属叶子类目ID，支持旅游度假线路8个类目。
        /// </summary>
        public Nullable<long> Cid { get; set; }

        /// <summary>
        /// 属性id (取某个类目属性时，传pid；若不传该值，返回该类目下所有属性)
        /// </summary>
        public Nullable<long> Pid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.travel.itemsprops.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cid", this.Cid);
            parameters.Add("pid", this.Pid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cid", this.Cid);
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
