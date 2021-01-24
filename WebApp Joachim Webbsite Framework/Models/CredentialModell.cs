using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_Joachim_Webbsite_Framework.Models
{
    public class CredentialModell
    {
        public bool logdin { get; set; }
        public string username { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string location { get; set; }
        public bool isAdmin { get; set; }
    }
}