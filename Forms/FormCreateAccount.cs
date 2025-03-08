using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proiect_II
{
    public partial class FormCreateAccount : Form
    {
        public FormCreateAccount()
        {
            InitializeComponent();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) ||
               string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
               string.IsNullOrWhiteSpace(textBoxRepeatPassword.Text) ||
               string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
               string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
               string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
               string.IsNullOrWhiteSpace(textBoxTelephone.Text))
            {
                MessageBox.Show("Toate câmpurile trebuie completate.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxPassword.Text != textBoxRepeatPassword.Text)
            {
                MessageBox.Show("Parolele nu se potrivesc.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = DBconfig.DBstring;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Inserarea în tabela Login
                string insertLoginQuery = "INSERT INTO Login (username, password) VALUES (@username, @password); SELECT SCOPE_IDENTITY();";
                using (SqlCommand command = new SqlCommand(insertLoginQuery, connection))
                {
                    command.Parameters.AddWithValue("@username", textBoxUsername.Text.Trim());
                    command.Parameters.AddWithValue("@password", textBoxPassword.Text.Trim());
                    int usernameId = Convert.ToInt32(command.ExecuteScalar());

                    // Inserarea în tabela Owner
                    string insertOwnerQuery = "INSERT INTO Owner (username_Id, first_name, last_name, email, phone_number) VALUES (@usernameId, @firstName, @lastName, @email, @phoneNumber)";
                    using (SqlCommand ownerCommand = new SqlCommand(insertOwnerQuery, connection))
                    {
                        ownerCommand.Parameters.AddWithValue("@usernameId", usernameId);
                        ownerCommand.Parameters.AddWithValue("@firstName", textBoxFirstName.Text.Trim());
                        ownerCommand.Parameters.AddWithValue("@lastName", textBoxLastName.Text.Trim());
                        ownerCommand.Parameters.AddWithValue("@email", textBoxEmail.Text.Trim());
                        ownerCommand.Parameters.AddWithValue("@phoneNumber", textBoxTelephone.Text.Trim());
                        ownerCommand.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Contul a fost creat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormLogin form = new FormLogin();
            form.Show();
            this.Close();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                FormLogin form = new FormLogin();
                form.Show();
                this.Close();
                return;
            }
        }
    }
}
