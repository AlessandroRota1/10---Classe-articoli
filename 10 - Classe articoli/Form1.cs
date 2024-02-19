using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10___Classe_articoli
{
    public partial class Form1 : Form
    {
        class Articolo
        {
            protected string codice;
            protected double prezzounitario;
            protected string descrizione;
            public string Codice
            {
                get => codice;
                set => codice= value;
            }
            public string Descrizione
            {
                get => descrizione;
                set => descrizione = value;
            }
            public double Prezzounitario
            {
                get => prezzounitario;
                set => prezzounitario = value;
            }
            public void sconto()
            {
                
            }
        }
        class ArticoloAlimentare : Articolo
        {
            private int annodiscadenza;
            public int Annodiscadenza
            {
                get => annodiscadenza;
                set => annodiscadenza = value;
            }
            private double Scontoalimentari()
            {
                if (annodiscadenza == DateTime.Now.Year)
                    prezzounitario = prezzounitario - prezzounitario * 20 / 100;

                return prezzounitario;
            }
        }
        class ArticoloNonAlimentare : Articolo
        {

        }
        class AlimentareFresco : Articolo
        {
            private double Scontofresco()
            {

                return prezzounitario;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
