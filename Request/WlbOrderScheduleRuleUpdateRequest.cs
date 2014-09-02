using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.order.schedule.rule.update
    /// </summary>
    public class WlbOrderScheduleRuleUpdateRequest : ITopRequest<WlbOrderScheduleRuleUpdateResponse>
    {
        /// <summary>
        /// 备用发货仓库id
        /// </summary>
        public Nullable<long> BackupStoreId { get; set; }

        /// <summary>
        /// 默认发货仓库id
        /// </summary>
        public Nullable<long> DefaultStoreId { get; set; }

        /// <summary>
        /// 订单调度规则的额外规则设置： REMARK_STOP--有订单留言不自动下发 COD_STOP--货到付款订单不自动下发 CHECK_WAREHOUSE_DELIVER--检查仓库的配送范围
        /// </summary>
        public string Option { get; set; }

        /// <summary>
        /// 国家地区标准编码列表
        /// </summary>
        public string ProvAreaIds { get; set; }

        /// <summary>
        /// 要修改的订单调度规则明细id
        /// </summary>
        public Nullable<long> ScheduleRuleId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.order.schedule.rule.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("backup_store_id", this.BackupStoreId);
            parameters.Add("default_store_id", this.DefaultStoreId);
            parameters.Add("option", this.Option);
            parameters.Add("prov_area_ids", this.ProvAreaIds);
            parameters.Add("schedule_rule_id", this.ScheduleRuleId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("schedule_rule_id", this.ScheduleRuleId);
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
