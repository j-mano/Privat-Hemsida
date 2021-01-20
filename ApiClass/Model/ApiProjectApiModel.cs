using System;
using System.Collections.Generic;
using System.Text;

namespace ApiClass
{
    public class ApiProjectApiModel
    {
        public int idInDatabase { get; set; }
        public string projectName { get; set; }
        public DateTime initalDate { get; set; }
        public DateTime lastUpdatedDate { get; set; }
        public string projectDescription { get; set; }
        public string programingLangugeWritenwidth { get; set; }
    }
}
