using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.waybillallocation.requestwaybillnum
    /// </summary>
    public class WlbWaybillallocationRequestwaybillnumRequest : ITopRequest<WlbWaybillallocationRequestwaybillnumResponse>
    {
        /// <summary>
        /// 申请号码数量
        /// </summary>
        public Nullable<long> Num { get; set; }

        /// <summary>
        /// 外部去重号
        /// </summary>
        public string OutBizCode { get; set; }

        /// <summary>
        /// 面单类型
        /// </summary>
        public string PoolType { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        public string ServiceCode { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public Nullable<long> UserId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.waybillallocation.requestwaybillnum";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("num", this.Num);
            parameters.Add("out_biz_code", this.OutBizCode);
            parameters.Add("pool_type", this.PoolType);
            parameters.Add("service_code", this.ServiceCode);
            parameters.Add("user_id", this.UserId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("num", this.Num);
            RequestValidator.ValidateRequired("out_biz_code", this.OutBizCode);
            RequestValidator.ValidateRequired("pool_type", this.PoolType);
            RequestValidator.ValidateRequired("service_code", this.ServiceCode);
            RequestValidator.ValidateRequired("user_id", this.UserId);
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
