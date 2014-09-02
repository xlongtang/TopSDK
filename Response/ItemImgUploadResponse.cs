using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ItemImgUploadResponse.
    /// </summary>
    public class ItemImgUploadResponse : TopResponse
    {
        /// <summary>
        /// 商品图片结构
        /// </summary>
        [XmlElement("item_img")]
        public ItemImg ItemImg { get; set; }
    }
}
