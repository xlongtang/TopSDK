using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ItemTemplatesGetResponse.
    /// </summary>
    public class ItemTemplatesGetResponse : TopResponse
    {
        /// <summary>
        /// 返回宝贝模板对象。包含模板id，模板name，还有模板的类别（0表示外店，1表示内店）
        /// </summary>
        [XmlArray("item_template_list")]
        [XmlArrayItem("item_template")]
        public List<ItemTemplate> ItemTemplateList { get; set; }
    }
}
