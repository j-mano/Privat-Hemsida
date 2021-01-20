using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend_Processing
{
    class BackendProjectListProcessModel
    {
        public string projectName { get; set; }
        public DateTime initalDate { get; set; }
        public DateTime lastUpdatedDate { get; set; }
        public string projectDescription { get; set; }
        public string programingLangugeWritenwidth { get; set; }
    }
}
