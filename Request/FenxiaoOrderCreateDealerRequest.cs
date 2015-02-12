using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.order.create.dealer
    /// </summary>
    public class FenxiaoOrderCreateDealerRequest : ITopRequest<FenxiaoOrderCreateDealerResponse>
    {
        /// <summary>
        /// 街道
        /// </summary>
        public string Addr { get; set; }

        /// <summary>
        /// 买家姓名
        /// </summary>
        public string BuyerName { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// 运费，单位为分
        /// </summary>
        public Nullable<long> LogisticFee { get; set; }

        /// <summary>
        /// 运输方式，快递,平邮等
        /// </summary>
        public string LogisticType { get; set; }

        /// <summary>
        /// 留言
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 买家手机号码和电话号码两者中必须有一个
        /// </summary>
        public string MobilePhone { get; set; }

        /// <summary>
        /// erp主订单号，用于去重。当传入号已存在将返回原来的采购单
        /// </summary>
        public Nullable<long> OuterId { get; set; }

        /// <summary>
        /// 支付类型,需要供应支持该支付类型
        /// </summary>
        public string PayType { get; set; }

        /// <summary>
        /// 买家电话号码
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 子单信息,子单内部以‘,’隔开，多个子单以‘;’隔开.  例(分销产品id,skuid,购买数量,单价;分销产品id:,skuid,购买数量,单价)  单价的单位位分
        /// </summary>
        public string SubOrderDetail { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        public string ZipCode { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.order.create.dealer";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("addr", this.Addr);
            parameters.Add("buyer_name", this.BuyerName);
            parameters.Add("city", this.City);
            parameters.Add("country", this.Country);
            parameters.Add("logistic_fee", this.LogisticFee);
            parameters.Add("logistic_type", this.LogisticType);
            parameters.Add("message", this.Message);
            parameters.Add("mobile_phone", this.MobilePhone);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("pay_type", this.PayType);
            parameters.Add("phone", this.Phone);
            parameters.Add("province", this.Province);
            parameters.Add("sub_order_detail", this.SubOrderDetail);
            parameters.Add("zip_code", this.ZipCode);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("addr", this.Addr);
            RequestValidator.ValidateRequired("buyer_name", this.BuyerName);
            RequestValidator.ValidateMaxLength("buyer_name", this.BuyerName, 20);
            RequestValidator.ValidateRequired("logistic_fee", this.LogisticFee);
            RequestValidator.ValidateRequired("logistic_type", this.LogisticType);
            RequestValidator.ValidateMaxLength("message", this.Message, 200);
            RequestValidator.ValidateRequired("outer_id", this.OuterId);
            RequestValidator.ValidateRequired("pay_type", this.PayType);
            RequestValidator.ValidateRequired("province", this.Province);
            RequestValidator.ValidateRequired("sub_order_detail", this.SubOrderDetail);
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
