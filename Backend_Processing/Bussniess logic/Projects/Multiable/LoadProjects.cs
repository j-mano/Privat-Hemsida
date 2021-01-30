using System;
using System.Collections.Generic;
using Backend_Processing.DataAcess;
using System.Threading;

namespace Backend_Processing.Bussniess_logic
{
    public class LoadProjects
    {
        public static List<BackendProjectListProcessModel> LoadAllProject()
        {
            string sqlQuestion = @"Select Id, projectName, Description, InitalDate, LastUpdatedDate, language from dbo.Projects"; // The Sql question for getting all projects

            return SqlDataAcess.LoadData<BackendProjectListProcessModel>(sqlQuestion);
        }
    }
}
