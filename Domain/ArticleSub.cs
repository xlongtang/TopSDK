using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ArticleSub Data Structure.
    /// </summary>
    [Serializable]
    public class ArticleSub : TopObject
    {
        /// <summary>
        /// 应用收费代码，从合作伙伴后台（my.open.taobao.com）-收费管理-收费项目列表 能够获得该应用的收费代码
        /// </summary>
        [XmlElement("article_code")]
        public string ArticleCode { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [XmlElement("article_name")]
        public string ArticleName { get; set; }

        /// <summary>
        /// 是否自动续费
        /// </summary>
        [XmlElement("autosub")]
        public bool Autosub { get; set; }

        /// <summary>
        /// 订购关系到期时间
        /// </summary>
        [XmlElement("deadline")]
        public string Deadline { get; set; }

        /// <summary>
        /// 是否到期提醒
        /// </summary>
        [XmlElement("expire_notice")]
        public bool ExpireNotice { get; set; }

        /// <summary>
        /// 收费项目代码，从合作伙伴后台（my.open.taobao.com）-收费管理-收费项目列表 能够获得收费项目代码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 收费项目名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 淘宝会员名
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 状态，1=有效 2=过期
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
