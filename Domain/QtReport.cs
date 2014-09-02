using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// QtReport Data Structure.
    /// </summary>
    [Serializable]
    public class QtReport : TopObject
    {
        /// <summary>
        /// 扩展属性通过冒号分隔属性与属性值. 分号分隔不同属性
        /// </summary>
        [XmlElement("ext_attr")]
        public string ExtAttr { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 质检有效期限
        /// </summary>
        [XmlElement("gmt_expiry")]
        public string GmtExpiry { get; set; }

        /// <summary>
        /// 出具报告时间。
        /// </summary>
        [XmlElement("gmt_report")]
        public string GmtReport { get; set; }

        /// <summary>
        /// 提交检查时间
        /// </summary>
        [XmlElement("gmt_submit")]
        public string GmtSubmit { get; set; }

        /// <summary>
        /// 质检报告在淘宝的Id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 是否合格
        /// </summary>
        [XmlElement("is_passed")]
        public bool IsPassed { get; set; }

        /// <summary>
        /// 样品的链接
        /// </summary>
        [XmlElement("item_url")]
        public string ItemUrl { get; set; }

        /// <summary>
        /// 不合格原因
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 送检人昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 样本宝贝id
        /// </summary>
        [XmlElement("num_iid")]
        public long NumIid { get; set; }

        /// <summary>
        /// 质检编号
        /// </summary>
        [XmlElement("qt_code")]
        public string QtCode { get; set; }

        /// <summary>
        /// 质检项名称
        /// </summary>
        [XmlElement("qt_name")]
        public string QtName { get; set; }

        /// <summary>
        /// 质检标准
        /// </summary>
        [XmlElement("qt_standard")]
        public string QtStandard { get; set; }

        /// <summary>
        /// 质检类型 0,全部 1,聚划算认证2,消保打标
        /// </summary>
        [XmlElement("qt_type")]
        public long QtType { get; set; }

        /// <summary>
        /// 质检报告地址
        /// </summary>
        [XmlElement("report_url")]
        public string ReportUrl { get; set; }

        /// <summary>
        /// 质检服务商名称
        /// </summary>
        [XmlElement("sp_name")]
        public string SpName { get; set; }

        /// <summary>
        /// 质检报告状态   0:已提交申请 1:已收到样品 2:已出检测结果 3.已出具报告
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
