using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaDuzenleme
{
    public class FaturaTarihEventArgs:EventArgs
    {
        public FaturaTarihEventArgs(string eskiTarih, string yeniTarih)
        {
            EskiTarih = eskiTarih;
            YeniTarih = yeniTarih;
        }

        public string EskiTarih { get; set; }
        public string YeniTarih { get; set; }

    }
}
