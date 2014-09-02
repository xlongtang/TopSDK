using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// TravelItems Data Structure.
    /// </summary>
    [Serializable]
    public class TravelItems : TopObject
    {
        /// <summary>
        /// 商品发布后的状态。onsale出售中，instock仓库中。
        /// </summary>
        [XmlElement("approve_status")]
        public string ApproveStatus { get; set; }

        /// <summary>
        /// 商城返点比例，为5的倍数，最低0.5%。[0,500]
        /// </summary>
        [XmlElement("auction_point")]
        public long AuctionPoint { get; set; }

        /// <summary>
        /// 商品所属叶子类目ID。
        /// </summary>
        [XmlElement("cid")]
        public long Cid { get; set; }

        /// <summary>
        /// 商品发布时间。
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 下架时间，未使用（格式：yyyy-MM-dd HH:mm:ss）。
        /// </summary>
        [XmlElement("delist_time")]
        public string DelistTime { get; set; }

        /// <summary>
        /// 商品描述，字数要大于5个字符，小于50000个字符。
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 商品详情url。
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 最晚成团提前天数，最小0天，最大为300天，不填默认为0天。
        /// </summary>
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 费用包含，不超过1500个字符。
        /// </summary>
        [XmlElement("fee_include")]
        public string FeeInclude { get; set; }

        /// <summary>
        /// 费用不包，不超过1500个字符。
        /// </summary>
        [XmlElement("fee_not_include")]
        public string FeeNotInclude { get; set; }

        /// <summary>
        /// 机票信息，不超过1500字
        /// </summary>
        [XmlElement("flight_info")]
        public string FlightInfo { get; set; }

        /// <summary>
        /// 运费承担方式,seller（卖家承担），buyer（买家承担）。
        /// </summary>
        [XmlElement("freight_payer")]
        public string FreightPayer { get; set; }

        /// <summary>
        /// 集合地，不超过30个字符。
        /// </summary>
        [XmlElement("gathering_place")]
        public string GatheringPlace { get; set; }

        /// <summary>
        /// 会员打折 true/false。
        /// </summary>
        [XmlElement("has_discount")]
        public bool HasDiscount { get; set; }

        /// <summary>
        /// 是否有发票,true/false。
        /// </summary>
        [XmlElement("has_invoice")]
        public bool HasInvoice { get; set; }

        /// <summary>
        /// 是否有橱窗true/false。
        /// </summary>
        [XmlElement("has_showcase")]
        public bool HasShowcase { get; set; }

        /// <summary>
        /// 酒店信息，不超过1500字符
        /// </summary>
        [XmlElement("hotel_info")]
        public string HotelInfo { get; set; }

        /// <summary>
        /// 用户自行输入的类目属性ID串。结构："pid1,pid2,pid3"，如："2000"（表示品牌） 注：通常一个类目下用户可输入的关键属性不超过1个。在度假线路类目中，该属性ID为“自由行包含元素”或“一日游包含元素”属性ID。
        /// </summary>
        [XmlElement("input_pids")]
        public string InputPids { get; set; }

        /// <summary>
        /// 用户自行输入的子属性名和属性值，如“自定义自由行包含元素”。
        /// </summary>
        [XmlElement("input_str")]
        public string InputStr { get; set; }

        /// <summary>
        /// 是否“铁定出游”商品。
        /// </summary>
        [XmlElement("is_tdcy")]
        public bool IsTdcy { get; set; }

        /// <summary>
        /// 是否定时上架商品。
        /// </summary>
        [XmlElement("is_timing")]
        public bool IsTiming { get; set; }

        /// <summary>
        /// 商品数字ID。
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 商品图片列表(包括主图)。
        /// </summary>
        [XmlArray("item_imgs")]
        [XmlArrayItem("travel_items_img")]
        public List<TravelItemsImg> ItemImgs { get; set; }

        /// <summary>
        /// 上架时间,未使用（格式：yyyy-MM-dd HH:mm:ss）。
        /// </summary>
        [XmlElement("list_time")]
        public string ListTime { get; set; }

        /// <summary>
        /// 电子凭证信息。
        /// </summary>
        [XmlElement("locality_life")]
        public TravelItemsLocalityLife LocalityLife { get; set; }

        /// <summary>
        /// 宝贝所在地，格式为(省份:城市)。
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 最多橱窗数。
        /// </summary>
        [XmlElement("max_showcase")]
        public long MaxShowcase { get; set; }

        /// <summary>
        /// 商品修改时间（格式：yyyy-MM-dd HH:mm:ss）。
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 卖家昵称。
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 商品数量。
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 预定须知，不超过1500个字符。
        /// </summary>
        [XmlElement("order_info")]
        public string OrderInfo { get; set; }

        /// <summary>
        /// 商家编码。
        /// </summary>
        [XmlElement("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 自费项目，不超过1500个字符。
        /// </summary>
        [XmlElement("own_expense")]
        public string OwnExpense { get; set; }

        /// <summary>
        /// 商品主图片地址。
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 商品价格，格式：500；单位：分；精确到：分。
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 商品属性列表。格式为：pid:vid;pid:vid。例如度假线路商品，那么这里就需要填写：出发地属性id:城市id;目的地市属性id:目的地市id;……
        /// </summary>
        [XmlElement("props")]
        public string Props { get; set; }

        /// <summary>
        /// 商品属性名称。标识着props内容里面的pid和vid所对应的名称。格式为：pid1:vid1:pid_name1:vid_name1;pid2:vid2:pid_name2:vid_name2……
        /// </summary>
        [XmlElement("props_name")]
        public string PropsName { get; set; }

        /// <summary>
        /// 退改规定，不超过1500个字符。
        /// </summary>
        [XmlElement("refund_regulation")]
        public string RefundRegulation { get; set; }

        /// <summary>
        /// 秒杀商品类型。
        /// </summary>
        [XmlElement("second_kill")]
        public string SecondKill { get; set; }

        /// <summary>
        /// 商品所属的店铺内卖家自定义类目列表，多个以“,”分割。
        /// </summary>
        [XmlElement("seller_cids")]
        public string SellerCids { get; set; }

        /// <summary>
        /// 购物店信息，不超过1500个字符。
        /// </summary>
        [XmlElement("shoping_info")]
        public string ShopingInfo { get; set; }

        /// <summary>
        /// 商品Sku列表。
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("travel_items_sku")]
        public List<TravelItemsSku> Skus { get; set; }

        /// <summary>
        /// 商品开始出售时间。
        /// </summary>
        [XmlElement("start")]
        public string Start { get; set; }

        /// <summary>
        /// 商品是否支持拍下减库存:1支持;2取消支持(付款减库存)。
        /// </summary>
        [XmlElement("sub_stock")]
        public long SubStock { get; set; }

        /// <summary>
        /// 门票信息，不超过1500字
        /// </summary>
        [XmlElement("ticket_info")]
        public string TicketInfo { get; set; }

        /// <summary>
        /// 商品标题，能超过60字符，一个汉字占2个字符。
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 套餐价格日历信息。
        /// </summary>
        [XmlArray("travel_items_combos")]
        [XmlArrayItem("travel_items_combo")]
        public List<TravelItemsCombo> TravelItemsCombos { get; set; }

        /// <summary>
        /// 商品类型(fixed:一口价;auction:拍卖)注：取消团购。
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 已被使用的橱窗数。
        /// </summary>
        [XmlElement("used_showcase")]
        public long UsedShowcase { get; set; }

        /// <summary>
        /// 商品是否违规，违规：true , 不违规：false。
        /// </summary>
        [XmlElement("violation")]
        public bool Violation { get; set; }

        /// <summary>
        /// 不带html标签的desc文本信息，该字段只在taobao.item.get接口中返回。
        /// </summary>
        [XmlElement("wap_desc")]
        public string WapDesc { get; set; }

        /// <summary>
        /// 适合wap应用的商品详情url。
        /// </summary>
        [XmlElement("wap_detail_url")]
        public string WapDetailUrl { get; set; }
    }
}
