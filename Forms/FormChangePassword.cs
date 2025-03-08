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
    public partial class FormChangePassword : Form
    {
        SqlConnection myCon = new SqlConnection();
        public FormChangePassword()
        {
            InitializeComponent();
            myCon.ConnectionString = DBconfig.DBstring;
            myCon.Open();
        }

        private void labelExit1_Click(object sender, EventArgs e)
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

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) ||
                          string.IsNullOrWhiteSpace(textBoxOldPassword.Text) ||
                          string.IsNullOrWhiteSpace(textBoxNewPassword.Text) ||
                          string.IsNullOrWhiteSpace(textBoxRepeatPassword.Text))
            {
                MessageBox.Show("Toate câmpurile trebuie completate.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = textBoxUsername.Text;
            string oldPassword = textBoxOldPassword.Text;

            // Construiți interogarea SQL pentru a căuta utilizatorul și parola în baza de date
            string query = "SELECT COUNT(*) FROM Login WHERE username=@username AND password=@oldPassword";

            // Creare comandă SQL și setarea parametrilor
            using (SqlCommand command = new SqlCommand(query, myCon))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@oldPassword", oldPassword);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    // Verificați dacă parolele noi coincid
                    if (textBoxNewPassword.Text != textBoxRepeatPassword.Text)
                    {
                        MessageBox.Show("Parolele nu se potrivesc.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Actualizează parola în baza de date
                    string updateLoginQuery = "UPDATE Login SET password=@newPassword WHERE username=@username";
                    using (SqlCommand commandUpdate = new SqlCommand(updateLoginQuery, myCon))
                    {
                        commandUpdate.Parameters.AddWithValue("@username", username);
                        commandUpdate.Parameters.AddWithValue("@newPassword", textBoxNewPassword.Text.Trim());
                        commandUpdate.ExecuteNonQuery();
                    }

                    MessageBox.Show("Parola a fost schimbată cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormLogin form = new FormLogin();
                    form.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nume utilizator sau parolă incorectă. Vă rugăm să încercați din nou.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
