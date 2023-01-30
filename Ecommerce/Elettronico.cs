using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class PElettronico:Prodotto
    {
        private string _codice;

        public PElettronico(string id, string nome, string prod, string descr, decimal prezzo, string codice) : base(id, nome, prod, descr, prezzo)
        {
            Codice = codice;
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
        public void ApplicaS()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
                ApplyDiscount(5);
        }
    }
}
