using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TbkShopsGetResponse.
    /// </summary>
    public class TbkShopsGetResponse : TopResponse
    {
        /// <summary>
        /// 搜索结果列表
        /// </summary>
        [XmlArray("tbk_shops")]
        [XmlArrayItem("tbk_shop")]
        public List<TbkShop> TbkShops { get; set; }

        /// <summary>
        /// 符合条件的店铺总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
