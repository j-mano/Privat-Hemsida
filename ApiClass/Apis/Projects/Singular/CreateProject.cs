using System;
using System.Collections.Generic;
using System.Text;
using Backend_Processing.Bussniess_logic;

namespace ApiClass.Apis
{
    public class CreateProject
    {
        public static void createProject(string projectName, DateTime initalDate, DateTime lastUpdatedDate, string projectDescription, string programingLangugeWritenwidth)
        {
            try
            {
                Backend_Processing.Bussniess_logic.CreateProject.CreateProjectAsync(projectName, initalDate, lastUpdatedDate, projectDescription, programingLangugeWritenwidth);
            }
            catch
            {
                throw;
            }
        }
    }
}
