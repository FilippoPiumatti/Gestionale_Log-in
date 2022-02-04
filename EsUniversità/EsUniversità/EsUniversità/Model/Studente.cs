using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsUniversità.Model
{
    class Studente
    {
        private int _matricola;
        private string _nome;
        private string _cognome;
        private PianoStudi _ps;

        public int Matricola { get => _matricola; set => _matricola = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Cognome { get => _cognome; set => _cognome = value; }
        public PianoStudi Ps { get => _ps; } // internal = public nella stessa name space

        public Studente(int matricola, string nome, string cognome)
        {
            _matricola = matricola;
            _nome = nome;
            _cognome = cognome;
        }

        public void setPianoStudi(PianoStudi ps)
        {
            this._ps = ps; // implemento una associazione 1 a 1 con PianoStud
        }
    }
}
