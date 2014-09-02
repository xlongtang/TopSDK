using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ProductImg Data Structure.
    /// </summary>
    [Serializable]
    public class ProductImg : TopObject
    {
        /// <summary>
        /// 添加时间.格式:yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 产品图片ID
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
        /// 图片地址.(绝对地址,格式:http://host/image_path)
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
