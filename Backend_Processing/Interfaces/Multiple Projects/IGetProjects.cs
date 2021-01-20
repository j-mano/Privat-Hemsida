using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Processing.Interfaces
{
    interface IGetProjects
    {
        Bussniess_logic.LoadProjects LoadAllProjectAsync();
    }
}
