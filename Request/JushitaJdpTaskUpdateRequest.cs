using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jushita.jdp.task.update
    /// </summary>
    public class JushitaJdpTaskUpdateRequest : ITopRequest<JushitaJdpTaskUpdateResponse>
    {
        /// <summary>
        /// 任务执行失败的错误信息，可以方便排查问题。<br /> 支持最大长度为：100<br /> 支持的最大列表长度为：100
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 任务执行的机器主机名,用于方便排查问题。<br /> 支持最大长度为：30<br /> 支持的最大列表长度为：30
        /// </summary>
        public string ExecuteHost { get; set; }

        /// <summary>
        /// 任务的编号
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 任务的下次开始执行时间。
        /// </summary>
        public Nullable<DateTime> NextExecuteTime { get; set; }

        /// <summary>
        /// 任务当前同步到的时间点。
        /// </summary>
        public Nullable<DateTime> NowSyncTime { get; set; }

        /// <summary>
        /// 任务的参数，用json格式表示<br /> 支持最大长度为：512<br /> 支持的最大列表长度为：512
        /// </summary>
        public string Params { get; set; }

        /// <summary>
        /// 任务的状态，0表示任务新建或未执行完成，1表示任务停止，2表示任务已经完成，-1表示任务执行失败。<br /> 支持最大值为：2<br /> 支持最小值为：-1
        /// </summary>
        public Nullable<long> Status { get; set; }

        /// <summary>
        /// 任务的类型,<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> Type { get; set; }

        /// <summary>
        /// 任务更新时的版本号，此值在选择出的任务中获取到。
        /// </summary>
        public Nullable<long> Version { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.jushita.jdp.task.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("error_message", this.ErrorMessage);
            parameters.Add("execute_host", this.ExecuteHost);
            parameters.Add("id", this.Id);
            parameters.Add("next_execute_time", this.NextExecuteTime);
            parameters.Add("now_sync_time", this.NowSyncTime);
            parameters.Add("params", this.Params);
            parameters.Add("status", this.Status);
            parameters.Add("type", this.Type);
            parameters.Add("version", this.Version);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("error_message", this.ErrorMessage, 100);
            RequestValidator.ValidateMaxLength("execute_host", this.ExecuteHost, 30);
            RequestValidator.ValidateRequired("id", this.Id);
            RequestValidator.ValidateRequired("next_execute_time", this.NextExecuteTime);
            RequestValidator.ValidateRequired("now_sync_time", this.NowSyncTime);
            RequestValidator.ValidateMaxLength("params", this.Params, 512);
            RequestValidator.ValidateRequired("status", this.Status);
            RequestValidator.ValidateMaxValue("status", this.Status, 2);
            RequestValidator.ValidateMinValue("status", this.Status, -1);
            RequestValidator.ValidateMinValue("type", this.Type, 0);
            RequestValidator.ValidateRequired("version", this.Version);
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
