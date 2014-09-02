using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallBrandcatSuiteconfGetResponse.
    /// </summary>
    public class TmallBrandcatSuiteconfGetResponse : TopResponse
    {
        /// <summary>
        /// 套装的配置信息
        /// </summary>
        [XmlArray("suite_conf_list")]
        [XmlArrayItem("suite_conf_d_o")]
        public List<SuiteConfDO> SuiteConfList { get; set; }
    }
}
