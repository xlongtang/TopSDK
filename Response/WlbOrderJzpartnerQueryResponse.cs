using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbOrderJzpartnerQueryResponse.
    /// </summary>
    public class WlbOrderJzpartnerQueryResponse : TopResponse
    {
        /// <summary>
        /// 安装服务商列表
        /// </summary>
        [XmlArray("install_list")]
        [XmlArrayItem("jz_partner")]
        public List<JzPartner> InstallList { get; set; }

        /// <summary>
        /// 接口查询成功或者失败
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 查询返回信息，如果失败，存储错误信息
        /// </summary>
        [XmlElement("result_info")]
        public string ResultInfo { get; set; }

        /// <summary>
        /// 物流配送服务商对象列表
        /// </summary>
        [XmlArray("server_list")]
        [XmlArrayItem("jz_partner")]
        public List<JzPartner> ServerList { get; set; }
    }
}
