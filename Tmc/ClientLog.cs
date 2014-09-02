using Taobao.Top.Link;
using Top.Api;

namespace Top.Tmc
{
    //refer to https://gist.github.com/wsky/5027961
    internal class ClientLog : DefaultLogger, IClientLog
    {
        public ClientLog(string name
            , bool isDebugEnabled
            , bool isInfoEnabled
            , bool isWarnEnabled
            , bool isErrorEnabled
            , bool isFatalEnabled)
            : base(name
            , isDebugEnabled
            , isInfoEnabled
            , isWarnEnabled
            , isErrorEnabled
            , isFatalEnabled) { }

        void ITopLogger.Error(string message)
        {
            this.Error(message);
        }

        void ITopLogger.Warn(string message)
        {
            this.Warn(message);
        }

        void ITopLogger.Info(string message)
        {
            this.Info(message);
        }
    }
}