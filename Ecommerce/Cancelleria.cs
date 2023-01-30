using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class PCancelleria : Prodotto
    {
        public int _grammatura;
        public string _funzionamento;

        public PCancelleria(string id, string nome, string prod, string descr, decimal prezzo, int grammatura, string funzionamento) : base(id, nome, prod, descr, prezzo)
        {
            Grammatura = grammatura;
            Funzionamento = funzionamento;
        }

        public string Funzionamento
        {
            get
            {
                return _funzionamento;
            }
            private set
            {
                if (value != null)
                    _funzionamento = value;
                else
                   throw new Exception("Inserire un funzionamento valido");
               }
        }
        public int Grammatura
        {
            get
            {
                return _grammatura;
            }
            set
            {
                if (value > 0)
                    _grammatura = value;
                else
                    throw new Exception("Grammatura errata");
            }
        }
        public void ApplicaS()
        {
            if (DateTime.Today.Day % 2 == 0)
                ApplyDiscount(3);
        }
    }
}