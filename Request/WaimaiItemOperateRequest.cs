using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.waimai.item.operate
    /// </summary>
    public class WaimaiItemOperateRequest : ITopRequest<WaimaiItemOperateResponse>
    {
        /// <summary>
        /// 待操作宝贝id，多个以英文逗号分隔
        /// </summary>
        public string Ids { get; set; }

        /// <summary>
        /// 操作类型(1上架2下架3删除)
        /// </summary>
        public Nullable<long> O { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.waimai.item.operate";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("ids", this.Ids);
            parameters.Add("o", this.O);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ids", this.Ids);
            RequestValidator.ValidateRequired("o", this.O);
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
