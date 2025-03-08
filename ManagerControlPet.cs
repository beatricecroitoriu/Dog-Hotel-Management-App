using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_II
{

    public partial class ManagerControlPet : UserControl
    {
        private readonly string connectionString = DBconfig.DBstring;
        private DataTable dataTable = new DataTable();
        private SqlConnection conn; // Adaugă această linie pentru a defini obiectul de conexiune
       

        public ManagerControlPet()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString); // Inițializează obiectul de conexiune
            LoadAllPets();
            dataGridViewPet.SelectionChanged += dataGridViewPet_SelectionChanged;
        }
        
        // Funcție pentru încărcarea tuturor animalelor în DataGridView
        private void LoadAllPets()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Pet";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(dataTable);
                    dataGridViewPet.DataSource = dataTable;
                }
            }
        }

        // Funcție pentru gestionarea evenimentului de apăsare a butonului de căutare
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Verificare dacă nu sunt completate mai multe câmpuri pentru căutare
            if ((textBoxOwnerIDSearch.Text != "" ? 1 : 0) + (textBoxPetNameSearch.Text != "" ? 1 : 0) + (textBoxAnimalIDSearch.Text != "" ? 1 : 0) + (textBoxOwnerLastNameSearch.Text != "" ? 1 : 0) > 1)
            {
                MessageBox.Show("Completează un singur câmp pentru căutare!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Construirea interogării SQL în funcție de câmpurile completate pentru căutare
            string query = "SELECT Pet.* FROM Pet INNER JOIN Owner ON Pet.Owner_Id = Owner.owner_Id WHERE 1=1";

            if (!string.IsNullOrEmpty(textBoxOwnerIDSearch.Text))
                query += " AND Pet.owner_Id = @OwnerId";
            if (!string.IsNullOrEmpty(textBoxPetNameSearch.Text))
                query += " AND Pet.animal_Name LIKE @AnimalName";
            if (!string.IsNullOrEmpty(textBoxAnimalIDSearch.Text))
                query += " AND Pet.animal_Id = @AnimalId";
            if (!string.IsNullOrEmpty(textBoxOwnerLastNameSearch.Text))
                query += " AND Owner.last_name LIKE @OwnerLastName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(textBoxOwnerIDSearch.Text))
                        command.Parameters.AddWithValue("@OwnerId", textBoxOwnerIDSearch.Text);
                    if (!string.IsNullOrEmpty(textBoxPetNameSearch.Text))
                        command.Parameters.AddWithValue("@AnimalName", "%" + textBoxPetNameSearch.Text + "%");
                    if (!string.IsNullOrEmpty(textBoxAnimalIDSearch.Text))
                        command.Parameters.AddWithValue("@AnimalId", textBoxAnimalIDSearch.Text);
                    if (!string.IsNullOrEmpty(textBoxOwnerLastNameSearch.Text))
                        command.Parameters.AddWithValue("@OwnerLastName", "%" + textBoxOwnerLastNameSearch.Text + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        dataTable.Clear(); // Șterge datele existente
                        adapter.Fill(dataTable); // Populează DataTable cu rezultatele căutării
                    }
                }
            }
        }

        // Funcție pentru gestionarea evenimentului de selectare a unei linii în DataGridView
        private void dataGridViewPet_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPet.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewPet.SelectedRows[0];
                textBoxOwnerIDUpdate.Text = selectedRow.Cells["owner_Id"].Value.ToString();
                textBoxAnimalIDUpdate.Text = selectedRow.Cells["animal_Id"].Value.ToString();
                textBoxPetNameUpdate.Text = selectedRow.Cells["animal_Name"].Value.ToString();
                textBoxRasaUpdate.Text = selectedRow.Cells["rasa_Animal"].Value.ToString();
                comboBoxTalieUpdate.SelectedItem = selectedRow.Cells["talie_Animal"].Value.ToString();
                comboBoxTipCazareUpdate.SelectedItem = selectedRow.Cells["tip_Cazare"].Value.ToString();
                comboBoxTipHranaUpdate.SelectedItem = selectedRow.Cells["tip_Hrana"].Value.ToString();
                textBoxObservatiiUpdate.Text = selectedRow.Cells["observatii"].Value.ToString();
            }
        }


        private void buttonAddPet_Click(object sender, EventArgs e)
        {
            int ownerId = int.Parse(textBoxOwnerIdAdd.Text);
            string petName = textBoxPetNameAdd.Text;
            string rasa = textBoxRasaAdd.Text;
            string talie = comboBoxTalieAdd.SelectedItem.ToString();
            string tipCazare = comboBoxTipCazareAdd.SelectedItem.ToString();
            string tipHrana = comboBoxTipHranaAdd.SelectedItem.ToString();
            string observatii = textBoxObservatiiAdd.Text;

            if (!AllFieldsAreFilledForAdd())
            {
                MessageBox.Show("Te rog să completezi toate câmpurile.");
                return;
            }

            // Verificăm dacă owner ID-ul există în baza de date
            
            if (!int.TryParse(textBoxOwnerIdAdd.Text, out ownerId))
            {
                MessageBox.Show("Owner ID trebuie să fie un număr întreg.");
                return;
            }
            if (!OwnerExists(ownerId))
            {
                MessageBox.Show("Owner ID-ul introdus nu există în baza de date. Te rog să introduci un Owner ID valid.");
                return;
            }

            // Verificăm dacă animalul pe care încercăm să-l adăugăm deja există în baza de date
            
            if (PetExists(petName))
            {
                MessageBox.Show("Animalul introdus deja există în baza de date.");
                return;
            }

            string query = "INSERT INTO Pet (owner_Id, animal_Name, rasa_Animal, talie_Animal, tip_Cazare, tip_Hrana, observatii) " +
                           "VALUES (@OwnerId, @AnimalName, @Rasa, @Talie, @TipCazare, @TipHrana, @Observatii)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@OwnerId", ownerId);
            cmd.Parameters.AddWithValue("@AnimalName", petName);
            cmd.Parameters.AddWithValue("@Rasa", rasa);
            cmd.Parameters.AddWithValue("@Talie", talie);
            cmd.Parameters.AddWithValue("@TipCazare", tipCazare);
            cmd.Parameters.AddWithValue("@TipHrana", tipHrana);
            cmd.Parameters.AddWithValue("@Observatii", observatii);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Pet added successfully.");

            textBoxOwnerIdAdd.Text = "";
            textBoxPetNameAdd.Text = "";
            textBoxRasaAdd.Text = "";
            comboBoxTalieAdd.SelectedItem = null;
            comboBoxTipCazareAdd.SelectedItem = null;
            comboBoxTipHranaAdd.SelectedItem = null;
            textBoxObservatiiAdd.Text = "";
        }

        private bool OwnerExists(int ownerId)
        {
            // Interogare pentru a verifica dacă owner ID-ul există în baza de date
            string query = "SELECT COUNT(*) FROM Owner WHERE owner_Id = @OwnerId";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OwnerId", ownerId);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private bool AllFieldsAreFilledForAdd()
        {
            // Verificăm dacă toate câmpurile necesare sunt completate
            return !string.IsNullOrWhiteSpace(textBoxOwnerIdAdd.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxPetNameAdd.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxRasaAdd.Text) &&
                   comboBoxTalieAdd.SelectedItem != null &&
                   comboBoxTipCazareAdd.SelectedItem != null &&
                   comboBoxTipHranaAdd.SelectedItem != null;
        }

        private bool PetExists(string petName)
        {
            // Interogare pentru a verifica dacă animalul există deja în baza de date
            string query = "SELECT COUNT(*) FROM Pet WHERE animal_Name = @PetName";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PetName", petName);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string ownerId = textBoxOwnerIDUpdate.Text;
            string petName = textBoxPetNameUpdate.Text;
            string rasa = textBoxRasaUpdate.Text;
            string talie = comboBoxTalieUpdate.SelectedItem.ToString();
            string tipCazare = comboBoxTipCazareUpdate.SelectedItem.ToString();
            string tipHrana = comboBoxTipHranaUpdate.SelectedItem.ToString();
            string observatii = textBoxObservatiiUpdate.Text;
            string animalId = textBoxAnimalIDUpdate.Text;

            if (!AllFieldsAreFilledForUpdate())
            {
                MessageBox.Show("Te rog să completezi toate câmpurile.");
                return;
            }

            string query = "UPDATE Pet SET owner_Id = @OwnerId, animal_Name = @PetName, rasa_Animal = @Rasa, talie_Animal = @Talie, tip_Cazare = @TipCazare, tip_Hrana = @TipHrana, observatii = @Observatii WHERE animal_Id = @AnimalId";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@OwnerId", ownerId);
            cmd.Parameters.AddWithValue("@PetName", petName);
            cmd.Parameters.AddWithValue("@Rasa", rasa);
            cmd.Parameters.AddWithValue("@Talie", talie);
            cmd.Parameters.AddWithValue("@TipCazare", tipCazare);
            cmd.Parameters.AddWithValue("@TipHrana", tipHrana);
            cmd.Parameters.AddWithValue("@Observatii", observatii);
            cmd.Parameters.AddWithValue("@AnimalId", animalId);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Pet updated successfully.");

            textBoxAnimalIDUpdate.Text = "";
            textBoxOwnerIDUpdate.Text = "";
            textBoxPetNameUpdate.Text = "";
            textBoxRasaUpdate.Text = "";
            comboBoxTalieUpdate.SelectedItem = null;
            comboBoxTipCazareUpdate.SelectedItem = null;
            comboBoxTipHranaUpdate.SelectedItem = null;
            textBoxObservatiiUpdate.Text = "";
        }

        private bool AllFieldsAreFilledForUpdate()
        {
            // Verificăm dacă toate câmpurile necesare sunt completate
            return !string.IsNullOrWhiteSpace(textBoxAnimalIDUpdate.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxOwnerIDUpdate.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxPetNameUpdate.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxRasaUpdate.Text) &&
                   comboBoxTalieUpdate.SelectedItem != null &&
                   comboBoxTipCazareUpdate.SelectedItem != null &&
                   comboBoxTipHranaUpdate.SelectedItem != null;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string animalId = textBoxAnimalIDUpdate.Text;

            string query = "DELETE FROM Pet WHERE animal_Id = @AnimalId";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@AnimalId", animalId);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Pet deleted successfully.");

            textBoxAnimalIDUpdate.Text = "";
            textBoxOwnerIDUpdate.Text = "";
            textBoxPetNameUpdate.Text = "";
            textBoxRasaUpdate.Text = "";
            comboBoxTalieUpdate.SelectedItem = null;
            comboBoxTipCazareUpdate.SelectedItem = null;
            comboBoxTipHranaUpdate.SelectedItem = null;
            textBoxObservatiiUpdate.Text = "";
        }
    }
}
