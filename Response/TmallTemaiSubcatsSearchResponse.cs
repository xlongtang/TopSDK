using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallTemaiSubcatsSearchResponse.
    /// </summary>
    public class TmallTemaiSubcatsSearchResponse : TopResponse
    {
        /// <summary>
        /// 返回传入类目下子类目信息
        /// </summary>
        [XmlArray("cat_list")]
        [XmlArrayItem("tmall_tm_cat")]
        public List<TmallTmCat> CatList { get; set; }
    }
}
