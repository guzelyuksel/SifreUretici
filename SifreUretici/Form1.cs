using System;
using System.Windows.Forms;

namespace SifreUretici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool kucukHarf;
        private bool buyukHarf;
        private bool rakam;
        private bool ozelKarakter;
        private int sifreSayisi;
        private int sifreUzunlugu;

        const string kucukHarfler = "abcçdefgğhıijklmnoöprsştuüvyz";
        const string buyukHarfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
        const string rakamlar = "0123456789";
        const string ozelKarakterler = "!@#$%^&*()_+-=[]{}|;':,./<>?";

        private void btnUret_Click(object sender, EventArgs e)
        {
            txtUretilenSifreler.Clear();
            kucukHarf = cbKucukHarf.Checked;
            buyukHarf = cbBuyukHarf.Checked;
            rakam = cbRakam.Checked;
            ozelKarakter = cbOzelKarakter.Checked;
            sifreSayisi = Convert.ToInt32(nudSifreSayisi.Value);
            sifreUzunlugu = Convert.ToInt32(nudSifreUzunlugu.Value);

            SifreUret();
        }

        private void SifreUret()
        {
            string tumKarakterler = "";
            if (kucukHarf) tumKarakterler += kucukHarfler;
            if (buyukHarf) tumKarakterler += buyukHarfler;
            if (rakam) tumKarakterler += rakamlar;
            if (ozelKarakter) tumKarakterler += ozelKarakterler;
            if (string.IsNullOrEmpty(tumKarakterler))
            {
                MessageBox.Show("Lütfen en az bir karakter grubu seçiniz.");
                return;
            }
            Random rnd = new Random();
            for (int i = 0; i < sifreSayisi; i++)
            {
                string uretilenSifre = "";
                for (int j = 0; j < sifreUzunlugu; j++)
                {
                    uretilenSifre += tumKarakterler[rnd.Next(1, tumKarakterler.Length)];
                }
                txtUretilenSifreler.AppendText(uretilenSifre + Environment.NewLine);
            }
            txtUretilenSifreler.ScrollToCaret();
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            cbKucukHarf.Checked = false;
            cbBuyukHarf.Checked = false;
            cbRakam.Checked = false;
            cbOzelKarakter.Checked = false;
            nudSifreSayisi.Value = 1;
            nudSifreUzunlugu.Value = 6;
        }
    }
}
