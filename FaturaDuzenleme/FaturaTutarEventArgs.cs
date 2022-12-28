using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaDuzenleme
{
    public class FaturaTutarEventArgs:EventArgs
    {
        public FaturaTutarEventArgs(decimal eskiTutar, decimal yeniTutar)
        {
            EskiTutar = eskiTutar;
            YeniTutar = yeniTutar;
        }

        public decimal EskiTutar { get; set; }
        public decimal YeniTutar { get; set; }
    }
}
