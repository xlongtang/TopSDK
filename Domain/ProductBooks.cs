using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ProductBooks Data Structure.
    /// </summary>
    [Serializable]
    public class ProductBooks : TopObject
    {
        /// <summary>
        /// 作者/著者
        /// </summary>
        [XmlElement("author")]
        public string Author { get; set; }

        /// <summary>
        /// 条形码，13位，9787开头
        /// </summary>
        [XmlElement("bar_code")]
        public string BarCode { get; set; }

        /// <summary>
        /// 完整的图书名称
        /// </summary>
        [XmlElement("book_name")]
        public string BookName { get; set; }

        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("category_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// ISBN号
        /// </summary>
        [XmlElement("isbn")]
        public string Isbn { get; set; }

        /// <summary>
        /// 图书价格，若有多个，则以';'号分隔
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
