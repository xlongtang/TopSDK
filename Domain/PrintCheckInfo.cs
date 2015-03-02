using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// PrintCheckInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PrintCheckInfo : TopObject
    {
        /// <summary>
        /// 收件人地址
        /// </summary>
        [XmlElement("consignee_address")]
        public WaybillAddress ConsigneeAddress { get; set; }

        /// <summary>
        /// 收货网点编码
        /// </summary>
        [XmlElement("consignee_branch_code")]
        public string ConsigneeBranchCode { get; set; }

        /// <summary>
        /// 收货网点信息
        /// </summary>
        [XmlElement("consignee_branch_name")]
        public string ConsigneeBranchName { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [XmlElement("consignee_name")]
        public string ConsigneeName { get; set; }

        /// <summary>
        /// consigneePhone
        /// </summary>
        [XmlElement("consignee_phone")]
        public string ConsigneePhone { get; set; }

        /// <summary>
        /// 物流服务能力集合
        /// </summary>
        [XmlArray("logistics_service_list")]
        [XmlArrayItem("logistics_service")]
        public List<LogisticsService> LogisticsServiceList { get; set; }

        /// <summary>
        /// 集包地、目的地中心代码。打 印时根据该 code 生成目的地 中心的条码，条码生成的算法 与对应的电子面单条码一致
        /// </summary>
        [XmlElement("package_center_code")]
        public string PackageCenterCode { get; set; }

        /// <summary>
        /// 集包地、目的地中心名称
        /// </summary>
        [XmlElement("package_center_name")]
        public string PackageCenterName { get; set; }

        /// <summary>
        /// 快递服务产品类型编码
        /// </summary>
        [XmlElement("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// 使用者ID
        /// </summary>
        [XmlElement("real_user_id")]
        public long RealUserId { get; set; }

        /// <summary>
        /// 发件人姓名
        /// </summary>
        [XmlElement("send_name")]
        public string SendName { get; set; }

        /// <summary>
        /// 发件人联系方式
        /// </summary>
        [XmlElement("send_phone")]
        public string SendPhone { get; set; }

        /// <summary>
        /// 发件人地址
        /// </summary>
        [XmlElement("shipping_address")]
        public WaybillAddress ShippingAddress { get; set; }

        /// <summary>
        /// 发货网点编码
        /// </summary>
        [XmlElement("shipping_branch_code")]
        public string ShippingBranchCode { get; set; }

        /// <summary>
        /// 发货网点信息
        /// </summary>
        [XmlElement("shipping_branch_name")]
        public string ShippingBranchName { get; set; }

        /// <summary>
        /// 拣货规则（大头笔信息）
        /// </summary>
        [XmlElement("short_address")]
        public string ShortAddress { get; set; }

        /// <summary>
        /// 包裹体积 单位为ML(毫升)或立方厘米
        /// </summary>
        [XmlElement("volume")]
        public long Volume { get; set; }

        /// <summary>
        /// 电子面单单号
        /// </summary>
        [XmlElement("waybill_code")]
        public string WaybillCode { get; set; }

        /// <summary>
        /// 包裹重量 单位为G(克)
        /// </summary>
        [XmlElement("weight")]
        public long Weight { get; set; }
    }
}
