using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hanoi.dataservice.write
    /// </summary>
    public class HanoiDataserviceWriteRequest : ITopRequest<HanoiDataserviceWriteResponse>
    {
        /// <summary>
        /// 分配给调用方的名称信息，内部统计使用
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// json对象，key为属性ID，值为需要回写的内容,如果属性值域不为空（通过taobao.hanoi.ranges.get获取）则需要把值转成key回写，并以逗号","隔开拼接成字符串
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// 回流数据的主键或上下文环境，如卖家id，类目id等。
        /// </summary>
        public string Params { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hanoi.dataservice.write";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_name", this.AppName);
            parameters.Add("data", this.Data);
            parameters.Add("params", this.Params);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("app_name", this.AppName);
            RequestValidator.ValidateRequired("data", this.Data);
            RequestValidator.ValidateRequired("params", this.Params);
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
