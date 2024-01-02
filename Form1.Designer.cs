
namespace knjizaraprojekat
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
            this.lbKnjige = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbZanrovi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKolicina = new System.Windows.Forms.TextBox();
            this.lbRacun = new System.Windows.Forms.ListBox();
            this.lblRacuni = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.tbNazivKnjige = new System.Windows.Forms.TextBox();
            this.tbCenaKnjige = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnDodajNaRacun = new System.Windows.Forms.Button();
            this.dtpPocetni = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpKrajnji = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpIzdavanje = new System.Windows.Forms.DateTimePicker();
            this.btnIzlistajRacune = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbPopust = new System.Windows.Forms.TextBox();
            this.tbBrojStrana = new System.Windows.Forms.TextBox();
            this.btnUkloniSaRacuna = new System.Windows.Forms.Button();
            this.btnSnimiRacun = new System.Windows.Forms.Button();
            this.pbAnimacija = new System.Windows.Forms.PictureBox();
            this.lblNajprodavanijaJedan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimacija)).BeginInit();
            this.SuspendLayout();
            // 
            // lbKnjige
            // 
            this.lbKnjige.FormattingEnabled = true;
            this.lbKnjige.ItemHeight = 16;
            this.lbKnjige.Location = new System.Drawing.Point(19, 97);
            this.lbKnjige.Margin = new System.Windows.Forms.Padding(4);
            this.lbKnjige.Name = "lbKnjige";
            this.lbKnjige.Size = new System.Drawing.Size(448, 388);
            this.lbKnjige.TabIndex = 0;
            this.lbKnjige.SelectedIndexChanged += new System.EventHandler(this.lbKnjige_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(515, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Žanr";
            // 
            // cbZanrovi
            // 
            this.cbZanrovi.FormattingEnabled = true;
            this.cbZanrovi.Location = new System.Drawing.Point(651, 96);
            this.cbZanrovi.Margin = new System.Windows.Forms.Padding(4);
            this.cbZanrovi.Name = "cbZanrovi";
            this.cbZanrovi.Size = new System.Drawing.Size(215, 24);
            this.cbZanrovi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(515, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naziv knjige";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(520, 347);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Količina";
            // 
            // tbKolicina
            // 
            this.tbKolicina.Location = new System.Drawing.Point(656, 347);
            this.tbKolicina.Margin = new System.Windows.Forms.Padding(4);
            this.tbKolicina.Name = "tbKolicina";
            this.tbKolicina.Size = new System.Drawing.Size(215, 22);
            this.tbKolicina.TabIndex = 6;
            // 
            // lbRacun
            // 
            this.lbRacun.FormattingEnabled = true;
            this.lbRacun.ItemHeight = 16;
            this.lbRacun.Location = new System.Drawing.Point(956, 94);
            this.lbRacun.Margin = new System.Windows.Forms.Padding(4);
            this.lbRacun.Name = "lbRacun";
            this.lbRacun.Size = new System.Drawing.Size(417, 388);
            this.lbRacun.TabIndex = 7;
            // 
            // lblRacuni
            // 
            this.lblRacuni.AutoSize = true;
            this.lblRacuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRacuni.Location = new System.Drawing.Point(1125, 65);
            this.lblRacuni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRacuni.Name = "lblRacuni";
            this.lblRacuni.Size = new System.Drawing.Size(105, 25);
            this.lblRacuni.TabIndex = 8;
            this.lblRacuni.Text = "Novi racun";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(514, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cena po komadu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1020, 496);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ukupna cena na računu";
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupno.Location = new System.Drawing.Point(1272, 496);
            this.lblUkupno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(32, 25);
            this.lblUkupno.TabIndex = 14;
            this.lblUkupno.Text = "....";
            // 
            // tbNazivKnjige
            // 
            this.tbNazivKnjige.Location = new System.Drawing.Point(651, 138);
            this.tbNazivKnjige.Margin = new System.Windows.Forms.Padding(4);
            this.tbNazivKnjige.Name = "tbNazivKnjige";
            this.tbNazivKnjige.Size = new System.Drawing.Size(215, 22);
            this.tbNazivKnjige.TabIndex = 15;
            // 
            // tbCenaKnjige
            // 
            this.tbCenaKnjige.Location = new System.Drawing.Point(695, 218);
            this.tbCenaKnjige.Margin = new System.Windows.Forms.Padding(4);
            this.tbCenaKnjige.Name = "tbCenaKnjige";
            this.tbCenaKnjige.Size = new System.Drawing.Size(169, 22);
            this.tbCenaKnjige.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(229, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Knjige";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(481, 533);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(151, 59);
            this.btnDodaj.TabIndex = 18;
            this.btnDodaj.Text = "Dodaj knjigu u bazu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnDodajNaRacun
            // 
            this.btnDodajNaRacun.Location = new System.Drawing.Point(640, 533);
            this.btnDodajNaRacun.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajNaRacun.Name = "btnDodajNaRacun";
            this.btnDodajNaRacun.Size = new System.Drawing.Size(151, 59);
            this.btnDodajNaRacun.TabIndex = 19;
            this.btnDodajNaRacun.Text = "Dodaj knjigu na račun";
            this.btnDodajNaRacun.UseVisualStyleBackColor = true;
            this.btnDodajNaRacun.Click += new System.EventHandler(this.btnDodajNaRacun_Click);
            // 
            // dtpPocetni
            // 
            this.dtpPocetni.Location = new System.Drawing.Point(610, 439);
            this.dtpPocetni.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPocetni.Name = "dtpPocetni";
            this.dtpPocetni.Size = new System.Drawing.Size(267, 22);
            this.dtpPocetni.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(519, 439);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Početni";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(520, 489);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Krajnji";
            // 
            // dtpKrajnji
            // 
            this.dtpKrajnji.Location = new System.Drawing.Point(610, 489);
            this.dtpKrajnji.Margin = new System.Windows.Forms.Padding(4);
            this.dtpKrajnji.Name = "dtpKrajnji";
            this.dtpKrajnji.Size = new System.Drawing.Size(267, 22);
            this.dtpKrajnji.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(519, 390);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 25);
            this.label12.TabIndex = 25;
            this.label12.Text = "Datum izdavanja";
            // 
            // dtpIzdavanje
            // 
            this.dtpIzdavanje.Location = new System.Drawing.Point(684, 392);
            this.dtpIzdavanje.Margin = new System.Windows.Forms.Padding(4);
            this.dtpIzdavanje.Name = "dtpIzdavanje";
            this.dtpIzdavanje.Size = new System.Drawing.Size(267, 22);
            this.dtpIzdavanje.TabIndex = 26;
            // 
            // btnIzlistajRacune
            // 
            this.btnIzlistajRacune.Location = new System.Drawing.Point(481, 600);
            this.btnIzlistajRacune.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzlistajRacune.Name = "btnIzlistajRacune";
            this.btnIzlistajRacune.Size = new System.Drawing.Size(151, 59);
            this.btnIzlistajRacune.TabIndex = 27;
            this.btnIzlistajRacune.Text = "Pogledaj racune";
            this.btnIzlistajRacune.UseVisualStyleBackColor = true;
            this.btnIzlistajRacune.Click += new System.EventHandler(this.btnIzlistajRacune_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(514, 175);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 25);
            this.label13.TabIndex = 28;
            this.label13.Text = "Autor";
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(649, 179);
            this.tbAutor.Margin = new System.Windows.Forms.Padding(4);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(215, 22);
            this.tbAutor.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(515, 253);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Popust";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(514, 296);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 25);
            this.label14.TabIndex = 31;
            this.label14.Text = "Broj strana";
            // 
            // tbPopust
            // 
            this.tbPopust.Location = new System.Drawing.Point(644, 257);
            this.tbPopust.Margin = new System.Windows.Forms.Padding(4);
            this.tbPopust.Name = "tbPopust";
            this.tbPopust.Size = new System.Drawing.Size(221, 22);
            this.tbPopust.TabIndex = 32;
            // 
            // tbBrojStrana
            // 
            this.tbBrojStrana.Location = new System.Drawing.Point(644, 300);
            this.tbBrojStrana.Margin = new System.Windows.Forms.Padding(4);
            this.tbBrojStrana.Name = "tbBrojStrana";
            this.tbBrojStrana.Size = new System.Drawing.Size(221, 22);
            this.tbBrojStrana.TabIndex = 33;
            // 
            // btnUkloniSaRacuna
            // 
            this.btnUkloniSaRacuna.Location = new System.Drawing.Point(640, 600);
            this.btnUkloniSaRacuna.Margin = new System.Windows.Forms.Padding(4);
            this.btnUkloniSaRacuna.Name = "btnUkloniSaRacuna";
            this.btnUkloniSaRacuna.Size = new System.Drawing.Size(151, 59);
            this.btnUkloniSaRacuna.TabIndex = 34;
            this.btnUkloniSaRacuna.Text = "Ukloni sa racuna";
            this.btnUkloniSaRacuna.UseVisualStyleBackColor = true;
            this.btnUkloniSaRacuna.Click += new System.EventHandler(this.btnUkloniSaRacuna_Click);
            // 
            // btnSnimiRacun
            // 
            this.btnSnimiRacun.Location = new System.Drawing.Point(796, 533);
            this.btnSnimiRacun.Margin = new System.Windows.Forms.Padding(4);
            this.btnSnimiRacun.Name = "btnSnimiRacun";
            this.btnSnimiRacun.Size = new System.Drawing.Size(151, 59);
            this.btnSnimiRacun.TabIndex = 35;
            this.btnSnimiRacun.Text = "Snimi racun";
            this.btnSnimiRacun.UseVisualStyleBackColor = true;
            this.btnSnimiRacun.Click += new System.EventHandler(this.btnSnimiRacun_Click);
            // 
            // pbAnimacija
            // 
            this.pbAnimacija.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pbAnimacija.Location = new System.Drawing.Point(-7, -2);
            this.pbAnimacija.Name = "pbAnimacija";
            this.pbAnimacija.Size = new System.Drawing.Size(1402, 50);
            this.pbAnimacija.TabIndex = 36;
            this.pbAnimacija.TabStop = false;
            // 
            // lblNajprodavanijaJedan
            // 
            this.lblNajprodavanijaJedan.AutoSize = true;
            this.lblNajprodavanijaJedan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNajprodavanijaJedan.ForeColor = System.Drawing.Color.Red;
            this.lblNajprodavanijaJedan.Location = new System.Drawing.Point(246, 533);
            this.lblNajprodavanijaJedan.Name = "lblNajprodavanijaJedan";
            this.lblNajprodavanijaJedan.Size = new System.Drawing.Size(128, 24);
            this.lblNajprodavanijaJedan.TabIndex = 37;
            this.lblNajprodavanijaJedan.Text = "Ana Karenjina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(246, 570);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "Cekajuci Godoa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(246, 606);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 24);
            this.label9.TabIndex = 39;
            this.label9.Text = "C# Programiranje";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 677);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNajprodavanijaJedan);
            this.Controls.Add(this.pbAnimacija);
            this.Controls.Add(this.btnSnimiRacun);
            this.Controls.Add(this.btnUkloniSaRacuna);
            this.Controls.Add(this.tbBrojStrana);
            this.Controls.Add(this.tbPopust);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnIzlistajRacune);
            this.Controls.Add(this.dtpIzdavanje);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpKrajnji);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpPocetni);
            this.Controls.Add(this.btnDodajNaRacun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCenaKnjige);
            this.Controls.Add(this.tbNazivKnjige);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRacuni);
            this.Controls.Add(this.lbRacun);
            this.Controls.Add(this.tbKolicina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbZanrovi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbKnjige);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimacija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbKnjige;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbZanrovi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKolicina;
        private System.Windows.Forms.ListBox lbRacun;
        private System.Windows.Forms.Label lblRacuni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.TextBox tbNazivKnjige;
        private System.Windows.Forms.TextBox tbCenaKnjige;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnDodajNaRacun;
        private System.Windows.Forms.DateTimePicker dtpPocetni;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpKrajnji;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpIzdavanje;
        private System.Windows.Forms.Button btnIzlistajRacune;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbPopust;
        private System.Windows.Forms.TextBox tbBrojStrana;
        private System.Windows.Forms.Button btnUkloniSaRacuna;
        private System.Windows.Forms.Button btnSnimiRacun;
        private System.Windows.Forms.PictureBox pbAnimacija;
        private System.Windows.Forms.Label lblNajprodavanijaJedan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
    }
}

