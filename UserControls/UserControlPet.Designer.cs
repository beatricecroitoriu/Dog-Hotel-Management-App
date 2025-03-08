namespace Proiect_II
{
    partial class UserControlPet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlPet = new System.Windows.Forms.TabControl();
            this.tabPageAddPet = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTipHrana = new System.Windows.Forms.ComboBox();
            this.labelTip = new System.Windows.Forms.Label();
            this.comboBoxTipCazare = new System.Windows.Forms.ComboBox();
            this.labelObservatii = new System.Windows.Forms.Label();
            this.labelTalie = new System.Windows.Forms.Label();
            this.labelRasa = new System.Windows.Forms.Label();
            this.labelPetName = new System.Windows.Forms.Label();
            this.textBoxRasa = new System.Windows.Forms.TextBox();
            this.textBoxObservatii = new System.Windows.Forms.TextBox();
            this.textBoxTalie = new System.Windows.Forms.TextBox();
            this.textBoxPetName = new System.Windows.Forms.TextBox();
            this.buttonAddPet = new System.Windows.Forms.Button();
            this.labelAddClient = new System.Windows.Forms.Label();
            this.tabPageSearchPet = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.dataGridViewPet = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlPet.SuspendLayout();
            this.tabPageAddPet.SuspendLayout();
            this.tabPageSearchPet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPet
            // 
            this.tabControlPet.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlPet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlPet.Controls.Add(this.tabPageAddPet);
            this.tabControlPet.Controls.Add(this.tabPageSearchPet);
            this.tabControlPet.Location = new System.Drawing.Point(26, 25);
            this.tabControlPet.Name = "tabControlPet";
            this.tabControlPet.SelectedIndex = 0;
            this.tabControlPet.Size = new System.Drawing.Size(1342, 526);
            this.tabControlPet.TabIndex = 6;
            // 
            // tabPageAddPet
            // 
            this.tabPageAddPet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(222)))), ((int)(((byte)(195)))));
            this.tabPageAddPet.Controls.Add(this.label1);
            this.tabPageAddPet.Controls.Add(this.comboBoxTipHrana);
            this.tabPageAddPet.Controls.Add(this.labelTip);
            this.tabPageAddPet.Controls.Add(this.comboBoxTipCazare);
            this.tabPageAddPet.Controls.Add(this.labelObservatii);
            this.tabPageAddPet.Controls.Add(this.labelTalie);
            this.tabPageAddPet.Controls.Add(this.labelRasa);
            this.tabPageAddPet.Controls.Add(this.labelPetName);
            this.tabPageAddPet.Controls.Add(this.textBoxRasa);
            this.tabPageAddPet.Controls.Add(this.textBoxObservatii);
            this.tabPageAddPet.Controls.Add(this.textBoxTalie);
            this.tabPageAddPet.Controls.Add(this.textBoxPetName);
            this.tabPageAddPet.Controls.Add(this.buttonAddPet);
            this.tabPageAddPet.Controls.Add(this.labelAddClient);
            this.tabPageAddPet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.tabPageAddPet.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddPet.Name = "tabPageAddPet";
            this.tabPageAddPet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddPet.Size = new System.Drawing.Size(1334, 493);
            this.tabPageAddPet.TabIndex = 0;
            this.tabPageAddPet.Text = "Add Pet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(686, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tip Hrana:";
            // 
            // comboBoxTipHrana
            // 
            this.comboBoxTipHrana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipHrana.FormattingEnabled = true;
            this.comboBoxTipHrana.Items.AddRange(new object[] {
            "uscata",
            "umeda"});
            this.comboBoxTipHrana.Location = new System.Drawing.Point(691, 177);
            this.comboBoxTipHrana.Name = "comboBoxTipHrana";
            this.comboBoxTipHrana.Size = new System.Drawing.Size(246, 28);
            this.comboBoxTipHrana.TabIndex = 31;
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTip.Location = new System.Drawing.Point(392, 137);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(115, 25);
            this.labelTip.TabIndex = 30;
            this.labelTip.Text = "Tip Cazare:";
            // 
            // comboBoxTipCazare
            // 
            this.comboBoxTipCazare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipCazare.FormattingEnabled = true;
            this.comboBoxTipCazare.Items.AddRange(new object[] {
            "indoor",
            "outdoor"});
            this.comboBoxTipCazare.Location = new System.Drawing.Point(397, 177);
            this.comboBoxTipCazare.Name = "comboBoxTipCazare";
            this.comboBoxTipCazare.Size = new System.Drawing.Size(246, 28);
            this.comboBoxTipCazare.TabIndex = 29;
            // 
            // labelObservatii
            // 
            this.labelObservatii.AutoSize = true;
            this.labelObservatii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelObservatii.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelObservatii.Location = new System.Drawing.Point(246, 213);
            this.labelObservatii.Name = "labelObservatii";
            this.labelObservatii.Size = new System.Drawing.Size(106, 25);
            this.labelObservatii.TabIndex = 28;
            this.labelObservatii.Text = "Observatii:";
            // 
            // labelTalie
            // 
            this.labelTalie.AutoSize = true;
            this.labelTalie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTalie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTalie.Location = new System.Drawing.Point(539, 47);
            this.labelTalie.Name = "labelTalie";
            this.labelTalie.Size = new System.Drawing.Size(61, 25);
            this.labelTalie.TabIndex = 27;
            this.labelTalie.Text = "Talie:";
            // 
            // labelRasa
            // 
            this.labelRasa.AutoSize = true;
            this.labelRasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRasa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelRasa.Location = new System.Drawing.Point(833, 47);
            this.labelRasa.Name = "labelRasa";
            this.labelRasa.Size = new System.Drawing.Size(63, 25);
            this.labelRasa.TabIndex = 26;
            this.labelRasa.Text = "Rasa:";
            // 
            // labelPetName
            // 
            this.labelPetName.AutoSize = true;
            this.labelPetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPetName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPetName.Location = new System.Drawing.Point(246, 43);
            this.labelPetName.Name = "labelPetName";
            this.labelPetName.Size = new System.Drawing.Size(70, 25);
            this.labelPetName.TabIndex = 25;
            this.labelPetName.Text = "Nume:";
            // 
            // textBoxRasa
            // 
            this.textBoxRasa.Location = new System.Drawing.Point(838, 84);
            this.textBoxRasa.Name = "textBoxRasa";
            this.textBoxRasa.Size = new System.Drawing.Size(246, 26);
            this.textBoxRasa.TabIndex = 23;
            // 
            // textBoxObservatii
            // 
            this.textBoxObservatii.Location = new System.Drawing.Point(251, 255);
            this.textBoxObservatii.Multiline = true;
            this.textBoxObservatii.Name = "textBoxObservatii";
            this.textBoxObservatii.Size = new System.Drawing.Size(833, 138);
            this.textBoxObservatii.TabIndex = 22;
            // 
            // textBoxTalie
            // 
            this.textBoxTalie.Location = new System.Drawing.Point(544, 84);
            this.textBoxTalie.Name = "textBoxTalie";
            this.textBoxTalie.Size = new System.Drawing.Size(246, 26);
            this.textBoxTalie.TabIndex = 21;
            // 
            // textBoxPetName
            // 
            this.textBoxPetName.Location = new System.Drawing.Point(251, 84);
            this.textBoxPetName.Name = "textBoxPetName";
            this.textBoxPetName.Size = new System.Drawing.Size(246, 26);
            this.textBoxPetName.TabIndex = 20;
            // 
            // buttonAddPet
            // 
            this.buttonAddPet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.buttonAddPet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddPet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.buttonAddPet.FlatAppearance.BorderSize = 0;
            this.buttonAddPet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddPet.ForeColor = System.Drawing.Color.White;
            this.buttonAddPet.Location = new System.Drawing.Point(625, 417);
            this.buttonAddPet.Name = "buttonAddPet";
            this.buttonAddPet.Size = new System.Drawing.Size(94, 45);
            this.buttonAddPet.TabIndex = 18;
            this.buttonAddPet.Text = "Add";
            this.buttonAddPet.UseVisualStyleBackColor = false;
            this.buttonAddPet.Click += new System.EventHandler(this.buttonAddPet_Click);
            // 
            // labelAddClient
            // 
            this.labelAddClient.AutoSize = true;
            this.labelAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAddClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.labelAddClient.Location = new System.Drawing.Point(22, 23);
            this.labelAddClient.Name = "labelAddClient";
            this.labelAddClient.Size = new System.Drawing.Size(97, 26);
            this.labelAddClient.TabIndex = 0;
            this.labelAddClient.Text = "Add Pet";
            // 
            // tabPageSearchPet
            // 
            this.tabPageSearchPet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(222)))), ((int)(((byte)(195)))));
            this.tabPageSearchPet.Controls.Add(this.label11);
            this.tabPageSearchPet.Controls.Add(this.textBox10);
            this.tabPageSearchPet.Controls.Add(this.dataGridViewPet);
            this.tabPageSearchPet.Controls.Add(this.buttonSearch);
            this.tabPageSearchPet.Controls.Add(this.label8);
            this.tabPageSearchPet.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchPet.Name = "tabPageSearchPet";
            this.tabPageSearchPet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchPet.Size = new System.Drawing.Size(1334, 493);
            this.tabPageSearchPet.TabIndex = 1;
            this.tabPageSearchPet.Text = "Search Pet";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(530, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 25);
            this.label11.TabIndex = 69;
            this.label11.Text = "Nume:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(534, 114);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(266, 26);
            this.textBox10.TabIndex = 68;
            // 
            // dataGridViewPet
            // 
            this.dataGridViewPet.AllowUserToAddRows = false;
            this.dataGridViewPet.AllowUserToDeleteRows = false;
            this.dataGridViewPet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewPet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPet.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPet.Location = new System.Drawing.Point(237, 207);
            this.dataGridViewPet.Name = "dataGridViewPet";
            this.dataGridViewPet.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPet.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewPet.RowHeadersWidth = 62;
            this.dataGridViewPet.RowTemplate.Height = 28;
            this.dataGridViewPet.Size = new System.Drawing.Size(863, 182);
            this.dataGridViewPet.TabIndex = 28;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(610, 413);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(117, 45);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(159)))), ((int)(((byte)(115)))));
            this.label8.Location = new System.Drawing.Point(16, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "Search Pet";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Proiect_II.Properties.Resources.dog_hug;
            this.pictureBox1.Location = new System.Drawing.Point(1203, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // UserControlPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(222)))), ((int)(((byte)(195)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControlPet);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlPet";
            this.Size = new System.Drawing.Size(1476, 630);
            this.tabControlPet.ResumeLayout(false);
            this.tabPageAddPet.ResumeLayout(false);
            this.tabPageAddPet.PerformLayout();
            this.tabPageSearchPet.ResumeLayout(false);
            this.tabPageSearchPet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlPet;
        private System.Windows.Forms.TabPage tabPageAddPet;
        private System.Windows.Forms.Label labelAddClient;
        private System.Windows.Forms.TabPage tabPageSearchPet;
        private System.Windows.Forms.DataGridView dataGridViewPet;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.ComboBox comboBoxTipCazare;
        private System.Windows.Forms.Label labelObservatii;
        private System.Windows.Forms.Label labelTalie;
        private System.Windows.Forms.Label labelRasa;
        private System.Windows.Forms.Label labelPetName;
        private System.Windows.Forms.TextBox textBoxRasa;
        private System.Windows.Forms.TextBox textBoxObservatii;
        private System.Windows.Forms.TextBox textBoxTalie;
        private System.Windows.Forms.TextBox textBoxPetName;
        private System.Windows.Forms.Button buttonAddPet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTipHrana;
    }
}
