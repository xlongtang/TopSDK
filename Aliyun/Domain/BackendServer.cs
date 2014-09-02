using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// BackendServer Data Structure.
    /// </summary>
    [Serializable]
    public class BackendServer : TopObject
    {
        /// <summary>
        /// 后端服务器的健康状况，normal,abnormal或unavailable。  normal表示状态为健康；  abnormal表示状态为不健康；  unavailable表示未能完成健康检查，具体原因可能是：未开启健康检查、因故未能正常触发健康检查。针对最后一种情况，需要与我们取得联系确认原因。
        /// </summary>
        [XmlElement("ServerHealthStatus")]
        public string ServerHealthStatus { get; set; }

        /// <summary>
        /// 后端服务器名称Id，为ECS实例Id
        /// </summary>
        [XmlElement("ServerId")]
        public string ServerId { get; set; }

        /// <summary>
        /// 后端服务器的权重
        /// </summary>
        [XmlElement("Weight")]
        public long Weight { get; set; }
    }
}
