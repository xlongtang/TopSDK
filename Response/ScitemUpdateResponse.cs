using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// ScitemUpdateResponse.
    /// </summary>
    public class ScitemUpdateResponse : TopResponse
    {
        /// <summary>
        /// 更新商品数量,1表示成功更新了一条数据，0：表示未找到匹配的数据
        /// </summary>
        [XmlElement("update_rows")]
        public long UpdateRows { get; set; }
    }
}
