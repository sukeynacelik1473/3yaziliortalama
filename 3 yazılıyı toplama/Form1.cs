namespace _3_yazılıyı_toplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı1 = Convert.ToInt32(txtSayı1.Text);
            int sayı2 = Convert.ToInt32(txtSayı2.Text);
            int sayı3 = Convert.ToInt32(txtSayı3.Text);

            int Sonuc = sayı1 + sayı2 + sayı3;

            lblSonuc.Text = Sonuc.ToString();
        }
    }
}