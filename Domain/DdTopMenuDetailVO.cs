using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// DdTopMenuDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class DdTopMenuDetailVO : TopObject
    {
        /// <summary>
        /// 联系人
        /// </summary>
        [XmlElement("contact")]
        public string Contact { get; set; }

        /// <summary>
        /// 菜单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 就餐时间
        /// </summary>
        [XmlElement("dining_time")]
        public string DiningTime { get; set; }

        /// <summary>
        /// 点菜单菜品列表
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("dd_item_v_o")]
        public List<DdItemVO> Items { get; set; }

        /// <summary>
        /// 菜单编码
        /// </summary>
        [XmlElement("menu_id")]
        public long MenuId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 买家备注
        /// </summary>
        [XmlElement("note")]
        public string Note { get; set; }

        /// <summary>
        /// 外部门店id
        /// </summary>
        [XmlElement("out_store_id")]
        public string OutStoreId { get; set; }

        /// <summary>
        /// 就餐人数
        /// </summary>
        [XmlElement("people")]
        public long People { get; set; }

        /// <summary>
        /// 现价：小于等于原价
        /// </summary>
        [XmlElement("real_price")]
        public string RealPrice { get; set; }

        /// <summary>
        /// 状态：
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 淘点点门店编码
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 桌台编码
        /// </summary>
        [XmlElement("table_code")]
        public string TableCode { get; set; }

        /// <summary>
        /// 桌台名称
        /// </summary>
        [XmlElement("table_name")]
        public string TableName { get; set; }

        /// <summary>
        /// 原价
        /// </summary>
        [XmlElement("total_price")]
        public string TotalPrice { get; set; }
    }
}
