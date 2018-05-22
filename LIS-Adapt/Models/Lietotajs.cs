using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LISAdapt.Models
{
    public class Lietotajs
    {
        public int SeansuSkaits { get; set; }
        public int PavaditaisLaiksSistema { get; set; }
        public int PalidzibasApmeklesana { get; set; }
        public int VeiktiePasutijumi { get; set; }
        public int AtceltiePasutijumi { get; set; }
        public int PiesaistiKlienti { get; set; }
        public string Klase { get; set; }
    }

    public class LietotajuSaraksts
    {
        public List<Lietotajs> Saraksts { get; set; }
    }
}
