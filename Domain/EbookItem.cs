using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// EbookItem Data Structure.
    /// </summary>
    [Serializable]
    public class EbookItem : TopObject
    {
        /// <summary>
        /// 实际代扣金额，单位：分
        /// </summary>
        [XmlElement("actual_fee")]
        public long ActualFee { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        [XmlElement("author")]
        public string Author { get; set; }

        /// <summary>
        /// 推荐语
        /// </summary>
        [XmlElement("brief")]
        public string Brief { get; set; }

        /// <summary>
        /// 版权方
        /// </summary>
        [XmlElement("copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// 书库ID
        /// </summary>
        [XmlElement("ebook_lib_id")]
        public long EbookLibId { get; set; }

        /// <summary>
        /// 实体书价格，单位：分。
        /// </summary>
        [XmlElement("entity_price")]
        public long EntityPrice { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 商品图片地址
        /// </summary>
        [XmlElement("item_pic_url")]
        public string ItemPicUrl { get; set; }

        /// <summary>
        /// 商品价格，单位：分。
        /// </summary>
        [XmlElement("item_price")]
        public long ItemPrice { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("item_title")]
        public string ItemTitle { get; set; }
    }
}
