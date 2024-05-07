using M3UF5PR1_EspanaJan.Models.DTOs;
using M3UF5PR1_EspanaJan.Persistence.Mapping;
using System.Text.RegularExpressions;

namespace M3UF5PR1_EspanaJan
{
    public partial class RescueForm : Form
    {
        public RescueForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void RescueForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Vet");
            comboBox1.Items.Add("Technical");

            AnimalDAO animalDAO = new AnimalDAO();
            AnimalDTO animal = animalDAO.PickRandomAnimal();

            RescueDTO rescue = new RescueDTO();
            rescue.GenerateRescue(animal);

            rescuenum.Text = rescue.RescueNumber;
            rescueDate.Text = rescue.RescueDate.ToString();
            species.Text = animal.Superfamily;
            ad.Text = rescue.GA.ToString();
            location.Text = rescue.Location;
            animalId.Text = animal.Id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex name = new Regex(@"^[a-zA-Z\s]+$");
            if (comboBox1.SelectedItem == null)
            {
                errorJob.SetError(comboBox1, "Please select a job");
                return;
            }
            else if (!comboBox1.Items.Contains(comboBox1.SelectedItem))
            {
                errorJob.SetError(comboBox1, "Please select a valid job");
                return;
            }
            else
            {
                errorJob.Clear();
            }

            if (textBox1.Text == "")
            {
                errorName.SetError(textBox1, "Please enter a name");
                return;
            }
            else if (!name.IsMatch(textBox1.Text))
            {
                errorName.SetError(textBox1, "Only letters are valid");
                return;
            }
            else
            {
                errorName.Clear();
            }

            PersonDTO person = new PersonDTO();
            person.Name = textBox1.Text;
            person.Job = comboBox1.SelectedItem.ToString();
            if (person.Job == "Vet")
            {
                person.XP = 80;
            }
            else
            {
                person.XP = 45;
            }

            DialogResult dialogResult = MessageBox.Show("Do you want to move the animal to CRAM?", "CRAM", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                AnimalDAO animalDAO = new AnimalDAO();
                int id = animalId.Text == "" ? 0 : int.Parse(animalId.Text);
                AnimalDTO animal = animalDAO.SelectById(id);
                if (animal != null)
                {
                    RescueDTO rescue = new RescueDTO();
                    double ga = rescue.CalculateGA(animal, double.Parse(ad.Text), true);
                    rescue.RescueDate = DateTime.Parse(rescueDate.Text);
                    rescue.GenerateRescue(animal);
                    if (ga < 0)
                    {
                        ga = 0;
                    }
                    rescue.GA = ga;
                    rescue.Location = location.Text;

                    RescueDAO rescueDAO = new RescueDAO();

                    rescueDAO.InsertRescue(rescue);
                    if (rescue.GA < 30)
                    {
                        MessageBox.Show("Animal moved to CRAM. Affectation number: " + rescue.GA + ". You won 50XP!");
                        person.XP += 50;

                    }
                    else
                    {
                        MessageBox.Show("Animal moved to CRAM. Affectation number: " + rescue.GA + ". You lost 20XP...");
                        person.XP -= 20;
                    }
                    MessageBox.Show("Final results: " + person.Name + " has " + person.XP + "XP");

                    XMLHelper xmlHelper = new XMLHelper();
                    person.RescueNum = rescue.RescueNumber;
                    xmlHelper.InsertPerson(person);

                    Form1 form1 = new Form1();
                    form1.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Animal not found");
                }
            }
            else
            {
                AnimalDAO animalDAO = new AnimalDAO();
                AnimalDTO animal = animalDAO.SelectById(int.Parse(animalId.Text));
                if (animal != null)
                {
                    RescueDTO rescue = new RescueDTO();
                    double ga = rescue.CalculateGA(animal, double.Parse(ad.Text), false);
                    rescue.RescueDate = DateTime.Parse(rescueDate.Text);
                    rescue.GenerateRescue(animal);
                    if (ga < 0)
                    {
                        ga = 0;
                    }
                    rescue.GA = ga;
                    rescue.Location = location.Text;

                    RescueDAO rescueDAO = new RescueDAO();

                    rescueDAO.InsertRescue(rescue);
                    if (rescue.GA < 30)
                    {
                        MessageBox.Show("Animal not moved to CRAM. Affectation number: " + rescue.GA + ". You won 50XP!");
                        person.XP += 50;

                    }
                    else
                    {
                        MessageBox.Show("Animal not moved to CRAM. Affectation number: " + rescue.GA + ". You lost 20XP...");
                        person.XP -= 20;
                    }
                    MessageBox.Show("Final results: " + person.Name + " has " + person.XP + "XP");

                    XMLHelper xmlHelper = new XMLHelper();
                    person.RescueNum = rescue.RescueNumber;
                    xmlHelper.InsertPerson(person);

                    Form1 form1 = new Form1();
                    form1.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Animal not found");
                }
            }
        }
    }
}
