using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend_Processing
{
    public class BackendProjectListProcessModel
    {
        // Same name as database colums, A few processes is reling on thet to clone data from database. Dont touch
        public int id { get; set; }
        public string projectName { get; set; }
        public DateTime initalDate { get; set; }
        public DateTime lastUpdatedDate { get; set; }
        public string description { get; set; }
        public string language { get; set; }
    }
}
