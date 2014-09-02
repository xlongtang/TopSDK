using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// AddressResult Data Structure.
    /// </summary>
    [Serializable]
    public class AddressResult : TopObject
    {
        /// <summary>
        /// 详细街道地址，不需要重复填写省/市/区
        /// </summary>
        [XmlElement("addr")]
        public string Addr { get; set; }

        /// <summary>
        /// 区域ID
        /// </summary>
        [XmlElement("area_id")]
        public long AreaId { get; set; }

        /// <summary>
        /// 是否默认退货地址
        /// </summary>
        [XmlElement("cancel_def")]
        public bool CancelDef { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 地址库ID
        /// </summary>
        [XmlElement("contact_id")]
        public long ContactId { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 区、县
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 是否默认取货地址
        /// </summary>
        [XmlElement("get_def")]
        public bool GetDef { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 手机号码，手机与电话必需有一个   手机号码不能超过20位
        /// </summary>
        [XmlElement("mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 修改日期时间
        /// </summary>
        [XmlElement("modify_date")]
        public string ModifyDate { get; set; }

        /// <summary>
        /// 电话号码,手机与电话必需有一个
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 公司名称,
        /// </summary>
        [XmlElement("seller_company")]
        public string SellerCompany { get; set; }

        /// <summary>
        /// 是否默认发货地址
        /// </summary>
        [XmlElement("send_def")]
        public bool SendDef { get; set; }

        /// <summary>
        /// 地区邮政编码
        /// </summary>
        [XmlElement("zip_code")]
        public string ZipCode { get; set; }
    }
}
