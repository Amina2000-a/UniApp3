using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Prog
    {
        public string Fullname { get; set; }
        public int Id { get; private set; }
        public List<Prog> ProgList { get; set; }
        private static int proId = 1;

        public Prog(string Fullname)
        {
            this.Fullname = Fullname;
            this.Id = proId;
            proId++;
        }
    }
}
