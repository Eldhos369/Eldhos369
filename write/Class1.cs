using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace write
{
    public class Class1
    {
        public string write(string pb)
        {
            string r;
            string txt=null;
            using (StreamReader sd = new StreamReader(pb))
            {
                
                while ((r = sd.ReadLine()) != null)
                {
                    txt = txt + r + "\n";
                }
            }

            return txt;
        }
    }
}
