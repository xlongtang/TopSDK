using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.ju.catitemids.get
    /// </summary>
    public class JuCatitemidsGetRequest : ITopRequest<JuCatitemidsGetResponse>
    {
        /// <summary>
        /// 商品子类目ID。男装:100001,女装:100002。
        /// </summary>
        public Nullable<long> ChildCategoryid { get; set; }

        /// <summary>
        /// 查询本地生活团商品时需要用city进行过滤，如果city是all的话，则查询所有城市的本地生活团商品。如果为空，则查询普通商品
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 分页获取商品信息页序号，代表第几页。page_no=0代表第一页。<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每次获取商品列表的数量。最大是100个，如果超出则报41错。<br /> 支持最大值为：100<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 商品父类目ID。服装:100000,保险:1000000。
        /// </summary>
        public Nullable<long> ParentCategoryid { get; set; }

        /// <summary>
        /// 平台ID。搜狗:1008,聚划算:1001,商城:1002,无线WAP:1007,支付宝:1003,淘宝天下:1004,嗨淘:1006
        /// </summary>
        public Nullable<long> PlatformId { get; set; }

        /// <summary>
        /// IPHONE,WAP,ANDROID,SINA,163 各种终端类型
        /// </summary>
        public string TerminalType { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.ju.catitemids.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("child_categoryid", this.ChildCategoryid);
            parameters.Add("city", this.City);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("parent_categoryid", this.ParentCategoryid);
            parameters.Add("platform_id", this.PlatformId);
            parameters.Add("terminal_type", this.TerminalType);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("page_no", this.PageNo);
            RequestValidator.ValidateMinValue("page_no", this.PageNo, 0);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 100);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
            RequestValidator.ValidateRequired("parent_categoryid", this.ParentCategoryid);
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
