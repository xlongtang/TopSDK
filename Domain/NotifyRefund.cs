using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// NotifyRefund Data Structure.
    /// </summary>
    [Serializable]
    public class NotifyRefund : TopObject
    {
        /// <summary>
        /// 买家昵称
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 商品修改时间（格式：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 消息所属的用户昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 子订单退款交易编号
        /// </summary>
        [XmlElement("oid")]
        public long Oid { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 退款编号
        /// </summary>
        [XmlElement("rid")]
        public long Rid { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 退款操作所对应的退款增量消息状态   可选值：   RefundSuccess（退款成功）   RefundClosed（退款关闭）   RefundCreated（退款创建）   RefundSellerAgreeAgreement（卖家同意退款协议）   RefundSellerRefuseAgreement（卖家拒绝退款协议）   RefundBuyerModifyAgreement（买家修改退款协议）   RefundBuyerReturnGoods（买家退货给卖家）   RefundCreateMessage（发表留言）   RefundBlockMessage（屏蔽留言）   RefundTimeoutRemind（退款超时提醒）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 父订单退款交易编号
        /// </summary>
        [XmlElement("tid")]
        public long Tid { get; set; }

        /// <summary>
        /// 消息所属的用户编号
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
