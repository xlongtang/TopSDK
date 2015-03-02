using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ItemTaoSirElDO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemTaoSirElDO : TopObject
    {
        /// <summary>
        /// 是否输入框
        /// </summary>
        [XmlElement("is_input")]
        public bool IsInput { get; set; }

        /// <summary>
        /// 是否文本元素，用于显示也用于组装value_name，比如：操作符
        /// </summary>
        [XmlElement("is_label")]
        public bool IsLabel { get; set; }

        /// <summary>
        /// 是否只用于显示的文本元素
        /// </summary>
        [XmlElement("is_show_label")]
        public bool IsShowLabel { get; set; }

        /// <summary>
        /// 显示文本
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// 0 - 类型为label元素，只用于展示，不用于组装value_name；  1 - 类型为label元素，用于展示，用于组装value_name；  2 - 类型为输入狂元素，主要用于卖家输入数据. 卖家填写完后需要重新设置该元素的文本数据；
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
