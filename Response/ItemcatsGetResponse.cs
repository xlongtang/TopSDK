using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ItemcatsGetResponse.
    /// </summary>
    public class ItemcatsGetResponse : TopResponse
    {
        /// <summary>
        /// 增量类目信息,根据fields传入的参数返回相应的结果
        /// </summary>
        [XmlArray("item_cats")]
        [XmlArrayItem("item_cat")]
        public List<ItemCat> ItemCats { get; set; }

        /// <summary>
        /// 最近修改时间(如果取增量，会返回该字段)。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("last_modified")]
        public string LastModified { get; set; }
    }
}
