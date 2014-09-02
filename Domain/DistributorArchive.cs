using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// DistributorArchive Data Structure.
    /// </summary>
    [Serializable]
    public class DistributorArchive : TopObject
    {
        /// <summary>
        /// 近30天投诉率=近30天投诉总数/近30天支付宝成交笔数
        /// </summary>
        [XmlElement("complaints_count_per")]
        public string ComplaintsCountPer { get; set; }

        /// <summary>
        /// 供应商授权分销商的产品的下载率。  率的值都是*10000后的，取值后直接除以100后加上%即可。比如12.33%，返回值是1233。
        /// </summary>
        [XmlElement("down_load_ratio")]
        public string DownLoadRatio { get; set; }

        /// <summary>
        /// 好评率
        /// </summary>
        [XmlElement("good_evaluation_rate")]
        public string GoodEvaluationRate { get; set; }

        /// <summary>
        /// 店铺好评率，即店铺累计好评数/店铺评价总数
        /// </summary>
        [XmlElement("good_evaluation_rate_d")]
        public string GoodEvaluationRateD { get; set; }

        /// <summary>
        /// 总商品数
        /// </summary>
        [XmlElement("goods_sum")]
        public string GoodsSum { get; set; }

        /// <summary>
        /// 行业主营占比
        /// </summary>
        [XmlElement("indus_per_scole")]
        public string IndusPerScole { get; set; }

        /// <summary>
        /// 所在行业
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 开店时间
        /// </summary>
        [XmlElement("openashop_time")]
        public string OpenashopTime { get; set; }

        /// <summary>
        /// 近180天“宝贝与描述相符”店铺动态评分数据
        /// </summary>
        [XmlElement("order_merchandise_score")]
        public string OrderMerchandiseScore { get; set; }

        /// <summary>
        /// 供应商在分销商店铺中的成交（已付款）订单笔数占比。  率的值都是*10000后的，取值后直接除以100后加上%即可。比如12.33%，返回值是1233。
        /// </summary>
        [XmlElement("order_shop_ratio")]
        public string OrderShopRatio { get; set; }

        /// <summary>
        /// 近30天被处罚总数
        /// </summary>
        [XmlElement("punished_count")]
        public string PunishedCount { get; set; }

        /// <summary>
        /// 近180天“卖家发货速度”店铺动态评分数据
        /// </summary>
        [XmlElement("sale_consignment_score")]
        public string SaleConsignmentScore { get; set; }

        /// <summary>
        /// 近30天卖家平均退款时间,单位天
        /// </summary>
        [XmlElement("seller_refund_time")]
        public string SellerRefundTime { get; set; }

        /// <summary>
        /// 近30天平均退款率=近30天退款笔数/近30天支付宝成交笔数
        /// </summary>
        [XmlElement("seller_refund_time_per")]
        public string SellerRefundTimePer { get; set; }

        /// <summary>
        /// 卖家星级，加载周期：日
        /// </summary>
        [XmlElement("seller_star_name")]
        public string SellerStarName { get; set; }

        /// <summary>
        /// 卖家类型
        /// </summary>
        [XmlElement("seller_type")]
        public string SellerType { get; set; }

        /// <summary>
        /// 近180天“卖家服务态度”店铺动态评分数据
        /// </summary>
        [XmlElement("service_quality_score")]
        public string ServiceQualityScore { get; set; }

        /// <summary>
        /// 店铺url
        /// </summary>
        [XmlElement("shop_address")]
        public string ShopAddress { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 供应商授权分销商的产品的上架率。  率的值都是*10000后的，取值后直接除以100后加上%即可。比如12.33%，返回值是1233。
        /// </summary>
        [XmlElement("up_self_ratio")]
        public string UpSelfRatio { get; set; }

        /// <summary>
        /// 供应商在分销商店铺中的上架商品占比。  率的值都是*10000后的，取值后直接除以100后加上%即可。比如12.33%，返回值是1233。
        /// </summary>
        [XmlElement("up_shop_ratio")]
        public string UpShopRatio { get; set; }

        /// <summary>
        /// 供应商在分销商店铺中铺货商品UV占店铺商品总UV的比。  率的值都是*10000后的，取值后直接除以100后加上%即可。比如12.33%，返回值是1233。
        /// </summary>
        [XmlElement("uv_shop_ratio")]
        public string UvShopRatio { get; set; }
    }
}
