using System;

namespace Top.Api
{
    /// <summary>
    /// 日志打点接口。
    /// </summary>
    public interface ITopLogger
    {
        void Error(string message);
        void Warn(string message);
        void Info(string message);
    }
}
