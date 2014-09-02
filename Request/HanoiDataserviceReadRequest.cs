using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hanoi.dataservice.read
    /// </summary>
    public class HanoiDataserviceReadRequest : ITopRequest<HanoiDataserviceReadResponse>
    {
        /// <summary>
        /// 分配给调用方的名称信息，内部统计使用
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 要查询的属性的id(Long型)。以json的数组的形式。所有属性的querykey必须相同，如有不同的需要分多次查询。属性的taobao.hanoi.ranges.get不为空时，值为key的拼接
        /// </summary>
        public string Attrs { get; set; }

        /// <summary>
        /// 查询的主键。如查询关系数据，主键是sellerId+buyerId，但sellerId是系统自动传过来的，所以只需要传"BUYERNICK"或"BUYERID"二选一。再例如查询类目数据，则需要传"CATEGORYID"。
        /// </summary>
        public string Pk { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hanoi.dataservice.read";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_name", this.AppName);
            parameters.Add("attrs", this.Attrs);
            parameters.Add("pk", this.Pk);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("app_name", this.AppName);
            RequestValidator.ValidateRequired("attrs", this.Attrs);
            RequestValidator.ValidateRequired("pk", this.Pk);
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
