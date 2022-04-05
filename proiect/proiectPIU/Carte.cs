using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPIU
{
    public class Carte
    {
        private const int ID = 0;
        private const int TITLU = 1;
        private const int AUTOR = 2;
        private const int EXEMPLARE = 3;
        private const int DISPONIBILE = 4;
        private const int DATA = 5;

        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        Autor autor;
        string titlu;
        int index, exemplare, disponibile;
        string rezumat;
        string imagine;
        DateTime dataActualizare;
        //New Update
        int ID_TaraOrigine;
        int ID_Editura;
        int ID_Gen;
        //End New Update

        static int ultimulIndex = 0;


        public Carte()
        {
            index = ultimulIndex; ultimulIndex++;
            titlu = string.Empty;
            autor = new Autor(string.Empty, string.Empty);
            exemplare = 0;
            disponibile = 0;
            rezumat = string.Empty;
            imagine = "Resurse/NotFound.PNG";
            dataActualizare = DateTime.Now;
        }
        //Constructori
        public Carte(string _titlu, string _numeAutor, string _prenumeAutor)
        {
            index = ultimulIndex; ultimulIndex++;
            titlu = _titlu;
            autor = new Autor(_numeAutor, _prenumeAutor);
            exemplare = 1;
            disponibile = 1;
            rezumat = "";
            imagine = "Resurse/NotFound.PNG";
            dataActualizare = DateTime.Now;
        }
        public Carte(string _titlu, Autor _autor)
        {
            index = ultimulIndex; ultimulIndex++;
            titlu = _titlu;
            autor = _autor;
            exemplare = 1;
            disponibile = 1;
            rezumat = "";
            imagine = "Resurse/NotFound.PNG";
            dataActualizare = DateTime.Now;
        }
        public Carte(string _titlu, Autor _autor, int _exemplare, int _disponibile)
        {
            index = ultimulIndex; ultimulIndex++;
            titlu = _titlu;
            autor = _autor;
            exemplare = _exemplare;
            disponibile = _disponibile;
            rezumat = "";
            imagine = "Resurse/NotFound.PNG";
            dataActualizare = DateTime.Now;
        }
        public Carte(string _titlu, int _exemplare, int _disponibile)
        {
            index = ultimulIndex; ultimulIndex++;
            titlu = _titlu;
            autor = null;
            exemplare = _exemplare;
            disponibile = _disponibile;
            rezumat = "";
            imagine = "Resurse/NotFound.PNG";
            dataActualizare = DateTime.Now;
        }

        public Carte(int _idCarte, int _idAutor, int _idTaraOrigine, int _idEditura, int _idGen, string _titlu, string _imagine, string _descriere, int _exemplare, int _disponibilitate, DateTime _dataActualizare)
        {
            /*int id_carte = Convert.ToInt32(reader.GetString(0));
            int id_autor = Convert.ToInt32(reader.GetString(1));
            int id_taraOrigine = Convert.ToInt32(reader.GetString(2));
            int id_editura = Convert.ToInt32(reader.GetString(3));
            int id_get = Convert.ToInt32(reader.GetString(4));
            string titlu = reader.GetString(5);
            string imagine = reader.GetString(6);
            string descriere = reader.GetString(7);
            string exemplare = reader.GetString(8);
            string disponibilitate = reader.GetString(9);
            string dataActualizare = reader.GetString(10);*/
            index = _idCarte;
            //IdAutor = _idAutor;
            /* IdAutorBun = _idAutor;
             IdTaraOrigine = _idTaraOrigine;
             IdEditura = _idEditura;
             IdGen = _idGen*/
            ;
            titlu = _titlu;
            imagine = _imagine;
            rezumat = _descriere;
            exemplare = _exemplare;
            disponibile = _disponibilitate;
            dataActualizare = _dataActualizare;

        }
        //constructor cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public Carte(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            index = Convert.ToInt32(dateFisier[ID]);
            titlu = dateFisier[TITLU];
            string[] numeAutorComplet = dateFisier[AUTOR].ToString().Split();
            autor.Nume = numeAutorComplet[0];
            autor.Prenume = numeAutorComplet[1];
            exemplare = Convert.ToInt32(dateFisier[EXEMPLARE]);
            disponibile = Convert.ToInt32(dateFisier[DISPONIBILE]);

        }
        public string ConversieFisier()
        {
            return string.Format("{0},{1},{0},{2},{0},{3},{0},{4},{0},{5},{0},{6}", SEPARATOR_PRINCIPAL_FISIER, index.ToString(), (titlu ?? "NECUNOSCUT "), autor.ConversieFisier() , exemplare.ToString(), disponibile.ToString(), ( rezumat ?? "NECUNOSCUT "), dataActualizare.ToString());
        }
    }
}
