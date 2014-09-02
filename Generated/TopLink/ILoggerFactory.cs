using System;
using System.Collections.Generic;
using System.Text;

namespace Taobao.Top.Link
{
    /// <summary>logger provider
    /// </summary>
    public interface ILoggerFactory
    {
        ILog Create(string name);
        ILog Create(Type type);
        ILog Create(object obj);
    }
}
