using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// JushitaJdpTasksGetResponse.
    /// </summary>
    public class JushitaJdpTasksGetResponse : TopResponse
    {
        /// <summary>
        /// 查询到的未执行任务
        /// </summary>
        [XmlArray("data_push_tasks")]
        [XmlArrayItem("data_push_task")]
        public List<DataPushTask> DataPushTasks { get; set; }
    }
}
