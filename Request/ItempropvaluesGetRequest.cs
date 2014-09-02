using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itempropvalues.get
    /// </summary>
    public class ItempropvaluesGetRequest : ITopRequest<ItempropvaluesGetResponse>
    {
        /// <summary>
        /// 属性的Key，支持多条，以“,”分隔
        /// </summary>
        public string AttrKeys { get; set; }

        /// <summary>
        /// 叶子类目ID ,通过taobao.itemcats.get获得叶子类目ID
        /// </summary>
        public Nullable<long> Cid { get; set; }

        /// <summary>
        /// 需要返回的字段。目前支持有：cid,pid,prop_name,vid,name,name_alias,status,sort_order
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 属性和属性值 id串，格式例如(pid1;pid2)或(pid1:vid1;pid2:vid2)或(pid1;pid2:vid2)
        /// </summary>
        public string Pvs { get; set; }

        /// <summary>
        /// 获取类目的类型：1代表集市、2代表天猫
        /// </summary>
        public Nullable<long> Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itempropvalues.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("attr_keys", this.AttrKeys);
            parameters.Add("cid", this.Cid);
            parameters.Add("fields", this.Fields);
            parameters.Add("pvs", this.Pvs);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cid", this.Cid);
            RequestValidator.ValidateRequired("fields", this.Fields);
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
