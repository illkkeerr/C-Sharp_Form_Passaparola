using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassaparolaOyunu
{
    internal class Soru
    {
        public string Soru_ { get; set; }
        public List<string> Cevaplar { get; set; } = new List<string>();

        public Soru()
        {

        }

        public Soru(string soru, List<string> cevaplar)
        {
            this.Soru_ = soru;
            this.Cevaplar = cevaplar;
        }

    }
}
