using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTools_V2._0
{
    public static class IS
    {

        public static bool creatable(string name)
        {

            bool ist = false;

            foreach (char c in name)
            {


                if(c == '?' | c == '\\'| c == '/'| c == ':' | c == '*' | c == '"' | c == '<' | c == '>' | c == '|')
                {
                    ist = false;
                }
                else
                {
                    ist = true;
                }


            }

            return ist;
        }

    }
}
