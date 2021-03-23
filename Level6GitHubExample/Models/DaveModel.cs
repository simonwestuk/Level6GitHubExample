using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Level6GitHubExample.Models
{
    public class DaveModel
    {
        public int Id { get; set; }

        public string Fname { get; set; }

        public string Sname { get; set; }

        public DaveModel(int id, string fname, string sname)
        {
            Id = id;
            Fname = fname;
            Sname = sname;
        }
    }
}
