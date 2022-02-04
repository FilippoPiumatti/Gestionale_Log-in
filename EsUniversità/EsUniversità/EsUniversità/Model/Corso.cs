using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsUniversità.Model // mvc model control viewer
{
    class Corso
    {
        private int _codiceC;
        private string _nomeC;
        private int _nCrediti;
        private List<PianoStudi> _lstPS = new List<PianoStudi>();
        private List<Laurea> _lstL = new List<Laurea>();


        public int CodiceC { get => _codiceC; set => _codiceC = value; }
        public string NomeC { get => _nomeC; set => _nomeC = value; }
        public int NCrediti { get => _nCrediti; }
        public List<PianoStudi> LstPS { get => _lstPS; }
        internal List<Laurea> LstL { get => _lstL; }

        public Corso(int c, string nome, int ncr)
        {
            this._codiceC = c;
            this._nomeC = nome;
            this._nCrediti = ncr;
        }

        public void aggiungiPiano(PianoStudi ps)
        {
            this._lstPS.Add(ps);
        }
        public void aggiungiLaurea(Laurea l)
        {
            this._lstL.Add(l);
        }
    }
}
