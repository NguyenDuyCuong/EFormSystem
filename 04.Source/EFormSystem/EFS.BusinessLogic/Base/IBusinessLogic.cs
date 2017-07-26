using EFS.APIModel.Base;
using EFS.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.BusinessLogic.Base
{
    /// <summary>
    /// The BusinessLogic interface.
    /// </summary>
    /// <typeparam name="T">
    /// A domain entity.
    /// </typeparam>
    public interface IBusinessLogic<T> where T : ModelItem
    {
        
    }
}
