using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace LinqXMLDokumenti
{
    public partial class Posudivanje : Form
    {
        public Posudivanje()
        {
            InitializeComponent();
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

                                    select Korisnik.Element("Korisnik_ID").Value

                                    ;

                Evidencija a = new Evidencija(Convert.ToInt32(query2.SingleOrDefault()), Convert.ToInt32(txtISBN.Text), DateTime.Now,true);

                List<Evidencija> evidencije = new List<Evidencija>();


                evidencije.Add(a);

                var evidency = XDocument.Load("Evidencija.xml");

                foreach (Evidencija evi in evidencije)
                {
                    var Evidentare = new XElement("Evidencija",
                        new XElement("ISBN", a.ISBN1),
                        new XElement("Korisnik_ID", a.Korisnik_ID1),
                         new XElement("Stanje", a.Posudena),
                          new XElement("Datum", a.Posudba));



                    evidency.Element("evidencije").Add(Evidentare);
                    evidency.Save("Evidencija.xml");

                }
                evidencije.Clear();
                txtImeK.Clear();
                listbKorisnici.Items.Clear();
                txtISBN.Clear();

                MessageBox.Show("Uspješno obavljena posudba, rok za vraćanje je 14 dana!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Došlo je do pogreške, pokušajte ponovno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}
