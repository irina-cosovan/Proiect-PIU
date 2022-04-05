using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proiectPIU;

namespace nivel
{
    class AdministrareBiblioteca_FisierText
    {
        private const int NR_MAX_CARTI = 100;
        private string numeFisier;
        
        public AdministrareBiblioteca_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddCarte(Carte carte)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(carte.ConversieFisier());
            }
        }

        public Carte[] GetCarti(out int nrCarti)
        { 
        Carte[] carti = new Carte[NR_MAX_CARTI];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrCarti = 0;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    carti[nrCarti++] = new Carte(linieFisier);
                }
            }
            return carti;
        }
    }
}
