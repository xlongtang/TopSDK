using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.weitao.comments.get
    /// </summary>
    public class WeitaoCommentsGetRequest : ITopRequest<WeitaoCommentsGetResponse>
    {
        /// <summary>
        /// 翻页时当前页，如果time_stamp参数不设置，此值必需传入<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// 向前后翻页，direction=0，向上翻;direction=1 向下翻<br /> 支持最大值为：1<br /> 支持最小值为：0<br /> 支持的最大列表长度为：2
        /// </summary>
        public Nullable<long> Direction { get; set; }

        /// <summary>
        /// 查询评论所对应feed的Id<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> FeedId { get; set; }

        /// <summary>
        /// 翻页查询一页大小<br /> 支持最大值为：100<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 翻页时间戳，没有时间参数，则说明是跳页查询或者第一页，current_page有效，direction无效；有时间参数，则说明是上下翻页，current_page无效，direction有效；  如果current_page=1，则time_stamp无效，强制刷新为第一页。<br /> 支持的最大列表长度为：15
        /// </summary>
        public Nullable<long> TimeStamp { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.weitao.comments.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("current_page", this.CurrentPage);
            parameters.Add("direction", this.Direction);
            parameters.Add("feed_id", this.FeedId);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("time_stamp", this.TimeStamp);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("current_page", this.CurrentPage, 1);
            RequestValidator.ValidateMaxValue("direction", this.Direction, 1);
            RequestValidator.ValidateMinValue("direction", this.Direction, 0);
            RequestValidator.ValidateRequired("feed_id", this.FeedId);
            RequestValidator.ValidateMinValue("feed_id", this.FeedId, 1);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 100);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
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
