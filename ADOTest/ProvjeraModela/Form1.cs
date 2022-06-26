using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvjeraModela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Projekt odabraniProjekt;
            using (var kontekst = new Entities())
            {
                dataGridViewProjekti.DataSource = kontekst.Projekts.ToList();
                dataGridViewProjekti.Columns["Dokumentacijas"].Visible = false;
                dataGridViewProjekti.Columns["Eksplozivs"].Visible = false;
                dataGridViewProjekti.Columns["ZaposleniciNaProjektus"].Visible = false;
                /*
                dataGridViewRezervacije.DataSource = kontekst.Rezervacijas.ToList();
                dataGridViewRezervacije.Columns["Smjestaj"].Visible = false;
                dataGridViewRezervacije.Columns["ZaposleniciNaProjektus"].Visible = false;
                dataGridViewZaposleniciNaProjektu.DataSource = kontekst.ZaposleniciNaProjektus.ToList();
                dataGridViewZaposleniciNaProjektu.Columns["Projekt"].Visible = false;
                dataGridViewZaposleniciNaProjektu.Columns["Zaposlenik"].Visible = false;
                dataGridViewZaposleniciNaProjektu.Columns["Voziloes"].Visible = false;
                dataGridViewZaposleniciNaProjektu.Columns["Rezervacijas"].Visible = false;
                */
            }
        }

        private void dataGridViewProjekti_SelectionChanged(object sender, EventArgs e)
        {
            Projekt odabraniProjekt = dataGridViewProjekti.CurrentRow.DataBoundItem as Projekt;
            dataGridViewZaposleniciNaProjektu.DataSource = DohvatiZaposlenikeProjekta(odabraniProjekt);
            dataGridViewZaposleniciNaProjektu.Columns["Projekt"].Visible = false;
            dataGridViewZaposleniciNaProjektu.Columns["Zaposlenik"].Visible = false;
            dataGridViewZaposleniciNaProjektu.Columns["Voziloes"].Visible = false;
            dataGridViewZaposleniciNaProjektu.Columns["Rezervacijas"].Visible = false;

        }
        private List<ZaposleniciNaProjektu> DohvatiZaposlenikeProjekta(Projekt projekt)
        {
            using (var kontekst = new Entities())
            {
                kontekst.Projekts.Attach(projekt);
                return projekt.ZaposleniciNaProjektus.ToList();
            }
        }
    }
}
