using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// AppCustomer Data Structure.
    /// </summary>
    [Serializable]
    public class AppCustomer : TopObject
    {
        /// <summary>
        /// isv为用户开通增量消息服务的时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 最后修改时间，开通、用户的session生效或失效都会更改这个时间。
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 开通用户的淘宝昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 应用用户开通增量消息服务的状态：有两个返回值valid_session和invalid_session。valid_session表示已开通且seesion有效；invalid_session已开通但session失效，此时，无法接收该用户的消息。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 应用为用户开通的消息类型。只有用户开通的消息在应用所订阅的消息类别集合内时，应用才能收到相应的消息。例如：应用订阅添加商品，用户开通了添加商品和删除商品，此时应用只能收到添加商品的消息，收不到删除商品的消息。
        /// </summary>
        [XmlArray("subscriptions")]
        [XmlArrayItem("subscription")]
        public List<Subscription> Subscriptions { get; set; }

        /// <summary>
        /// 用户使用的功能。get表示增量api取消息功能；notify表示主动通知功能；syn表示同步数据到ISV数据库功能。
        /// </summary>
        [XmlArray("type")]
        [XmlArrayItem("string")]
        public List<string> Type { get; set; }

        /// <summary>
        /// 用户编号
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
