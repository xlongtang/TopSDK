using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// CloudsTag Data Structure.
    /// </summary>
    [Serializable]
    public class CloudsTag : TopObject
    {
        /// <summary>
        /// 1:bool,2:short,3:int,4:long,5:float,6:double,7:string
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 标签id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 1：数值；2：radio；3：checkbox；4：精确文本匹配 ; 5 模糊文本匹配
        /// </summary>
        [XmlElement("input_type")]
        public string InputType { get; set; }

        /// <summary>
        /// 标签中文名字
        /// </summary>
        [XmlElement("name_ch")]
        public string NameCh { get; set; }

        /// <summary>
        /// 入参校验
        /// </summary>
        [XmlElement("validator")]
        public string Validator { get; set; }

        /// <summary>
        /// validator中的valueSet
        /// </summary>
        [XmlElement("values")]
        public string Values { get; set; }
    }
}
