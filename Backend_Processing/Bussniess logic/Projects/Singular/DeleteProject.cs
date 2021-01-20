using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Processing.Bussniess_logic.Projects
{
    public class DeleteProject
    {
        public static void deleteProject(int id)
        {
            string sqlQuestion = @"DELETE FROM Projects WHERE Id = @id;";

            BackendProjectListProcessModel data = new BackendProjectListProcessModel
            {
                id = id,
            };

            DataAcess.SqlDataAcess.SaveData(sqlQuestion, data);
        }
    }
}
