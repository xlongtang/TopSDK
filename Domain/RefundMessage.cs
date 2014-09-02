using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// RefundMessage Data Structure.
    /// </summary>
    [Serializable]
    public class RefundMessage : TopObject
    {
        /// <summary>
        /// 留言内容。最大长度: 400个字节
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 留言创建时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 留言编号
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 退款类型：NORMAL（普通留言），RETURN_GOODS_APPROVED（卖家留退货地址时留言）；如果为RETURN_GOODS_APPROVED，则退款留言中有卖家收货地址
        /// </summary>
        [XmlElement("message_type")]
        public string MessageType { get; set; }

        /// <summary>
        /// 留言者编号
        /// </summary>
        [XmlElement("owner_id")]
        public long OwnerId { get; set; }

        /// <summary>
        /// 留言者昵称
        /// </summary>
        [XmlElement("owner_nick")]
        public string OwnerNick { get; set; }

        /// <summary>
        /// 留言者身份 1代表买家，2代表卖家，3代表小二
        /// </summary>
        [XmlElement("owner_role")]
        public string OwnerRole { get; set; }

        /// <summary>
        /// 凭证附件地址（图片）
        /// </summary>
        [XmlArray("pic_urls")]
        [XmlArrayItem("pic_url")]
        public List<PicUrl> PicUrls { get; set; }

        /// <summary>
        /// 退款编号。
        /// </summary>
        [XmlElement("refund_id")]
        public long RefundId { get; set; }
    }
}
