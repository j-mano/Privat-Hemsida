using Backend_Processing.DataAcess;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Processing.Bussniess_logic.Projects
{
    public class LoadProject
    {
        public static BackendProjectListProcessModel LoadSpecificAccount(int ProjectID)
        {
            string sqlQuestion = @"select Id, projectName, Description, InitalDate, LastUpdatedDate, language from dbo.Projects where id = " + ProjectID + ";"; // The Sql question for getting all projects

            // todo: check if sql question is a bvalid sql question as expecteed.

            List<BackendProjectListProcessModel> projectList    = new List<BackendProjectListProcessModel>();
            BackendProjectListProcessModel chosenProject        = new BackendProjectListProcessModel();

            try
            {
                projectList = SqlDataAcess.LoadData<BackendProjectListProcessModel>(sqlQuestion);

                foreach (var Project in projectList)
                {
                    chosenProject.projectName           = Project.projectName;
                    chosenProject.description           = Project.description;
                    chosenProject.initalDate            = Project.initalDate;
                    chosenProject.lastUpdatedDate       = Project.lastUpdatedDate;
                    chosenProject.language              = Project.language;
                }
            }
            catch
            {
                chosenProject.projectName = "Could not load from database.";
            }

            return chosenProject;
        }
    }
}
