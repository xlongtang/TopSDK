using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alipay.ebpp.bill.add
    /// </summary>
    public class AlipayEbppBillAddRequest : ITopRequest<AlipayEbppBillAddResponse>
    {
        /// <summary>
        /// 如果传入调用api有淘宝授权的session可以不传这个字段
        /// </summary>
        public string AuthToken { get; set; }

        /// <summary>
        /// 账单的账期，例如201203表示2012年3月的账单。
        /// </summary>
        public string BillDate { get; set; }

        /// <summary>
        /// 账单单据号，例如水费单号，手机号，电费号，信用卡卡号。没有唯一性要求。
        /// </summary>
        public string BillKey { get; set; }

        /// <summary>
        /// 支付宝给每个出账机构指定了一个对应的英文短名称来唯一表示该收费单位。
        /// </summary>
        public string ChargeInst { get; set; }

        /// <summary>
        /// 输出机构的业务流水号，需要保证唯一性。
        /// </summary>
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 用户的手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 支付宝订单类型。公共事业缴纳JF,信用卡还款HK
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 拥有该账单的用户姓名
        /// </summary>
        public string OwnerName { get; set; }

        /// <summary>
        /// 缴费金额。用户支付的总金额。单位为：RMB Yuan。取值范围为[0.01，100000000.00]，精确到小数点后两位。
        /// </summary>
        public string PayAmount { get; set; }

        /// <summary>
        /// 账单的服务费。
        /// </summary>
        public string ServiceAmount { get; set; }

        /// <summary>
        /// 子业务类型是业务类型的下一级概念，例如：WATER表示JF下面的水费，ELECTRIC表示JF下面的电费，GAS表示JF下面的燃气费。
        /// </summary>
        public string SubOrderType { get; set; }

        /// <summary>
        /// 交通违章地点，sub_order_type=TRAFFIC时填写。
        /// </summary>
        public string TrafficLocation { get; set; }

        /// <summary>
        /// 违章行为，sub_order_type=TRAFFIC时填写。
        /// </summary>
        public string TrafficRegulations { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "alipay.ebpp.bill.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("auth_token", this.AuthToken);
            parameters.Add("bill_date", this.BillDate);
            parameters.Add("bill_key", this.BillKey);
            parameters.Add("charge_inst", this.ChargeInst);
            parameters.Add("merchant_order_no", this.MerchantOrderNo);
            parameters.Add("mobile", this.Mobile);
            parameters.Add("order_type", this.OrderType);
            parameters.Add("owner_name", this.OwnerName);
            parameters.Add("pay_amount", this.PayAmount);
            parameters.Add("service_amount", this.ServiceAmount);
            parameters.Add("sub_order_type", this.SubOrderType);
            parameters.Add("traffic_location", this.TrafficLocation);
            parameters.Add("traffic_regulations", this.TrafficRegulations);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("bill_key", this.BillKey);
            RequestValidator.ValidateMaxLength("bill_key", this.BillKey, 50);
            RequestValidator.ValidateRequired("charge_inst", this.ChargeInst);
            RequestValidator.ValidateMaxLength("charge_inst", this.ChargeInst, 80);
            RequestValidator.ValidateRequired("merchant_order_no", this.MerchantOrderNo);
            RequestValidator.ValidateMaxLength("merchant_order_no", this.MerchantOrderNo, 32);
            RequestValidator.ValidateRequired("mobile", this.Mobile);
            RequestValidator.ValidateRequired("order_type", this.OrderType);
            RequestValidator.ValidateMaxLength("order_type", this.OrderType, 10);
            RequestValidator.ValidateMaxLength("owner_name", this.OwnerName, 50);
            RequestValidator.ValidateRequired("pay_amount", this.PayAmount);
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
