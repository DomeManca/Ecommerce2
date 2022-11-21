using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Prodotto
    {
        private string _id;
        private string _nome;
        private string _produttore;
        private float _prezzo;
        private string _descrizione;

        public string Id;
        public string Nome;
        public string Produttore;
        public string Descrizione;
        public float Prezzo;
        public Prodotto(string id, string nome, string produttore, string descrizione)
        {
            Id = id;
            Nome = nome;
            Produttore = produttore;
            Descrizione = descrizione;
        }
        
        public void setPrezzo(float prezzo)
        {
            Prezzo = prezzo;
        }
    }
}
