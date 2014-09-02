using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.waimai.address.operate
    /// </summary>
    public class WaimaiAddressOperateRequest : ITopRequest<WaimaiAddressOperateResponse>
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 城市汉字名称
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 是否是默认地址
        /// </summary>
        public Nullable<long> Defaulted { get; set; }

        /// <summary>
        /// 地址ID
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 经度保留8位有效整数
        /// </summary>
        public Nullable<long> X { get; set; }

        /// <summary>
        /// 纬度保留7位有效整数
        /// </summary>
        public Nullable<long> Y { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.waimai.address.operate";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("address", this.Address);
            parameters.Add("city", this.City);
            parameters.Add("defaulted", this.Defaulted);
            parameters.Add("id", this.Id);
            parameters.Add("name", this.Name);
            parameters.Add("phone", this.Phone);
            parameters.Add("x", this.X);
            parameters.Add("y", this.Y);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", this.Name);
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
