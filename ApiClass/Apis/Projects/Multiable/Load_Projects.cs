using System;
using System.Collections.Generic;
using System.Text;
using Backend_Processing;
using Backend_Processing.Bussniess_logic;
using NPOI.SS.Formula.Functions;

namespace ApiClass.Apis
{
    public static class Load_Projects
    {
        public static List<ApiProjectApiModel> GetProjectsAsync()
        {
            List<ApiProjectApiModel> returnApiModelList = new List<ApiProjectApiModel>();

            List<BackendProjectListProcessModel> ProjectsFromBackend = LoadProjects.LoadAllProject();

            foreach (var project in ProjectsFromBackend)
            {
                returnApiModelList.Add(new ApiProjectApiModel
                {
                    idInDatabase                    = project.id,
                    initalDate                      = project.initalDate,
                    projectName                     = project.projectName,
                    lastUpdatedDate                 = project.lastUpdatedDate,
                    projectDescription              = project.description,
                    programingLangugeWritenwidth    = project.language
                });
            }

            //List<T> Projectlist = LoadProjects.LoadAllProject(); // Calling processing layer after a project.

            return returnApiModelList;
        }
    }
}
