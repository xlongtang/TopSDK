using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TmallTmCat Data Structure.
    /// </summary>
    [Serializable]
    public class TmallTmCat : TopObject
    {
        /// <summary>
        /// 特卖二级类目ID
        /// </summary>
        [XmlElement("sub_cat_id")]
        public long SubCatId { get; set; }

        /// <summary>
        /// 特卖二级类目名称
        /// </summary>
        [XmlElement("sub_cat_name")]
        public string SubCatName { get; set; }
    }
}
