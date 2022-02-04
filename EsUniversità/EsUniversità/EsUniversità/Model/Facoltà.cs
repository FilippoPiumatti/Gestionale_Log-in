using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsUniversità.Model
{
    class Facoltà
    {
        private int _codF;
        private string _nome;
        private string _ind;
        private List<Laurea> _lstLauree = new List<Laurea>();

        public int CodF { get => _codF; set => _codF = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public List<Laurea> LstLauree { get => _lstLauree; set => _lstLauree = value; }
        public string Ind { get => _ind; set => _ind = value; }

        public Facoltà(int c, string n)
        {
            this._codF = c;
            this._nome = n;
        }
        public void aggiungiLaurea(Laurea l)
        {
            this._lstLauree.Add(l);
        }
    }
}
