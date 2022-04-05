using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPIU.Clase { 
     class Editura
    {

        public Editura(int _idEditura, string _nume)
        {
            ID_Editura = _idEditura;
            Nume = _nume;
        }
        public int ID_Editura { get; set; }
        public string Nume { get; set; }
    }
}
