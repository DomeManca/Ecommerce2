﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        PAlimentare Carne = new PAlimentare("P1", "Carne", "Macelleria", "Carne di vacca", 4, DateTime.Today);
        PAlimentare Latte = new PAlimentare("P2", "Latte", "Latteria", "Latte di vacca", 2,DateTime.Today);
        PAlimentare Acqua = new PAlimentare("P3", "Acqua", "Stabilimento", "Acqua di fonte", 1, DateTime.Today);
        PAlimentare Pane = new PAlimentare("P4", "Pane", "Panettiere", "Pane arabo,poco nemica di marocco", 5, DateTime.Today);
        PAlimentare Olio = new PAlimentare("P5", "Olio", "Frantoio", "Olio Extra-vergine d'oliva", 6, DateTime.Today);
        PAlimentare Uova = new PAlimentare("P6", "Uova", "Pollaio", "Ouva di gallina ovaiola", 1, DateTime.Today);
        PAlimentare Formaggio = new PAlimentare("P7", "Formaggio", "Fomraggificio", "Formaggio di capra", 13, DateTime.Today);
        PElettronico Lego = new PElettronico("P8", "Lego", "LEGO®", "LEGO 60316 City Police Stazione di Polizia, con Elicottero Giocattolo e Camion della Spazzatura, Giochi per Bambini e Bambine dai 6 Anni, Idee Regalo", 60, "60316");
        PElettronico Computer = new PElettronico("P9", "Computer", "AKinformatica", "Pc desktop gaming completo Intel i5 11400F 4.4Ghz,Nvidia Ge Force Gtx 1650 Gaming 4gb Ddr5,Ram 16gb Ddr4,Ssd M.2 250gb + Hdd 1Tb Wifi - Windows 11 Pro - TALENT i550F", 1500, "A12345");
        List<Prodotto> lista = new List<Prodotto>(9);
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
            lista.Add(Carne);
            lista.Add(Latte);
            lista.Add(Acqua);
            lista.Add(Pane);
            lista.Add(Olio);
            lista.Add(Uova);
            lista.Add(Formaggio);
            lista.Add(Lego);
            lista.Add(Computer);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string a = Convert.ToString(domainUpDown1.SelectedItem);
                carrello1.Aggiungi(prod(a));
                aggiorna();
            }
            catch (Exception eccezione)
            {
                MessageBox.Show(eccezione.Message);
            }
        }
        public Prodotto prod(string a)
        {
            Prodotto p;
            foreach (Prodotto f in lista)
            {
                if (f.Nome == a)
                {
                    p = f;
                    return p;
                }
            }
            return null;
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
            DialogResult dialogResult = MessageBox.Show("Sicuro di voler eliminare?", "Attenzione", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                carrello1.Svuota();
                aggiorna();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            aggiorna();
        }
        public void aggiorna()
        {
            listView1.Items.Clear();
            foreach(Prodotto p in carrello1.Prodotti) { 
                ListViewItem itm;
                itm = new ListViewItem(p.TuString());
                listView1.Items.Add(itm);
            }

            label2.Text = Convert.ToString(carrello1.Calctot());//senza sconto
            label3.Text = Convert.ToString(carrello1.Calctots());//con sconto
        }
    }
}