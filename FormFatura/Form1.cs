using FaturaDuzenleme;
using System.Drawing.Text;

namespace FormFatura
{
    public partial class frmFatura : Form
    {
        public frmFatura()
        {
            InitializeComponent();
        }

        private void btnTarih_Click(object sender, EventArgs e)
        {
            Fatura fatura = new Fatura();
            fatura.Tarih = "2022";
            fatura.degisimTarih += new DegisimTarihEventHandler(DegisimtarihGoster);
            fatura.Tarih = "2023";
            fatura.Tarih = "2025";
            fatura.Tarih = "2026";

            fatura.SeriNo = "a125";
            fatura.degisimSeri += new DegisimSeriEventHandler(DegisimSeriGoster);
            fatura.SeriNo = "0147";
            fatura.SeriNo = "9896";
            fatura.SeriNo = "5544123";

            fatura.Tutar = 600;
            fatura.degisimTutar += new DegisimTutarEventHandler(DegisimTutarGoster);
            fatura.Tutar = 35;
            fatura.Tutar = 100;
            fatura.Tutar = 500;

        }

        private void DegisimTutarGoster(Fatura sender, FaturaTutarEventArgs e)
        {
            MessageBox.Show($"Eski Tutar : {e.EskiTutar}\n Yeni Tutar :{e.YeniTutar}");
        }

       

        private void DegisimSeriGoster(Fatura sender, FaturaSeriNoEventArgs e)
        {
            
            MessageBox.Show($"Eski Seri : {e.EskiSeriNo}\n Yeni Seri :{e.YeniSeriNo}");
        }

        private void DegisimtarihGoster(Fatura sender, FaturaTarihEventArgs e)
        {
            MessageBox.Show($"Eski Tarih :{e.EskiTarih}\n Yeni Tarih: {e.YeniTarih}"); 
        }

       
    }
}