using System.Drawing;
using System.Windows.Forms;

namespace Proiect_II
{
    partial class FormUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.buttonIntrebari = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonPet = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelWelcomeUser = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.panelSlide);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Controls.Add(this.buttonReservation);
            this.panel1.Controls.Add(this.buttonIntrebari);
            this.panel1.Controls.Add(this.buttonAbout);
            this.panel1.Controls.Add(this.buttonPet);
            this.panel1.Location = new System.Drawing.Point(-22, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 1128);
            this.panel1.TabIndex = 0;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(52, 249);
            this.panelSlide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSlide.Size = new System.Drawing.Size(15, 52);
            this.panelSlide.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(105, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dog Hotel";
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Location = new System.Drawing.Point(51, 249);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(304, 52);
            this.buttonHome.TabIndex = 9;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonReservation
            // 
            this.buttonReservation.FlatAppearance.BorderSize = 0;
            this.buttonReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReservation.ForeColor = System.Drawing.Color.White;
            this.buttonReservation.Location = new System.Drawing.Point(50, 373);
            this.buttonReservation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(304, 52);
            this.buttonReservation.TabIndex = 12;
            this.buttonReservation.Text = "Reservation";
            this.buttonReservation.UseVisualStyleBackColor = true;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // buttonIntrebari
            // 
            this.buttonIntrebari.FlatAppearance.BorderSize = 0;
            this.buttonIntrebari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIntrebari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIntrebari.ForeColor = System.Drawing.Color.White;
            this.buttonIntrebari.Location = new System.Drawing.Point(50, 435);
            this.buttonIntrebari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonIntrebari.Name = "buttonIntrebari";
            this.buttonIntrebari.Size = new System.Drawing.Size(304, 52);
            this.buttonIntrebari.TabIndex = 11;
            this.buttonIntrebari.Text = "Intrebari frecvente";
            this.buttonIntrebari.UseVisualStyleBackColor = true;
            this.buttonIntrebari.Click += new System.EventHandler(this.buttonIntrebari_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAbout.ForeColor = System.Drawing.Color.White;
            this.buttonAbout.Location = new System.Drawing.Point(50, 497);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(304, 52);
            this.buttonAbout.TabIndex = 10;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonPet
            // 
            this.buttonPet.FlatAppearance.BorderSize = 0;
            this.buttonPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPet.ForeColor = System.Drawing.Color.White;
            this.buttonPet.Location = new System.Drawing.Point(50, 311);
            this.buttonPet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPet.Name = "buttonPet";
            this.buttonPet.Size = new System.Drawing.Size(304, 52);
            this.buttonPet.TabIndex = 14;
            this.buttonPet.Text = "Pet";
            this.buttonPet.UseVisualStyleBackColor = true;
            this.buttonPet.Click += new System.EventHandler(this.buttonPet_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.labelWelcomeUser);
            this.panel2.Location = new System.Drawing.Point(334, 102);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1808, 123);
            this.panel2.TabIndex = 1;
            // 
            // labelWelcomeUser
            // 
            this.labelWelcomeUser.AutoSize = true;
            this.labelWelcomeUser.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWelcomeUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelWelcomeUser.Location = new System.Drawing.Point(183, 46);
            this.labelWelcomeUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWelcomeUser.Name = "labelWelcomeUser";
            this.labelWelcomeUser.Size = new System.Drawing.Size(26, 29);
            this.labelWelcomeUser.TabIndex = 3;
            this.labelWelcomeUser.Text = "?";
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.labelDateTime.Location = new System.Drawing.Point(400, 37);
            this.labelDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(26, 29);
            this.labelDateTime.TabIndex = 2;
            this.labelDateTime.Text = "?";
            // 
            // labelLogOut
            // 
            this.labelLogOut.AutoSize = true;
            this.labelLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.labelLogOut.Location = new System.Drawing.Point(1736, 37);
            this.labelLogOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(100, 29);
            this.labelLogOut.TabIndex = 3;
            this.labelLogOut.Text = "Log out";
            this.labelLogOut.Click += new System.EventHandler(this.labelLogOut_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proiect_II.Properties.Resources.paw_heart;
            this.pictureBox2.Location = new System.Drawing.Point(72, 25);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect_II.Properties.Resources.place_dog_house_building;
            this.pictureBox1.Location = new System.Drawing.Point(122, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(222)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(1920, 1072);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelLogOut);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dog Hotel Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelWelcomeUser;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.Button buttonIntrebari;
        private System.Windows.Forms.Button buttonAbout;
        private DataGridViewTextBoxColumn ownerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn animalIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn animalNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rasaAnimalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn talieAnimalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipCazareDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipMeniuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn observatiiDataGridViewTextBoxColumn;
        private Button buttonPet;
    }
}