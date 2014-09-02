using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SpItemFeedInfoGetResponse.
    /// </summary>
    public class SpItemFeedInfoGetResponse : TopResponse
    {
        /// <summary>
        /// 分别返回好评,中评,差评最新的50条, type:评价类型 1好评 0中评 -1差评; nick: 评价者昵称; feedback: 评价内容; date: 评价时间
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
