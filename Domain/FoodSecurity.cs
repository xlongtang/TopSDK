using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// FoodSecurity Data Structure.
    /// </summary>
    [Serializable]
    public class FoodSecurity : TopObject
    {
        /// <summary>
        /// 厂家联系方式
        /// </summary>
        [XmlElement("contact")]
        public string Contact { get; set; }

        /// <summary>
        /// 产品标准号
        /// </summary>
        [XmlElement("design_code")]
        public string DesignCode { get; set; }

        /// <summary>
        /// 厂名
        /// </summary>
        [XmlElement("factory")]
        public string Factory { get; set; }

        /// <summary>
        /// 厂址
        /// </summary>
        [XmlElement("factory_site")]
        public string FactorySite { get; set; }

        /// <summary>
        /// 食品添加剂
        /// </summary>
        [XmlElement("food_additive")]
        public string FoodAdditive { get; set; }

        /// <summary>
        /// 健字号，保健品/膳食营养补充剂 这个类目下特有的信息，此类目下无需填写生产许可证编号（QS），如果填写了生产许可证编号（QS）将被忽略不保存；保存宝贝时，标题前会自动加上健字号产品名称一起作为宝贝标题；
        /// </summary>
        [XmlElement("health_product_no")]
        public string HealthProductNo { get; set; }

        /// <summary>
        /// 配料表
        /// </summary>
        [XmlElement("mix")]
        public string Mix { get; set; }

        /// <summary>
        /// 保质期
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 储藏方法
        /// </summary>
        [XmlElement("plan_storage")]
        public string PlanStorage { get; set; }

        /// <summary>
        /// 生产许可证号
        /// </summary>
        [XmlElement("prd_license_no")]
        public string PrdLicenseNo { get; set; }

        /// <summary>
        /// 生产结束日期
        /// </summary>
        [XmlElement("product_date_end")]
        public string ProductDateEnd { get; set; }

        /// <summary>
        /// 生产开始日期
        /// </summary>
        [XmlElement("product_date_start")]
        public string ProductDateStart { get; set; }

        /// <summary>
        /// 进货结束日期，要在生产日期之后
        /// </summary>
        [XmlElement("stock_date_end")]
        public string StockDateEnd { get; set; }

        /// <summary>
        /// 进货开始日期，要在生产日期之后
        /// </summary>
        [XmlElement("stock_date_start")]
        public string StockDateStart { get; set; }

        /// <summary>
        /// 供货商
        /// </summary>
        [XmlElement("supplier")]
        public string Supplier { get; set; }
    }
}
