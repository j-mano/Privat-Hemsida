using System;
using System.Collections.Generic;
using System.Text;
using Backend_Processing.DataAcess;
using Backend_Processing.Bussniess_logic;

namespace Backend_Processing.Bussniess_logic
{
    public static class CreateProject
    {
        public static int createProject(string ProjectName, DateTime InitalDate, DateTime LastUpdatedDate, string ProjectDescription, string ProgramingLangugeWritenwidth)
        {
            BackendProjectListProcessModel data = new BackendProjectListProcessModel
            {
                projectName                     = ProjectName,
                initalDate                      = InitalDate,
                lastUpdatedDate                 = LastUpdatedDate,
                projectDescription              = ProjectDescription,
                programingLangugeWritenwidth    = ProgramingLangugeWritenwidth
            };

            string sql = @"insert into dbo.Projects (Namn , Description, InitialDate, LastUpdatedDate, language) values( @projectName, @initalDate, @lastUpdatedDate, @projectDescription, @programingLangugeWritenwidth);";

            return SqlDataAcess.SaveData(sql, data);
        }
    }
}
