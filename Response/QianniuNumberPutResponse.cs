using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// QianniuNumberPutResponse.
    /// </summary>
    public class QianniuNumberPutResponse : TopResponse
    {
        /// <summary>
        /// 是否上传成功。返回的是个json串，分别表示每条记录是否成功。
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
