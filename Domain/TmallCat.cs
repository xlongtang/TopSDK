using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TmallCat Data Structure.
    /// </summary>
    [Serializable]
    public class TmallCat : TopObject
    {
        /// <summary>
        /// 搜索前台类目id
        /// </summary>
        [XmlElement("cat_id")]
        public long CatId { get; set; }

        /// <summary>
        /// 搜索前台类目名字
        /// </summary>
        [XmlElement("cat_name")]
        public string CatName { get; set; }
    }
}
