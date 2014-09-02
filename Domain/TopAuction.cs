using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// TopAuction Data Structure.
    /// </summary>
    [Serializable]
    public class TopAuction : TopObject
    {
        /// <summary>
        /// 外卖商品描述
        /// </summary>
        [XmlElement("auction_desc")]
        public string AuctionDesc { get; set; }

        /// <summary>
        /// 商品sku列表
        /// </summary>
        [XmlArray("auction_skudos")]
        [XmlArrayItem("auction_sku_d_o")]
        public List<AuctionSkuDO> AuctionSkudos { get; set; }

        /// <summary>
        /// 宝贝状态(0,1出售状态,-2在仓库中)
        /// </summary>
        [XmlElement("auction_status")]
        public long AuctionStatus { get; set; }

        /// <summary>
        /// 外卖宝贝所属后台类目
        /// </summary>
        [XmlElement("category_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 商品发布时间(毫秒)
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 宝贝外部编码
        /// </summary>
        [XmlElement("goods_no")]
        public string GoodsNo { get; set; }

        /// <summary>
        /// 外卖商品id
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 单个宝贝限购数量
        /// </summary>
        [XmlElement("limit_buy")]
        public long LimitBuy { get; set; }

        /// <summary>
        /// 最后修改时间(毫秒)
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 商品最初发布的数量
        /// </summary>
        [XmlElement("old_quantity")]
        public long OldQuantity { get; set; }

        /// <summary>
        /// 宝贝原价
        /// </summary>
        [XmlElement("ori_price")]
        public string OriPrice { get; set; }

        /// <summary>
        /// 宝贝完整图片路径
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 宝贝价格，最多两位小数
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 宝贝库存
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 1推荐，0不推荐
        /// </summary>
        [XmlElement("recommend")]
        public long Recommend { get; set; }

        /// <summary>
        /// 宝贝规则ID
        /// </summary>
        [XmlElement("rule_id")]
        public long RuleId { get; set; }

        /// <summary>
        /// 外卖商品标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 商品多图信息，多个图片url以英文逗号分隔
        /// </summary>
        [XmlElement("vice_image")]
        public string ViceImage { get; set; }
    }
}
