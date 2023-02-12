using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqXMLDokumenti
{
    internal class Knjiga
    {
        int ISBN;
        string autor, izdavac, naslov;

        public Knjiga(int knjiga_id, string autor, string izdavac, string naslov)
        {
            this.ISBN1 = knjiga_id;
            this.autor = autor;
            this.izdavac = izdavac;
            this.naslov = naslov;
        }

        
        public string Autor { get => autor; set => autor = value; }
        public string Izdavac { get => izdavac; set => izdavac = value; }
        public string Naslov { get => naslov; set => naslov = value; }
        public int ISBN1 { get => ISBN; set => ISBN = value; }

        public override string ToString()
        {
            return "Knjiga ID: " + ISBN + " Autor: " + Autor + ", Izdavac" + Izdavac + ",  Naslov: " + Naslov;
        }

      
    }
}
