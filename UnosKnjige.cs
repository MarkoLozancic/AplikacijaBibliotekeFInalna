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
    public partial class UnosKnjige : Form
    {
        public UnosKnjige()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
          
            

           
           
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();     }

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
                List<Knjiga> Knjige = new List<Knjiga>();
                Knjiga book = new Knjiga(Convert.ToInt32(txtISBN.Text), txtAutor.Text, txtIzdavac.Text, txtNaslov.Text);


                Knjige.Add(book);
                var libero = XDocument.Load("Knjiga.xml");

                foreach (Knjiga k in Knjige)
                {
                    var knjiga = new XElement("Knjiga",
                         new XElement("ISBN", book.ISBN1),
                          new XElement("Autor", book.Autor),
                        new XElement("Izdavac", book.Izdavac),
                          new XElement("Naslov", book.Naslov));



                    libero.Element("knjige").Add(knjiga);


                }
                libero.Save("Knjiga.xml");
                Knjige.Clear();
                txtAutor.Clear();
                txtIzdavac.Clear();
                txtISBN.Clear();
                txtNaslov.Clear();

                MessageBox.Show("Uspješno izvršen unos knjige", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Greška u unosu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
