using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace save
{
    public class Class12
    {
       
        public void save(string pb,string txt)
        {
            using (StreamWriter st = new StreamWriter(pb))
            {
                string r = txt;
                st.Write(r); 
            }
        }
    }
}
