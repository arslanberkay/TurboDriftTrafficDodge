namespace TurboDriftTrafficDodge.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOyunuBaslat_Click(object sender, EventArgs e)
        {
            OyunuBaslat();
        }

        private void OyunuBaslat()
        {
            tmrHareket.Start();
        }

        private void tmrHareket_Tick(object sender, EventArgs e)
        {
            pbAraba1.Top += 5;
            pbAraba2.Top += 5;
            pbAraba3.Top += 5;
            pbAraba4.Top += 5;
            pbAraba5.Top += 5;
        }
    }
}
