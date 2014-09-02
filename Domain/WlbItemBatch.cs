using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WlbItemBatch Data Structure.
    /// </summary>
    [Serializable]
    public class WlbItemBatch : TopObject
    {
        /// <summary>
        /// 批次编号
        /// </summary>
        [XmlElement("batch_code")]
        public string BatchCode { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 残次数量
        /// </summary>
        [XmlElement("defect_quantity")]
        public long DefectQuantity { get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        [XmlElement("due_date")]
        public string DueDate { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 保质期
        /// </summary>
        [XmlElement("guarantee_period")]
        public string GuaranteePeriod { get; set; }

        /// <summary>
        /// 天（单位）
        /// </summary>
        [XmlElement("guarantee_unit")]
        public long GuaranteeUnit { get; set; }

        /// <summary>
        /// 商品批次记录id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 是否删除。0：正常 1：删除
        /// </summary>
        [XmlElement("is_deleted")]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 最后修改者
        /// </summary>
        [XmlElement("last_modifier")]
        public string LastModifier { get; set; }

        /// <summary>
        /// 产地
        /// </summary>
        [XmlElement("produce_area")]
        public string ProduceArea { get; set; }

        /// <summary>
        /// 生产编号
        /// </summary>
        [XmlElement("produce_code")]
        public string ProduceCode { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        [XmlElement("produce_date")]
        public string ProduceDate { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 接受日期
        /// </summary>
        [XmlElement("receive_date")]
        public string ReceiveDate { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// 状态。item_batch_status_open:开放 item_batch_status_lock:冻结 item_batch_status_invalid:无效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 存储类型
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [XmlElement("version")]
        public long Version { get; set; }
    }
}
