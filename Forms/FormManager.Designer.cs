using System.Drawing;
using System.Windows.Forms;

namespace Proiect_II
{
    partial class FormManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.buttonRoom = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPet = new System.Windows.Forms.Button();
            this.buttonOwner = new System.Windows.Forms.Button();
            this.buttonFood = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.buttonReservation);
            this.panel1.Controls.Add(this.buttonRoom);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonPet);
            this.panel1.Controls.Add(this.buttonOwner);
            this.panel1.Controls.Add(this.buttonFood);
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
            // buttonReservation
            // 
            this.buttonReservation.FlatAppearance.BorderSize = 0;
            this.buttonReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReservation.ForeColor = System.Drawing.Color.White;
            this.buttonReservation.Location = new System.Drawing.Point(52, 554);
            this.buttonReservation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(306, 52);
            this.buttonReservation.TabIndex = 12;
            this.buttonReservation.Text = "Reservation";
            this.buttonReservation.UseVisualStyleBackColor = true;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // buttonRoom
            // 
            this.buttonRoom.FlatAppearance.BorderSize = 0;
            this.buttonRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRoom.ForeColor = System.Drawing.Color.White;
            this.buttonRoom.Location = new System.Drawing.Point(52, 493);
            this.buttonRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRoom.Name = "buttonRoom";
            this.buttonRoom.Size = new System.Drawing.Size(306, 52);
            this.buttonRoom.TabIndex = 11;
            this.buttonRoom.Text = "Room";
            this.buttonRoom.UseVisualStyleBackColor = true;
            this.buttonRoom.Click += new System.EventHandler(this.buttonRoom_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Location = new System.Drawing.Point(51, 249);
            this.buttonDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(304, 52);
            this.buttonDashboard.TabIndex = 9;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(40, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dog Hotel Management";
            // 
            // buttonPet
            // 
            this.buttonPet.FlatAppearance.BorderSize = 0;
            this.buttonPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPet.ForeColor = System.Drawing.Color.White;
            this.buttonPet.Location = new System.Drawing.Point(50, 310);
            this.buttonPet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPet.Name = "buttonPet";
            this.buttonPet.Size = new System.Drawing.Size(306, 52);
            this.buttonPet.TabIndex = 10;
            this.buttonPet.Text = "Pet";
            this.buttonPet.UseVisualStyleBackColor = true;
            this.buttonPet.Click += new System.EventHandler(this.buttonPet_Click);
            // 
            // buttonOwner
            // 
            this.buttonOwner.FlatAppearance.BorderSize = 0;
            this.buttonOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOwner.ForeColor = System.Drawing.Color.White;
            this.buttonOwner.Location = new System.Drawing.Point(50, 371);
            this.buttonOwner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOwner.Name = "buttonOwner";
            this.buttonOwner.Size = new System.Drawing.Size(306, 52);
            this.buttonOwner.TabIndex = 12;
            this.buttonOwner.Text = "Owner";
            this.buttonOwner.UseVisualStyleBackColor = true;
            this.buttonOwner.Click += new System.EventHandler(this.buttonOwner_Click);
            // 
            // buttonFood
            // 
            this.buttonFood.FlatAppearance.BorderSize = 0;
            this.buttonFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFood.ForeColor = System.Drawing.Color.White;
            this.buttonFood.Location = new System.Drawing.Point(52, 432);
            this.buttonFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFood.Name = "buttonFood";
            this.buttonFood.Size = new System.Drawing.Size(306, 52);
            this.buttonFood.TabIndex = 14;
            this.buttonFood.Text = "Food";
            this.buttonFood.UseVisualStyleBackColor = true;
            this.buttonFood.Click += new System.EventHandler(this.buttonFood_Click);
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
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(222)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(1920, 1072);
            this.Controls.Add(this.labelLogOut);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dog Hotel Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormManager_Load);
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
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.Button buttonRoom;
        private System.Windows.Forms.Button buttonPet;
        private Button buttonOwner;
        private Button buttonFood;
    }
}