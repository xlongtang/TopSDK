using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ItemAnchorGetResponse.
    /// </summary>
    public class ItemAnchorGetResponse : TopResponse
    {
        /// <summary>
        /// 宝贝描述规范化可使用打标模块的锚点信息
        /// </summary>
        [XmlArray("anchor_modules")]
        [XmlArrayItem("ids_module")]
        public List<IdsModule> AnchorModules { get; set; }

        /// <summary>
        /// 返回的宝贝描述模板结果数目
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
