using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knjizaraprojekat
{
    public partial class Form1 : Form
    {
        Baza baza;
        List<Knjiga> knjige;
        List<Zanr> zanrovi;
        List<Pripadnost> pripadnosti;
        List<StavkaRacuna> stavke;
        List<Knjiga> sortiraneKnjige;
        List<Zanr> sortiraniZanrovi;
        List<Racun> racuni;
        Label najprodavanija;
        PictureBox pb;
        Point pocetna;
        int idr;
        Thread t;

        public Form1()
        {
            InitializeComponent();
            baza = new Baza(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\38164\Downloads\Knjizara.mdb");
            knjige = new List<Knjiga>();
            zanrovi = new List<Zanr>();
            sortiraneKnjige = new List<Knjiga>();
            sortiraniZanrovi = new List<Zanr>();
            pripadnosti = new List<Pripadnost>();
            stavke = new List<StavkaRacuna>();
            racuni = new List<Racun>();
            pocetna = new Point(ClientSize.Width-200, 10);
            najprodavanija = new Label();
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbKolicina.Text = "";
            najprodavanija = new Label();
            pb = new PictureBox();
            pb.Width = ClientSize.Width;
            pb.Height = 25;
            pb.BackColor = Color.White;
            najprodavanija.Text = "Najprodavanije knjige danas: " + Najprodavanije();
            najprodavanija.Location = pocetna;
            najprodavanija.Width = 650;
            najprodavanija.Left = ClientSize.Width;
            najprodavanija.Font = new Font("Arial", 12);
            najprodavanija.ForeColor = Color.White;
            pbAnimacija.Controls.Add(najprodavanija);


            try
            {
                baza.otvoriKonekciju();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT * FROM KNJIGA";
                OleDbDataReader reader = cmd.ExecuteReader();

                knjige.Clear();
                while (reader.Read())
                {
                    Knjiga k = new Knjiga();
                    k.Id_knjiga = int.Parse(reader["id_knjiga"].ToString());
                    k.Autor = reader["autor"].ToString();
                    k.Naziv = reader["naziv"].ToString();
                    k.Cena = int.Parse(reader["cena"].ToString());
                    k.Popust = int.Parse(reader["popust"].ToString());
                    k.Broj_strana = int.Parse(reader["broj_strana"].ToString());

                    knjige.Add(k);
                }

                sortiraneKnjige = knjige.OrderBy(x => x.Naziv).ToList();
                lbKnjige.DataSource = sortiraneKnjige;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baza.zatvoriKonekciju();
            }

            try
            {
                baza.otvoriKonekciju();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT * FROM ZANR";
                OleDbDataReader reader = cmd.ExecuteReader();

                zanrovi.Clear();
                while (reader.Read())
                {
                    Zanr z = new Zanr();
                    z.Id_zanr = int.Parse(reader["id_zanr"].ToString());
                    z.Naziv = reader["naziv"].ToString();

                    zanrovi.Add(z);
                }

                sortiraniZanrovi = zanrovi.OrderBy(x => x.Naziv).ToList();
                cbZanrovi.DataSource = sortiraniZanrovi;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baza.zatvoriKonekciju();
            }

            try
            {
                baza.otvoriKonekciju();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT * FROM RACUN";
                OleDbDataReader reader = cmd.ExecuteReader();
                
                racuni.Clear();
                while (reader.Read())
                {
                    Racun r = new Racun();
                    r.Id_racun = int.Parse(reader["id_racun"].ToString());
                    r.Datum = DateTime.Parse(reader["datum"].ToString());
                    r.Ukupna_cena = double.Parse(reader["ukupna_cena"].ToString());

                    racuni.Add(r);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baza.zatvoriKonekciju();
            }
            t = new Thread(Animacija);
            t.IsBackground = true;
            t.Start();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (cbZanrovi.SelectedItem != null)
            {
                Knjiga k = lbKnjige.SelectedItem as Knjiga;
                int idk = k.Id_knjiga;
                Zanr z = cbZanrovi.SelectedItem as Zanr;
                int idz = z.Id_zanr;
                int rez = 0;
                try
                {
                    baza.otvoriKonekciju();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = baza.Conn;
                    cmd.CommandText = "INSERT INTO KNJIGA(id_knjiga,autor,naziv,cena,popust,broj_strana)" +
                        "VALUES (@id_knjiga,@autor,@naziv,@cena,@popust,@broj_strana)";

                    cmd.Parameters.AddWithValue("id_knjiga", knjige[knjige.Count - 1].Id_knjiga + 1);
                    cmd.Parameters.AddWithValue("autor", tbAutor.Text);
                    cmd.Parameters.AddWithValue("naziv", tbNazivKnjige.Text);
                    cmd.Parameters.AddWithValue("cena", double.Parse(tbCenaKnjige.Text));
                    cmd.Parameters.AddWithValue("popust", double.Parse(tbPopust.Text));
                    cmd.Parameters.AddWithValue("broj_strana", int.Parse(tbBrojStrana.Text));

                    rez = cmd.ExecuteNonQuery();
                    MessageBox.Show(knjige.Count.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    baza.zatvoriKonekciju();
                }
                if (rez != 0)
                {
                    MessageBox.Show("Uspesno ste dodali knjigu u bazu!");
                    Form1_Load(null, null);
                }
                try
                {
                    baza.otvoriKonekciju();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = baza.Conn;
                    cmd.CommandText = "INSERT INTO Pripadnost(id_knjiga,id_zanr)" +
                    "VALUES (@id_knjiga,@id_zanr)";

                    
                    cmd.Parameters.AddWithValue("id_knjiga", knjige[knjige.Count - 1].Id_knjiga);
                    cmd.Parameters.AddWithValue("iz_zanr", idz);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    baza.zatvoriKonekciju();
                }
            }
            else
            {
                MessageBox.Show("Niste izabrali zanr!");
            }
            
        }
        double ukupna_cena = 0;

        int ocisti = 0;

        private void btnDodajNaRacun_Click(object sender, EventArgs e)
        {
            if (ocisti != 0)
            {
                lbRacun.Items.Clear();
            }
            ocisti = 0;
            lblRacuni.Text = "Novi racun";
            Knjiga k = lbKnjige.SelectedItem as Knjiga;
            
            if (racuni.Count == 0)
            {
                idr = 1;
            }
            else
            {
                idr = racuni[racuni.Count - 1].Id_racun+1;

            }
            StavkaRacuna stavka = new StavkaRacuna();
            
            
            if(tbKolicina.Text == "") 
            {
                MessageBox.Show("Niste uneli kolicinu!");    
            }
            else
            {
                stavka.Id_knjiga = k.Id_knjiga;
                stavka.Id_racun = idr;
                stavka.Cena = k.Cena * int.Parse(tbKolicina.Text);
                stavka.Cena -= stavka.Cena * (int.Parse(tbPopust.Text) / 100);
                ukupna_cena += stavka.Cena;
                stavka.Popust = k.Popust;
                stavke.Add(stavka);
                lbRacun.Items.Add(stavka);
                lblUkupno.Text = ukupna_cena.ToString();
                MessageBox.Show("Uspesno ste dodali knjigu na racun!");
            }
        }

        private void lbKnjige_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                baza.otvoriKonekciju();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT * FROM PRIPADNOST";
                OleDbDataReader reader = cmd.ExecuteReader();

                pripadnosti.Clear();
                while (reader.Read())
                {
                    Pripadnost p = new Pripadnost();
                    p.Id_zanr = int.Parse(reader["id_knjiga"].ToString());
                    p.Id_zanr = int.Parse(reader["id_zanr"].ToString());

                    pripadnosti.Add(p);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baza.zatvoriKonekciju();
            }
            Knjiga k = lbKnjige.SelectedItem as Knjiga;
            for (int i = 0; i < pripadnosti.Count; i++)
            {
                if (k.Id_knjiga == pripadnosti[i].Id_knjiga)
                {
                    cbZanrovi.SelectedIndex = i;
                    break;
                }
            }
            tbNazivKnjige.Text = k.Naziv;
            tbAutor.Text = k.Autor;
            tbCenaKnjige.Text = k.Cena.ToString();
            tbPopust.Text = k.Popust.ToString();
            tbBrojStrana.Text = k.Broj_strana.ToString();
        }

        private void btnSnimiRacun_Click(object sender, EventArgs e)
        {
            if (stavke.Count > 0)
            {
                try
                {
                    baza.otvoriKonekciju();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = baza.Conn;
                    cmd.CommandText = "INSERT INTO RACUN(id_racun,datum,ukupna_cena)" +
                    "VALUES (@id_racun,@datum,@ukupna_cena)";


                    cmd.Parameters.AddWithValue("id_racun", idr);
                    cmd.Parameters.AddWithValue("datum", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("ukupna_cena", double.Parse(lblUkupno.Text));
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    baza.zatvoriKonekciju();
                }
                try
                {
                    baza.otvoriKonekciju();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = baza.Conn;
                    cmd.CommandText = "INSERT INTO STAVKA_RACUNA(id_racun,id_knjiga,cena,popust)" +
                    "VALUES (@id_racun,@id_knjiga,@cena,@popust)";

                    foreach(StavkaRacuna stavka in stavke)
                    {
                        cmd.Parameters.AddWithValue("id_racun", stavka.Id_racun);
                        cmd.Parameters.AddWithValue("id_knjiga", stavka.Id_knjiga);
                        cmd.Parameters.AddWithValue("cena", stavka.Cena);
                        cmd.Parameters.AddWithValue("popust", stavka.Popust);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    baza.zatvoriKonekciju();
                }
                MessageBox.Show("Uspesno ste snimili racun!");
                lbRacun.Items.Clear();
                stavke.Clear();
                lblUkupno.Text = "...";
                Form1_Load(null,null);
            }
        }

        private void btnIzlistajRacune_Click(object sender, EventArgs e)
        {
            ocisti = 1;
            lbRacun.Items.Clear();
            lblRacuni.Text = "Svi racuni";
            lblUkupno.Text = "...";
            try
            {
                baza.otvoriKonekciju();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT * FROM RACUN";
                OleDbDataReader reader = cmd.ExecuteReader();

                racuni.Clear();
                while (reader.Read())
                {
                    Racun r = new Racun();
                    r.Id_racun = int.Parse(reader["id_racun"].ToString());
                    r.Datum = DateTime.Parse(reader["datum"].ToString());
                    r.Ukupna_cena = double.Parse(reader["ukupna_cena"].ToString());

                    racuni.Add(r);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baza.zatvoriKonekciju();
            }
            foreach (Racun racun in racuni)
            {
                if(racun.Datum.Date.CompareTo(dtpPocetni.Value.Date) > 0)
                {
                    if(racun.Datum.Date.CompareTo(dtpKrajnji.Value.Date) < 0)
                    {
                        lbRacun.Items.Add(racun);
                    }
                }
            }
        }

        private void btnUkloniSaRacuna_Click(object sender, EventArgs e)
        {
            if(lbRacun.SelectedItem != null && lblRacuni.Text == "Novi racun")
            {
                int index = lbRacun.SelectedIndex;
                lbRacun.Items.RemoveAt(index);
                MessageBox.Show("Uspesno ste uklonili knjigu sa racuna!");
            }
            else
            {
                MessageBox.Show("Niste izabrali knjigu za uklanjanje!");
            }
        }

        public string Najprodavanije()
        {
            string najprodavanijeKnjige = " 1. Ana Karenjina 2.Cekajuci Godoa 3.C# programiranje";
            return najprodavanijeKnjige;
        }

        public void Animacija()
        {
            int korak = -1;
            while (true)
            {
                if (najprodavanija.Location.X < -najprodavanija.Width)
                {
                    najprodavanija.Invoke((MethodInvoker)(() => najprodavanija.Location = new Point(ClientSize.Width, najprodavanija.Location.Y)));
                }
                najprodavanija.Invoke((MethodInvoker)(()=>najprodavanija.Location = new Point(najprodavanija.Location.X + korak,najprodavanija.Location.Y)));
                Thread.Sleep(1);
                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(50,420,100,100);

            e.Graphics.FillPie(Brushes.Green, r, 0, -80);
            e.Graphics.FillPie(Brushes.Red, r, -80, -180);
            e.Graphics.FillPie(Brushes.Blue, r, 0, 105);
        }
    }
}