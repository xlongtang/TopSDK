using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// ItemData Data Structure.
    /// </summary>
    [Serializable]
    public class ItemData : TopObject
    {
        /// <summary>
        /// 商品的聚划算价格，单位分
        /// </summary>
        [XmlElement("activity_price")]
        public long ActivityPrice { get; set; }

        /// <summary>
        /// 商品对应的淘宝类目id
        /// </summary>
        [XmlElement("category_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 商品对应的聚划算二级类目
        /// </summary>
        [XmlElement("child_category")]
        public long ChildCategory { get; set; }

        /// <summary>
        /// 商品所在城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 商品的当前库存
        /// </summary>
        [XmlElement("current_stock")]
        public long CurrentStock { get; set; }

        /// <summary>
        /// 商品对应的折扣 聚划算价/原价
        /// </summary>
        [XmlElement("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 是否存在占座（下单未支付的订单）
        /// </summary>
        [XmlElement("exist_hold_stock")]
        public bool ExistHoldStock { get; set; }

        /// <summary>
        /// 商品对应的团id
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 商品是否为锁定状态,锁定状态的商品才显示为可销售
        /// </summary>
        [XmlElement("is_lock")]
        public bool IsLock { get; set; }

        /// <summary>
        /// 商品对应的聚划算描述信息
        /// </summary>
        [XmlElement("item_desc")]
        public string ItemDesc { get; set; }

        /// <summary>
        /// 代表聚划算支持的6种消保该商品是否支持，1支持，0不支持  第一位：如实描述  第二位：七天退换  第三位：假一陪三  第四位：商城正品保障  第五位：商城提供发票  第六位：商城7天退换
        /// </summary>
        [XmlElement("item_guarantee")]
        public string ItemGuarantee { get; set; }

        /// <summary>
        /// 商品的数字id
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 描述商品的状态，AVAIL_BUY=可以购买  WAIT_FOR_START=即将开始  EXIST_HOLDER=有占座  NO_STOCK=卖光了  OUT_OF_TIME=团购已结束
        /// </summary>
        [XmlElement("item_status")]
        public string ItemStatus { get; set; }

        /// <summary>
        /// 商品对应的URl
        /// </summary>
        [XmlElement("item_url")]
        public string ItemUrl { get; set; }

        /// <summary>
        /// 商品的长名称
        /// </summary>
        [XmlElement("long_name")]
        public string LongName { get; set; }

        /// <summary>
        /// 商品活动结束时间点的毫秒值
        /// </summary>
        [XmlElement("online_end_time")]
        public long OnlineEndTime { get; set; }

        /// <summary>
        /// 商品上架开始时间点的毫秒值
        /// </summary>
        [XmlElement("online_start_time")]
        public long OnlineStartTime { get; set; }

        /// <summary>
        /// 商品的原价，单位分
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 商品对应的聚划算一级类目
        /// </summary>
        [XmlElement("parent_category")]
        public long ParentCategory { get; set; }

        /// <summary>
        /// 商品是否包邮
        /// </summary>
        [XmlElement("pay_postage")]
        public bool PayPostage { get; set; }

        /// <summary>
        /// 商品对应的图片地址
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 商品对应的交易线原始图片地址
        /// </summary>
        [XmlElement("pic_url_from_ic")]
        public string PicUrlFromIc { get; set; }

        /// <summary>
        /// 聚划算图片宽图的地址
        /// </summary>
        [XmlElement("pic_wide_url")]
        public string PicWideUrl { get; set; }

        /// <summary>
        /// 商品对应的平台id，1001=聚划算
        /// </summary>
        [XmlElement("platform_id")]
        public long PlatformId { get; set; }

        /// <summary>
        /// 卖家对应的信用等级
        /// </summary>
        [XmlElement("seller_credit")]
        public long SellerCredit { get; set; }

        /// <summary>
        /// 商品对应的卖家账户id
        /// </summary>
        [XmlElement("seller_id")]
        public long SellerId { get; set; }

        /// <summary>
        /// 商品对应的卖家账户nick
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 本地化服务对象的分店信息
        /// </summary>
        [XmlArray("shop_position_list")]
        [XmlArrayItem("shop_position_data")]
        public List<ShopPositionData> ShopPositionList { get; set; }

        /// <summary>
        /// 商品对应的店铺类型，集市，商城
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 商品短名称
        /// </summary>
        [XmlElement("short_name")]
        public string ShortName { get; set; }

        /// <summary>
        /// 已参团的人数（付款）
        /// </summary>
        [XmlElement("sold_count")]
        public long SoldCount { get; set; }
    }
}
