using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// WlbOrderDetail Data Structure.
    /// </summary>
    [Serializable]
    public class WlbOrderDetail : TopObject
    {
        /// <summary>
        /// 如果是交易单，则显示交易中买家昵称
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 是否已全部完成
        /// </summary>
        [XmlElement("is_completed")]
        public bool IsCompleted { get; set; }

        /// <summary>
        /// 订单最后一次修改时间
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 出库或者入库，IN表示入库，OUT表示出库
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 订单编码
        /// </summary>
        [XmlElement("order_code")]
        public string OrderCode { get; set; }

        /// <summary>
        /// 物流宝订单对应的商品详情
        /// </summary>
        [XmlArray("order_item_list")]
        [XmlArrayItem("wlb_order_item")]
        public List<WlbOrderItem> OrderItemList { get; set; }

        /// <summary>
        /// 订单来源:  产生物流订单的原因，比如:    订单来源:1:TAOBAO;2:EXT;3:ERP;4:WMS
        /// </summary>
        [XmlElement("order_source")]
        public string OrderSource { get; set; }

        /// <summary>
        /// 对应创建物流宝订单top接口中的的out_biz_code字段，主要是用来去重用
        /// </summary>
        [XmlElement("order_source_code")]
        public string OrderSourceCode { get; set; }

        /// <summary>
        /// 物流状态，  订单已创建：0  订单已取消: -1  订单关闭:-3  下发中: 10  已下发: 11  接收方拒签 :-100  已发货:100  签收成功:200
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// (1)其它:    OTHER  (2)淘宝交易: TAOBAO  (3)301:调拨: ALLOCATION  (4)401:盘点:CHECK  (5)501:销售采购:PRUCHASE
        /// </summary>
        [XmlElement("order_sub_type")]
        public string OrderSubType { get; set; }

        /// <summary>
        /// 1:正常订单: NARMAL  2:退货订单: RETURN  3:换货订单: CHANGE
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }

        /// <summary>
        /// 卖家ID
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 卖家NICK
        /// </summary>
        [XmlElement("user_nick")]
        public string UserNick { get; set; }
    }
}
