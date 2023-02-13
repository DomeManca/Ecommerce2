using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class PAlimentare : Prodotto
    {
        private DateTime _scadenza;
        private List<string> _ingredienti;

        public PAlimentare(string id, string nome, string prod, string descr, decimal prezzo, DateTime scadenza) : base(id, nome, prod, descr, prezzo)
        {
            Scadenza = scadenza;
            _ingredienti = new List<string>(10);
        }
        public DateTime Scadenza
        {
            get
            {
                return _scadenza;
            }
            private set
            {
                if (value <= DateTime.Today)
                    _scadenza = value;
                else
                    throw new Exception("Inserire un codice valido");
            }
        }
        public override void ApplicaS()
        {
            if (DateTime.Today.DayOfWeek - Scadenza.DayOfWeek < 7)
                ApplyDiscount(50);
        }
        public void Carica(string a)
        {
            _ingredienti.Add(a);
        }
        public override string[] TuString()
        {
            string[] p = { Id, Nome, Produttore, Convert.ToString(Prezzo), Convert.ToString(Scontato), Convert.ToString(Scadenza).Substring(0, 10), Descrizione + _ingredienti[0] + _ingredienti[1] + _ingredienti[2] + _ingredienti[3] + _ingredienti[4] + _ingredienti[5] + _ingredienti[6] + _ingredienti[7] + _ingredienti[8] + _ingredienti[9]};
            return p;
        }
    }
}
