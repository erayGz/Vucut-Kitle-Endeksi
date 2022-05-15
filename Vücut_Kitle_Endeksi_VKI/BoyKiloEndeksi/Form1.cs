namespace BoyKiloEndeksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void sadeceSayiGirme(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double  boy, kilo, sonuc=0,boyunKaresi;
            boy = Convert.ToDouble(tbBoy.Text.Insert(1, ","));
            kilo = Convert.ToDouble(tbKilo.Text);
            

            boyunKaresi = boy * boy;
            sonuc = kilo / boyunKaresi;
            if (sonuc<18.5)
            {
                lblSonuc.Text = "Zayýfsýnýz Efendim";
            }
            else if (sonuc>=18.5&&sonuc<24.9)
            {
                lblSonuc.Text = "Normal Kilosunuz Efendim";
            }
            else if (sonuc >25 && sonuc < 30)
            {
                lblSonuc.Text = "Fazla Kilolusunuz Efendim";
            }
            else if (sonuc >= 30 && sonuc <35)
            {
                lblSonuc.Text = "Tip 1 Obezsiniz Efendim";
            }
            else if (sonuc >= 35 && sonuc <40)
            {
                lblSonuc.Text = "Tip 2 Obezsiniz Efendim";
            }
            else if (sonuc >= 40)
            {
                lblSonuc.Text = "Morbid Obezsiniz Efendim";
            }
            else if (sonuc >= 50)
            {
                lblSonuc.Text = "Süper Obezsiniz Efendim";
            }
            else if (sonuc >= 60)
            {
                lblSonuc.Text = "Süper Süper Obezsiniz Efendim";
            }
            else
            {
                lblSonuc.Text = "Yazdýðýnýz Deðerleri Kontrol Ediniz !!!!";
            }

        }
    }
}