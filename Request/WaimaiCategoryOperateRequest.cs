using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.waimai.category.operate
    /// </summary>
    public class WaimaiCategoryOperateRequest : ITopRequest<WaimaiCategoryOperateResponse>
    {
        /// <summary>
        /// 2，新增   参数：storeId ; 0=1 ; d=json数组      如：{"cates":[{"name":"test1","cid":111,"order":2,"user":"test","pid":111,"rid":1111,"bid":12346}]}        {    "cates": [      {        "name": "test1",   // 类目名， 必选        "order": 2    // 排序值，升序,可选      }    ]  }    3, 修改    {    "cates": [      {        "name": "test1",        "cid": 111,   // 类目id，必须        "order": 2   // 排序值，升序      }    ]  }    4, 删除  {    "cates": [      {        "cid": 111,   // 类目id，必须      }    ]  }
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// 0 查询 1 创建 2 更新 3 删除
        /// </summary>
        public Nullable<long> Operate { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public Nullable<long> ShopId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.waimai.category.operate";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("data", this.Data);
            parameters.Add("operate", this.Operate);
            parameters.Add("shop_id", this.ShopId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("operate", this.Operate);
            RequestValidator.ValidateRequired("shop_id", this.ShopId);
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
