using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.logistics.partners.get
    /// </summary>
    public class LogisticsPartnersGetRequest : ITopRequest<LogisticsPartnersGetResponse>
    {
        /// <summary>
        /// 货物价格.只有当选择货到付款此参数才会有效
        /// </summary>
        public string GoodsValue { get; set; }

        /// <summary>
        /// 是否需要揽收资费信息，默认false。在此值为false时，返回内容中将无carriage。在未设置source_id或target_id的情况下，无法查询揽收资费信息。自己联系无揽收资费记录。
        /// </summary>
        public Nullable<bool> IsNeedCarriage { get; set; }

        /// <summary>
        /// 服务类型，根据此参数可查出提供相应服务类型的物流公司信息(物流公司状态正常)，可选值：cod(货到付款)、online(在线下单)、 offline(自己联系)、limit(限时物流)。然后再根据source_id,target_id,goods_value这三个条件来过滤物流公司. 目前输入自己联系服务类型将会返回空，因为自己联系并没有具体的服务信息，所以不会有记录。
        /// </summary>
        public string ServiceType { get; set; }

        /// <summary>
        /// 物流公司揽货地地区码（必须是区、县一级的）.参考:http://www.stats.gov.cn/tjbz/xzqhdm/t20100623_402652267.htm  或者调用 taobao.areas.get 获取
        /// </summary>
        public string SourceId { get; set; }

        /// <summary>
        /// 物流公司派送地地区码（必须是区、县一级的）.参考:http://www.stats.gov.cn/tjbz/xzqhdm/t20100623_402652267.htm  或者调用 taobao.areas.get 获取
        /// </summary>
        public string TargetId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.logistics.partners.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("goods_value", this.GoodsValue);
            parameters.Add("is_need_carriage", this.IsNeedCarriage);
            parameters.Add("service_type", this.ServiceType);
            parameters.Add("source_id", this.SourceId);
            parameters.Add("target_id", this.TargetId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("service_type", this.ServiceType);
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
