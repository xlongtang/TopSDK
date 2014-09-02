using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TicketItem Data Structure.
    /// </summary>
    [Serializable]
    public class TicketItem : TopObject
    {
        /// <summary>
        /// 商品返点比例（只对B卖家开放，单位为%）
        /// </summary>
        [XmlElement("auction_point")]
        public string AuctionPoint { get; set; }

        /// <summary>
        /// 商品状态（onsale：上架，instock：仓库）
        /// </summary>
        [XmlElement("auction_status")]
        public string AuctionStatus { get; set; }

        /// <summary>
        /// 类目标识
        /// </summary>
        [XmlElement("cat_id")]
        public long CatId { get; set; }

        /// <summary>
        /// 商品所在地-城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品对应的错误信息。针对get接口使用。
        /// </summary>
        [XmlElement("err_msg")]
        public string ErrMsg { get; set; }

        /// <summary>
        /// 商品电子凭证信息-在门票商品为电子凭证时必选
        /// </summary>
        [XmlElement("etc")]
        public TicketEtc Etc { get; set; }

        /// <summary>
        /// 商品是否有发票（有发票为true，没有发票为false）
        /// </summary>
        [XmlElement("have_invoice")]
        public bool HaveInvoice { get; set; }

        /// <summary>
        /// 商品主图
        /// </summary>
        [XmlElement("image_1")]
        public string Image1 { get; set; }

        /// <summary>
        /// 商品第一张多图
        /// </summary>
        [XmlElement("image_2")]
        public string Image2 { get; set; }

        /// <summary>
        /// 商品第二张多图
        /// </summary>
        [XmlElement("image_3")]
        public string Image3 { get; set; }

        /// <summary>
        /// 商品第三张多图
        /// </summary>
        [XmlElement("image_4")]
        public string Image4 { get; set; }

        /// <summary>
        /// 商品第四张多图
        /// </summary>
        [XmlElement("image_5")]
        public string Image5 { get; set; }

        /// <summary>
        /// 商品的标识
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 商品的上架时间（精确到分，格式为：yyyy-MM-dd HH:mm）
        /// </summary>
        [XmlElement("list_time")]
        public string ListTime { get; set; }

        /// <summary>
        /// 商品的物流运费模板-在产品规格使用到物流时必选
        /// </summary>
        [XmlElement("postage_id")]
        public long PostageId { get; set; }

        /// <summary>
        /// 产品（具有产品规格的）标识
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 商品是否橱窗推荐（橱窗推荐；true，不推荐：false）
        /// </summary>
        [XmlElement("promoted_status")]
        public bool PromotedStatus { get; set; }

        /// <summary>
        /// 商品所在地-省份
        /// </summary>
        [XmlElement("prov")]
        public string Prov { get; set; }

        /// <summary>
        /// 宝贝所属的店铺分类列表-店铺分类标识请使用店铺相关接口获取获取，多个店铺分类标识之间通过逗号进行分隔，最多包含10个分类标识
        /// </summary>
        [XmlElement("shop_cats")]
        public string ShopCats { get; set; }

        /// <summary>
        /// 参见taobao.ticket.item.add文档描述
        /// </summary>
        [XmlElement("skus")]
        public string Skus { get; set; }

        /// <summary>
        /// 商品是否为拍下减库存（拍下减库存为true，付款减库存为false）
        /// </summary>
        [XmlElement("sub_stock_at_buy")]
        public bool SubStockAtBuy { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 商品视频-视频标识由多媒体中相关接口获取
        /// </summary>
        [XmlElement("video_id")]
        public long VideoId { get; set; }

        /// <summary>
        /// 商品是否参与店铺会员打折
        /// </summary>
        [XmlElement("vip_promoted")]
        public bool VipPromoted { get; set; }
    }
}
