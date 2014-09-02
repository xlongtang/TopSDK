using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.weitao.menu.create
    /// </summary>
    public class WeitaoMenuCreateRequest : ITopRequest<WeitaoMenuCreateResponse>
    {
        /// <summary>
        /// 支持的type共4种，宝贝分类、h5 url、wangwang和tel，具体见示例：[{ "name": "宝贝分类", "sub_button": [ { "name": "新品", "type": "shopCat", "catId": "111111" }, { "name": "特惠宝贝", "type": "shopCat", "catId": "213214" }, { "name": "特惠宝贝", "type": "shopCat", "catId": "21342435" }] }, { "name": "活动", "sub_button": [  { "name": "我的微官网", "type": "view", "url": "http://mweb.taobao.com" }, {"name": "我的特惠品", "type": "view" ,"url": "http://mpromotion.taobao.com" }, { "name": "我的活动", "type": "view", "url": "http://test.we.app.jae.m.taobao.com?seller_nick=test&seller_id=123124" }] }, { "name": "客服", "sub_button": [  { "name": "客服", "type": "wangwang", "wangwang": "商家测试帐号xx" }, {{ "name": "电话", "type": "tel", "tel": "66668888" }] }]
        /// </summary>
        public string MenuString { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.weitao.menu.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("menu_string", this.MenuString);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("menu_string", this.MenuString);
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
