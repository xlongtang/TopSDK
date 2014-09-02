using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WaimaiItemPicUploadResponse.
    /// </summary>
    public class WaimaiItemPicUploadResponse : TopResponse
    {
        /// <summary>
        /// 返回图片地址及提示信息及code.  返回结果result_data为完整图片地址,例如:  http://img.taobaocdn.com/bao/uploaded/i1/T1uTCUXExiXXcK5RZ8
        /// </summary>
        [XmlElement("result")]
        public CreateResult Result { get; set; }
    }
}
