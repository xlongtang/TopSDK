using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.discount.add
    /// </summary>
    public class FenxiaoDiscountAddRequest : ITopRequest<FenxiaoDiscountAddResponse>
    {
        /// <summary>
        /// 折扣名称,长度不能超过25字节
        /// </summary>
        public string DiscountName { get; set; }

        /// <summary>
        /// PERCENT（按折扣优惠）、PRICE（按减价优惠），例如"PERCENT,PRICE,PERCENT"
        /// </summary>
        public string DiscountTypes { get; set; }

        /// <summary>
        /// 优惠比率或者优惠价格，例如：”8000,-2300,7000”,大小为-100000000到100000000之间（单位：分）
        /// </summary>
        public string DiscountValues { get; set; }

        /// <summary>
        /// 会员等级的id或者分销商id，例如：”1001,2001,1002”
        /// </summary>
        public string TargetIds { get; set; }

        /// <summary>
        /// GRADE（按会员等级优惠）、DISTRIBUTOR（按分销商优惠），例如"GRADE,DISTRIBUTOR"
        /// </summary>
        public string TargetTypes { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.discount.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("discount_name", this.DiscountName);
            parameters.Add("discount_types", this.DiscountTypes);
            parameters.Add("discount_values", this.DiscountValues);
            parameters.Add("target_ids", this.TargetIds);
            parameters.Add("target_types", this.TargetTypes);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("discount_name", this.DiscountName);
            RequestValidator.ValidateRequired("discount_types", this.DiscountTypes);
            RequestValidator.ValidateRequired("discount_values", this.DiscountValues);
            RequestValidator.ValidateRequired("target_ids", this.TargetIds);
            RequestValidator.ValidateRequired("target_types", this.TargetTypes);
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
