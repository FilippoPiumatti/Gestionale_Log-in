using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsUniversità.Model;
using Newtonsoft.Json;
using System.IO;

namespace EsUniversità.Controller
{
    class LaureaController
    {
        private Laurea _l;
        private List<Laurea> _lstLauree;

        public LaureaController()
        { }
        ///CRUD  Create - Read - Upadate - Delete
        ///

        public Laurea GetLaurea(int cl)
        {
            FacoltàController fc = new FacoltàController();
            _lstLauree = new List<Laurea>();
            String testo;
            StreamReader sr = new StreamReader("Laurea.json");
            testo = sr.ReadToEnd();
            sr.Close();
            _lstLauree = JsonConvert.DeserializeObject<List<Laurea>>(testo);
            _l = _lstLauree.Find(lr => lr.CodL == cl);
            /* collegamento con la sua facoltà */
            _l.F = fc.GetFacoltà(_l.CodF);


            return _l;
        }

        public List<Laurea> GetAllLauree()
        {
            FacoltàController fc = new FacoltàController();
            _lstLauree = new List<Laurea>();
            String testo;
            StreamReader sr = new StreamReader("Laurea.json");
            testo = sr.ReadToEnd();
            sr.Close();
            _lstLauree = JsonConvert.DeserializeObject<List<Laurea>>(testo);

            for (int i = 0; i < _lstLauree.Count; i++)
                _lstLauree[i].F = fc.GetFacoltà(_lstLauree[i].CodF);

            return _lstLauree;
        }

        public List<Laurea> GetLaureeFac(int cf)
        {
            _lstLauree = new List<Laurea>();

            String testo;
            StreamReader sr = new StreamReader("Laurea.json");
            testo = sr.ReadToEnd();
            sr.Close();
            _lstLauree = JsonConvert.DeserializeObject<List<Laurea>>(testo);
            
            return _lstLauree.FindAll(lr => lr.CodF == cf);
        }


    }
}
