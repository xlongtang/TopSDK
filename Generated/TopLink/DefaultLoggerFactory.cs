using System;
using System.Collections.Generic;
using System.Text;

namespace Taobao.Top.Link
{
    public class DefaultLoggerFactory : ILoggerFactory
    {
        private static ILoggerFactory _default;
        public static ILoggerFactory Default
        {
            get
            {
                return _default ?? (_default = new DefaultLoggerFactory(true, true, true, true, true));
            }
        }

        public bool IsDebugEnabled { get; private set; }
        public bool IsInfoEnabled { get; private set; }
        public bool IsWarnEnabled { get; private set; }
        public bool IsErrorEnabled { get; private set; }
        public bool IsFatalEnabled { get; private set; }

        public DefaultLoggerFactory(bool isDebugEnabled
            , bool isInfoEnabled
            , bool isWarnEnabled
            , bool isErrorEnabled
            , bool isFatalEnabled)
        {
            this.IsDebugEnabled = isDebugEnabled;
            this.IsInfoEnabled = isInfoEnabled;
            this.IsWarnEnabled = isWarnEnabled;
            this.IsErrorEnabled = isErrorEnabled;
            this.IsFatalEnabled = isFatalEnabled;
        }

        public ILog Create(string name)
        {
            return new DefaultLogger(name
                , this.IsDebugEnabled
                , this.IsInfoEnabled
                , this.IsWarnEnabled
                , this.IsErrorEnabled
                , this.IsFatalEnabled);
        }

        public ILog Create(Type type)
        {
            return new DefaultLogger(type.FullName
                 , this.IsDebugEnabled
                 , this.IsInfoEnabled
                 , this.IsWarnEnabled
                 , this.IsErrorEnabled
                 , this.IsFatalEnabled);
        }

        public ILog Create(object obj)
        {
            return new DefaultLogger(obj.GetType().FullName
                , this.IsDebugEnabled
                , this.IsInfoEnabled
                , this.IsWarnEnabled
                , this.IsErrorEnabled
                , this.IsFatalEnabled);
        }
    }
}