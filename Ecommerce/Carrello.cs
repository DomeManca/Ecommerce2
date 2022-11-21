using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Carrello
    {
        private string _id;
        private Prodotto[] prodotti;
        private int counter = 0;

        public Carrello(string id)
        {
            Id = id;
            prodotti = new Prodotto[100];
        }
        public string Id;
        public void Aggiungi(Prodotto p)
        {
            prodotti[counter] = p;
            counter++;
        }
        public void Rimuovi(Prodotto p)
        {
            int pos = -1;
            for (int i = 0; i < 99; i++)
            {
                if (prodotti[i] == p)
                {
                    pos = i;
                    break;
                }
            }

            if (pos != -1)
            {
                prodotti[pos] = null;

                for (int i = pos; i < 99; i++)
                {
                    prodotti[i] = prodotti[i+1];
                }
            }   
            else
                throw new Exception("Prodotto non esistente!");
        }
        public string Visualizza(int l)
        {
            if(prodotti[l] != null)
                return prodotti[l].Nome;
            else
                return null;
        }
        public void Svuota()
        {
            counter = 0;
            for (int i = 0; i < 100; i++)
            {
                prodotti[i] = null;
            }
        }
    }
} 