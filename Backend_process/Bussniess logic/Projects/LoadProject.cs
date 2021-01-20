using Backend_Processing.DataAcess;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Processing.Bussniess_logic.Projects
{
    public class LoadProject
    {
        public static List<T> LoadSpecifikProject(int ProjectID)
        {
            string sqlQuestion = @"select * from dbo.projects where id = @ProjectID"; // The Sql question for getting all projects

            // todo: check if sql question is a bvalid sql question as expecteed.

            List<T> lists = SqlDataAcess.LoadData<T>(sqlQuestion);

            foreach(var project in lists)
            {
                
            }

            return lists;
        }
    }
}
