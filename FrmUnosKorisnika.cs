using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LinqXMLDokumenti
{
    public partial class FrmUnosKorisnika : Form
    {
        //  List<Osoba> osobe = new List<Osoba>();
        int id = 0;
        public FrmUnosKorisnika()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {


        } 

                
                    
                
                
               
               
              
                 
            
          
        

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizirajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maksimizirajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {

            try
            {
                id++;
                List<Korisnik> Korisnici = new List<Korisnik>();
                Korisnik os = new Korisnik(id, txtEmail.Text, txtIme.Text, txtPrezime.Text, txtAdresa.Text, Convert.ToInt32(txtBrojTelf.Text));


                Korisnici.Add(os);

                var users = XDocument.Load("Korisnik.xml");

                foreach (Korisnik korisnik in Korisnici)
                {
                    var Osoba = new XElement("Korisnik",
                         new XElement("Korisnik_ID", os.Korisnik_id),
                          new XElement("Email", os.Email),
                        new XElement("Ime", os.Ime),
                          new XElement("Prezime", os.Prezime),
                           new XElement("Adresa", os.Adresa),
                            new XElement("Broj_Telefona", os.BrojTelefona));

                    users.Element("korisnici").Add(Osoba);
                    users.Save("Korisnik.xml");

                }
                Korisnici.Clear();

                txtAdresa.Clear();
                txtIme.Clear();
                txtPrezime.Clear();
                txtBrojTelf.Clear();
                txtEmail.Clear();
                MessageBox.Show("Uspješno izvršen unos korisnika", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Greška u unosu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

