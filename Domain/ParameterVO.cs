using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ParameterVO Data Structure.
    /// </summary>
    [Serializable]
    public class ParameterVO : TopObject
    {
        /// <summary>
        /// 参数名称、与模板参数对应
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 参数取值
        /// </summary>
        [XmlElement("string_value")]
        public string StringValue { get; set; }
    }
}
