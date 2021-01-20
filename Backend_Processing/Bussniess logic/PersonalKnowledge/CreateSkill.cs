using Backend_Processing.DataAcess;
using Backend_Processing.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Processing.Bussniess_logic.PersonalKnowledge
{
    class CreateSkill
    {
        static async System.Threading.Tasks.Task<int> CreateJoachimSkillsAsync(string inputProgLang, int inputskillLvl, string inputoptaniedFrom)
        {
            BackendProgSkillsModell data = new BackendProgSkillsModell
            {
                skill = inputProgLang,
                skillLvl = inputskillLvl,
                obtaintdFrom = inputoptaniedFrom
            };

            string sqlQuestion = "insert into dbo.JoachimSkills(ProgLang, skillLvl, optaniedFrom) values(@skill, @skillLvl, @obtaintdFrom)";

            return SqlDataAcess.SaveData(sqlQuestion, data);
        }
    }
}
