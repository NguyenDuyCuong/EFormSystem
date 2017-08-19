using EFS.Common.Global;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.Common.Exceptions
{
    public interface IEFSException
    {
        Layers Layer { get; }
        Levels Level { get; }
        string Message { get; }
        string StackTrace { get;}
        string Source { get; }

        /// <summary>
        /// Json
        /// </summary>
        string InputData { get; } 
        ValidationErrorTypes ErrorType { get; }
        string FuncName { get; }
    }
}
