using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// BatchOperateResult Data Structure.
    /// </summary>
    [Serializable]
    public class BatchOperateResult : TopObject
    {
        /// <summary>
        /// 商品操作错误代码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 操作提示
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 批量操作失败的宝贝列表
        /// </summary>
        [XmlArray("failed_item_list")]
        [XmlArrayItem("number")]
        public List<long> FailedItemList { get; set; }

        /// <summary>
        /// 操作是否成功，只要有一家宝贝发布成功则返回true
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 操作成功的宝贝id列表
        /// </summary>
        [XmlArray("success_item_list")]
        [XmlArrayItem("number")]
        public List<long> SuccessItemList { get; set; }
    }
}
