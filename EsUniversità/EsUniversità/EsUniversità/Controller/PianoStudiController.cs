using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsUniversità.Model;
using Newtonsoft.Json;

namespace EsUniversità.Controller
{
    class PianoStudiController
    {
        private PianoStudi _ps;
        private List<PianoStudi> _lstPianoStudi;

        public PianoStudiController()
        { }

        //CRUD 

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <param name="cr"></param>
        public void PutPianoStudi(int c, int a, int cr)
        { }

        /// <summary>
        /// Read All
        /// </summary>
        /// <returns></returns>
        public List<PianoStudi> GetAllPianoStudio()
        {
            StudentiController studente = new StudentiController();
            _lstPianoStudi = new List<PianoStudi>();
            StreamReader sr = new StreamReader("PianoStudi.json");
            string testo = sr.ReadToEnd();
            sr.Close();
            _lstPianoStudi = JsonConvert.DeserializeObject<List<PianoStudi>>(testo);
            for (int i = 0; i < _lstPianoStudi.Count; i++)
                _lstPianoStudi[i].St = studente.GetStudente(_lstPianoStudi[i].Matricola);
            
            return _lstPianoStudi;
        }
        ///<summary>
        ///read singolo piano di studi
        ///</summary>
        ///<param name="c">codice piano studi</param>
        public PianoStudi GetPianoStudi(int c)
        {
            StudentiController studente = new StudentiController();
            _lstPianoStudi = new List<PianoStudi>();
            StreamReader sr = new StreamReader("PianoStudi.json");
            String testo = sr.ReadToEnd();
            sr.Close();
            _lstPianoStudi = JsonConvert.DeserializeObject<List<PianoStudi>>(testo);
            _ps = _lstPianoStudi.Find(pds => pds.CodicePS == c);

            _ps.St = studente.GetStudente(_ps.Matricola);
            return _ps;
        }
    }
}
