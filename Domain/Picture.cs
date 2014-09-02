using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Picture Data Structure.
    /// </summary>
    [Serializable]
    public class Picture : TopObject
    {
        /// <summary>
        /// 图片的创建时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 图片是否删除的标记
        /// </summary>
        [XmlElement("deleted")]
        public string Deleted { get; set; }

        /// <summary>
        /// 图片在后台处理之后的md5值  当md5值为32位长度的字符串时为图片搬家后的文件md5验证码  md5值为长整数时为图片替换后的时间戳
        /// </summary>
        [XmlElement("md5")]
        public string Md5 { get; set; }

        /// <summary>
        /// 图片的修改时间
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 图片分类ID
        /// </summary>
        [XmlElement("picture_category_id")]
        public long PictureCategoryId { get; set; }

        /// <summary>
        /// 图片ID
        /// </summary>
        [XmlElement("picture_id")]
        public long PictureId { get; set; }

        /// <summary>
        /// 返回的是绝对路径如：http://img07.taobaocdn.com/imgextra/i7/22670458/T2dD0kXb4cXXXXXXXX_!!22670458.jpg
        /// </summary>
        [XmlElement("picture_path")]
        public string PicturePath { get; set; }

        /// <summary>
        /// 图片相素,格式:长x宽，如450x150
        /// </summary>
        [XmlElement("pixel")]
        public string Pixel { get; set; }

        /// <summary>
        /// 图片是否被引用
        /// </summary>
        [XmlElement("referenced")]
        public bool Referenced { get; set; }

        /// <summary>
        /// 图片大小,bite单位
        /// </summary>
        [XmlElement("sizes")]
        public long Sizes { get; set; }

        /// <summary>
        /// 图片状态,unfroze代表没有被冻结，froze代表被冻结,pass代表排查通过
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 图片标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 卖家ID
        /// </summary>
        [XmlElement("uid")]
        public long Uid { get; set; }
    }
}
