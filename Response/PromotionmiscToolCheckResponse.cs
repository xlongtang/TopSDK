using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PromotionmiscToolCheckResponse.
    /// </summary>
    public class PromotionmiscToolCheckResponse : TopResponse
    {
        /// <summary>
        /// 工具审核结果。
        /// </summary>
        [XmlElement("check_tool_module")]
        public CheckToolModule CheckToolModule { get; set; }

        /// <summary>
        /// 接口调用错误信息描述。
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 工具检测动作是否成功。检测是否通过请查看返回值default_model里的is_pass。
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
