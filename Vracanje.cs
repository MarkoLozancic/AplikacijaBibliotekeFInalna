using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LinqXMLDokumenti
{
    public partial class Vracanje : Form
    {
        public Vracanje()
        {
            InitializeComponent();
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

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnpretragaK_Click(object sender, EventArgs e)
        {
            var users = XDocument.Load("Korisnik.xml");


            if (txtImeK.Text != "")
            {
                var query =
                                from Korisnik in
                                    users.Descendants("Korisnik")
                                where Korisnik.Element("Ime").Value == txtImeK.Text

                                select 
                               Korisnik.Element("Ime").Value+"\t"+Korisnik.Element("Prezime").Value +"\t"+ 
                    Korisnik.Element("Email").Value
                                ;
                
                foreach (string Korisnik in query)
                {
                    listbKorisnici.Items.Add(Convert.ToString(Korisnik));
                }

                
            }
        }

        private void btnPosudi_Click(object sender, EventArgs e)
        {
            try
            {

                var users = XDocument.Load("Korisnik.xml");
                var query2 =
                                    from Korisnik in
                                        users.Descendants("Korisnik")
                                    where Korisnik.Element("Ime").Value + "\t" + Korisnik.Element("Prezime").Value + "\t" +
                        Korisnik.Element("Email").Value == listbKorisnici.SelectedItem.ToString()

                                    select Korisnik.Element("Korisnik_ID").Value;




                var evidency = XDocument.Load("Evidencija.xml");

                var query3 =
                 from Evidencija in
                                         evidency.Descendants("Evidencija")
                 where Evidencija.Element("ISBN").Value + Evidencija.Element("Korisnik_ID").Value == txtISBN.Text + query2.SingleOrDefault()


                 select Evidencija;

                try
                {
                    if (Convert.ToDateTime(query3.Last().Element("Datum").Value).AddDays(14) < DateTime.Now)
                        MessageBox.Show("Osoba je zakasnila s vraćanjem knjige!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Došlo je do pogreške", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                query3.SingleOrDefault().Element("Stanje").Value=Convert.ToString(false)  ;
               
              

                    evidency.Save("Evidencija.xml");

                
                
                txtImeK.Clear();
                listbKorisnici.Items.Clear();
                txtISBN.Clear();

                MessageBox.Show("Uspješno obavljeno vraćanje,", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Došlo je do pogreške", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
