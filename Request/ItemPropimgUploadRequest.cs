using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.propimg.upload
    /// </summary>
    public class ItemPropimgUploadRequest : ITopUploadRequest<ItemPropimgUploadResponse>
    {
        /// <summary>
        /// 属性图片ID。如果是新增不需要填写
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 属性图片内容。类型:JPG,GIF;最大长度:500K;图片大小不超过:1M
        /// </summary>
        public FileItem Image { get; set; }

        /// <summary>
        /// 商品数字ID，必选
        /// </summary>
        public Nullable<long> NumIid { get; set; }

        /// <summary>
        /// 图片位置
        /// </summary>
        public Nullable<long> Position { get; set; }

        /// <summary>
        /// 属性列表。调用taobao.itemprops.get获取类目属性，属性必须是颜色属性，再用taobao.itempropvalues.get取得vid。格式:pid:vid。
        /// </summary>
        public string Properties { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.propimg.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
            parameters.Add("num_iid", this.NumIid);
            parameters.Add("position", this.Position);
            parameters.Add("properties", this.Properties);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("image", this.Image, 1048576);
            RequestValidator.ValidateRequired("num_iid", this.NumIid);
            RequestValidator.ValidateMinValue("num_iid", this.NumIid, 0);
            RequestValidator.ValidateRequired("properties", this.Properties);
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("image", this.Image);
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
