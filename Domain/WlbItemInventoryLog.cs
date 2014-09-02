using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WlbItemInventoryLog Data Structure.
    /// </summary>
    [Serializable]
    public class WlbItemInventoryLog : TopObject
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [XmlElement("batch_code")]
        public string BatchCode { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 库存变更ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// VENDIBLE  1-可销售;  FREEZE  201-冻结库存;  ONWAY  301-在途库存;  DEFECT  101-残存品;  ENGINE_DAMAGE 102-机损;  BOX_DAMAGE 103-箱损
        /// </summary>
        [XmlElement("invent_type")]
        public string InventType { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 库存操作作类型  CHU_KU 1-出库  RU_KU 2-入库  FREEZE 3-冻结  THAW 4-解冻  CHECK_FREEZE 5-冻结确认  CHANGE_KU 6-库存类型变更
        /// </summary>
        [XmlElement("op_type")]
        public string OpType { get; set; }

        /// <summary>
        /// 库存操作者ID
        /// </summary>
        [XmlElement("op_user_id")]
        public long OpUserId { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_code")]
        public string OrderCode { get; set; }

        /// <summary>
        /// 订单商品ID
        /// </summary>
        [XmlElement("order_item_id")]
        public long OrderItemId { get; set; }

        /// <summary>
        /// 处理数量变化值
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 结果值
        /// </summary>
        [XmlElement("result_quantity")]
        public long ResultQuantity { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
