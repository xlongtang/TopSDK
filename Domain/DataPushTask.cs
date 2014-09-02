using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// DataPushTask Data Structure.
    /// </summary>
    [Serializable]
    public class DataPushTask : TopObject
    {
        /// <summary>
        /// 任务所属的appkey
        /// </summary>
        [XmlElement("app_key")]
        public string AppKey { get; set; }

        /// <summary>
        /// 任务编号
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 下次执行时间
        /// </summary>
        [XmlElement("next_execute_time")]
        public string NextExecuteTime { get; set; }

        /// <summary>
        /// 上一次同步到的时间点
        /// </summary>
        [XmlElement("now_sync_time")]
        public string NowSyncTime { get; set; }

        /// <summary>
        /// 任务的业务参数，用json格式表示
        /// </summary>
        [XmlElement("params")]
        public string Params { get; set; }

        /// <summary>
        /// 任务类型代码
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }

        /// <summary>
        /// 任务所属的用户编号
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 用户的nick
        /// </summary>
        [XmlElement("user_nick")]
        public string UserNick { get; set; }

        /// <summary>
        /// 任务的版本号，在更新任务时，需要用到此数据
        /// </summary>
        [XmlElement("version")]
        public long Version { get; set; }
    }
}
