using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qt.report.add
    /// </summary>
    public class QtReportAddRequest : ITopRequest<QtReportAddResponse>
    {
        /// <summary>
        /// 自定义属性字段;分号分隔<br /> 支持最大长度为：2000<br /> 支持的最大列表长度为：2000
        /// </summary>
        public string ExtAttr { get; set; }

        /// <summary>
        /// 质检有效到期时间，一般为一年有效期  status状态为3时必须非空
        /// </summary>
        public Nullable<DateTime> GmtExpiry { get; set; }

        /// <summary>
        /// 提交报告结果时间
        /// </summary>
        public Nullable<DateTime> GmtReport { get; set; }

        /// <summary>
        /// 送检日期
        /// </summary>
        public Nullable<DateTime> GmtSubmit { get; set; }

        /// <summary>
        /// 只有status=3时赋值,   true 质检结果合格,false质检结果不合格.  留空表示成分鉴定,不做判定
        /// </summary>
        public Nullable<bool> IsPassed { get; set; }

        /// <summary>
        /// 样品信息描述<br /> 支持最大长度为：150<br /> 支持的最大列表长度为：150
        /// </summary>
        public string ItemDesc { get; set; }

        /// <summary>
        /// 样品链接.  QT_TYPE=9的时候，请填写N\A<br /> 支持最大长度为：256<br /> 支持的最大列表长度为：256
        /// </summary>
        public string ItemUrl { get; set; }

        /// <summary>
        /// 检测结果消息描述<br /> 支持最大长度为：600<br /> 支持的最大列表长度为：600
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 送检者昵称<br /> 支持最大长度为：32<br /> 支持的最大列表长度为：32
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 当前接口只有淘宝订单真假鉴定（QT_TYPE=9）的报告在该字段传入订单号，其他类型报告都不需要传输该值
        /// </summary>
        public Nullable<long> NumIid { get; set; }

        /// <summary>
        /// 一个质检服务唯一标识质量检验单的编号<br /> 支持最大长度为：64<br /> 支持的最大列表长度为：64
        /// </summary>
        public string QtCode { get; set; }

        /// <summary>
        /// 质检名称<br /> 支持最大长度为：150<br /> 支持的最大列表长度为：150
        /// </summary>
        public string QtName { get; set; }

        /// <summary>
        /// 质检标准  status=3 时 必须非空<br /> 支持最大长度为：16<br /> 支持的最大列表长度为：16
        /// </summary>
        public string QtStandard { get; set; }

        /// <summary>
        /// (1L, "聚划算"),  (2L, "消保"),  (3L, "分销"),  (4L, "抽检"),  (5L, "良无限线下数据"),  (6L, "入驻/续签商城"),  (7L, "买家质检维权"),  (8L, "实地验证"),  (9L, "淘宝买家订单商品鉴定"),  (10L,"假一赔三");<br /> 支持最大值为：15<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> QtType { get; set; }

        /// <summary>
        /// 质检报告源文件url  status状态为3时必须非空<br /> 支持最大长度为：256<br /> 支持的最大列表长度为：256
        /// </summary>
        public string ReportUrl { get; set; }

        /// <summary>
        /// 收费项code<br /> 支持最大长度为：64<br /> 支持的最大列表长度为：64
        /// </summary>
        public string ServcieItemCode { get; set; }

        /// <summary>
        /// 质检服务商名称<br /> 支持最大长度为：50<br /> 支持的最大列表长度为：50
        /// </summary>
        public string SpName { get; set; }

        /// <summary>
        /// 0:已提交申请  1:已收到样品  2:已出检测结果  3.已出具报告<br /> 支持最大值为：4<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> Status { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.qt.report.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("ext_attr", this.ExtAttr);
            parameters.Add("gmt_expiry", this.GmtExpiry);
            parameters.Add("gmt_report", this.GmtReport);
            parameters.Add("gmt_submit", this.GmtSubmit);
            parameters.Add("is_passed", this.IsPassed);
            parameters.Add("item_desc", this.ItemDesc);
            parameters.Add("item_url", this.ItemUrl);
            parameters.Add("message", this.Message);
            parameters.Add("nick", this.Nick);
            parameters.Add("num_iid", this.NumIid);
            parameters.Add("qt_code", this.QtCode);
            parameters.Add("qt_name", this.QtName);
            parameters.Add("qt_standard", this.QtStandard);
            parameters.Add("qt_type", this.QtType);
            parameters.Add("report_url", this.ReportUrl);
            parameters.Add("servcie_item_code", this.ServcieItemCode);
            parameters.Add("sp_name", this.SpName);
            parameters.Add("status", this.Status);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("ext_attr", this.ExtAttr, 2000);
            RequestValidator.ValidateRequired("gmt_submit", this.GmtSubmit);
            RequestValidator.ValidateRequired("item_desc", this.ItemDesc);
            RequestValidator.ValidateMaxLength("item_desc", this.ItemDesc, 150);
            RequestValidator.ValidateRequired("item_url", this.ItemUrl);
            RequestValidator.ValidateMaxLength("item_url", this.ItemUrl, 256);
            RequestValidator.ValidateMaxLength("message", this.Message, 600);
            RequestValidator.ValidateRequired("nick", this.Nick);
            RequestValidator.ValidateMaxLength("nick", this.Nick, 32);
            RequestValidator.ValidateRequired("qt_code", this.QtCode);
            RequestValidator.ValidateMaxLength("qt_code", this.QtCode, 64);
            RequestValidator.ValidateRequired("qt_name", this.QtName);
            RequestValidator.ValidateMaxLength("qt_name", this.QtName, 150);
            RequestValidator.ValidateMaxLength("qt_standard", this.QtStandard, 16);
            RequestValidator.ValidateRequired("qt_type", this.QtType);
            RequestValidator.ValidateMaxValue("qt_type", this.QtType, 15);
            RequestValidator.ValidateMinValue("qt_type", this.QtType, 0);
            RequestValidator.ValidateMaxLength("report_url", this.ReportUrl, 256);
            RequestValidator.ValidateRequired("servcie_item_code", this.ServcieItemCode);
            RequestValidator.ValidateMaxLength("servcie_item_code", this.ServcieItemCode, 64);
            RequestValidator.ValidateRequired("sp_name", this.SpName);
            RequestValidator.ValidateMaxLength("sp_name", this.SpName, 50);
            RequestValidator.ValidateRequired("status", this.Status);
            RequestValidator.ValidateMaxValue("status", this.Status, 4);
            RequestValidator.ValidateMinValue("status", this.Status, 0);
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
