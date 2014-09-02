using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itemcats.get
    /// </summary>
    public class ItemcatsGetRequest : ITopRequest<ItemcatsGetResponse>
    {
        /// <summary>
        /// 商品所属类目ID列表，用半角逗号(,)分隔 例如:(18957,19562,) (cids、parent_cid至少传一个)<br /> 支持最大值为：9223372036854775807<br /> 支持最小值为：0
        /// </summary>
        public string Cids { get; set; }

        /// <summary>
        /// 需要返回的字段列表，见ItemCat，默认返回：cid,parent_cid,name,is_parent；增量类目信息,根据fields传入的参数返回相应的结果。 features字段： 1、如果存在attr_key=freeze表示该类目被冻结了，attr_value=0,5，value可能存在2个值（也可能只有1个），用逗号分割，0表示禁编辑，5表示禁止发布
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 父商品类目 id，0表示根节点, 传输该参数返回所有子类目。 (cids、parent_cid至少传一个)<br /> 支持最大值为：9223372036854775807<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> ParentCid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itemcats.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cids", this.Cids);
            parameters.Add("fields", this.Fields);
            parameters.Add("parent_cid", this.ParentCid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxListSize("cids", this.Cids, 1000);
            RequestValidator.ValidateMaxValue("parent_cid", this.ParentCid, 9223372036854775807);
            RequestValidator.ValidateMinValue("parent_cid", this.ParentCid, 0);
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
