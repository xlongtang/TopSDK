using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.grade.set
    /// </summary>
    public class CrmGradeSetRequest : ITopRequest<CrmGradeSetResponse>
    {
        /// <summary>
        /// 只对设置的层级等级有效，必须要在amount和count参数中选择一个<br>  amount参数的填写规范：升级到下一个级别的需要的交易额，单位为分,必须全部填写.例如10000,20000,30000，其中10000表示非会员升级到普通的所需的交易额，20000表示普通升级到高级所需的交易额，层级等级中最高等级的下一个等级默认为0。会员等级越高，所需交易额必须越高。<br /> 支持最小值为：0
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// 只对设置的层级等级有效，必须要在amount和count参数中选择一个<br>  count参数的填写规范：  升级到下一个级别的需要的交易量,必须全部填写. 以逗号分隔,例如100,200,300，其中100表示非会员升级到普通会员交易量。层级等级中最高等级的下一个等级的交易量默认为0。会员等级越高，交易量必须越高。<br /> 支持最小值为：0
        /// </summary>
        public string Count { get; set; }

        /// <summary>
        /// 会员级别折扣率。会员等级越高，折扣必须越低。  950即9.5折，888折即8.88折。出于安全原因，折扣现最低只能设置到700即7折。<br /> 支持最大值为：1000<br /> 支持最小值为：700
        /// </summary>
        public string Discount { get; set; }

        /// <summary>
        /// 会员等级，用逗号分隔。买家会员级别0：店铺客户 1：普通会员 2 ：高级会员 3：VIP会员 4：至尊VIP<br /> 支持最大值为：4<br /> 支持最小值为：1
        /// </summary>
        public string Grade { get; set; }

        /// <summary>
        /// 是否设置达到某一会员等级的交易量和交易额，必填。4个级别都需要设置，如入参为true,true,true,false时，表示设置达到高级会员、VIP会员的交易量或者交易额，不设置达到至尊会员的交易量和交易额
        /// </summary>
        public string Hierarchy { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.grade.set";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("amount", this.Amount);
            parameters.Add("count", this.Count);
            parameters.Add("discount", this.Discount);
            parameters.Add("grade", this.Grade);
            parameters.Add("hierarchy", this.Hierarchy);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxListSize("amount", this.Amount, 4);
            RequestValidator.ValidateMaxListSize("count", this.Count, 4);
            RequestValidator.ValidateRequired("discount", this.Discount);
            RequestValidator.ValidateMaxListSize("discount", this.Discount, 4);
            RequestValidator.ValidateRequired("grade", this.Grade);
            RequestValidator.ValidateMaxListSize("grade", this.Grade, 4);
            RequestValidator.ValidateRequired("hierarchy", this.Hierarchy);
            RequestValidator.ValidateMaxListSize("hierarchy", this.Hierarchy, 4);
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
