using System;
using Top.Api.Domain;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.order.jzwithoutins.consign
    /// </summary>
    public class WlbOrderJzwithoutinsConsignRequest : ITopRequest<WlbOrderJzwithoutinsConsignResponse>
    {
        /// <summary>
        /// 包括package的信息和自有物流的信息
        /// </summary>
        public string JzConsignArgs { get; set; }

        /// <summary>
        /// 淘宝交易订单号
        /// </summary>
        public Nullable<long> Tid { get; set; }

        /// <summary>
        /// 物流配送服务服务商。若针对灯具安装和卫浴小件安装，请将快递公司的tpName，tpCode(对应companyCode)，还有对应的serviceType封装成Partner对象作为P1
        /// </summary>
        public string TmsPartner { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.order.jzwithoutins.consign";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("jz_consign_args", this.JzConsignArgs);
            parameters.Add("tid", this.Tid);
            parameters.Add("tms_partner", this.TmsPartner);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("jz_consign_args", this.JzConsignArgs);
            RequestValidator.ValidateRequired("tid", this.Tid);
            RequestValidator.ValidateRequired("tms_partner", this.TmsPartner);
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
