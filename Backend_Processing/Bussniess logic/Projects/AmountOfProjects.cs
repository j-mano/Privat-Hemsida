using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Processing.Bussniess_logic.Projects
{
    public class AmountOfProjects
    {
        public static int NumbOfProjects()
        {
            int returnInt = 0;
            List<BackendProjectListProcessModel> projects = LoadProjects.LoadAllProject(); // Using the LoadAllProject function to get all projexts

            foreach (var Project in projects)
                returnInt = returnInt + 1;

            return returnInt;
        }
    }
}
