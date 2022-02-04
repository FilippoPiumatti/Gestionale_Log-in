using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsUniversità.Model; // per vedere le proprietà di Model
using System.IO;
using Newtonsoft.Json;

namespace EsUniversità.Controller
{
    class StudentiController
    {
        private Studente _st;
        private List<Studente> _lstStud;

        public StudentiController()
        {

        }

        /// <summary>
        /// realizza il create del crud(create-read-update-delete) cioè le funzioni di base per partire a creare un gestionale
        /// <param name="m">matricola</param>
        /// <param name="n">nome</param>
        /// <param name="c">cognome</param>
        /// </summary>
        public void PutStudente(int m, string n, string c) // inserimento (create)
        {
            string testo;
            _st = new Studente(m, n, c);
            //scrittura sul file json
            _lstStud = new List<Studente>();
            StreamReader sr = new StreamReader("sutudenti.json");
            testo = sr.ReadToEnd();
            _lstStud = JsonConvert.DeserializeObject<List<Studente>>(testo);
            _lstStud.Add(_st);
            sr.Close();
            StreamWriter sw = new StreamWriter("studenti.json");
            testo = JsonConvert.SerializeObject(_lstStud);
            sw.WriteLine(testo);
        }

        /// <summary>
        /// realizza il read del crud
        /// </summary>
        public List<Studente> GetAllStudenti()
        {
            List <Studente> _lstStudenti = new List<Studente>();

            StreamReader sr = new StreamReader("studenti.json");
            string testo = sr.ReadToEnd();
            _lstStudenti = JsonConvert.DeserializeObject<List<Studente>>(testo);
            sr.Close();

            return _lstStudenti;
        }

        /// <summary>
        /// realizza l'updare
        /// </summary>
        /// <param name="m">matricola</param>
        /// <param name="c">cognome</param>
        /// <param name="n">nome</param>
        public void UpdateStudente(int m, string c, string n)
        {
            _lstStud = new List<Studente>();

            StreamReader sr = new StreamReader("studenti.json");
            string testo = sr.ReadToEnd();
            sr.Close();
            _lstStud = JsonConvert.DeserializeObject<List<Studente>>(testo);
            foreach(Studente s in _lstStud)
            {
                if(s.Matricola == m)
                {
                    s.Cognome = c;
                    s.Nome = n;
                }
            }
            StreamWriter sw = new StreamWriter("studenti.json");
            testo = JsonConvert.SerializeObject(_lstStud);
            sw.WriteLine(testo);
            sw.Close();
        }

        /// <summary>
        /// realizzazione delete
        /// </summary>
        /// <param name="m">matricola</param>
        public void DeleteStudente(int m)
        {
            _lstStud = new List<Studente>();

            StreamReader sr = new StreamReader("studenti.json");
            string testo = sr.ReadToEnd();
            sr.Close();
            _lstStud = JsonConvert.DeserializeObject<List<Studente>>(testo);
            _lstStud.RemoveAll(stud => stud.Matricola == m); // elimino dalla lista la matricola selezionata

            StreamWriter sw = new StreamWriter("studenti.json");
            testo = JsonConvert.SerializeObject(_lstStud);
            sw.WriteLine(testo);
            sw.Close();
        }

        /// <summary>
        /// Read singolo studente
        /// </summary>
        /// <param name="m">matricola</param>
        public Studente GetStudente(int m)
        {
            _lstStud = new List<Studente>();

            StreamReader sr = new StreamReader("studenti.json");
            string testo = sr.ReadToEnd();
            sr.Close();
            _lstStud = JsonConvert.DeserializeObject<List<Studente>>(testo);
            _st = _lstStud.Find(stud => stud.Matricola == m);

            return _st;
        }
    }
}