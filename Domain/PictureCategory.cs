using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// PictureCategory Data Structure.
    /// </summary>
    [Serializable]
    public class PictureCategory : TopObject
    {
        /// <summary>
        /// 图片类目的创建时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 图片分类的修改时间
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 一级分类的parent_id为0  二级分类的则为其父分类的picture_category_id
        /// </summary>
        [XmlElement("parent_id")]
        public long ParentId { get; set; }

        /// <summary>
        /// 图片分类ID
        /// </summary>
        [XmlElement("picture_category_id")]
        public long PictureCategoryId { get; set; }

        /// <summary>
        /// 图片分类名
        /// </summary>
        [XmlElement("picture_category_name")]
        public string PictureCategoryName { get; set; }

        /// <summary>
        /// 图片分类排序
        /// </summary>
        [XmlElement("position")]
        public long Position { get; set; }

        /// <summary>
        /// 图片分类型别，sys-fixture代表店铺装修分类(系统分类)，sys-auction代表宝贝图片分类(系统分类)，user-define代表用户自定义分类
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
