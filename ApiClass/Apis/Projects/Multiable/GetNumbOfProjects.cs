using System;
using System.Collections.Generic;
using System.Text;

namespace LvlApiClass.Apis
{
    public class GetNumbOfProjects
    {
        public static int GetNumbofProjectsAsync()
        {
            int numbOfProjects = 0;

            numbOfProjects = Backend_Processing.Bussniess_logic.Projects.AmountOfProjects.NumbOfProjects();

            return numbOfProjects;
        }
    }
}
