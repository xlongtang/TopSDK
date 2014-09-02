using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ProductPropImg Data Structure.
    /// </summary>
    [Serializable]
    public class ProductPropImg : TopObject
    {
        /// <summary>
        /// 添加时间.格式:yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 产品属性图片ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 修改时间.格式:yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 图片序号。产品里的图片展示顺序，数据越小越靠前。要求是正整数。
        /// </summary>
        [XmlElement("position")]
        public long Position { get; set; }

        /// <summary>
        /// 图片所属产品的ID
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 属性串(pid:vid),目前只有颜色属性.如:颜色:红色表示为　1627207:28326
        /// </summary>
        [XmlElement("props")]
        public string Props { get; set; }

        /// <summary>
        /// 图片地址.(绝对地址,格式:http://host/image_path)
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
