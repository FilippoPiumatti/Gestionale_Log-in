using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsUniversità.Model
{
    class Laurea
    {
        private int _codL; // codice laurea
        private string _nome; // nome laurea
        private int _creditiTot;
        private Facoltà _f;
        private List<Corso> _lstCorsi = new List<Corso>();
        private int _codF;

        public int CodL { get => _codL; set => _codL = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public int CreditiTot { get => _creditiTot; set => _creditiTot = value; }
        public Facoltà F { get => _f; set => _f = value; }
        public List<Corso> LstCorsi { get => _lstCorsi; }
        public int CodF { get => _codF; set => _codF = value; }

        public Laurea(int c, string n, int ncr, Facoltà f)
        {
            this._codL = c;
            this._nome = n;
            this._creditiTot = ncr;
            this._f = f;
        }
        public void aggiungiCorso(Corso corso)
        {
            this._lstCorsi.Add(corso);
        }
    }
}
