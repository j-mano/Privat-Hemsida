using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Processing.Bussniess_logic.PersonalKnowledge
{
    public class GetMyProgramSkills
    {
        static List<BackendProjectListProcessModel> getJoachimSkills()
        {
            string sqlQuestion = "insert into dbo.JoachimSkills(ProgLang, skillLvl, optaniedFrom) values('Apticate', 3, 'Skolwork')";

            List<BackendProjectListProcessModel> skillsList = new List<BackendProjectListProcessModel>();

            return skillsList;
        }
    }
}
