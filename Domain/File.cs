using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// File Data Structure.
    /// </summary>
    [Serializable]
    public class File : TopObject
    {
        /// <summary>
        /// 申请cdn资源的分配的userId
        /// </summary>
        [XmlElement("cdn_user_id")]
        public long CdnUserId { get; set; }

        /// <summary>
        /// 文件是否删除
        /// </summary>
        [XmlElement("deleted")]
        public string Deleted { get; set; }

        /// <summary>
        /// 该文件所属目录的目录编号
        /// </summary>
        [XmlElement("dir_id")]
        public long DirId { get; set; }

        /// <summary>
        /// 文件在多媒体平台的编号
        /// </summary>
        [XmlElement("file_id")]
        public long FileId { get; set; }

        /// <summary>
        /// 返回的是绝对路径如：http://img07.taobaocdn.com/imgextra/i7/22670458/T2dD0kXb4cXXXXXXXX_!!22670458.jpg
        /// </summary>
        [XmlElement("file_path")]
        public string FilePath { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 文件内容修改时间
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 文件在多媒体平台的文件名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 图片像素，如果非图片，该值为空
        /// </summary>
        [XmlElement("picture_pix")]
        public string PicturePix { get; set; }

        /// <summary>
        /// 文件的大小
        /// </summary>
        [XmlElement("size")]
        public long Size { get; set; }

        /// <summary>
        /// 图片状态,unfroze代表没有被冻结，froze代表被冻结,pass代表排查通过
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
