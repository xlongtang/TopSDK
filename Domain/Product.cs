using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// Product Data Structure.
    /// </summary>
    [Serializable]
    public class Product : TopObject
    {
        /// <summary>
        /// 产品的非关键属性列表.格式:pid:vid;pid:vid.
        /// </summary>
        [XmlElement("binds")]
        public string Binds { get; set; }

        /// <summary>
        /// 产品的非关键属性字符串列表.格式同props_str(<strong>注：</strong><font color="red">属性名称中的冒号":"被转换为："#cln#";   分号";"被转换为："#scln#" </font>)
        /// </summary>
        [XmlElement("binds_str")]
        public string BindsStr { get; set; }

        /// <summary>
        /// 商品类目名称
        /// </summary>
        [XmlElement("cat_name")]
        public string CatName { get; set; }

        /// <summary>
        /// 商品类目ID.必须是叶子类目ID
        /// </summary>
        [XmlElement("cid")]
        public long Cid { get; set; }

        /// <summary>
        /// 产品的collect次数（不提供数据，返回0)
        /// </summary>
        [XmlElement("collect_num")]
        public long CollectNum { get; set; }

        /// <summary>
        /// 创建时间.格式:yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 标识是否为达尔文体系下的产品 。  如果为空表示是非达尔文体系下的产品  如果cspu:0 表示是达尔文体系下的产品，有cspu正在待小二审核，但不能发布商品。  如果cspu:1 表示是达尔文体系下的产品，且有小二确认的cspu，能发布商品
        /// </summary>
        [XmlElement("cspu_feature")]
        public string CspuFeature { get; set; }

        /// <summary>
        /// 用户自定义属性,结构：pid1:value1;pid2:value2 例如：“20000:优衣库”，表示“品牌:优衣库”
        /// </summary>
        [XmlElement("customer_props")]
        public string CustomerProps { get; set; }

        /// <summary>
        /// 产品的描述.最大25000个字节
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 产品的级别level
        /// </summary>
        [XmlElement("level")]
        public long Level { get; set; }

        /// <summary>
        /// 修改时间.格式:yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部产品ID
        /// </summary>
        [XmlElement("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 产品对应的图片路径
        /// </summary>
        [XmlElement("pic_path")]
        public string PicPath { get; set; }

        /// <summary>
        /// 产品的主图片地址.(绝对地址,格式:http://host/image_path)
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 产品的市场价.单位为元.精确到2位小数;如:200.07
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 产品扩展信息
        /// </summary>
        [XmlArray("product_extra_infos")]
        [XmlArrayItem("product_extra_info")]
        public List<ProductExtraInfo> ProductExtraInfos { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 产品的子图片.目前最多支持4张。fields中设置为product_imgs.id、product_imgs.url、product_imgs.position 等形式就会返回相应的字段
        /// </summary>
        [XmlArray("product_imgs")]
        [XmlArrayItem("product_img")]
        public List<ProductImg> ProductImgs { get; set; }

        /// <summary>
        /// 产品的属性图片.比如说黄色对应的产品图片,绿色对应的产品图片。fields中设置为product_prop_imgs.id、   product_prop_imgs.props、product_prop_imgs.url、product_prop_imgs.position等形式就会返回相应的字段
        /// </summary>
        [XmlArray("product_prop_imgs")]
        [XmlArrayItem("product_prop_img")]
        public List<ProductPropImg> ProductPropImgs { get; set; }

        /// <summary>
        /// 销售属性值别名。格式为pid1:vid1:alias1;pid1:vid2:alia2。
        /// </summary>
        [XmlElement("property_alias")]
        public string PropertyAlias { get; set; }

        /// <summary>
        /// 产品的关键属性列表.格式：pid:vid;pid:vid
        /// </summary>
        [XmlElement("props")]
        public string Props { get; set; }

        /// <summary>
        /// 产品的关键属性字符串列表.比如:品牌:诺基亚;型号:N73(<strong>注：</strong><font color="red">属性名称中的冒号":"被转换为："#cln#";   分号";"被转换为："#scln#" </font>)
        /// </summary>
        [XmlElement("props_str")]
        public string PropsStr { get; set; }

        /// <summary>
        /// 产品的评分次数
        /// </summary>
        [XmlElement("rate_num")]
        public long RateNum { get; set; }

        /// <summary>
        /// 产品的销售量
        /// </summary>
        [XmlElement("sale_num")]
        public long SaleNum { get; set; }

        /// <summary>
        /// 产品的销售属性列表.格式:pid:vid;pid:vid
        /// </summary>
        [XmlElement("sale_props")]
        public string SaleProps { get; set; }

        /// <summary>
        /// 产品的销售属性字符串列表.格式同props_str(<strong>注：</strong><font color="red">属性名称中的冒号":"被转换为："#cln#";   分号";"被转换为："#scln#" </font>)
        /// </summary>
        [XmlElement("sale_props_str")]
        public string SalePropsStr { get; set; }

        /// <summary>
        /// 产品卖点描述，长度限制20个汉字
        /// </summary>
        [XmlElement("sell_pt")]
        public string SellPt { get; set; }

        /// <summary>
        /// 产品的店内价格
        /// </summary>
        [XmlElement("shop_price")]
        public string ShopPrice { get; set; }

        /// <summary>
        /// 产品的标准价格
        /// </summary>
        [XmlElement("standard_price")]
        public string StandardPrice { get; set; }

        /// <summary>
        /// 当前状态(0 商家确认 1 屏蔽 3 小二确认 2 未确认 -1 删除)
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 淘宝标准产品编码
        /// </summary>
        [XmlElement("tsc")]
        public string Tsc { get; set; }

        /// <summary>
        /// 垂直市场,如：3（3C），4（鞋城）
        /// </summary>
        [XmlElement("vertical_market")]
        public long VerticalMarket { get; set; }
    }
}
