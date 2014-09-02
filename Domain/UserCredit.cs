using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// UserCredit Data Structure.
    /// </summary>
    [Serializable]
    public class UserCredit : TopObject
    {
        /// <summary>
        /// 收到的好评总条数。取值范围:大于零的整数
        /// </summary>
        [XmlElement("good_num")]
        public long GoodNum { get; set; }

        /// <summary>
        /// 信用等级（是根据score生成的），信用等级：淘宝会员在淘宝网上的信用度，分为20个级别，级别如：level = 1 时，表示一心；level = 2 时，表示二心
        /// </summary>
        [XmlElement("level")]
        public long Level { get; set; }

        /// <summary>
        /// 信用总分（“好评”加一分，“中评”不加分，“差评”扣一分。分越高，等级越高）
        /// </summary>
        [XmlElement("score")]
        public long Score { get; set; }

        /// <summary>
        /// 收到的评价总条数。取值范围:大于零的整数
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
