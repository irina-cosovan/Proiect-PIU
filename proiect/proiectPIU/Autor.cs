using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPIU
{
    public class Autor : Persoana
    {
        static int ultimulId = 0;
        int id;
        private void Builder()
        {
            id = ultimulId;
            ultimulId++;
        }
        public Autor(int _id, string _nume, string _prenume) : base(_nume, _prenume)
        {
            Id = _id;
        }
        public Autor(Persoana _persoana) : base(_persoana)
        {
            Builder();
        }
        public Autor(string _nume, string _prenume) : base(_nume, _prenume)
        {
            Builder();
        }
        public Autor(string _numeComplet) : base(_numeComplet)
        {
            Builder();
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public static int UltimulId
        {
            get { return ultimulId; }
            set { ultimulId = value; }
        }
        public string ConversieFisier()
        {
            return string.Format("{0},{1},{2}", id, Nume, Prenume);
        }
    }
}
