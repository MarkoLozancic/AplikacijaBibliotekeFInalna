namespace LinqXMLDokumenti
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detaljanPregledKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNoveKnjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detaljanPregledKnjigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posudbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vraćanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maksimizirajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizirajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSize = true;
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.menuStrip1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1450, 56);
            this.panelMenu.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.knjigeToolStripMenuItem,
            this.posudbeToolStripMenuItem,
            this.vraćanjaToolStripMenuItem,
            this.izlazToolStripMenuItem,
            this.maksimizirajToolStripMenuItem,
            this.minimizirajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1450, 56);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovogKorisnikaToolStripMenuItem,
            this.detaljanPregledKorisnikaToolStripMenuItem});
            this.korisniciToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("korisniciToolStripMenuItem.Image")));
            this.korisniciToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(170, 52);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // unosNovogKorisnikaToolStripMenuItem
            // 
            this.unosNovogKorisnikaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("unosNovogKorisnikaToolStripMenuItem.Image")));
            this.unosNovogKorisnikaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.unosNovogKorisnikaToolStripMenuItem.Name = "unosNovogKorisnikaToolStripMenuItem";
            this.unosNovogKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(430, 58);
            this.unosNovogKorisnikaToolStripMenuItem.Text = "Unos novog korisnika";
            this.unosNovogKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.unosNovogKorisnikaToolStripMenuItem_Click);
            // 
            // detaljanPregledKorisnikaToolStripMenuItem
            // 
            this.detaljanPregledKorisnikaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detaljanPregledKorisnikaToolStripMenuItem.Image")));
            this.detaljanPregledKorisnikaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detaljanPregledKorisnikaToolStripMenuItem.Name = "detaljanPregledKorisnikaToolStripMenuItem";
            this.detaljanPregledKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(430, 58);
            this.detaljanPregledKorisnikaToolStripMenuItem.Text = "Detaljan pregled korisnika";
            // 
            // knjigeToolStripMenuItem
            // 
            this.knjigeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNoveKnjigeToolStripMenuItem,
            this.detaljanPregledKnjigaToolStripMenuItem});
            this.knjigeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("knjigeToolStripMenuItem.Image")));
            this.knjigeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.knjigeToolStripMenuItem.Name = "knjigeToolStripMenuItem";
            this.knjigeToolStripMenuItem.Size = new System.Drawing.Size(143, 52);
            this.knjigeToolStripMenuItem.Text = "Knjige";
            // 
            // unosNoveKnjigeToolStripMenuItem
            // 
            this.unosNoveKnjigeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("unosNoveKnjigeToolStripMenuItem.Image")));
            this.unosNoveKnjigeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.unosNoveKnjigeToolStripMenuItem.Name = "unosNoveKnjigeToolStripMenuItem";
            this.unosNoveKnjigeToolStripMenuItem.Size = new System.Drawing.Size(396, 58);
            this.unosNoveKnjigeToolStripMenuItem.Text = "Unos nove knjige";
            this.unosNoveKnjigeToolStripMenuItem.Click += new System.EventHandler(this.unosNoveKnjigeToolStripMenuItem_Click_1);
            // 
            // detaljanPregledKnjigaToolStripMenuItem
            // 
            this.detaljanPregledKnjigaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detaljanPregledKnjigaToolStripMenuItem.Image")));
            this.detaljanPregledKnjigaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detaljanPregledKnjigaToolStripMenuItem.Name = "detaljanPregledKnjigaToolStripMenuItem";
            this.detaljanPregledKnjigaToolStripMenuItem.Size = new System.Drawing.Size(396, 58);
            this.detaljanPregledKnjigaToolStripMenuItem.Text = "Detaljan pregled knjiga";
            // 
            // posudbeToolStripMenuItem
            // 
            this.posudbeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("posudbeToolStripMenuItem.Image")));
            this.posudbeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.posudbeToolStripMenuItem.Name = "posudbeToolStripMenuItem";
            this.posudbeToolStripMenuItem.Size = new System.Drawing.Size(166, 52);
            this.posudbeToolStripMenuItem.Text = "Posudbe";
            this.posudbeToolStripMenuItem.Click += new System.EventHandler(this.posudbeToolStripMenuItem_Click);
            // 
            // vraćanjaToolStripMenuItem
            // 
            this.vraćanjaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vraćanjaToolStripMenuItem.Image")));
            this.vraćanjaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vraćanjaToolStripMenuItem.Name = "vraćanjaToolStripMenuItem";
            this.vraćanjaToolStripMenuItem.Size = new System.Drawing.Size(170, 52);
            this.vraćanjaToolStripMenuItem.Text = "Vraćanja";
            this.vraćanjaToolStripMenuItem.Click += new System.EventHandler(this.vraćanjaToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.izlazToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("izlazToolStripMenuItem.Image")));
            this.izlazToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(64, 52);
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // maksimizirajToolStripMenuItem
            // 
            this.maksimizirajToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.maksimizirajToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("maksimizirajToolStripMenuItem.Image")));
            this.maksimizirajToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.maksimizirajToolStripMenuItem.Name = "maksimizirajToolStripMenuItem";
            this.maksimizirajToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.maksimizirajToolStripMenuItem.Size = new System.Drawing.Size(64, 52);
            this.maksimizirajToolStripMenuItem.Click += new System.EventHandler(this.maksimizirajToolStripMenuItem_Click);
            // 
            // minimizirajToolStripMenuItem
            // 
            this.minimizirajToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minimizirajToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("minimizirajToolStripMenuItem.Image")));
            this.minimizirajToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.minimizirajToolStripMenuItem.Name = "minimizirajToolStripMenuItem";
            this.minimizirajToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.minimizirajToolStripMenuItem.Size = new System.Drawing.Size(64, 52);
            this.minimizirajToolStripMenuItem.Click += new System.EventHandler(this.minimizirajToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 640);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 95);
            this.label1.TabIndex = 1;
            this.label1.Text = "Upravitelj knjižnice";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::LinqXMLDokumenti.Properties.Resources.Salle_de_lecture_Bibliothèque_Mazarine_depuis_gallerie;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1450, 735);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1450, 200);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Knjižnica";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posudbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vraćanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizirajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maksimizirajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovogKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detaljanPregledKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNoveKnjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detaljanPregledKnjigaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

