using System;
using System.Collections.Generic;
using System.Text;

namespace SampleAutomation.Config
{
    public class UAT
    {
        public string url { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }
        public string scriptExp { get; set; }
        public string detailsExp { get; set; }
        public string activityExp { get; set; }
    }

    public class Root
    {
        public UAT AppSettings { get; set; }
    }

}
