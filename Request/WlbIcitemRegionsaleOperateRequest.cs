using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.icitem.regionsale.operate
    /// </summary>
    public class WlbIcitemRegionsaleOperateRequest : ITopRequest<WlbIcitemRegionsaleOperateResponse>
    {
        /// <summary>
        /// 前台宝贝id
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// 1:表示添加区域化销售服务  -1:表示去除区域化销售服务
        /// </summary>
        public Nullable<long> OpType { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.icitem.regionsale.operate";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("item_id", this.ItemId);
            parameters.Add("op_type", this.OpType);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("item_id", this.ItemId);
            RequestValidator.ValidateRequired("op_type", this.OpType);
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
