using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPIU
{
    public  class Persoana
    {

        string nume, prenume;

        //Constructori.
        public Persoana()
        {
            nume = null;
            prenume = null;
        }
        public Persoana(string _nume, string _prenume)
        {
            nume = _nume;
            prenume = _prenume;
        }
        public Persoana(string _numeComplet)
        {
            nume = _numeComplet.Split(' ')[0];
            prenume = _numeComplet.Split(' ')[1];
        }
        public Persoana(Persoana _persoana)
        {
            nume = _persoana.nume;
            prenume = _persoana.prenume;
        }
        //Metode
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public string Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }
        public void afisare()
        {
            Console.WriteLine("Nume: {0}, Prenume: {1}", arg0: nume, arg1: prenume);
        }
        public string getNumeComplet()
        {
            return string.Format(nume + " " + prenume);
        }

        
    }
}

