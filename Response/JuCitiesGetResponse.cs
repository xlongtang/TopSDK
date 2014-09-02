using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// JuCitiesGetResponse.
    /// </summary>
    public class JuCitiesGetResponse : TopResponse
    {
        /// <summary>
        /// 返回城市名称列表类似 "上海","成都"
        /// </summary>
        [XmlArray("cities")]
        [XmlArrayItem("string")]
        public List<string> Cities { get; set; }
    }
}
