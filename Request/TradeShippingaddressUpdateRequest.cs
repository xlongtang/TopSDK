using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.shippingaddress.update
    /// </summary>
    public class TradeShippingaddressUpdateRequest : ITopRequest<TradeShippingaddressUpdateResponse>
    {
        /// <summary>
        /// 收货地址。最大长度为228个字节。
        /// </summary>
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// 城市。最大长度为32个字节。如：杭州
        /// </summary>
        public string ReceiverCity { get; set; }

        /// <summary>
        /// 区/县。最大长度为32个字节。如：西湖区
        /// </summary>
        public string ReceiverDistrict { get; set; }

        /// <summary>
        /// 移动电话。最大长度为30个字节。
        /// </summary>
        public string ReceiverMobile { get; set; }

        /// <summary>
        /// 收货人全名。最大长度为50个字节。
        /// </summary>
        public string ReceiverName { get; set; }

        /// <summary>
        /// 固定电话。最大长度为30个字节。
        /// </summary>
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 省份。最大长度为32个字节。如：浙江
        /// </summary>
        public string ReceiverState { get; set; }

        /// <summary>
        /// 邮政编码。必须由6个数字组成。
        /// </summary>
        public string ReceiverZip { get; set; }

        /// <summary>
        /// 交易编号。
        /// </summary>
        public Nullable<long> Tid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.shippingaddress.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("receiver_address", this.ReceiverAddress);
            parameters.Add("receiver_city", this.ReceiverCity);
            parameters.Add("receiver_district", this.ReceiverDistrict);
            parameters.Add("receiver_mobile", this.ReceiverMobile);
            parameters.Add("receiver_name", this.ReceiverName);
            parameters.Add("receiver_phone", this.ReceiverPhone);
            parameters.Add("receiver_state", this.ReceiverState);
            parameters.Add("receiver_zip", this.ReceiverZip);
            parameters.Add("tid", this.Tid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("receiver_address", this.ReceiverAddress, 228);
            RequestValidator.ValidateMaxLength("receiver_city", this.ReceiverCity, 32);
            RequestValidator.ValidateMaxLength("receiver_district", this.ReceiverDistrict, 32);
            RequestValidator.ValidateMaxLength("receiver_mobile", this.ReceiverMobile, 30);
            RequestValidator.ValidateMaxLength("receiver_name", this.ReceiverName, 50);
            RequestValidator.ValidateMaxLength("receiver_phone", this.ReceiverPhone, 30);
            RequestValidator.ValidateMaxLength("receiver_state", this.ReceiverState, 32);
            RequestValidator.ValidateMaxLength("receiver_zip", this.ReceiverZip, 6);
            RequestValidator.ValidateRequired("tid", this.Tid);
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
