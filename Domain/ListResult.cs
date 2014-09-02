using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// ListResult Data Structure.
    /// </summary>
    [Serializable]
    public class ListResult : TopObject
    {
        /// <summary>
        /// 订单列表
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("takeout_third_order")]
        public List<TakeoutThirdOrder> ResultList { get; set; }

        /// <summary>
        /// 返回记录数
        /// </summary>
        [XmlElement("result_size")]
        public long ResultSize { get; set; }

        /// <summary>
        /// 0:失败 1:成功
        /// </summary>
        [XmlElement("ret_code")]
        public string RetCode { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
