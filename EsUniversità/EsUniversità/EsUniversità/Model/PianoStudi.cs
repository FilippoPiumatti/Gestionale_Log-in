using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsUniversità.Model
{
    class PianoStudi
    {
        private int _codicePS;
        private int _anno;
        private int _creditiOttenuti;
        private int _creditiDaOttenere;
        private int _matricola;
        private Studente _st;
        private List<Corso> _lstCorsi = new List<Corso>();

        public int CodicePS { get => _codicePS; set => _codicePS = value; }
        public int Anno { get => _anno; set => _anno = value; }
        public int CreditiOttenuti { get => _creditiOttenuti; set => _creditiOttenuti = value; }
        public int CreditiDaOttenere { get => _creditiDaOttenere; set => _creditiDaOttenere = value; }
        public Studente St { get => _st; set => _st = value;  } // riferimento allo studente
        public List<Corso> LstCorsi { get => _lstCorsi; set => _lstCorsi = value; }
        public int Matricola { get => _matricola; set => _matricola = value; }

        public PianoStudi(int c, int a)
        {
            this._codicePS = c;
            this._anno = a;
        }

        public void aggiungiCorso(Corso c)
        {
            this._lstCorsi.Add(c);
        }
    }
}