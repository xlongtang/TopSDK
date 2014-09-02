using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ItempropsGetResponse.
    /// </summary>
    public class ItempropsGetResponse : TopResponse
    {
        /// <summary>
        /// 类目属性信息(如果是取全量或者增量，不包括属性值),根据fields传入的参数返回相应的结果
        /// </summary>
        [XmlArray("item_props")]
        [XmlArrayItem("item_prop")]
        public List<ItemProp> ItemProps { get; set; }

        /// <summary>
        /// 最近修改时间(只有取全量或增量的时候会返回该字段)。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("last_modified")]
        public string LastModified { get; set; }
    }
}
