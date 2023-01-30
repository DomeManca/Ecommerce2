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
        private decimal _scontato;

        public PAlimentare(string id, string nome, string prod, string descr, decimal prezzo, string codice) : base(id, nome, prod, descr, prezzo)
        {
            Codice = codice;
            Scontato = prezzo;
        }

        public string Codice
        {
            get
            {
                return _codice;
            }
            private set
            {
                if (value != null)
                    _codice = value;
                else
                    throw new Exception("Inserire un codice valido");
            }
        }
        public decimal Scontato
        {
            get
            {
                return _scontato;
            }
            set
            {
                if (value > 0)
                    _scontato = value;
                else
                    throw new Exception("Il prezzo deve essere positivo");
            }
        }
    }
}
