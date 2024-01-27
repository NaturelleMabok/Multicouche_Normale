using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EtudiantBLL
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public string matricule { get; set; }
        public bool sexe { get; set; }
        public DateTime date { get; set; }
        public string classe { get; set; }
        public bool status { get; set; }
        public byte[] photo { get; set; }
    }
}
