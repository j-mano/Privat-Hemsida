using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Processing.Interfaces
{
    public interface IGetProject
    {
        Bussniess_logic.Projects.LoadProject LoadSpecifikProject(int ProjectID);
    }
}
