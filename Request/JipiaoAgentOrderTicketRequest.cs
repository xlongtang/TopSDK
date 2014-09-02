using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jipiao.agent.order.ticket
    /// </summary>
    public class JipiaoAgentOrderTicketRequest : ITopRequest<JipiaoAgentOrderTicketResponse>
    {
        /// <summary>
        /// 淘宝系统订单id
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        /// <summary>
        /// 成功订单参数：列表元素结构为——  1.航班号（注：是订单里的航班号，非实际承运航班号）;  2.旧乘机人姓名;  3.新乘机人姓名;  4.票号 （乘机人、航段对应的票号）  说明：  1.往返订单，2段航班对应1个票号的，需要2条success_info记录，分别对应去程、回程；  2.有时用户输入的乘机人姓名输入错误或者有生僻字，代理商必须输入新的名字以保证验真通过；即旧乘机人姓名和新乘机人姓名不需要变化时可以相同
        /// </summary>
        public string SuccessInfo { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.jipiao.agent.order.ticket";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("order_id", this.OrderId);
            parameters.Add("success_info", this.SuccessInfo);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("order_id", this.OrderId);
            RequestValidator.ValidateRequired("success_info", this.SuccessInfo);
            RequestValidator.ValidateMaxListSize("success_info", this.SuccessInfo, 18);
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
