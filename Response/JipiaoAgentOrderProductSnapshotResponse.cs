using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// JipiaoAgentOrderProductSnapshotResponse.
    /// </summary>
    public class JipiaoAgentOrderProductSnapshotResponse : TopResponse
    {
        /// <summary>
        /// {   "pnr_id": {    "passengers": ["用户姓名"],    "isAutoBook": false,    "segments": [{     "depTime": "2014-04-04 15:25:00.0",     "filghtNO": "KN5856",     "flightSegment": "SZX-NAY"    }],    "pnr": "-",    "policyMemo": "-",    "fareMemo": "-",    "channel": "渠道"   }  }    pnr_id:淘宝内部pnr id 例如72749001  isAutoBook：是否使用淘宝自动出票  passengers：乘客姓名，可包含多个  segments：航段信息  pnr：pnr值 如果没有值，则返回"-"  policyMemo：政策备注，如果没有值，则返回"-"  fareMemo：运价备注，如果没有值，则返回"-"  channel：渠道 例如51book:300001
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 失败时的错误信息
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 返回操作成功失败信息
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
