using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Store Data Structure.
    /// </summary>
    [Serializable]
    public class Store : TopObject
    {
        /// <summary>
        /// 仓库的物理地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 仓库对应的淘宝区域
        /// </summary>
        [XmlElement("address_area_name")]
        public string AddressAreaName { get; set; }

        /// <summary>
        /// 仓库简称
        /// </summary>
        [XmlElement("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [XmlElement("contact")]
        public string Contact { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        [XmlElement("post_code")]
        public string PostCode { get; set; }

        /// <summary>
        /// 商家的仓库编码，不允许重复
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }

        /// <summary>
        /// 商家的仓库名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 仓库类型
        /// </summary>
        [XmlElement("store_type")]
        public string StoreType { get; set; }
    }
}
