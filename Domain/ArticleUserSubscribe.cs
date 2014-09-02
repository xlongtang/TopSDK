using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ArticleUserSubscribe Data Structure.
    /// </summary>
    [Serializable]
    public class ArticleUserSubscribe : TopObject
    {
        /// <summary>
        /// 订购关系到期时间
        /// </summary>
        [XmlElement("deadline")]
        public string Deadline { get; set; }

        /// <summary>
        /// 收费项目代码，从合作伙伴后台（my.open.taobao.com）-收费管理-收费项目列表 能够获得收费项目代码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }
    }
}
