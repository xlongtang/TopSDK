using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// JzConsignArgs Data Structure.
    /// </summary>
    [Serializable]
    public class JzConsignArgs : TopObject
    {
        /// <summary>
        /// 运单号（灯具安装，卫浴小件安装等，不包含商家自有物流运单号）
        /// </summary>
        [XmlElement("mail_no")]
        public string MailNo { get; set; }

        /// <summary>
        /// 包裹数目
        /// </summary>
        [XmlElement("package_number")]
        public string PackageNumber { get; set; }

        /// <summary>
        /// 包裹备注信息
        /// </summary>
        [XmlElement("package_remark")]
        public string PackageRemark { get; set; }

        /// <summary>
        /// 包裹体积
        /// </summary>
        [XmlElement("package_volume")]
        public string PackageVolume { get; set; }

        /// <summary>
        /// 包裹重量
        /// </summary>
        [XmlElement("package_weight")]
        public string PackageWeight { get; set; }

        /// <summary>
        /// 商家自有物流对应的公司, Partner中virualType为1的状态下，必填项。
        /// </summary>
        [XmlElement("zy_company")]
        public string ZyCompany { get; set; }

        /// <summary>
        /// 发货时间（商家自有物流对应发货时间）,Partner中virualType为1的状态下，必填项。
        /// </summary>
        [XmlElement("zy_consign_time")]
        public string ZyConsignTime { get; set; }

        /// <summary>
        /// 商家自有物流对应的运单号，Partner中virualType为1的状态下，必填项
        /// </summary>
        [XmlElement("zy_mail_no")]
        public string ZyMailNo { get; set; }

        /// <summary>
        /// 商家自有物流对应物流公司电话，Partner中virualType为1的状态下，必填项
        /// </summary>
        [XmlElement("zy_phone_number")]
        public string ZyPhoneNumber { get; set; }
    }
}
