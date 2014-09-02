using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alipay.ebpp.bill.key.search
    /// </summary>
    public class AlipayEbppBillKeySearchRequest : ITopRequest<AlipayEbppBillKeySearchResponse>
    {
        /// <summary>
        /// 支付宝给每个出账机构指定了一个对应的英文短名称来唯一表示该收费单位。<br /> 支持最大长度为：80<br /> 支持的最大列表长度为：80
        /// </summary>
        public string ChargeInst { get; set; }

        /// <summary>
        /// 结束时间。与开始时间间隔在七天之内
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// 需要返回的字段列表。bill_key:户号
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 是否仅包含订阅数据
        /// </summary>
        public Nullable<bool> OnlySubscribed { get; set; }

        /// <summary>
        /// 支付宝订单类型。公共事业缴纳JF,信用卡还款HK<br /> 支持最大长度为：10<br /> 支持的最大列表长度为：10
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 开始时间，时间必须是今天范围之内。格式为yyyy-MM-dd HH:mm:ss，精确到天
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// 子业务类型是业务类型的下一级概念，例如：WATER表示JF下面的水费，ELECTRIC表示JF下面的电费，GAS表示JF下面的燃气费。<br /> 支持最大长度为：10<br /> 支持的最大列表长度为：10
        /// </summary>
        public string SubOrderType { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "alipay.ebpp.bill.key.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("charge_inst", this.ChargeInst);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("fields", this.Fields);
            parameters.Add("only_subscribed", this.OnlySubscribed);
            parameters.Add("order_type", this.OrderType);
            parameters.Add("start_time", this.StartTime);
            parameters.Add("sub_order_type", this.SubOrderType);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("charge_inst", this.ChargeInst);
            RequestValidator.ValidateMaxLength("charge_inst", this.ChargeInst, 80);
            RequestValidator.ValidateRequired("end_time", this.EndTime);
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateRequired("order_type", this.OrderType);
            RequestValidator.ValidateMaxLength("order_type", this.OrderType, 10);
            RequestValidator.ValidateRequired("start_time", this.StartTime);
            RequestValidator.ValidateRequired("sub_order_type", this.SubOrderType);
            RequestValidator.ValidateMaxLength("sub_order_type", this.SubOrderType, 10);
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
