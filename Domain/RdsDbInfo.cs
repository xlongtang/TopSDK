using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// RdsDbInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RdsDbInfo : TopObject
    {
        /// <summary>
        /// 数据库编码
        /// </summary>
        [XmlElement("charset")]
        public string Charset { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// 数据库id
        /// </summary>
        [XmlElement("db_id")]
        public string DbId { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [XmlElement("db_name")]
        public string DbName { get; set; }

        /// <summary>
        /// 数据库状态 0：创建中 ；1：激活；3：正在删除
        /// </summary>
        [XmlElement("db_status")]
        public string DbStatus { get; set; }

        /// <summary>
        /// 数据库类型，mysql或者mssql
        /// </summary>
        [XmlElement("db_type")]
        public string DbType { get; set; }

        /// <summary>
        /// rds实例id
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// rds实例名
        /// </summary>
        [XmlElement("instance_name")]
        public string InstanceName { get; set; }

        /// <summary>
        /// rds实例类型,s:共享型，x:专享型
        /// </summary>
        [XmlElement("instance_type")]
        public string InstanceType { get; set; }

        /// <summary>
        /// 最大帐号数，1个数据库最多可以创建的账户数目
        /// </summary>
        [XmlElement("max_account")]
        public string MaxAccount { get; set; }

        /// <summary>
        /// 数据库登录密码
        /// </summary>
        [XmlElement("password")]
        public string Password { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 登录数据库的帐号
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
