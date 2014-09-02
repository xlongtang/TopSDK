using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jushita.jdp.tasks.get
    /// </summary>
    public class JushitaJdpTasksGetRequest : ITopRequest<JushitaJdpTasksGetResponse>
    {
        /// <summary>
        /// 最大可返回的任务数量<br /> 支持最大值为：200<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> FetchNum { get; set; }

        /// <summary>
        /// 任务分组数量，表示把所有任务平均分成x组，在线订购应用此参数必传；非在线订购应用此参数忽略。<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> TaskItemNum { get; set; }

        /// <summary>
        /// 指定获取哪些分组的任务，取多个分组有半角逗号分隔，在线订购应用此参数必传；非在线订购应用此参数忽略。其中task_items >= 0且task_items < task_item_num
        /// </summary>
        public string TaskItems { get; set; }

        /// <summary>
        /// 任务类型<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> Type { get; set; }

        /// <summary>
        /// 需要查询哪些用户的任务，非在线订购应用此参数必传；在线订购应用此参数忽略。
        /// </summary>
        public string UserIds { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.jushita.jdp.tasks.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fetch_num", this.FetchNum);
            parameters.Add("task_item_num", this.TaskItemNum);
            parameters.Add("task_items", this.TaskItems);
            parameters.Add("type", this.Type);
            parameters.Add("user_ids", this.UserIds);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("fetch_num", this.FetchNum, 200);
            RequestValidator.ValidateMinValue("fetch_num", this.FetchNum, 1);
            RequestValidator.ValidateMinValue("task_item_num", this.TaskItemNum, 1);
            RequestValidator.ValidateMaxListSize("task_items", this.TaskItems, 500);
            RequestValidator.ValidateRequired("type", this.Type);
            RequestValidator.ValidateMinValue("type", this.Type, 0);
            RequestValidator.ValidateMaxListSize("user_ids", this.UserIds, 200);
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
