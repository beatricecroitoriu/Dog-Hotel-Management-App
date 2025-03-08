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
    public partial class FormUser : Form
    {
        SqlConnection myCon = new SqlConnection();
        private FUserControlAbout aboutControl;
        private UserControlReservation reservationControl;
        private UserControlPet petControl;
        private UserControlIntrebari intrebariControl;

        private Timer timer;
        public FormUser()
        {
            InitializeComponent();

            myCon.ConnectionString = DBconfig.DBstring;
            myCon.Open();

            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();

            aboutControl = new FUserControlAbout();
            aboutControl.Location = new Point(260, 260); 
            aboutControl.Visible = false;
            this.Controls.Add(aboutControl);

            reservationControl = new UserControlReservation();
            reservationControl.Location = new Point(280, 220); 
            reservationControl.Visible = false; 
            this.Controls.Add(reservationControl);

            petControl = new UserControlPet();
            petControl.Location = new Point(280, 220); 
            petControl.Visible = false; 
            this.Controls.Add(petControl);

            intrebariControl = new UserControlIntrebari();
            intrebariControl.Location = new Point(280, 200);
            intrebariControl.Visible = false;
            this.Controls.Add(intrebariControl);
        }

        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }


        private void FormUser_Load(object sender, EventArgs e)
        {

            UpdateDateTime();
            labelWelcomeUser.Text = "Welcome, " + FormLogin.firstName + " " + FormLogin.lastName + "!";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateDateTime(); 
        }

        private void UpdateDateTime()
        {
            labelDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }


        private void labelLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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

        private void buttonHome_Click(object sender, EventArgs e)
        {
            MovePanel(buttonHome);
            aboutControl.Visible = false;
            reservationControl.Visible = false;
            petControl.Visible = false;
            intrebariControl.Visible = false;
        }

        private void buttonPet_Click(object sender, EventArgs e)
        {
            MovePanel(buttonPet);
            aboutControl.Visible = false;
            reservationControl.Visible = false;
            petControl.Visible = true;
            intrebariControl.Visible = false;
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            aboutControl.Visible = false;
            reservationControl.Visible = true;
            petControl.Visible = false;
            intrebariControl.Visible = false;
        }

        private void buttonIntrebari_Click(object sender, EventArgs e)
        {
            MovePanel(buttonIntrebari);
            aboutControl.Visible = false;
            reservationControl.Visible = false;
            petControl.Visible = false;
            intrebariControl.Visible = true;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MovePanel(buttonAbout);
            aboutControl.Visible = true;
            reservationControl.Visible = false;
            petControl.Visible = false;
            intrebariControl.Visible = false;
        }

       
    }
}
