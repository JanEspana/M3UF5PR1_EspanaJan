using M3UF5PR1_EspanaJan.Persistence.Mapping;
using M3UF5PR1_EspanaJan.Models.DTOs;
using System.Text.RegularExpressions;


namespace M3UF5PR1_EspanaJan
{
    public partial class ManagementForm : Form
    {
        public ManagementForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex words = new Regex(@"^[a-zA-Z\s]+$");
            //regex for decimal numbers
            Regex weight = new Regex(@"^\d+(\,\d+)?$");
            if (insertName.Text == "")
            {
                errorName.SetError(insertName, "Name is required");
                return;
            }
            else if (!words.IsMatch(insertName.Text))
            {
                errorName.SetError(insertName, "Name must contain only letters");
                return;
            }
            else
            {
                errorName.Clear();
            }

            if (insertSuperfamily.Text == "")
            {
                errorComboBox.SetError(insertSuperfamily, "Superfamily is required");
                return;
            }
            else
            {
                errorComboBox.Clear();
            }

            if (insertSpecies.Text == "")
            {
                errorSpecies.SetError(insertSpecies, "Species is required");
                return;
            }
            else if (!words.IsMatch(insertSpecies.Text))
            {
                errorSpecies.SetError(insertSpecies, "Species must contain only letters");
                return;
            }
            else
            {
                errorSpecies.Clear();
            }

            if (insertWeight.Text == "")
            {
                errorWeight.SetError(insertWeight, "Weight is required");
                return;
            }
            else if (!weight.IsMatch(insertWeight.Text))
            {
                errorWeight.SetError(insertWeight, "Weight must be a number");
                return;
            }
            else
            {
                errorWeight.Clear();

            }

            AnimalDTO animal = new AnimalDTO
            {
                Name = insertName.Text,
                Superfamily = insertSuperfamily.Text,
                Species = insertSpecies.Text,
                Weight = double.Parse(insertWeight.Text)
            };

            AnimalDAO animalDAO = new AnimalDAO();
            animalDAO.InsertAnimal(animal);

            MessageBox.Show("Animal inserted successfully");

            insertId.Text = animalDAO.NextId().ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            AnimalDAO animalDAO = new AnimalDAO();
            insertId.Text = animalDAO.NextId().ToString();

            List<int> ids = animalDAO.GetAllIds();

            foreach (int id in ids)
            {
                deleteId.Items.Add(id);
                updateId.Items.Add(id);
            }

            List<string> superfamilies = new List<string> { "Sea bird", "Sea turtle", "Cetaceus" };

            foreach (string superfamily in superfamilies)
            {
                insertSuperfamily.Items.Add(superfamily);
                updateSuperfamily.Items.Add(superfamily);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (updateId.Text == "")
            {
                errorId.SetError(updateId, "Id is required");
                return;
            }
            else if (!updateId.Items.Contains(int.Parse(updateId.Text)))
            {
                errorId.SetError(updateId, "Id not found");
                return;
            }
            else
            {
                errorId.Clear();
            }

            Regex words = new Regex(@"^[a-zA-Z\s]+$");
            Regex weight = new Regex(@"^\d+(\,\d+)?$");

            if (updateName.Text == "")
            {
                errorName.SetError(updateName, "Name is required");
                return;
            }
            else if (!words.IsMatch(updateName.Text))
            {
                errorName.SetError(updateName, "Name must contain only letters");
                return;
            }
            else
            {
                errorName.Clear();
            }

            if (!updateSuperfamily.Items.Contains(updateSuperfamily.Text))
            {
                errorComboBox.SetError(updateSuperfamily, "Superfamily is required");
                return;
            }
            else
            {
                errorComboBox.Clear();
            }

            if (updateSpecies.Text == "")
            {
                errorSpecies.SetError(updateSpecies, "Species is required");
                return;
            }
            else if (!words.IsMatch(updateSpecies.Text))
            {
                errorSpecies.SetError(updateSpecies, "Species must contain only letters");
                return;
            }
            else
            {
                errorSpecies.Clear();
            }

            if (updateWeight.Text == "")
            {
                errorWeight.SetError(updateWeight, "Weight is required");
                return;
            }
            else if (!weight.IsMatch(updateWeight.Text))
            {
                errorWeight.SetError(updateWeight, "Weight must be a number");
                return;
            }
            else
            {
                errorWeight.Clear();
            }

            AnimalDTO animal = new AnimalDTO
            {
                Id = int.Parse(updateId.Text),
                Name = updateName.Text,
                Superfamily = updateSuperfamily.Text,
                Species = updateSpecies.Text,
                Weight = double.Parse(updateWeight.Text)
            };
            AnimalDAO animalDAO = new AnimalDAO();
            animalDAO.UpdateAnimal(animal);
            MessageBox.Show("Animal updated successfully");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            updateId.Items.Clear();

            AnimalDAO animalDAO = new AnimalDAO();
            List<int> ids = animalDAO.GetAllIds();
            foreach (int id in ids)
            {
                updateId.Items.Add(id);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            deleteId.Items.Clear();

            AnimalDAO animalDAO = new AnimalDAO();
            List<int> ids = animalDAO.GetAllIds();
            foreach (int id in ids)
            {
                deleteId.Items.Add(id);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (deleteId.Text == "")
            {
                errorId.SetError(deleteId, "Id is required");
                return;
            }
            else if (!deleteId.Items.Contains(int.Parse(deleteId.Text)))
            {
                errorId.SetError(deleteId, "Id not found");
                return;
            }
            else
            {
                errorId.Clear();
            }

            AnimalDAO animalDAO = new AnimalDAO();
            animalDAO.DeleteAnimalById(int.Parse(deleteId.Text));
            MessageBox.Show("Animal deleted successfully");

            deleteId.Items.Clear();
            List<int> ids = animalDAO.GetAllIds();
            foreach (int id in ids)
            {
                deleteId.Items.Add(id);
            }
        }
    }
}
