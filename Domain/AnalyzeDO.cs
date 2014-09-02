using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// AnalyzeDO Data Structure.
    /// </summary>
    [Serializable]
    public class AnalyzeDO : TopObject
    {
        /// <summary>
        /// 返回透视结果的二维数组
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("analyze_data")]
        public List<AnalyzeData> DataList { get; set; }

        /// <summary>
        /// 列的名字
        /// </summary>
        [XmlArray("field_names_list")]
        [XmlArrayItem("string")]
        public List<string> FieldNamesList { get; set; }

        /// <summary>
        /// 返回类型
        /// </summary>
        [XmlArray("field_types_list")]
        [XmlArrayItem("string")]
        public List<string> FieldTypesList { get; set; }
    }
}
