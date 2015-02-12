using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itemprops.get
    /// </summary>
    public class ItempropsGetRequest : ITopRequest<ItempropsGetResponse>
    {
        /// <summary>
        /// 属性的Key，支持多条，以“,”分隔
        /// </summary>
        public string AttrKeys { get; set; }

        /// <summary>
        /// 类目子属性路径,由该子属性上层的类目属性和类目属性值组成,格式pid:vid;pid:vid.取类目子属性需要传child_path,cid
        /// </summary>
        public string ChildPath { get; set; }

        /// <summary>
        /// 叶子类目ID，如果只传cid，则只返回一级属性,通过taobao.itemcats.get获得叶子类目ID
        /// </summary>
        public Nullable<long> Cid { get; set; }

        /// <summary>
        /// 增量时间戳。格式:yyyy-MM-dd HH:mm:ss 假如传2005-01-01 00:00:00，则取所有的属性和子属性ID(如果传了pid会忽略datetime)
        /// </summary>
        public Nullable<DateTime> Datetime { get; set; }

        /// <summary>
        /// 需要返回的字段列表，见：ItemProp，默认返回：pid, name, must, multi, prop_values
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 是否颜色属性。可选值:true(是),false(否) (删除的属性不会匹配和返回这个条件)
        /// </summary>
        public Nullable<bool> IsColorProp { get; set; }

        /// <summary>
        /// 是否枚举属性。可选值:true(是),false(否) (删除的属性不会匹配和返回这个条件)。如果返回true，属性值是下拉框选择输入，如果返回false，属性值是用户自行手工输入。
        /// </summary>
        public Nullable<bool> IsEnumProp { get; set; }

        /// <summary>
        /// 在is_enum_prop是true的前提下，是否是卖家可以自行输入的属性（注：如果is_enum_prop返回false，该参数统一返回false）。可选值:true(是),false(否) (删除的属性不会匹配和返回这个条件)
        /// </summary>
        public Nullable<bool> IsInputProp { get; set; }

        /// <summary>
        /// 是否商品属性，这个属性只能放于发布商品时使用。可选值:true(是),false(否)
        /// </summary>
        public Nullable<bool> IsItemProp { get; set; }

        /// <summary>
        /// 是否关键属性。可选值:true(是),false(否)
        /// </summary>
        public Nullable<bool> IsKeyProp { get; set; }

        /// <summary>
        /// 是否销售属性。可选值:true(是),false(否)
        /// </summary>
        public Nullable<bool> IsSaleProp { get; set; }

        /// <summary>
        /// 父属性ID
        /// </summary>
        public Nullable<long> ParentPid { get; set; }

        /// <summary>
        /// 属性id (取类目属性时，传pid，不用同时传PID和parent_pid)
        /// </summary>
        public Nullable<long> Pid { get; set; }

        /// <summary>
        /// 获取类目的类型：1代表集市、2代表天猫
        /// </summary>
        public Nullable<long> Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itemprops.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("attr_keys", this.AttrKeys);
            parameters.Add("child_path", this.ChildPath);
            parameters.Add("cid", this.Cid);
            parameters.Add("datetime", this.Datetime);
            parameters.Add("fields", this.Fields);
            parameters.Add("is_color_prop", this.IsColorProp);
            parameters.Add("is_enum_prop", this.IsEnumProp);
            parameters.Add("is_input_prop", this.IsInputProp);
            parameters.Add("is_item_prop", this.IsItemProp);
            parameters.Add("is_key_prop", this.IsKeyProp);
            parameters.Add("is_sale_prop", this.IsSaleProp);
            parameters.Add("parent_pid", this.ParentPid);
            parameters.Add("pid", this.Pid);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cid", this.Cid);
            RequestValidator.ValidateMaxValue("type", this.Type, 2);
            RequestValidator.ValidateMinValue("type", this.Type, 1);
        }

        #endregion

        public void AddOtherParameter(string key, string value)
        {
            if (this.otherParameters == null)
            {
                this.otherParameters = new TopDictionary();
            }
            this.otherParameters.Add(key, value);
        }
    }
}
