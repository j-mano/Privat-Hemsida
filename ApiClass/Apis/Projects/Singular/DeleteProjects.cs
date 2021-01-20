using System;
using System.Collections.Generic;
using System.Text;

namespace LvlApiClass.Apis.Projects
{
    public class DeleteProjects
    {
        public static void deleteProject(int id)
        {
            Backend_Processing.Bussniess_logic.Projects.DeleteProject.deleteProject(id);
        }
    }
}
