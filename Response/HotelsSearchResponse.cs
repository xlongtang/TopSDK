using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HotelsSearchResponse.
    /// </summary>
    public class HotelsSearchResponse : TopResponse
    {
        /// <summary>
        /// 多个酒店结构<br></br><font color = red>不返回房型信息，需要查看房型信息，请调用taobao.hotel.get</font>
        /// </summary>
        [XmlArray("hotels")]
        [XmlArrayItem("hotel")]
        public List<Hotel> Hotels { get; set; }

        /// <summary>
        /// 符合条件的结果总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
