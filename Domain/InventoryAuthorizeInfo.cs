using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// InventoryAuthorizeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InventoryAuthorizeInfo : TopObject
    {
        /// <summary>
        /// 本次授权的授权结果码
        /// </summary>
        [XmlElement("authorize_code")]
        public string AuthorizeCode { get; set; }

        /// <summary>
        /// 授权账户类型，共享/独享/仅独享  PUBLIC：共享；PRIVATE:独享；PRIVATE_ONLY：仅独享
        /// </summary>
        [XmlElement("authorize_type")]
        public string AuthorizeType { get; set; }

        /// <summary>
        /// 渠道标记  1 – 16 淘宝保留  17- 32 商家定义
        /// </summary>
        [XmlElement("channel_flag")]
        public long ChannelFlag { get; set; }

        /// <summary>
        /// 批量请求时列表的序号
        /// </summary>
        [XmlElement("index")]
        public long Index { get; set; }

        /// <summary>
        /// 库存类型 0-10 淘宝保留  11-20 商家自定义  1：普通良品  2：损坏  3：冻结  10：质押
        /// </summary>
        [XmlElement("inventory_type")]
        public long InventoryType { get; set; }

        /// <summary>
        /// 授权信息的用户昵称
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 共享时授权对象的淘宝昵称列表，用;分割[此字段暂时保留，没有用到]
        /// </summary>
        [XmlElement("nick_name_list")]
        public string NickNameList { get; set; }

        /// <summary>
        /// 当前总共占用的库存数量
        /// </summary>
        [XmlElement("occupy_quantity")]
        public long OccupyQuantity { get; set; }

        /// <summary>
        /// 总物理库存
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 授权给其他用户的配额库存数量
        /// </summary>
        [XmlElement("quota_quantity")]
        public long QuotaQuantity { get; set; }

        /// <summary>
        /// 预扣数量
        /// </summary>
        [XmlElement("reserve_quantity")]
        public long ReserveQuantity { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("sc_item_code")]
        public string ScItemCode { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("sc_item_id")]
        public long ScItemId { get; set; }

        /// <summary>
        /// 商家仓编号
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
