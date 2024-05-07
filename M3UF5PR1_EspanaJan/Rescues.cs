using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M3UF5PR1_EspanaJan.Models.DTOs;
using M3UF5PR1_EspanaJan.Persistence.Mapping;

namespace M3UF5PR1_EspanaJan
{
    public partial class Rescues : Form
    {
        public Rescues()
        {
            InitializeComponent();
        }

        private void Rescues_Load(object sender, EventArgs e)
        {
            RescueDAO rescueDAO = new RescueDAO();
            dataGridView1.DataSource = rescueDAO.GetAllRescue();

            List<int> ints = rescueDAO.GetAllIds();
            foreach (int i in ints)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (!comboBox1.Items.Contains(comboBox1.SelectedItem))
            {
                errorComboBox.SetError(comboBox1, "Please select a valid option");
                return;
            }
            else if (comboBox1.SelectedItem == null)
            {
                errorComboBox.SetError(comboBox1, "Please select an option");
                return;
            }
            else
            {
                errorComboBox.Clear();
            }

            RescueDAO rescueDAO = new RescueDAO();
            RescueDTO rescue = new RescueDTO();
            rescue = rescueDAO.GetRescueById(int.Parse(comboBox1.Text));

            rescueNum.Text = rescue.RescueNumber;
            rescueDate.Text = rescue.RescueDate.ToString();
            animalID.Text = rescue.Animal.Id.ToString();
            GA.Text = rescue.GA.ToString();
            location.Text = rescue.Location;
        }
    }
}
