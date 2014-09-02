using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// RoomImage Data Structure.
    /// </summary>
    [Serializable]
    public class RoomImage : TopObject
    {
        /// <summary>
        /// 商品所有图片的url，用”,”隔开。即，当前该商品的所有图片地址。
        /// </summary>
        [XmlElement("all_images")]
        public string AllImages { get; set; }

        /// <summary>
        /// 酒店商品id
        /// </summary>
        [XmlElement("gid")]
        public long Gid { get; set; }

        /// <summary>
        /// 图片url。当前接口操作的图片url。调用上传图片接口时，代表上传图片后得到的图片url。调用删除图片接口时，代表被删除掉的图片url。
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 图片位置，可选值：1,2,3,4,5。代表图片的位置，如：2，代表第二张图片。
        /// </summary>
        [XmlElement("position")]
        public long Position { get; set; }
    }
}
