using System;
using System.Collections.Generic;
using System.Text;

namespace ApiClass.Apis
{
    public class LoadSpecificProject
    {
        public static ApiProjectApiModel LoadSelectedProject(int id)
        {
            ApiProjectApiModel Project = new ApiProjectApiModel();

            Backend_Processing.Bussniess_logic.Projects.LoadProject.LoadSpecifikProject(id);

            return Project;
        }
    }
}
