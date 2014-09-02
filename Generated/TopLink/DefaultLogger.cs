using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Taobao.Top.Link
{
    /// <summary>log write to console
    /// </summary>
    public class DefaultLogger : ILog
    {
        public string Name { get; private set; }
        public bool IsDebugEnabled { get; private set; }
        public bool IsInfoEnabled { get; private set; }
        public bool IsWarnEnabled { get; private set; }
        public bool IsErrorEnabled { get; private set; }
        public bool IsFatalEnabled { get; private set; }

        public DefaultLogger(string name
            , bool isDebugEnabled
            , bool isInfoEnabled
            , bool isWarnEnabled
            , bool isErrorEnabled
            , bool isFatalEnabled)
        {
            this.Name = name;
            this.IsDebugEnabled = isDebugEnabled;
            this.IsInfoEnabled = isInfoEnabled;
            this.IsWarnEnabled = isWarnEnabled;
            this.IsErrorEnabled = isErrorEnabled;
            this.IsFatalEnabled = isFatalEnabled;
        }

        public void Debug(object message)
        {
            this.Write(Level.DEBUG, message);
        }
        public void DebugFormat(string format, params object[] args)
        {
            this.WriteFormat(Level.DEBUG, format, args);
        }
        public void Debug(object message, Exception exception)
        {
            this.WriteFormat(Level.DEBUG, "{0}\n{1}\n{2}", message, exception.Message, exception.StackTrace);
        }

        public void Info(object message)
        {
            this.Write(Level.INFO, message);
        }
        public void InfoFormat(string format, params object[] args)
        {
            this.WriteFormat(Level.INFO, format, args);
        }
        public void Info(object message, Exception exception)
        {
            this.WriteFormat(Level.INFO, "{0}\n{1}\n{2}", message, exception.Message, exception.StackTrace);
        }

        public void Warn(object message)
        {
            this.Write(Level.WARN, message);
        }
        public void WarnFormat(string format, params object[] args)
        {
            this.WriteFormat(Level.WARN, format, args);
        }
        public void Warn(object message, Exception exception)
        {
            this.WriteFormat(Level.WARN, "{0}\n{1}\n{2}", message, exception.Message, exception.StackTrace);
        }

        public void Error(object message)
        {
            this.Write(Level.ERROR, message);
        }
        public void ErrorFormat(string format, params object[] args)
        {
            this.WriteFormat(Level.ERROR, format, args);
        }
        public void Error(object message, Exception exception)
        {
            this.WriteFormat(Level.ERROR, "{0}\n{1}\n{2}", message, exception.Message, exception.StackTrace);
        }

        public void Fatal(object message)
        {
            this.Write(Level.FATAL, message);
        }
        public void FatalFormat(string format, params object[] args)
        {
            this.WriteFormat(Level.FATAL, format, args);
        }
        public void Fatal(object message, Exception exception)
        {
            this.WriteFormat(Level.FATAL, "{0}\n{1}\n{2}", message, exception.Message, exception.StackTrace);
        }

        private void WriteFormat(Level level, string format, params object[] args)
        {
            this.Write(level, string.Format(format, args));
        }
        private void Write(Level level, object message)
        {
            Console.WriteLine("{0} [{1}] [{2}] [{3}] - {4}"
                , DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                , level
                , this.Name
                , Thread.CurrentThread.Name
                , message);
        }

        enum Level
        {
            DEBUG, INFO, WARN, ERROR, FATAL
        }
    }
}