namespace cs0510
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mybutton.Text = "‰Ÿ‚³‚ê‚½";
            mybutton.Left = 500;
            mybutton.Visible = false;
            MessageBox.Show("‚±‚ñ‚É‚¿‚Í");

        }
    }
}