using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// CreativeRecord Data Structure.
    /// </summary>
    [Serializable]
    public class CreativeRecord : TopObject
    {
        /// <summary>
        /// 审核拒绝原因描述
        /// </summary>
        [XmlElement("audit_desc")]
        public string AuditDesc { get; set; }

        /// <summary>
        /// 审核状态： audit_wait-待审核；audit_pass-审核通过(上线)；audit_reject-审核拒绝；默认为audit_pass。
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 关键词id
        /// </summary>
        [XmlElement("creative_id")]
        public long CreativeId { get; set; }

        /// <summary>
        /// 创意图片地址，必须是推广组对应商品的图片之一
        /// </summary>
        [XmlElement("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 系统记录最后修改时间
        /// </summary>
        [XmlElement("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 创意被修改的时间
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 主人昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 修改前创意图片地址
        /// </summary>
        [XmlElement("old_img_url")]
        public string OldImgUrl { get; set; }

        /// <summary>
        /// 修改前创意标题
        /// </summary>
        [XmlElement("old_title")]
        public string OldTitle { get; set; }

        /// <summary>
        /// 创意标题，最多20个汉字
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
