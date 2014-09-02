using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.logistics.address.modify
    /// </summary>
    public class LogisticsAddressModifyRequest : ITopRequest<LogisticsAddressModifyResponse>
    {
        /// <summary>
        /// 详细街道地址，不需要重复填写省/市/区
        /// </summary>
        public string Addr { get; set; }

        /// <summary>
        /// 默认退货地址。<br>  <font color='red'>选择此项(true)，将当前地址设为默认退货地址，撤消原默认退货地址</font>
        /// </summary>
        public Nullable<bool> CancelDef { get; set; }

        /// <summary>
        /// 所在市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 地址库ID
        /// </summary>
        public Nullable<long> ContactId { get; set; }

        /// <summary>
        /// 联系人姓名  <font color='red'>长度不可超过20个字节</font>
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// 区、县  <br><font color='red'>如果所在地区是海外的可以为空，否则为必参</font>
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// 默认取货地址。<br>  <font color='red'>选择此项(true)，将当前地址设为默认取货地址，撤消原默认取货地址</font>
        /// </summary>
        public Nullable<bool> GetDef { get; set; }

        /// <summary>
        /// 备注,<br><font color='red'>备注不能超过256字节</font>
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 手机号码，手机与电话必需有一个 <br><font color='red'>手机号码不能超过20位</font>
        /// </summary>
        public string MobilePhone { get; set; }

        /// <summary>
        /// 电话号码,手机与电话必需有一个
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 所在省
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 公司名称,  <br><font color='red'>公司名称长能不能超过20字节</font>
        /// </summary>
        public string SellerCompany { get; set; }

        /// <summary>
        /// 地区邮政编码  <br><font color='red'>如果所在地区是海外的可以为空，否则为必参</font>
        /// </summary>
        public string ZipCode { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.logistics.address.modify";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("addr", this.Addr);
            parameters.Add("cancel_def", this.CancelDef);
            parameters.Add("city", this.City);
            parameters.Add("contact_id", this.ContactId);
            parameters.Add("contact_name", this.ContactName);
            parameters.Add("country", this.Country);
            parameters.Add("get_def", this.GetDef);
            parameters.Add("memo", this.Memo);
            parameters.Add("mobile_phone", this.MobilePhone);
            parameters.Add("phone", this.Phone);
            parameters.Add("province", this.Province);
            parameters.Add("seller_company", this.SellerCompany);
            parameters.Add("zip_code", this.ZipCode);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("addr", this.Addr);
            RequestValidator.ValidateRequired("city", this.City);
            RequestValidator.ValidateRequired("contact_id", this.ContactId);
            RequestValidator.ValidateRequired("contact_name", this.ContactName);
            RequestValidator.ValidateRequired("province", this.Province);
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
