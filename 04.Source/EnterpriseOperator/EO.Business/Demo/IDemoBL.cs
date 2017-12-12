using EO.Business.Base;
using EO.Models.Demo;
using System;
using System.Collections.Generic;
using System.Text;

namespace EO.Business.Demo
{
    public interface IDemoBL : IBusinessLogic
    {
        string[] Values();
    }
}
