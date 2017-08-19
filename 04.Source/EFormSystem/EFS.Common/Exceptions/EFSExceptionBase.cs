using System;
using System.Collections.Generic;
using System.Text;
using EFS.Common.Global;

namespace EFS.Common.Exceptions
{
    public abstract class EFSExceptionBase : Exception, IEFSException
    {
        public abstract Layers Layer { get; }

        private Levels _level;
        public Levels Level => _level;

        private string _inputData;
        public string InputData => _inputData;

        private ValidationErrorTypes _errorType;
        public ValidationErrorTypes ErrorType => _errorType;

        private string _funcName;
        public string FuncName => _funcName;

        public EFSExceptionBase(string message, Exception innerException, string funcName, string inputData, ValidationErrorTypes errorType = ValidationErrorTypes.LogicError, Levels lv = Levels.Normal) : base(message, innerException)
        {
            _inputData = inputData;
            _level = lv;
            _errorType = errorType;
            _funcName = funcName;
        }

        public EFSExceptionBase(string message, string funcName, string inputData, ValidationErrorTypes errorType = ValidationErrorTypes.LogicError, Levels lv = Levels.Normal) : base(message)
        {
            _inputData = inputData;
            _level = lv;
            _errorType = errorType;
            _funcName = funcName;
        }
    }
}
