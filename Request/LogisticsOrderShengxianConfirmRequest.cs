using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.logistics.order.shengxian.confirm
    /// </summary>
    public class LogisticsOrderShengxianConfirmRequest : ITopRequest<LogisticsOrderShengxianConfirmResponse>
    {
        /// <summary>
        /// 卖家联系人地址库ID，可以通过taobao.logistics.address.search接口查询到地址库ID。<br><font color='red'>如果为空，取的卖家的默认退货地址</font><br>
        /// </summary>
        public Nullable<long> CancelId { get; set; }

        /// <summary>
        /// 1：冷链。0：常温
        /// </summary>
        public Nullable<long> DeliveryType { get; set; }

        /// <summary>
        /// 物流订单ID 。同淘宝交易订单互斥，淘宝交易号存在，，以淘宝交易号为准<br /> 支持最小值为：1000
        /// </summary>
        public Nullable<long> LogisId { get; set; }

        /// <summary>
        /// 运单号.具体一个物流公司的真实运单号码。淘宝官方物流会校验，请谨慎传入；
        /// </summary>
        public string OutSid { get; set; }

        /// <summary>
        /// 商家的IP地址
        /// </summary>
        public string SellerIp { get; set; }

        /// <summary>
        /// 卖家联系人地址库ID，可以通过taobao.logistics.address.search接口查询到地址库ID。<font color='red'>如果为空，取的卖家的默认取货地址</font>    如果service_code不为空，默认使用service_code  如果service_code为空，sender_id不为空，使用sender_id对应的地址发货  如果service_code与sender_id都为空，使用默认地址发货
        /// </summary>
        public Nullable<long> SenderId { get; set; }

        /// <summary>
        /// 仓库的服务代码标示，代码一个仓库的实体。(可以通过taobao.wlb.stores.baseinfo.get接口查询)    如果service_code为空，默认通过sender_id来发货
        /// </summary>
        public string ServiceCode { get; set; }

        /// <summary>
        /// 淘宝交易ID<br /> 支持最小值为：1000
        /// </summary>
        public Nullable<long> Tid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.logistics.order.shengxian.confirm";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cancel_id", this.CancelId);
            parameters.Add("delivery_type", this.DeliveryType);
            parameters.Add("logis_id", this.LogisId);
            parameters.Add("out_sid", this.OutSid);
            parameters.Add("seller_ip", this.SellerIp);
            parameters.Add("sender_id", this.SenderId);
            parameters.Add("service_code", this.ServiceCode);
            parameters.Add("tid", this.Tid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("logis_id", this.LogisId, 1000);
            RequestValidator.ValidateRequired("out_sid", this.OutSid);
            RequestValidator.ValidateMinValue("tid", this.Tid, 1000);
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
