using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vulnsearch
{
    class Info
    {
        public int theLinenum { get; set; }
        public String Text { get; set; }
        public String Varsize { get; set; }
        public String TheFunction { get; set; }
        public String[] Commands { get; set; }
        public Info(int thelinenum, String text, String varsize, String thefunction)
        {
            theLinenum = thelinenum;
            Text = text;
            Varsize = varsize;
            TheFunction = thefunction;
            //Commands = get commands from wpf

        }
        //Other properties, methods, events...
    }
}

