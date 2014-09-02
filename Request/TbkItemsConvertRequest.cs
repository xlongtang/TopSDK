using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.tbk.items.convert
    /// </summary>
    public class TbkItemsConvertRequest : ITopRequest<TbkItemsConvertResponse>
    {
        /// <summary>
        /// 需返回的字段列表.可选值:click_url
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 推广者的淘宝会员昵称.注：指的是淘宝的会员登录名
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 淘宝客商品数字id串.最大输入40个.格式如:"value1,value2,value3" 用" , "号分隔商品数字id
        /// </summary>
        public string NumIids { get; set; }

        /// <summary>
        /// 自定义输入串.格式:英文和数字组成;长度不能大于12个字符,区分不同的推广渠道,如:bbs,表示bbs为推广渠道;blog,表示blog为推广渠道.
        /// </summary>
        public string OuterCode { get; set; }

        /// <summary>
        /// 用户的pid,必须是mm_xxxx_0_0这种格式中间的"xxxx". 注意nick和pid至少需要传递一个,如果2个都传了,将以pid为准,且pid的最大长度是20。第一次调用接口的用户，推荐该入参不要填写，使用nick=（淘宝账号）的方式去获取，以免出错。
        /// </summary>
        public Nullable<long> Pid { get; set; }

        /// <summary>
        /// 点击串跳转类型，1：单品，2：单品中间页（无线暂无）
        /// </summary>
        public Nullable<long> ReferType { get; set; }

        /// <summary>
        /// 商品track_iid串（带有追踪效果的商品id),最大输入40个,与num_iids必填其一
        /// </summary>
        public string TrackIids { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.tbk.items.convert";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("nick", this.Nick);
            parameters.Add("num_iids", this.NumIids);
            parameters.Add("outer_code", this.OuterCode);
            parameters.Add("pid", this.Pid);
            parameters.Add("refer_type", this.ReferType);
            parameters.Add("track_iids", this.TrackIids);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateMaxListSize("num_iids", this.NumIids, 50);
            RequestValidator.ValidateMaxListSize("track_iids", this.TrackIids, 50);
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
