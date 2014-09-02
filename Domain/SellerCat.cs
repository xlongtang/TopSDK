using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// SellerCat Data Structure.
    /// </summary>
    [Serializable]
    public class SellerCat : TopObject
    {
        /// <summary>
        /// 卖家自定义类目编号
        /// </summary>
        [XmlElement("cid")]
        public long Cid { get; set; }

        /// <summary>
        /// 创建时间。格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 修改时间。格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 卖家自定义类目名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父类目编号，值等于0：表示此类目为店铺下的一级类目，值不等于0：表示此类目有父类目
        /// </summary>
        [XmlElement("parent_cid")]
        public long ParentCid { get; set; }

        /// <summary>
        /// 链接图片地址
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 该类目在页面上的排序位置
        /// </summary>
        [XmlElement("sort_order")]
        public long SortOrder { get; set; }

        /// <summary>
        /// 店铺类目类型：可选值：manual_type：手动分类，new_type：新品上价， tree_type：二三级类目树 ，property_type：属性叶子类目树， brand_type：品牌推广
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
