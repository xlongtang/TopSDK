using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.logistics.order.create
    /// </summary>
    public class LogisticsOrderCreateRequest : ITopRequest<LogisticsOrderCreateResponse>
    {
        /// <summary>
        /// 运送的货物名称列表，用|号隔开
        /// </summary>
        public string GoodsNames { get; set; }

        /// <summary>
        /// 运送货物的数量列表，用|号隔开
        /// </summary>
        public string GoodsQuantities { get; set; }

        /// <summary>
        /// 创建订单同时是否进行发货，默认发货。
        /// </summary>
        public Nullable<bool> IsConsign { get; set; }

        /// <summary>
        /// 运送货物的单价列表(注意：单位为分），用|号隔开
        /// </summary>
        public string ItemValues { get; set; }

        /// <summary>
        /// 发货的物流公司代码，如申通=STO，圆通=YTO。is_consign=true时，此项必填。
        /// </summary>
        public string LogisCompanyCode { get; set; }

        /// <summary>
        /// 发货方式,默认为自己联系发货。可选值:ONLINE(在线下单)、OFFLINE(自己联系)。
        /// </summary>
        public string LogisType { get; set; }

        /// <summary>
        /// 发货的物流公司运单号。在logis_type=OFFLINE且is_consign=true时，此项必填。
        /// </summary>
        public string MailNo { get; set; }

        /// <summary>
        /// 收货人详细地址，比如”浙江省^^^杭州市^^^下城区^^^文二路“，中间用“^^^”分隔
        /// </summary>
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// 收货人手机号码（若此处为空，则电话必填）
        /// </summary>
        public string ReceiverMobilePhone { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收货人电话号码（若此处为空，则手机号码必填）
        /// </summary>
        public string ReceiverTelephone { get; set; }

        /// <summary>
        /// 收货人邮编
        /// </summary>
        public string ReceiverZipCode { get; set; }

        /// <summary>
        /// 卖家旺旺号
        /// </summary>
        public string SellerWangwangId { get; set; }

        /// <summary>
        /// 发货人详细地址，比如”浙江省^^^杭州市^^^下城区^^^文二路“，中间用“^^^”分隔
        /// </summary>
        public string SenderAddress { get; set; }

        /// <summary>
        /// 发货人手机号码（若此处为空，则电话必填）
        /// </summary>
        public string SenderMobilePhone { get; set; }

        /// <summary>
        /// 发货人姓名
        /// </summary>
        public string SenderName { get; set; }

        /// <summary>
        /// 发货人电话号码（如此处为空，则手机号码必填）
        /// </summary>
        public string SenderTelephone { get; set; }

        /// <summary>
        /// 发货人邮编
        /// </summary>
        public string SenderZipCode { get; set; }

        /// <summary>
        /// 运费承担方式。1为买家承担运费，2为卖家承担运费，其他值为错误参数。
        /// </summary>
        public Nullable<long> Shipping { get; set; }

        /// <summary>
        /// 订单的交易号码
        /// </summary>
        public Nullable<long> TradeId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.logistics.order.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("goods_names", this.GoodsNames);
            parameters.Add("goods_quantities", this.GoodsQuantities);
            parameters.Add("is_consign", this.IsConsign);
            parameters.Add("item_values", this.ItemValues);
            parameters.Add("logis_company_code", this.LogisCompanyCode);
            parameters.Add("logis_type", this.LogisType);
            parameters.Add("mail_no", this.MailNo);
            parameters.Add("receiver_address", this.ReceiverAddress);
            parameters.Add("receiver_mobile_phone", this.ReceiverMobilePhone);
            parameters.Add("receiver_name", this.ReceiverName);
            parameters.Add("receiver_telephone", this.ReceiverTelephone);
            parameters.Add("receiver_zip_code", this.ReceiverZipCode);
            parameters.Add("seller_wangwang_id", this.SellerWangwangId);
            parameters.Add("sender_address", this.SenderAddress);
            parameters.Add("sender_mobile_phone", this.SenderMobilePhone);
            parameters.Add("sender_name", this.SenderName);
            parameters.Add("sender_telephone", this.SenderTelephone);
            parameters.Add("sender_zip_code", this.SenderZipCode);
            parameters.Add("shipping", this.Shipping);
            parameters.Add("trade_id", this.TradeId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("goods_names", this.GoodsNames);
            RequestValidator.ValidateRequired("goods_quantities", this.GoodsQuantities);
            RequestValidator.ValidateRequired("item_values", this.ItemValues);
            RequestValidator.ValidateRequired("receiver_address", this.ReceiverAddress);
            RequestValidator.ValidateRequired("receiver_name", this.ReceiverName);
            RequestValidator.ValidateRequired("receiver_zip_code", this.ReceiverZipCode);
            RequestValidator.ValidateRequired("seller_wangwang_id", this.SellerWangwangId);
            RequestValidator.ValidateRequired("sender_address", this.SenderAddress);
            RequestValidator.ValidateRequired("sender_name", this.SenderName);
            RequestValidator.ValidateRequired("sender_zip_code", this.SenderZipCode);
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
