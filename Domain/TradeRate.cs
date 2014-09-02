using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TradeRate Data Structure.
    /// </summary>
    [Serializable]
    public class TradeRate : TopObject
    {
        /// <summary>
        /// 评价内容,最大长度:500个汉字
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 评价创建时间,格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 商品价格,精确到2位小数;单位:元.如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("item_price")]
        public string ItemPrice { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("item_title")]
        public string ItemTitle { get; set; }

        /// <summary>
        /// 评价者昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 商品的数字ID
        /// </summary>
        [XmlElement("num_iid")]
        public long NumIid { get; set; }

        /// <summary>
        /// 子订单ID
        /// </summary>
        [XmlElement("oid")]
        public long Oid { get; set; }

        /// <summary>
        /// 被评价者昵称
        /// </summary>
        [XmlElement("rated_nick")]
        public string RatedNick { get; set; }

        /// <summary>
        /// 评价解释,最大长度:500个汉字
        /// </summary>
        [XmlElement("reply")]
        public string Reply { get; set; }

        /// <summary>
        /// 评价结果,可选值:good(好评),neutral(中评),bad(差评)
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 评价者角色.可选值:seller(卖家),buyer(买家)
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }

        /// <summary>
        /// 交易ID
        /// </summary>
        [XmlElement("tid")]
        public long Tid { get; set; }

        /// <summary>
        /// 评价信息是否用于记分，  可取值：true(参与记分)和false(不参与记分)
        /// </summary>
        [XmlElement("valid_score")]
        public bool ValidScore { get; set; }
    }
}
