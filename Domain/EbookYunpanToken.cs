using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// EbookYunpanToken Data Structure.
    /// </summary>
    [Serializable]
    public class EbookYunpanToken : TopObject
    {
        /// <summary>
        /// 云盘访问的token信息
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// access_token的失效时间
        /// </summary>
        [XmlElement("expires_in")]
        public long ExpiresIn { get; set; }

        /// <summary>
        /// 刷新云盘access_token信息
        /// </summary>
        [XmlElement("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
