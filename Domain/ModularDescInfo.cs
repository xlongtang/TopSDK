using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// ModularDescInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ModularDescInfo : TopObject
    {
        /// <summary>
        /// 旧描述与新描述共存时间（切换时间）。
        /// </summary>
        [XmlElement("dead_line")]
        public string DeadLine { get; set; }

        /// <summary>
        /// 运营定义的该商品所属类目的类目级别模块信息列表，列表顺序即为模块顺序。
        /// </summary>
        [XmlArray("itm_dsc_modules")]
        [XmlArrayItem("item_desc_module")]
        public List<ItemDescModule> ItmDscModules { get; set; }

        /// <summary>
        /// 默认值为false，如果此字段为true，则卖家上传的模块化的描述信息可以自定义排序。
        /// </summary>
        [XmlElement("user_order")]
        public bool UserOrder { get; set; }

        /// <summary>
        /// 用户自定义模块数量最大值限制。类目级别模块+用户级别模块必须小于<20
        /// </summary>
        [XmlElement("usr_def_max_num")]
        public long UsrDefMaxNum { get; set; }
    }
}
