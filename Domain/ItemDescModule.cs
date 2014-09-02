using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ItemDescModule Data Structure.
    /// </summary>
    [Serializable]
    public class ItemDescModule : TopObject
    {
        /// <summary>
        /// 描述具体内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 一个List<String>的Json串，里面是模块引导提示，不超过3条（isv提交时可忽略不传）
        /// </summary>
        [XmlElement("intros")]
        public string Intros { get; set; }

        /// <summary>
        /// 模块id ,(注意:用户自定义模块不用填此项。)
        /// </summary>
        [XmlElement("module_id")]
        public long ModuleId { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        [XmlElement("module_name")]
        public string ModuleName { get; set; }

        /// <summary>
        /// 是否必填 （isv提交时可忽略不传）
        /// </summary>
        [XmlElement("required")]
        public bool Required { get; set; }

        /// <summary>
        /// 淘宝图片空间的地址链接，示例模板，最多不超过三个（isv提交时可忽略不传）
        /// </summary>
        [XmlElement("tpl_urls")]
        public string TplUrls { get; set; }

        /// <summary>
        /// cat_mod:表示是运营设置的类目维度模块，usr_mod表示的是商家自定义模块。
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
