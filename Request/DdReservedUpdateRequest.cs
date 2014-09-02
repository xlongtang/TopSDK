using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.dd.reserved.update
    /// </summary>
    public class DdReservedUpdateRequest : ITopRequest<DdReservedUpdateResponse>
    {
        /// <summary>
        /// 预定订单编号
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 0-未标注 1-已到店 2-未到店 3-不来了
        /// </summary>
        public Nullable<long> Mark { get; set; }

        /// <summary>
        /// 打印状态    * 0 : 未打印    * 1 : 已打印    * 2 : 已处理
        /// </summary>
        public Nullable<long> Option { get; set; }

        /// <summary>
        /// 淘宝店铺id
        /// </summary>
        public string StoreId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.dd.reserved.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
            parameters.Add("mark", this.Mark);
            parameters.Add("option", this.Option);
            parameters.Add("store_id", this.StoreId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", this.Id);
            RequestValidator.ValidateRequired("store_id", this.StoreId);
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
