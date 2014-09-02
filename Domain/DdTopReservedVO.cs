using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// DdTopReservedVO Data Structure.
    /// </summary>
    [Serializable]
    public class DdTopReservedVO : TopObject
    {
        /// <summary>
        /// 桌台类型：大厅|包厢
        /// </summary>
        [XmlElement("auction_position")]
        public long AuctionPosition { get; set; }

        /// <summary>
        /// 桌子容纳的最大人数
        /// </summary>
        [XmlElement("auction_serve_max")]
        public long AuctionServeMax { get; set; }

        /// <summary>
        /// 桌位容纳的最小人数
        /// </summary>
        [XmlElement("auction_serve_min")]
        public long AuctionServeMin { get; set; }

        /// <summary>
        /// 买家昵称
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city")]
        public long City { get; set; }

        /// <summary>
        /// 订金，以分为单位
        /// </summary>
        [XmlElement("deposit")]
        public long Deposit { get; set; }

        /// <summary>
        /// 淘点点预定单id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 点菜单订单id
        /// </summary>
        [XmlElement("menu_order_id")]
        public long MenuOrderId { get; set; }

        /// <summary>
        /// 预定人数
        /// </summary>
        [XmlElement("people_count")]
        public long PeopleCount { get; set; }

        /// <summary>
        /// 预定时间
        /// </summary>
        [XmlElement("reserve_time")]
        public string ReserveTime { get; set; }

        /// <summary>
        /// 卖家标注
        /// </summary>
        [XmlElement("seller_mark")]
        public long SellerMark { get; set; }

        /// <summary>
        /// 卖家备注
        /// </summary>
        [XmlElement("seller_memo")]
        public string SellerMemo { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 淘点点商户编码
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 买家备注
        /// </summary>
        [XmlElement("user_memo")]
        public string UserMemo { get; set; }

        /// <summary>
        /// 联系人称呼
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 用户电话
        /// </summary>
        [XmlElement("user_phone")]
        public string UserPhone { get; set; }
    }
}
