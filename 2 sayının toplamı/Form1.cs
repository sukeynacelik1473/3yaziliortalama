namespace _2_sayının_toplamı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayı1 = Convert.ToInt32(txtSayı1.Text);
            int sayı2 = Convert.ToInt32(txtSayı1.Text);

            int sonuc = sayı1 + sayı2; 

            lblSonuc.Text = sonuc.ToString();   
        }
    }
}