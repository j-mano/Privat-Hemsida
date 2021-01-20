using System;
using System.Collections.Generic;
using System.Text;

namespace ApiClass.Apis
{
    public class LoadMySkills
    {
        public static string[] getMySkills()
        {
            string[] MySkills = new string[] { "C#", "C", "Cad med solidworks", "MVC med asp.net", "Artifical intiligens", "Webbutvekling med html css och javascript", "SQL databas", "Byggandet av stationära datorer" }; ;

            return MySkills;
        }
    }
}
