using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTools_V2._0.ToolgruppenElemente
{
    [Serializable]
    public class Datei
    {

        public string path { get; set; }
        public string name { get; private set; }

        public ProcessListDemo.Window WindowSettings { get; set; }

        public Datei(string path)
        {

            this.path = path;
            name = System.IO.Path.GetFileNameWithoutExtension(path);

        }

    }
}
