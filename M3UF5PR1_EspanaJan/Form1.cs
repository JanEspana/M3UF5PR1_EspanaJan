namespace M3UF5PR1_EspanaJan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RescueForm rescueForm = new RescueForm();
            rescueForm.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManagementForm managementForm = new ManagementForm();
            managementForm.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ranking ranking = new Ranking();
            ranking.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rescues rescues = new Rescues();
            rescues.Show();
            Hide();
        }
    }
}
