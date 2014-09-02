using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.amount.get
    /// </summary>
    public class TradeAmountGetRequest : ITopRequest<TradeAmountGetResponse>
    {
        /// <summary>
        /// 订单帐务详情需要返回的字段信息，可选值如下：  1. TradeAmount中可指定的fields：  tid,alipay_no,created,pay_time,end_time,total_fee,payment,post_fee,cod_fee,commission_fee,buyer_obtain_point_fee  2. OrderAmount中可指定的fields：order_amounts.oid,order_amounts.title,order_amounts.num_iid,  order_amounts.sku_properties_name,order_amounts.sku_id,order_amounts.num,order_amounts.price,order_amounts.discount_fee,order_amounts.adjust_fee,order_amounts.payment,order_amounts.promotion_name  3. order_amounts(返回OrderAmount的所有内容)  4. promotion_details(指定该值会返回主订单的promotion_details中除id之外的所有字段)
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 订单交易编号
        /// </summary>
        public Nullable<long> Tid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.amount.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("tid", this.Tid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateRequired("tid", this.Tid);
            RequestValidator.ValidateMaxValue("tid", this.Tid, 9223372036854775807);
            RequestValidator.ValidateMinValue("tid", this.Tid, -9223372036854775808);
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
