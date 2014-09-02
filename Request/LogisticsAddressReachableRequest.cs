using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.logistics.address.reachable
    /// </summary>
    public class LogisticsAddressReachableRequest : ITopRequest<LogisticsAddressReachableResponse>
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 标准区域编码(三级行政区编码或是四级行政区)，可以通过taobao.areas.get获取，如北京市朝阳区为110105
        /// </summary>
        public string AreaCode { get; set; }

        /// <summary>
        /// 物流公司编码ID，可以从这个接口获取所有物流公司的标准编码taobao.logistics.companies.get，可以传入多个值，以英文逗号分隔，如“1000000952,1000000953”
        /// </summary>
        public string PartnerIds { get; set; }

        /// <summary>
        /// 服务对应的数字编码，如揽派范围对应88
        /// </summary>
        public Nullable<long> ServiceType { get; set; }

        /// <summary>
        /// 发货地，标准区域编码(四级行政)，可以通过taobao.areas.get获取，如浙江省杭州市余杭区闲林街道为 330110011
        /// </summary>
        public string SourceAreaCode { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.logistics.address.reachable";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("address", this.Address);
            parameters.Add("area_code", this.AreaCode);
            parameters.Add("partner_ids", this.PartnerIds);
            parameters.Add("service_type", this.ServiceType);
            parameters.Add("source_area_code", this.SourceAreaCode);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("partner_ids", this.PartnerIds);
            RequestValidator.ValidateRequired("service_type", this.ServiceType);
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
