using Backend_Processing;
using Backend_Processing.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiClass.Apis
{
    public class LoadSpecificProject : IGetBackendModell
    {
        public BackendProjectListProcessModel BackendProjectListProcessModel => new BackendProjectListProcessModel();

        public static ApiProjectApiModel LoadSelectedProject(int id)
        {
            ApiProjectApiModel Project = new ApiProjectApiModel();

            BackendProjectListProcessModel sd = Backend_Processing.Bussniess_logic.Projects.LoadProject.LoadSpecificAccount(id);

            Project.idInDatabase = sd.id;
            Project.initalDate = sd.initalDate;
            Project.lastUpdatedDate = sd.lastUpdatedDate;
            Project.programingLangugeWritenwidth = sd.language;
            Project.projectName = sd.projectName;
            Project.WebsiteLink = sd.WebsiteLink;

            return Project;
        }
    }
}
