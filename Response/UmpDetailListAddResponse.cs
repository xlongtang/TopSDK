using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// UmpDetailListAddResponse.
    /// </summary>
    public class UmpDetailListAddResponse : TopResponse
    {
        /// <summary>
        /// 返回对应的营销详情的id列表！若有某一条插入失败，会将插入成功的detail_id放到errorMessage里面返回，此时errorMessage里面会包含格式为(id1,id2,id3)的插入成功id列表。这些ids会对交易产生影响，通过截取此信息，将对应detail删除！
        /// </summary>
        [XmlArray("detail_id_list")]
        [XmlArrayItem("number")]
        public List<long> DetailIdList { get; set; }
    }
}
