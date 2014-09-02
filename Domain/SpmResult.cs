using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// SpmResult Data Structure.
    /// </summary>
    [Serializable]
    public class SpmResult : TopObject
    {
        /// <summary>
        /// appkey
        /// </summary>
        [XmlElement("app_key")]
        public string AppKey { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 该APP所使用的SPM第四位的报表数据
        /// </summary>
        [XmlArray("spm_modules")]
        [XmlArrayItem("top_spm")]
        public List<TopSpm> SpmModules { get; set; }

        /// <summary>
        /// 该APP所使用的SPM第三位的报表数据
        /// </summary>
        [XmlArray("spm_pages")]
        [XmlArrayItem("top_spm")]
        public List<TopSpm> SpmPages { get; set; }

        /// <summary>
        /// 该APP的整体报表数据
        /// </summary>
        [XmlElement("spm_site")]
        public TopSpm SpmSite { get; set; }
    }
}
