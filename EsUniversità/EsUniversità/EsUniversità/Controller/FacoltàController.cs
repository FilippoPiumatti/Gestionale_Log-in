using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsUniversità.Model;
using System.IO;
using Newtonsoft.Json;

namespace EsUniversità.Controller
{
    class FacoltàController
    {
        private Facoltà _f;
        private List<Facoltà> _lstFacoltà;

        public FacoltàController()
        { }

        ///CRUD  Create - Read - Upadate - Delete
        /// <summary>
        /// Create
        /// </summary>
        /// <param name="c"></param>
        /// <param name="n"></param>
        
            //create
        public void putFacolta(int c, string n)
        {
            string testo;
            _f = new Facoltà(c, n);
            //scrittura sul file json
            _lstFacoltà = new List<Facoltà>();
            StreamReader sr = new StreamReader("facoltà.json");
            testo = sr.ReadToEnd();
            _lstFacoltà = JsonConvert.DeserializeObject<List<Facoltà>>(testo);
            _lstFacoltà.Add(_f);
            sr.Close();
            StreamWriter sw = new StreamWriter("facoltà.json");
            testo = JsonConvert.SerializeObject(_lstFacoltà);
            sw.WriteLine(testo);
        }

        //read
        public List<Facoltà> ReadFacoltà()
        {
            List <Facoltà> _lstfacolta= new List<Facoltà>();

            _lstfacolta = GetAllFacoltà();
            return _lstfacolta;
        }

        //update
        public void UpdateFacoltà(int c,string n)
        {
            _lstFacoltà = new List<Facoltà>();

            StreamReader sr = new StreamReader("facoltà.json");
            string testo = sr.ReadToEnd();
            sr.Close();
            _lstFacoltà = JsonConvert.DeserializeObject<List<Facoltà>>(testo);
            foreach (Facoltà f in _lstFacoltà)
            {
                if (f.CodF == c)
                {
                    f.Nome = n;
                }
            }
            StreamWriter sw = new StreamWriter("facoltà.json");
            testo = JsonConvert.SerializeObject(_lstFacoltà);
            sw.WriteLine(testo);
            sw.Close();
        }

        //delete

        public void DeleteFacoltà(int c)
        {
            _lstFacoltà = new List<Facoltà>();

            StreamReader sr = new StreamReader("facoltà.json");
            string testo = sr.ReadToEnd();
            sr.Close();
            _lstFacoltà = JsonConvert.DeserializeObject<List<Facoltà>>(testo);
            _lstFacoltà.RemoveAll(fac => fac.CodF == c); // elimino dalla lista la matricola selezionata

            StreamWriter sw = new StreamWriter("facoltà.json");
            testo = JsonConvert.SerializeObject(_lstFacoltà);
            sw.WriteLine(testo);
            sw.Close();
        }

        public Facoltà GetFacoltà(int cf)
        {
            LaureaController lc = new LaureaController();

            _lstFacoltà = new List<Facoltà>();
            String testo;
            StreamReader sr = new StreamReader("facoltà.json");
            testo = sr.ReadToEnd();
            sr.Close();
            _lstFacoltà = JsonConvert.DeserializeObject<List<Facoltà>>(testo);
            _f = _lstFacoltà.Find(fac => fac.CodF == cf);
            _f.LstLauree = lc.GetLaureeFac(cf);
            
            return _f;
        }

        public List<Facoltà> GetAllFacoltà()
        {
            LaureaController lc = new LaureaController();

            _lstFacoltà = new List<Facoltà>();
            String testo;
            StreamReader sr = new StreamReader("facoltà.json");
            testo = sr.ReadToEnd();
            sr.Close();
            _lstFacoltà = JsonConvert.DeserializeObject<List<Facoltà>>(testo);
            foreach (Facoltà f in _lstFacoltà)
                f.LstLauree = lc.GetLaureeFac(f.CodF);


            return _lstFacoltà;
        }
    }
}
