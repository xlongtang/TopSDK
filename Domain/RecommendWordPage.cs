using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// RecommendWordPage Data Structure.
    /// </summary>
    [Serializable]
    public class RecommendWordPage : TopObject
    {
        /// <summary>
        /// 返回第几页的数据从1开始。  如果输入的值大于可取得的最大页码值时，将返回  最大的页码值并且recommend_word_list值将  为空
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页数据大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 推荐词分页对象列表
        /// </summary>
        [XmlArray("recommend_word_list")]
        [XmlArrayItem("recommend_word")]
        public List<RecommendWord> RecommendWordList { get; set; }

        /// <summary>
        /// 所查询的数据总数
        /// </summary>
        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
