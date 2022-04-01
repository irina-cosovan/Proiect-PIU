using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPIU.Clase
{
    class Gen
    {
        public Gen(int _idGen, string _nume)
        {
            ID_Gen = _idGen;
            Nume = _nume;
        }
        public int ID_Gen { get; set; }
        public string Nume { get; set; }
    }
}
