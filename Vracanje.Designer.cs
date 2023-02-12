namespace LinqXMLDokumenti
{
    partial class Vracanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vracanje));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maksimizirajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizirajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listbKorisnici = new System.Windows.Forms.ListBox();
            this.txtImeK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnpretragaK = new LinqXMLDokumenti.CircularButton();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVrati = new LinqXMLDokumenti.CircularButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 56);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem,
            this.maksimizirajToolStripMenuItem,
            this.minimizirajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 56);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
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
            // listbKorisnici
            // 
            this.listbKorisnici.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbKorisnici.FormattingEnabled = true;
            this.listbKorisnici.ItemHeight = 25;
            this.listbKorisnici.Location = new System.Drawing.Point(12, 223);
            this.listbKorisnici.Name = "listbKorisnici";
            this.listbKorisnici.Size = new System.Drawing.Size(470, 204);
            this.listbKorisnici.TabIndex = 5;
            // 
            // txtImeK
            // 
            this.txtImeK.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImeK.Location = new System.Drawing.Point(57, 98);
            this.txtImeK.Name = "txtImeK";
            this.txtImeK.Size = new System.Drawing.Size(229, 33);
            this.txtImeK.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(95, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime korisnika";
            // 
            // btnpretragaK
            // 
            this.btnpretragaK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnpretragaK.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpretragaK.Location = new System.Drawing.Point(348, 82);
            this.btnpretragaK.Name = "btnpretragaK";
            this.btnpretragaK.Size = new System.Drawing.Size(134, 61);
            this.btnpretragaK.TabIndex = 8;
            this.btnpretragaK.Text = "Pretraži";
            this.btnpretragaK.UseVisualStyleBackColor = false;
            this.btnpretragaK.Click += new System.EventHandler(this.btnpretragaK_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(568, 254);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(225, 33);
            this.txtISBN.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(641, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "ISBN:";
            // 
            // btnVrati
            // 
            this.btnVrati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVrati.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVrati.Location = new System.Drawing.Point(611, 293);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(134, 61);
            this.btnVrati.TabIndex = 14;
            this.btnVrati.Text = "Vrati";
            this.btnVrati.UseVisualStyleBackColor = false;
            this.btnVrati.Click += new System.EventHandler(this.btnPosudi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Prezime:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(303, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Email:";
            // 
            // Vracanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVrati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.btnpretragaK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImeK);
            this.Controls.Add(this.listbKorisnici);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vracanje";
            this.Text = "Vracanje";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maksimizirajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizirajToolStripMenuItem;
        private System.Windows.Forms.ListBox listbKorisnici;
        private System.Windows.Forms.TextBox txtImeK;
        private System.Windows.Forms.Label label1;
        private CircularButton btnpretragaK;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label3;
        private CircularButton btnVrati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}