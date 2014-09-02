using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WlbItem Data Structure.
    /// </summary>
    [Serializable]
    public class WlbItem : TopObject
    {
        /// <summary>
        /// 品牌ID
        /// </summary>
        [XmlElement("brand_id")]
        public long BrandId { get; set; }

        /// <summary>
        /// 颜色
        /// </summary>
        [XmlElement("color")]
        public string Color { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 标记，用逗号隔开的字符串。  BIT_HAS_AUTHORIZE 第1位 是否有授权规则;  BATCH  第2位 是否有批次规则；  SYNCHRONIZATION 第3位 是否有同步规则。
        /// </summary>
        [XmlElement("flag")]
        public string Flag { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 货类
        /// </summary>
        [XmlElement("goods_cat")]
        public string GoodsCat { get; set; }

        /// <summary>
        /// 高
        /// </summary>
        [XmlElement("height")]
        public long Height { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 是否危险品
        /// </summary>
        [XmlElement("is_dangerous")]
        public bool IsDangerous { get; set; }

        /// <summary>
        /// 是否易碎
        /// </summary>
        [XmlElement("is_friable")]
        public bool IsFriable { get; set; }

        /// <summary>
        /// 是不是sku商品  值为true或false
        /// </summary>
        [XmlElement("is_sku")]
        public bool IsSku { get; set; }

        /// <summary>
        /// 商家编码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 最后修改人
        /// </summary>
        [XmlElement("last_modifier")]
        public string LastModifier { get; set; }

        /// <summary>
        /// mm
        /// </summary>
        [XmlElement("length")]
        public long Length { get; set; }

        /// <summary>
        /// 商品的名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 包装材料
        /// </summary>
        [XmlElement("package_material")]
        public string PackageMaterial { get; set; }

        /// <summary>
        /// 父item的id，当item为物流宝子商品时，parent_id必填,否则不必填  可通过父ID来得知商品的关系。
        /// </summary>
        [XmlElement("parent_id")]
        public long ParentId { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 计价货类
        /// </summary>
        [XmlElement("pricing_cat")]
        public string PricingCat { get; set; }

        /// <summary>
        /// 属性key:value; key:value
        /// </summary>
        [XmlElement("properties")]
        public string Properties { get; set; }

        /// <summary>
        /// 发布版本号，用来同步商
        /// </summary>
        [XmlElement("publish_version")]
        public long PublishVersion { get; set; }

        /// <summary>
        /// 商品备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 状态，item_status_valid -- 1 表示 有效 item_status_lock -- 2 表示锁住
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 前台商品名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 商品类型：  NORMAL--普通类型;  COMBINE--组合商品;  DISTRIBUTION--分销商品;  默认为NORMAL
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 商品所有人淘宝ID
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 商品所有人淘宝nick
        /// </summary>
        [XmlElement("user_nick")]
        public string UserNick { get; set; }

        /// <summary>
        /// 立方mm
        /// </summary>
        [XmlElement("volume")]
        public long Volume { get; set; }

        /// <summary>
        /// 重量
        /// </summary>
        [XmlElement("weight")]
        public long Weight { get; set; }

        /// <summary>
        /// 宽
        /// </summary>
        [XmlElement("width")]
        public long Width { get; set; }
    }
}
