using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wangwang.eservice.accountstatus.get
    /// </summary>
    public class WangwangEserviceAccountstatusGetRequest : ITopRequest<WangwangEserviceAccountstatusGetResponse>
    {
        /// <summary>
        /// 的起始时间。</br>  格式为： YYYY-mm-dd_HH:MM:SS </br>  注：</br>  1. 查询时间必须在30天之内。  2. 起始时间和结束时间间隔不超过7天。
        /// </summary>
        public string Btime { get; set; }

        /// <summary>
        /// 结束时间 。 </br>  格式为：YYYY-mm-dd_HH:MM:SS </br>  注：</br>  1. 查询时间必须在30天之内。  2. 起始时间和结束时间间隔不超过7天。
        /// </summary>
        public string Etime { get; set; }

        /// <summary>
        /// 查询账号（序列）。 需要带前缀（如cntaobao）。</br>    注： </br>  1. uid中所有账号必须为授权店铺的店铺内账号。</br>  2. 如果传入多个账号，账号与账号之间以","分割。最多30个账号。每个账号的最大长度是64。</br>  3. 由于后端依然是顺序请求，所以该接口的响应时长是会随uid的数量线性增长，即uid数量越多，调用时间越长。请合理使用
        /// </summary>
        public string Uid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wangwang.eservice.accountstatus.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("btime", this.Btime);
            parameters.Add("etime", this.Etime);
            parameters.Add("uid", this.Uid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("btime", this.Btime);
            RequestValidator.ValidateMaxLength("btime", this.Btime, 19);
            RequestValidator.ValidateRequired("etime", this.Etime);
            RequestValidator.ValidateMaxLength("etime", this.Etime, 19);
            RequestValidator.ValidateRequired("uid", this.Uid);
            RequestValidator.ValidateMaxListSize("uid", this.Uid, 30);
            RequestValidator.ValidateMaxLength("uid", this.Uid, 1920);
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
