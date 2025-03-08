using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_II
{
    public partial class FormManager : Form
    {
        private readonly string connectionString = DBconfig.DBstring;
        private ManagerControlDashboard dashboardControl;
        private ManagerControlPet petControl;
        private ManagerControlOwner ownerControl;
        private ManagerControlFood foodControl;
        private ManagerControlRoom roomControl;
        private ManagerControlReservation reservationControl;

        private Timer timer;
        public FormManager()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();

            dashboardControl = new ManagerControlDashboard();
            dashboardControl.Location = new Point(260, 220);
            dashboardControl.Visible = false;
            this.Controls.Add(dashboardControl);

            petControl = new ManagerControlPet();
            petControl.Location = new Point(280, 220);
            petControl.Visible = false;
            this.Controls.Add(petControl);

            ownerControl = new ManagerControlOwner();
            ownerControl.Location = new Point(280, 220);
            ownerControl.Visible = false;
            this.Controls.Add(ownerControl);

            foodControl = new ManagerControlFood();
            foodControl.Location = new Point(280, 220);
            foodControl.Visible = false;
            this.Controls.Add(foodControl);

            roomControl = new ManagerControlRoom();
            roomControl.Location = new Point(280, 220);
            roomControl.Visible = false;
            this.Controls.Add(roomControl);

            reservationControl = new ManagerControlReservation();
            reservationControl.Location = new Point(280, 220);
            reservationControl.Visible = false;
            this.Controls.Add(reservationControl);

        }

       

        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

       

        private void FormManager_Load(object sender, EventArgs e)
        {
            UpdateDateTime();
            labelWelcomeUser.Text = "Welcome, " + FormLogin.firstName + " " + FormLogin.lastName + "!";
            dashboardControl.Visible = true;
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

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDashboard);
            ownerControl.Visible = false;
            dashboardControl.Visible = true;
            petControl.Visible = false;
            foodControl.Visible = false;
            roomControl.Visible = false;
            reservationControl.Visible = false;
        }

        private void buttonPet_Click(object sender, EventArgs e)
        {
            MovePanel(buttonPet);
            ownerControl.Visible = false;
            dashboardControl.Visible = false;
            petControl.Visible = true;
            foodControl.Visible = false;
            roomControl.Visible = false;
            reservationControl.Visible = false;
        }
        private void buttonOwner_Click(object sender, EventArgs e)
        {
            MovePanel(buttonOwner);
            ownerControl.Visible = true;
            dashboardControl.Visible = false;
            petControl.Visible = false;
            foodControl.Visible = false;
            roomControl.Visible = false;
            reservationControl.Visible = false;
        }

        private void buttonFood_Click(object sender, EventArgs e)
        {
            MovePanel(buttonFood);
            ownerControl.Visible = false;
            dashboardControl.Visible = false;
            petControl.Visible = false;
            foodControl.Visible = true;
            roomControl.Visible = false;
            reservationControl.Visible = false;
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            MovePanel(buttonRoom);
            ownerControl.Visible = false;
            dashboardControl.Visible = false;
            petControl.Visible = false;
            foodControl.Visible = false;
            roomControl.Visible = true;
            reservationControl.Visible = false;
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            ownerControl.Visible = false;
            dashboardControl.Visible = false;
            petControl.Visible = false;
            foodControl.Visible = false;
            roomControl.Visible = false;
            reservationControl.Visible = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
        
    }
}
