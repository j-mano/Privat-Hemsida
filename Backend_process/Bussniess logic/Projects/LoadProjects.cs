using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Backend_Processing.DataAcess;
using Backend_Processing.Bussniess_logic;
using NPOI.SS.Formula.Functions;

namespace Backend_Processing.Bussniess_logic
{
    public class LoadProjects
    {
        public static List<T> LoadAllProject()
        {
            string sqlQuestion = "select * from dbo.projects"; // The Sql question for getting all projects

            // todo: check if sql question is a bvalid sql question as expecteed.

            List<T> lists = SqlDataAcess.LoadData<T>(sqlQuestion);

            return lists;
        }
    }
}
