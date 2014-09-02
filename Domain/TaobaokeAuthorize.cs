using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaobaokeAuthorize Data Structure.
    /// </summary>
    [Serializable]
    public class TaobaokeAuthorize : TopObject
    {
        /// <summary>
        /// 输入参数，nick或seller_id或num_iid
        /// </summary>
        [XmlElement("param")]
        public string Param { get; set; }

        /// <summary>
        /// 卖家是否同意返利.true:同意返利,false:拒绝返利
        /// </summary>
        [XmlElement("rebate")]
        public bool Rebate { get; set; }
    }
}
