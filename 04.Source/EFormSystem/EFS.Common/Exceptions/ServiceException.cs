﻿using System;
using System.Collections.Generic;
using System.Text;
using EFS.Common.Global;

namespace EFS.Common.Exceptions
{
    public class ServiceException : EFSExceptionBase
    {
        public override Layers Layer => Layers.Service;

        public ServiceException(string message, Exception innerException, string funcName, string inputData, ValidationErrorTypes errorType = ValidationErrorTypes.LogicError, Levels lv = Levels.Normal)
            : base(message, innerException, funcName, inputData, errorType, lv) { }

        public ServiceException(string message, string funcName, string inputData, ValidationErrorTypes errorType = ValidationErrorTypes.LogicError, Levels lv = Levels.Normal)
            : base(message, funcName, inputData, errorType, lv) { }
    }
}
