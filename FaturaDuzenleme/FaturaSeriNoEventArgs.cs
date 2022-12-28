using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaDuzenleme
{
    public class FaturaSeriNoEventArgs:EventArgs
    {
        public FaturaSeriNoEventArgs(string eskiSeriNo, string yeniSeriNo)
        {
            EskiSeriNo = eskiSeriNo;
            YeniSeriNo = yeniSeriNo;
        }

        public string EskiSeriNo { get; set; }
        public string YeniSeriNo { get; set; }
    }
}
