using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ShopCat Data Structure.
    /// </summary>
    [Serializable]
    public class ShopCat : TopObject
    {
        /// <summary>
        /// 类目编号
        /// </summary>
        [XmlElement("cid")]
        public long Cid { get; set; }

        /// <summary>
        /// 该类目是否为父类目。即：该类目是否还有子类目
        /// </summary>
        [XmlElement("is_parent")]
        public bool IsParent { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父类目编号，注：此类目指前台类目，值等于0：表示此类目为一级类目，值不等于0：表示此类目有父类目
        /// </summary>
        [XmlElement("parent_cid")]
        public long ParentCid { get; set; }
    }
}
