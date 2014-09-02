using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// INWordBase Data Structure.
    /// </summary>
    [Serializable]
    public class INWordBase : TopObject
    {
        /// <summary>
        /// 词数据信息列表
        /// </summary>
        [XmlArray("in_record_base_list")]
        [XmlArrayItem("i_n_record_base")]
        public List<INRecordBase> InRecordBaseList { get; set; }

        /// <summary>
        /// 词名称
        /// </summary>
        [XmlElement("word")]
        public string Word { get; set; }
    }
}
