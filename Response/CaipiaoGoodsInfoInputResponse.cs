using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// CaipiaoGoodsInfoInputResponse.
    /// </summary>
    public class CaipiaoGoodsInfoInputResponse : TopResponse
    {
        /// <summary>
        /// 录入操作是否成功
        /// </summary>
        [XmlElement("input_result")]
        public bool InputResult { get; set; }
    }
}
