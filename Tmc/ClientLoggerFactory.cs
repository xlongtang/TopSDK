using System;
using Taobao.Top.Link;

namespace Top.Tmc
{
    //refer to https://gist.github.com/wsky/5027961
    internal class ClientLoggerFactory : ILoggerFactory
    {
        public bool IsDebugEnabled { get; private set; }
        public bool IsErrorEnabled { get; private set; }
        public bool IsFatalEnabled { get; private set; }
        public bool IsInfoEnabled { get; private set; }
        public bool IsWarnEnabled { get; private set; }

        public ClientLoggerFactory(bool isDebugEnabled
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
            return new ClientLog(name
                , this.IsDebugEnabled
                , this.IsInfoEnabled
                , this.IsWarnEnabled
                , this.IsErrorEnabled
                , this.IsFatalEnabled);
        }

        public ILog Create(Type type)
        {
            return new ClientLog(type.FullName
                 , this.IsDebugEnabled
                 , this.IsInfoEnabled
                 , this.IsWarnEnabled
                 , this.IsErrorEnabled
                 , this.IsFatalEnabled);
        }

        public ILog Create(object obj)
        {
            return new ClientLog(obj.GetType().FullName
                , this.IsDebugEnabled
                , this.IsInfoEnabled
                , this.IsWarnEnabled
                , this.IsErrorEnabled
                , this.IsFatalEnabled);
        }
    }
}