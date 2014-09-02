using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiGroupFilterResponse.
    /// </summary>
    public class HanoiGroupFilterResponse : TopResponse
    {
        /// <summary>
        /// 分组中匹配成功的标签id列表
        /// </summary>
        [XmlArray("label_list")]
        [XmlArrayItem("number")]
        public List<long> LabelList { get; set; }
    }
}
