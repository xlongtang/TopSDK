using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// NotifyItem Data Structure.
    /// </summary>
    [Serializable]
    public class NotifyItem : TopObject
    {
        /// <summary>
        /// 商品此次操作所变更的字段，以“,”分割，对应于商品Item的字段名称。目前支持title，price，num，item_img，prop_img，location，cid，approve_status， list_time几个字段的更改标记返回，其中“item_img，prop_img”会同时出现表示商品相关图片列表发生了修改
        /// </summary>
        [XmlElement("changed_fields")]
        public string ChangedFields { get; set; }

        /// <summary>
        /// 商品编号(注意：iid近期即将废弃，请用num_iid参数)
        /// </summary>
        [XmlElement("iid")]
        public string Iid { get; set; }

        /// <summary>
        /// 商品库存的变化量，当商品库存增加时，此值为正数；当商品库存减少时，此值为负数。
        /// </summary>
        [XmlElement("increment")]
        public long Increment { get; set; }

        /// <summary>
        /// 商品修改时间（格式：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 商品数字编号
        /// </summary>
        [XmlElement("num_iid")]
        public long NumIid { get; set; }

        /// <summary>
        /// 商品价格，格式：5.00；单位：元；精确到：分
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品SKU编号
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }

        /// <summary>
        /// 商品SKU库存
        /// </summary>
        [XmlElement("sku_num")]
        public long SkuNum { get; set; }

        /// <summary>
        /// 商品操作所对应的商品增量消息状态。  可选值   ItemAdd（新增商品）   ItemUpshelf（上架商品）   ItemDownshelf（下架商品）   ItemDelete（删除商品）   ItemUpdate（更新商品）   ItemRecommendDelete（取消橱窗推荐商品）   ItemRecommendAdd（橱窗推荐商品）   ItemZeroStock（商品卖空）  ItemPunishDelete（小二删除商品）  ItemPunishDownshelf（小二下架商品）  ItemPunishCc（小二CC商品）  ItemSkuZeroStock（商品SKU卖空）  ItemStockChanged（修改商品库存）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商品标题,不能超过60字节
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 消息所属的用户编号
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
