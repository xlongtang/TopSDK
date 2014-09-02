using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// LaiwangPPMenu Data Structure.
    /// </summary>
    [Serializable]
    public class LaiwangPPMenu : TopObject
    {
        /// <summary>
        /// 来往公众账号菜单按钮
        /// </summary>
        [XmlArray("button")]
        [XmlArrayItem("laiwang_p_p_button")]
        public List<LaiwangPPButton> Button { get; set; }
    }
}
