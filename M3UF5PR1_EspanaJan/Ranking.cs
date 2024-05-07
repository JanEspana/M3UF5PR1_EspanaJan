using M3UF5PR1_EspanaJan.Models.DTOs;
using M3UF5PR1_EspanaJan.Persistence.Mapping;
using System.Xml.Linq;

namespace M3UF5PR1_EspanaJan
{
    public partial class Ranking : Form
    {
        public Ranking()
        {
            InitializeComponent();
        }

        private void Ranking_Load(object sender, EventArgs e)
        {
            XMLHelper xmlHelper = new XMLHelper();
            List<PersonDTO> people = xmlHelper.GetPeople();
            dataGridView1.DataSource = people;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }
    }
}
