using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jipiao.policies.fulladd
    /// </summary>
    public class JipiaoPoliciesFulladdRequest : ITopUploadRequest<JipiaoPoliciesFulladdResponse>
    {
        /// <summary>
        /// (ZIP压缩UTF-8编码JSON)，压缩前格式为:[{数据结构BatchPolicy的json格式},{数据结构BatchPolicy的json格式},...] 示例：  [{          "attributes": "rfc=1;ipt=1;fdtod=0000;ldtod=2359",          "source": null,          "airline": "CZ",          "arrAirports": "CSX,CTU,CAN",          "autoHkFlag": true,          "autoTicketFlag": true,          "cabinRules": "[{\"matcher\":{\"mode\":\"ALL\",\"list\":[\"Y\"]},\"priceStrategy\":{\"mode\":\"DISCOUNT\",\"modeBaseValue\":null,\"retention\":5000,\"rebase\":-5},\"backMatcher\":null}]",          "changeRule": null,          "dayOfWeeks": "1234",          "depAirports": "PEK",          "ei": "ei",          "excludeDate": null,          "firstSaleAdvanceDay": null,          "flags": null,          "flightInfo": "+CA1234,CZ2345",          "lastSaleAdvanceDay": null,          "memo": "memoUpdate",          "officeId": "RRR003",          "outProductId": "46f9b762-ea50-4c71-877b-45fa2936277e",          "policyType": 8,          "refundRule": null,          "reissueRule": null,          "saleEndDate": "2013-06-19 00:00:00",          "saleStartDate": "2013-06-09 00:00:00",          "seatInfo": null,          "shareSupport": false,          "specialRule": null,          "travelEndDate": "2013-06-19 00:00:00",          "travelStartDate": "2013-06-09 00:00:00"      }  ]
        /// </summary>
        public FileItem CompressedPolicies { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.jipiao.policies.fulladd";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("compressed_policies", this.CompressedPolicies);
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("compressed_policies", this.CompressedPolicies);
            return parameters;
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
