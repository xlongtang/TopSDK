using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.logistics.consign.order.createandsend
    /// </summary>
    public class LogisticsConsignOrderCreateandsendRequest : ITopRequest<LogisticsConsignOrderCreateandsendResponse>
    {
        /// <summary>
        /// 物流公司ID
        /// </summary>
        public Nullable<long> CompanyId { get; set; }

        /// <summary>
        /// 物品的json数据。
        /// </summary>
        public string ItemJsonString { get; set; }

        /// <summary>
        /// 物流订单物流类型，值固定选择：2
        /// </summary>
        public Nullable<long> LogisType { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        public string MailNo { get; set; }

        /// <summary>
        /// 订单来源，值选择：30
        /// </summary>
        public Nullable<long> OrderSource { get; set; }

        /// <summary>
        /// 订单类型，值固定选择：30
        /// </summary>
        public Nullable<long> OrderType { get; set; }

        /// <summary>
        /// 收件人街道地址
        /// </summary>
        public string RAddress { get; set; }

        /// <summary>
        /// 收件人区域ID
        /// </summary>
        public Nullable<long> RAreaId { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        public string RCityName { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        public string RDistName { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string RMobilePhone { get; set; }

        /// <summary>
        /// 收件人名称
        /// </summary>
        public string RName { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        public string RProvName { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        public string RTelephone { get; set; }

        /// <summary>
        /// 收件人邮编
        /// </summary>
        public string RZipCode { get; set; }

        /// <summary>
        /// 发件人街道地址
        /// </summary>
        public string SAddress { get; set; }

        /// <summary>
        /// 发件人区域ID
        /// </summary>
        public Nullable<long> SAreaId { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        public string SCityName { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        public string SDistName { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string SMobilePhone { get; set; }

        /// <summary>
        /// 发件人名称
        /// </summary>
        public string SName { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        public string SProvName { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        public string STelephone { get; set; }

        /// <summary>
        /// 发件人出编
        /// </summary>
        public string SZipCode { get; set; }

        /// <summary>
        /// 费用承担方式 1买家承担运费 2卖家承担运费
        /// </summary>
        public string Shipping { get; set; }

        /// <summary>
        /// 交易流水号，淘外订单号或者商家内部交易流水号
        /// </summary>
        public Nullable<long> TradeId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public Nullable<long> UserId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.logistics.consign.order.createandsend";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("company_id", this.CompanyId);
            parameters.Add("item_json_string", this.ItemJsonString);
            parameters.Add("logis_type", this.LogisType);
            parameters.Add("mail_no", this.MailNo);
            parameters.Add("order_source", this.OrderSource);
            parameters.Add("order_type", this.OrderType);
            parameters.Add("r_address", this.RAddress);
            parameters.Add("r_area_id", this.RAreaId);
            parameters.Add("r_city_name", this.RCityName);
            parameters.Add("r_dist_name", this.RDistName);
            parameters.Add("r_mobile_phone", this.RMobilePhone);
            parameters.Add("r_name", this.RName);
            parameters.Add("r_prov_name", this.RProvName);
            parameters.Add("r_telephone", this.RTelephone);
            parameters.Add("r_zip_code", this.RZipCode);
            parameters.Add("s_address", this.SAddress);
            parameters.Add("s_area_id", this.SAreaId);
            parameters.Add("s_city_name", this.SCityName);
            parameters.Add("s_dist_name", this.SDistName);
            parameters.Add("s_mobile_phone", this.SMobilePhone);
            parameters.Add("s_name", this.SName);
            parameters.Add("s_prov_name", this.SProvName);
            parameters.Add("s_telephone", this.STelephone);
            parameters.Add("s_zip_code", this.SZipCode);
            parameters.Add("shipping", this.Shipping);
            parameters.Add("trade_id", this.TradeId);
            parameters.Add("user_id", this.UserId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("company_id", this.CompanyId);
            RequestValidator.ValidateRequired("item_json_string", this.ItemJsonString);
            RequestValidator.ValidateRequired("logis_type", this.LogisType);
            RequestValidator.ValidateRequired("order_source", this.OrderSource);
            RequestValidator.ValidateRequired("order_type", this.OrderType);
            RequestValidator.ValidateRequired("r_address", this.RAddress);
            RequestValidator.ValidateRequired("r_area_id", this.RAreaId);
            RequestValidator.ValidateRequired("r_city_name", this.RCityName);
            RequestValidator.ValidateRequired("r_name", this.RName);
            RequestValidator.ValidateRequired("r_prov_name", this.RProvName);
            RequestValidator.ValidateRequired("r_zip_code", this.RZipCode);
            RequestValidator.ValidateRequired("s_address", this.SAddress);
            RequestValidator.ValidateRequired("s_area_id", this.SAreaId);
            RequestValidator.ValidateRequired("s_city_name", this.SCityName);
            RequestValidator.ValidateRequired("s_name", this.SName);
            RequestValidator.ValidateRequired("s_prov_name", this.SProvName);
            RequestValidator.ValidateRequired("s_zip_code", this.SZipCode);
            RequestValidator.ValidateRequired("trade_id", this.TradeId);
            RequestValidator.ValidateRequired("user_id", this.UserId);
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
