using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERSHIPTEST
{
    public class Knowledge
    {
        private int level;
        public int setLevel
        {
            get { return level; }
        }
        public Knowledge(int level)
        {
            this.level = level;
        }
    }
}
