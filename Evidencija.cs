using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqXMLDokumenti
{
    class Evidencija
    {
       int Korisnik_ID;
        int ISBN;
        DateTime posudba = new DateTime();
        bool posudena;

       

        public Evidencija(int korisnik_ID, int iSBN, DateTime posudba, bool posudena)
        {
            Korisnik_ID = korisnik_ID;
            ISBN = iSBN;
            this.posudba = posudba;
            this.Posudena = posudena;
        }

        public int Korisnik_ID1 { get => Korisnik_ID; set => Korisnik_ID = value; }
        public int ISBN1 { get => ISBN; set => ISBN = value; }
        public DateTime Posudba { get => posudba; set => posudba = value; }
        public bool Posudena { get => posudena; set => posudena = value; }
    }
}
