using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ItemJointImgResponse.
    /// </summary>
    public class ItemJointImgResponse : TopResponse
    {
        /// <summary>
        /// 商品图片信息
        /// </summary>
        [XmlElement("item_img")]
        public ItemImg ItemImg { get; set; }
    }
}
