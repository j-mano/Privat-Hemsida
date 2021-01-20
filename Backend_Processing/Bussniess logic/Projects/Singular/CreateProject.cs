using System;
using Backend_Processing.DataAcess;

namespace Backend_Processing.Bussniess_logic
{
    public static class CreateProject
    {
        public static int CreateProjectAsync(string ProjectName, DateTime InitalDate, DateTime LastUpdatedDate, string ProjectDescription, string ProgramingLangugeWritenwidth)
        {
            BackendProjectListProcessModel data = new BackendProjectListProcessModel
            {
                projectName                     = ProjectName,
                initalDate                      = InitalDate,
                lastUpdatedDate                 = LastUpdatedDate,
                description                     = ProjectDescription,
                language                        = ProgramingLangugeWritenwidth
            };

            string sql = @"insert into dbo.Projects (ProjectName, Description, InitalDate, LastUpdatedDate, language) values( @projectName, @description, @initalDate, @lastUpdatedDate, @language);";

            try
            {
                return SqlDataAcess.SaveData(sql, data);
            }
            catch
            {
                throw;
            }
        }
    }
}
