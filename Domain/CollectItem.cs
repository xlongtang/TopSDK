using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// CollectItem Data Structure.
    /// </summary>
    [Serializable]
    public class CollectItem : TopObject
    {
        /// <summary>
        /// 商品或店铺的id号
        /// </summary>
        [XmlElement("item_numid")]
        public long ItemNumid { get; set; }

        /// <summary>
        /// 被收藏宝贝或店铺所有者的昵称
        /// </summary>
        [XmlElement("item_owner_nick")]
        public string ItemOwnerNick { get; set; }

        /// <summary>
        /// 收藏目标的标题名字
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
