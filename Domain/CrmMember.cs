using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// CrmMember Data Structure.
    /// </summary>
    [Serializable]
    public class CrmMember : TopObject
    {
        /// <summary>
        /// 平均客单价.
        /// </summary>
        [XmlElement("avg_price")]
        public string AvgPrice { get; set; }

        /// <summary>
        /// 会员买家id
        /// </summary>
        [XmlElement("buyer_id")]
        public long BuyerId { get; set; }

        /// <summary>
        /// 买家昵称
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 城市.  请注意:从2014.4.23之后,省市将采用地区标准码,请通过物流API taobao.areas.get接口获取,参考:http://api.taobao.com/apidoc/api.htm?spm=0.0.0.0.nOOF9g&path=cid:7-apiId:59.API对于老的省市代码兼容会逐步下线.
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 交易关闭的金额
        /// </summary>
        [XmlElement("close_trade_amount")]
        public string CloseTradeAmount { get; set; }

        /// <summary>
        /// 交易关闭的的笔数
        /// </summary>
        [XmlElement("close_trade_count")]
        public long CloseTradeCount { get; set; }

        /// <summary>
        /// 会员等级，0:店铺客户，1：普通会员，2：高级会员，3：VIP会员， 4：至尊VIP会员
        /// </summary>
        [XmlElement("grade")]
        public long Grade { get; set; }

        /// <summary>
        /// 会员拥有的所有分组
        /// </summary>
        [XmlElement("group_ids")]
        public string GroupIds { get; set; }

        /// <summary>
        /// 交易关闭的宝贝件数
        /// </summary>
        [XmlElement("item_close_count")]
        public long ItemCloseCount { get; set; }

        /// <summary>
        /// 购买的宝贝件数
        /// </summary>
        [XmlElement("item_num")]
        public long ItemNum { get; set; }

        /// <summary>
        /// 最后交易时间
        /// </summary>
        [XmlElement("last_trade_time")]
        public string LastTradeTime { get; set; }

        /// <summary>
        /// 北京=1,天津=2,河北省=3,山西省=4,内蒙古自治区=5,辽宁省=6,吉林省=7,黑龙江省=8,上海=9,江苏省=10,浙江省=11,安徽省=12,福建省=13,江西省=14,山东省=15,河南省=16,湖北省=17,湖南省=18, 广东省=19,广西壮族自治区=20,海南省=21,重庆=22,四川省=23,贵州省=24,云南省=25,西藏自治区26,陕西省=27,甘肃省=28,青海省=29,宁夏回族自治区=30,新疆维吾尔自治区=31,台湾省=32,香港特别行政区=33,澳门特别行政区=34,海外=35.  注:请注意:从2014.4.23之后,省市将采用地区标准码,请通过物流API taobao.areas.get接口获取,参考:http://api.taobao.com/apidoc/api.htm?spm=0.0.0.0.nOOF9g&path=cid:7-apiId:59.API对于老的省市代码兼容会逐步下线.
        /// </summary>
        [XmlElement("province")]
        public long Province { get; set; }

        /// <summary>
        /// 关系来源，1交易成功，2未成交，3卖家主动吸纳
        /// </summary>
        [XmlElement("relation_source")]
        public long RelationSource { get; set; }

        /// <summary>
        /// 显示会员的状态，normal正常，blacklist黑名单
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 交易成功的金额
        /// </summary>
        [XmlElement("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 交易成功笔数
        /// </summary>
        [XmlElement("trade_count")]
        public long TradeCount { get; set; }
    }
}
