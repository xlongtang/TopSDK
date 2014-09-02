using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TraderateImprImprwordByaucidGetResponse.
    /// </summary>
    public class TraderateImprImprwordByaucidGetResponse : TopResponse
    {
        /// <summary>
        /// 返回的大家印象的结构体
        /// </summary>
        [XmlArray("impr_word_list")]
        [XmlArrayItem("impr_item_d_o")]
        public List<ImprItemDO> ImprWordList { get; set; }
    }
}
