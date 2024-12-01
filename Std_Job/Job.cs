using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Std_Job
{
    internal class Job
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public List<string> RequiredSkills { get; set; } = new List<string>();
        public string Location { get; set; }

        public Job() { }
    }
}

