using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            carica();
            domainUpDown1.SelectedItem = Carne.Nome;
        }
        Carrello carrello1 = new Carrello("C123");
        Prodotto Carne = new Prodotto("P1", "Carne", "Macelleria", "Carne di vacca");
        Prodotto Latte = new Prodotto("P2", "Latte", "Latteria", "Latte di vacca");
        Prodotto Acqua = new Prodotto("P3", "Acqua", "Stabilimento", "Acqua di fonte");
        Prodotto Pane = new Prodotto("P4", "Pane", "Panettiere", "Pane arabo,poco nemica di marocco");
        Prodotto Olio = new Prodotto("P5", "Olio", "Frantoio", "Olio Extra-vergine d'oliva");
        Prodotto Uova = new Prodotto("P6", "Uova", "Pollaio", "Ouva di gallina ovaiola");
        Prodotto Formaggio = new Prodotto("P7", "Formaggio", "Fomraggificio", "Formaggio di capra");
        Prodotto Lego = new Prodotto("P8", "Lego", "LEGO®", "LEGO 60316 City Police Stazione di Polizia, con Elicottero Giocattolo e Camion della Spazzatura, Giochi per Bambini e Bambine dai 6 Anni, Idee Regalo");
        Prodotto Computer = new Prodotto("P9", "Computer", "AKinformatica", "Pc desktop gaming completo Intel i5 11400F 4.4Ghz,Nvidia Ge Force Gtx 1650 Gaming 4gb Ddr5,Ram 16gb Ddr4,Ssd M.2 250gb + Hdd 1Tb Wifi - Windows 11 Pro - TALENT i550F");
        Prodotto[] lista = new Prodotto[9];
        public void carica()
        {
            domainUpDown1.Items.Add(Carne.Nome);
            domainUpDown1.Items.Add(Latte.Nome);
            domainUpDown1.Items.Add(Acqua.Nome);
            domainUpDown1.Items.Add(Pane.Nome);
            domainUpDown1.Items.Add(Olio.Nome);
            domainUpDown1.Items.Add(Uova.Nome);
            domainUpDown1.Items.Add(Formaggio.Nome);
            domainUpDown1.Items.Add(Lego.Nome);
            domainUpDown1.Items.Add(Computer.Nome);
            lista[0] = Carne;
            lista[1] = Latte;
            lista[2] = Acqua;
            lista[3] = Pane;
            lista[4] = Olio;
            lista[5] = Uova;
            lista[6] = Formaggio;
            lista[7] = Lego;
            lista[8] = Computer;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(domainUpDown1.SelectedItem);
            carrello1.Aggiungi(prod(a));
            aggiorna();
        }
        public Prodotto prod(string a)
        {
            Prodotto p;
            for (int i = 0; i < 99; i++)
            {
                if (lista[i].Nome == a)
                {
                    p = lista[i];
                    return p;
                }
            }
            return null;
        }
        public void aggiorna()
        {
            for (int i = 0; i < 99; i++)
            {
                if (carrello1.Visualizza(i) != null)
                    listBox1.Items.Add(carrello1.Visualizza(i));
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string a = Convert.ToString(domainUpDown1.SelectedItem);
                carrello1.Rimuovi(prod(a));
                aggiorna();
            }
            catch(Exception eccezione)
            {
                MessageBox.Show(eccezione.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            carrello1.Svuota();
            aggiorna();
        }
    }
}