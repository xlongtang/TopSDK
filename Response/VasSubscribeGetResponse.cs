using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// VasSubscribeGetResponse.
    /// </summary>
    public class VasSubscribeGetResponse : TopResponse
    {
        /// <summary>
        /// 用户订购信息
        /// </summary>
        [XmlArray("article_user_subscribes")]
        [XmlArrayItem("article_user_subscribe")]
        public List<ArticleUserSubscribe> ArticleUserSubscribes { get; set; }
    }
}
