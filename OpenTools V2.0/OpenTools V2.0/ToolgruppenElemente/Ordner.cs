using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTools_V2._0.ToolgruppenElemente
{
    [Serializable]
    public class Ordner
    {
        public string path { get; set; } //Pfad zum Ordner
        public string name { get; private set; } //Name des Ordners
       // public string WindowTitel { get; set; } //Window Titel des Explorerfensters

        public ProcessListDemo.Window WindowSettings { get; set; }

        public Ordner(string path)
        {
            this.path = path;
            name = System.IO.Path.GetFileNameWithoutExtension(path) + System.IO.Path.GetExtension(path);
        }

    }
}
