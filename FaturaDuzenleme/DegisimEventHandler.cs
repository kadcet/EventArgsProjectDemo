using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaDuzenleme
{
    public delegate void DegisimTarihEventHandler(Fatura sender, FaturaTarihEventArgs e);

    public delegate void DegisimSeriEventHandler(Fatura sender, FaturaSeriNoEventArgs e);

    public delegate void DegisimTutarEventHandler(Fatura sender, FaturaTutarEventArgs e);

}
