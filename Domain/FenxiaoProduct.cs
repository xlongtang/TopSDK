using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// FenxiaoProduct Data Structure.
    /// </summary>
    [Serializable]
    public class FenxiaoProduct : TopObject
    {
        /// <summary>
        /// 警戒库存
        /// </summary>
        [XmlElement("alarm_number")]
        public long AlarmNumber { get; set; }

        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 所在地：市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 采购价格，单位：元。
        /// </summary>
        [XmlElement("cost_price")]
        public string CostPrice { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 经销采购价
        /// </summary>
        [XmlElement("dealer_cost_price")]
        public string DealerCostPrice { get; set; }

        /// <summary>
        /// 产品描述路径，通过http请求获取
        /// </summary>
        [XmlElement("desc_path")]
        public string DescPath { get; set; }

        /// <summary>
        /// 产品描述的内容
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 折扣ID（新增参数）
        /// </summary>
        [XmlElement("discount_id")]
        public long DiscountId { get; set; }

        /// <summary>
        /// 是否有保修，可选值：false（否）、true（是）
        /// </summary>
        [XmlElement("have_guarantee")]
        public bool HaveGuarantee { get; set; }

        /// <summary>
        /// 是否有发票，可选值：false（否）、true（是）
        /// </summary>
        [XmlElement("have_invoice")]
        public bool HaveInvoice { get; set; }

        /// <summary>
        /// 产品图片
        /// </summary>
        [XmlArray("images")]
        [XmlArrayItem("fenxiao_image")]
        public List<FenxiaoImage> Images { get; set; }

        /// <summary>
        /// 自定义属性，格式为pid:value;pid:value
        /// </summary>
        [XmlElement("input_properties")]
        public string InputProperties { get; set; }

        /// <summary>
        /// 查询产品列表时，查询入参增加is_authz:yes|no   yes:需要授权   no:不需要授权
        /// </summary>
        [XmlElement("is_authz")]
        public string IsAuthz { get; set; }

        /// <summary>
        /// 导入的商品ID
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 下载人数
        /// </summary>
        [XmlElement("items_count")]
        public long ItemsCount { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 累计采购次数
        /// </summary>
        [XmlElement("orders_count")]
        public long OrdersCount { get; set; }

        /// <summary>
        /// 商家编码
        /// </summary>
        [XmlElement("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 产品分销商信息
        /// </summary>
        [XmlArray("pdus")]
        [XmlArrayItem("fenxiao_pdu")]
        public List<FenxiaoPdu> Pdus { get; set; }

        /// <summary>
        /// 产品图片路径
        /// </summary>
        [XmlElement("pictures")]
        public string Pictures { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [XmlElement("pid")]
        public long Pid { get; set; }

        /// <summary>
        /// ems费用，单位：元
        /// </summary>
        [XmlElement("postage_ems")]
        public string PostageEms { get; set; }

        /// <summary>
        /// 快递费用，单位：元
        /// </summary>
        [XmlElement("postage_fast")]
        public string PostageFast { get; set; }

        /// <summary>
        /// 运费模板ID
        /// </summary>
        [XmlElement("postage_id")]
        public long PostageId { get; set; }

        /// <summary>
        /// 平邮费用，单位：元
        /// </summary>
        [XmlElement("postage_ordinary")]
        public string PostageOrdinary { get; set; }

        /// <summary>
        /// 运费类型，可选值：seller（供应商承担运费）、buyer（分销商承担运费）
        /// </summary>
        [XmlElement("postage_type")]
        public string PostageType { get; set; }

        /// <summary>
        /// 产品线ID
        /// </summary>
        [XmlElement("productcat_id")]
        public long ProductcatId { get; set; }

        /// <summary>
        /// 产品属性，格式为pid:vid;pid:vid
        /// </summary>
        [XmlElement("properties")]
        public string Properties { get; set; }

        /// <summary>
        /// 属性别名，格式为pid:vid:alias;pid:vid:alias
        /// </summary>
        [XmlElement("property_alias")]
        public string PropertyAlias { get; set; }

        /// <summary>
        /// 所在地：省
        /// </summary>
        [XmlElement("prov")]
        public string Prov { get; set; }

        /// <summary>
        /// 产品库存
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 根据商品ID查询时，返回这个产品对应的商品ID，只对分销商查询接口有效
        /// </summary>
        [XmlElement("query_item_id")]
        public long QueryItemId { get; set; }

        /// <summary>
        /// 最高零售价，单位：分。
        /// </summary>
        [XmlElement("retail_price_high")]
        public string RetailPriceHigh { get; set; }

        /// <summary>
        /// 最低零售价，单位：分。
        /// </summary>
        [XmlElement("retail_price_low")]
        public string RetailPriceLow { get; set; }

        /// <summary>
        /// 关联的后端商品id
        /// </summary>
        [XmlElement("scitem_id")]
        public long ScitemId { get; set; }

        /// <summary>
        /// sku列表
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("fenxiao_sku")]
        public List<FenxiaoSku> Skus { get; set; }

        /// <summary>
        /// 采购基准价，单位：元。
        /// </summary>
        [XmlElement("standard_price")]
        public string StandardPrice { get; set; }

        /// <summary>
        /// 零售基准价，单位：元
        /// </summary>
        [XmlElement("standard_retail_price")]
        public string StandardRetailPrice { get; set; }

        /// <summary>
        /// 发布状态，可选值：up（上架）、down（下架）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 分销方式：AGENT（只做代销，默认值）、DEALER（只做经销）、ALL（代销和经销都做）
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }

        /// <summary>
        /// 铺货时间
        /// </summary>
        [XmlElement("upshelf_time")]
        public string UpshelfTime { get; set; }
    }
}
