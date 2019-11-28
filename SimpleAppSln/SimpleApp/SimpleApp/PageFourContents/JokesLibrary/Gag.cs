using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp
{
    public class Attachment
    {
        public string fallback { get; set; }
        public string footer { get; set; }
        public string text { get; set; }
    }

    public class Gag
    {
        public List<Attachment> attachments { get; set; }
        public string response_type { get; set; }
        public string username { get; set; }
    }
}
