using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Job
    {
        public string projectunit { get; set; }
        public string process { get; set; }
        public string responesible { get; set; }
        public int page { get; set; }
        public string finishprocess { get; set; }
        public string jobdays { get; set; }
        public string jobefficiency { get; set; }
        public string joberrorrate { get; set; }
        public string lzId { get; set; }
        public int paged { get; set; }//pages表里的pages

        public int pages { get; set; }
        public DateTime processdate { get; set; }
    }
}
