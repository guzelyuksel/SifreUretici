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
        const string kucukHarfler = "abcçdefgğhıijklmnoöprsştuüvyz";
        const string buyukHarfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
        const string rakamlar = "0123456789";
        const string ozelKarakterler = "!@#$%^&*()_+-=[]{}|;':,./<>?";
        private void btnUret_Click(object sender, EventArgs e)
        {
            txtUretilenSifreler.Clear();
            SifreUret();
        }
        private void SifreUret()
        {
            string tumKarakterler = "";
            if (cbKucukHarf.Checked) tumKarakterler += kucukHarfler;
            if (cbBuyukHarf.Checked) tumKarakterler += buyukHarfler;
            if (cbRakam.Checked) tumKarakterler += rakamlar;
            if (cbOzelKarakter.Checked) tumKarakterler += ozelKarakterler;
            if (string.IsNullOrEmpty(tumKarakterler))
            {
                MessageBox.Show("Lütfen en az bir karakter grubu seçiniz.");
                return;
            }
            Random rnd = new Random();
            for (int i = 0; i < nudSifreSayisi.Value; i++)
            {
                string uretilenSifre = "";
                for (int j = 0; j < nudSifreUzunlugu.Value; j++)
                    uretilenSifre += tumKarakterler[rnd.Next(0, tumKarakterler.Length)];
                txtUretilenSifreler.AppendText(uretilenSifre + Environment.NewLine);
            }
            txtUretilenSifreler.ScrollToCaret();
        }
        private void btnSifirla_Click(object sender, EventArgs e)
        {
            cbKucukHarf.Checked = cbBuyukHarf.Checked = cbRakam.Checked = cbOzelKarakter.Checked = false;
            nudSifreSayisi.Value = 1;
            nudSifreUzunlugu.Value = 6;
        }
    }
}