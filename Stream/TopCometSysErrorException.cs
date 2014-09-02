using System;

/**
 * 出现的系统级的异常，这类型的异常产生后需要整个系统退出
 * 比如：missing app key,签名不对等
 **/
namespace Top.Api.Stream
{
    public class TopCometSysErrorException : TopCometException
    {
        public TopCometSysErrorException()
            : base()
        {
        }

        public TopCometSysErrorException(string message, Exception cause)
            : base(message, cause)
        {
        }

        public TopCometSysErrorException(string message)
            : base(message)
        {
        }

    }
}
