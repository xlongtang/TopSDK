using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Room Data Structure.
    /// </summary>
    [Serializable]
    public class Room : TopObject
    {
        /// <summary>
        /// 面积
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 宽带服务
        /// </summary>
        [XmlElement("bbn")]
        public string Bbn { get; set; }

        /// <summary>
        /// 床型
        /// </summary>
        [XmlElement("bed_type")]
        public string BedType { get; set; }

        /// <summary>
        /// 早餐
        /// </summary>
        [XmlElement("breakfast")]
        public string Breakfast { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 订金
        /// </summary>
        [XmlElement("deposit")]
        public long Deposit { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 手续费
        /// </summary>
        [XmlElement("fee")]
        public long Fee { get; set; }

        /// <summary>
        /// 酒店商品id
        /// </summary>
        [XmlElement("gid")]
        public long Gid { get; set; }

        /// <summary>
        /// 购买须知
        /// </summary>
        [XmlElement("guide")]
        public string Guide { get; set; }

        /// <summary>
        /// 酒店id
        /// </summary>
        [XmlElement("hid")]
        public long Hid { get; set; }

        /// <summary>
        /// 酒店信息
        /// </summary>
        [XmlElement("hotel")]
        public Hotel Hotel { get; set; }

        /// <summary>
        /// 淘宝商品id
        /// </summary>
        [XmlElement("iid")]
        public long Iid { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 为到店支付卖家特殊使用，代表多种支付类型的房态
        /// </summary>
        [XmlElement("multi_room_quotas")]
        public string MultiRoomQuotas { get; set; }

        /// <summary>
        /// 支付类型
        /// </summary>
        [XmlElement("payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// 酒店商品图片Url。多个url用逗号隔开
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 价格类型
        /// </summary>
        [XmlElement("price_type")]
        public string PriceType { get; set; }

        /// <summary>
        /// 房型id
        /// </summary>
        [XmlElement("rid")]
        public long Rid { get; set; }

        /// <summary>
        /// 房态信息。JSON格式串
        /// </summary>
        [XmlElement("room_quotas")]
        public string RoomQuotas { get; set; }

        /// <summary>
        /// 房型信息
        /// </summary>
        [XmlElement("room_type")]
        public RoomType RoomType { get; set; }

        /// <summary>
        /// 设施服务。JSON格式串
        /// </summary>
        [XmlElement("service")]
        public string Service { get; set; }

        /// <summary>
        /// 床宽
        /// </summary>
        [XmlElement("size")]
        public string Size { get; set; }

        /// <summary>
        /// 状态。1：上架。2：下架。3：删除
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 楼层
        /// </summary>
        [XmlElement("storey")]
        public string Storey { get; set; }

        /// <summary>
        /// 酒店商品名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
