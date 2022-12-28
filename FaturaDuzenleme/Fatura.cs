namespace FaturaDuzenleme
{
    public class Fatura
    {
        public event DegisimTarihEventHandler degisimTarih;
        public event DegisimSeriEventHandler degisimSeri;
        public event DegisimTutarEventHandler degisimTutar;

        private string tarih;
        private decimal tutar;
        private string seriNo;



        public string Tarih
        {
            get { return tarih; }
            set
            {
                var eskiTarih = tarih;
                tarih = value;
                degisimTarih?.Invoke(this, new FaturaTarihEventArgs(eskiTarih, tarih));
            }
        }

        public decimal Tutar
        {
            get { return tutar; }
            set
            {
                var eskiTutar = tutar;
                tutar = value;
                degisimTutar?.Invoke(this, new FaturaTutarEventArgs(eskiTutar, tutar));
            }
        }


        public string SeriNo
        {
            get { return seriNo; }
            set
            {
                var eskiSeri = seriNo;
                seriNo = value;
                degisimSeri?.Invoke(this, new FaturaSeriNoEventArgs(eskiSeri, seriNo));
            }
        }
    }
}