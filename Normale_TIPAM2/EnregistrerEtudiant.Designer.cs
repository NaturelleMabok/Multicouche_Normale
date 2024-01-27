namespace Normale_TIPAM2
{
    partial class EnregistrerEtudiant
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPacourir = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dtp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbPension = new System.Windows.Forms.ComboBox();
            this.cmbSexe = new System.Windows.Forms.ComboBox();
            this.txtClasse = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMatricule = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrenom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbUser = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dgvEtu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMatricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEnregistrer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtu)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnPacourir);
            this.guna2Panel1.Controls.Add(this.dtp);
            this.guna2Panel1.Controls.Add(this.cmbPension);
            this.guna2Panel1.Controls.Add(this.cmbSexe);
            this.guna2Panel1.Controls.Add(this.txtClasse);
            this.guna2Panel1.Controls.Add(this.txtMatricule);
            this.guna2Panel1.Controls.Add(this.txtPrenom);
            this.guna2Panel1.Controls.Add(this.txtNom);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.pbUser);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(622, 830);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btnPacourir
            // 
            this.btnPacourir.BorderRadius = 10;
            this.btnPacourir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPacourir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPacourir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPacourir.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPacourir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPacourir.FillColor = System.Drawing.Color.DarkBlue;
            this.btnPacourir.FillColor2 = System.Drawing.Color.Blue;
            this.btnPacourir.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPacourir.ForeColor = System.Drawing.Color.White;
            this.btnPacourir.Location = new System.Drawing.Point(0, 247);
            this.btnPacourir.Name = "btnPacourir";
            this.btnPacourir.Size = new System.Drawing.Size(203, 45);
            this.btnPacourir.TabIndex = 7;
            this.btnPacourir.Text = "Pacourir";
            this.btnPacourir.Click += new System.EventHandler(this.btnPacourir_Click);
            // 
            // dtp
            // 
            this.dtp.BorderRadius = 10;
            this.dtp.Checked = true;
            this.dtp.FillColor = System.Drawing.Color.Gray;
            this.dtp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp.Location = new System.Drawing.Point(250, 513);
            this.dtp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(361, 36);
            this.dtp.TabIndex = 4;
            this.dtp.Value = new System.DateTime(2024, 1, 26, 9, 3, 31, 963);
            // 
            // cmbPension
            // 
            this.cmbPension.FormattingEnabled = true;
            this.cmbPension.Items.AddRange(new object[] {
            "soldé",
            "non solde"});
            this.cmbPension.Location = new System.Drawing.Point(250, 781);
            this.cmbPension.Name = "cmbPension";
            this.cmbPension.Size = new System.Drawing.Size(279, 24);
            this.cmbPension.TabIndex = 3;
            // 
            // cmbSexe
            // 
            this.cmbSexe.FormattingEnabled = true;
            this.cmbSexe.Items.AddRange(new object[] {
            "Feminin",
            "Masculin"});
            this.cmbSexe.Location = new System.Drawing.Point(250, 438);
            this.cmbSexe.Name = "cmbSexe";
            this.cmbSexe.Size = new System.Drawing.Size(279, 24);
            this.cmbSexe.TabIndex = 3;
            // 
            // txtClasse
            // 
            this.txtClasse.BorderRadius = 10;
            this.txtClasse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClasse.DefaultText = "";
            this.txtClasse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClasse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClasse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClasse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClasse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtClasse.ForeColor = System.Drawing.Color.Black;
            this.txtClasse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClasse.Location = new System.Drawing.Point(233, 648);
            this.txtClasse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.PasswordChar = '\0';
            this.txtClasse.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtClasse.PlaceholderText = "entrer la classe";
            this.txtClasse.SelectedText = "";
            this.txtClasse.Size = new System.Drawing.Size(361, 53);
            this.txtClasse.TabIndex = 2;
            this.txtClasse.TextChanged += new System.EventHandler(this.guna2TextBox4_TextChanged);
            // 
            // txtMatricule
            // 
            this.txtMatricule.BorderRadius = 10;
            this.txtMatricule.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatricule.DefaultText = "";
            this.txtMatricule.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatricule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatricule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatricule.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatricule.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtMatricule.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatricule.Location = new System.Drawing.Point(250, 338);
            this.txtMatricule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.PasswordChar = '\0';
            this.txtMatricule.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtMatricule.PlaceholderText = "entrer le maticule";
            this.txtMatricule.SelectedText = "";
            this.txtMatricule.Size = new System.Drawing.Size(361, 53);
            this.txtMatricule.TabIndex = 2;
            // 
            // txtPrenom
            // 
            this.txtPrenom.BorderRadius = 10;
            this.txtPrenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrenom.DefaultText = "";
            this.txtPrenom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrenom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrenom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrenom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrenom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtPrenom.ForeColor = System.Drawing.Color.Black;
            this.txtPrenom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrenom.Location = new System.Drawing.Point(250, 209);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.PasswordChar = '\0';
            this.txtPrenom.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtPrenom.PlaceholderText = "entrer le prenom";
            this.txtPrenom.SelectedText = "";
            this.txtPrenom.Size = new System.Drawing.Size(361, 53);
            this.txtPrenom.TabIndex = 2;
            // 
            // txtNom
            // 
            this.txtNom.BorderRadius = 10;
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNom.DefaultText = "";
            this.txtNom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtNom.ForeColor = System.Drawing.Color.Black;
            this.txtNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNom.Location = new System.Drawing.Point(250, 71);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNom.PlaceholderText = "entrer le nom";
            this.txtNom.SelectedText = "";
            this.txtNom.Size = new System.Drawing.Size(361, 53);
            this.txtNom.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date de naissance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(245, 726);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "Status pension";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(245, 582);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Classe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sexe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Matricule IUC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom de l\'etudiant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom de l\'etudiant";
            // 
            // pbUser
            // 
            this.pbUser.BorderRadius = 10;
            this.pbUser.ImageRotate = 0F;
            this.pbUser.Location = new System.Drawing.Point(16, 22);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(199, 184);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 0;
            this.pbUser.TabStop = false;
            // 
            // dgvEtu
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvEtu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEtu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEtu.ColumnHeadersHeight = 19;
            this.dgvEtu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEtu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvN,
            this.dgvNom,
            this.dgvPrenom,
            this.dgvMatricule,
            this.dgvSexe,
            this.dgvDate,
            this.dgvClasse,
            this.dgvStatus,
            this.dgvPhoto});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEtu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEtu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEtu.Location = new System.Drawing.Point(631, 12);
            this.dgvEtu.Name = "dgvEtu";
            this.dgvEtu.RowHeadersVisible = false;
            this.dgvEtu.RowTemplate.Height = 24;
            this.dgvEtu.Size = new System.Drawing.Size(842, 737);
            this.dgvEtu.TabIndex = 1;
            this.dgvEtu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEtu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEtu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEtu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEtu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEtu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEtu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEtu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvEtu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEtu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEtu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEtu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEtu.ThemeStyle.HeaderStyle.Height = 19;
            this.dgvEtu.ThemeStyle.ReadOnly = false;
            this.dgvEtu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEtu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEtu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEtu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEtu.ThemeStyle.RowsStyle.Height = 24;
            this.dgvEtu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEtu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dgvN
            // 
            this.dgvN.HeaderText = "N";
            this.dgvN.Name = "dgvN";
            // 
            // dgvNom
            // 
            this.dgvNom.HeaderText = "Nom";
            this.dgvNom.Name = "dgvNom";
            // 
            // dgvPrenom
            // 
            this.dgvPrenom.HeaderText = "Prenom";
            this.dgvPrenom.Name = "dgvPrenom";
            // 
            // dgvMatricule
            // 
            this.dgvMatricule.HeaderText = "Matricule";
            this.dgvMatricule.Name = "dgvMatricule";
            // 
            // dgvSexe
            // 
            this.dgvSexe.HeaderText = "Sexe";
            this.dgvSexe.Name = "dgvSexe";
            // 
            // dgvDate
            // 
            this.dgvDate.HeaderText = "Date";
            this.dgvDate.Name = "dgvDate";
            // 
            // dgvClasse
            // 
            this.dgvClasse.HeaderText = "Classe";
            this.dgvClasse.Name = "dgvClasse";
            // 
            // dgvStatus
            // 
            this.dgvStatus.HeaderText = "status";
            this.dgvStatus.Name = "dgvStatus";
            // 
            // dgvPhoto
            // 
            this.dgvPhoto.HeaderText = "Photo";
            this.dgvPhoto.Name = "dgvPhoto";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BorderRadius = 10;
            this.btnEnregistrer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnregistrer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnregistrer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnregistrer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnregistrer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnregistrer.FillColor = System.Drawing.Color.DarkBlue;
            this.btnEnregistrer.FillColor2 = System.Drawing.Color.Blue;
            this.btnEnregistrer.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(863, 772);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(249, 45);
            this.btnEnregistrer.TabIndex = 6;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // EnregistrerEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 934);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.dgvEtu);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "EnregistrerEtudiant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnregistrerEtudiant";
            this.Load += new System.EventHandler(this.EnregistrerEtudiant_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox pbUser;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp;
        private System.Windows.Forms.ComboBox cmbPension;
        private System.Windows.Forms.ComboBox cmbSexe;
        private Guna.UI2.WinForms.Guna2TextBox txtClasse;
        private Guna.UI2.WinForms.Guna2TextBox txtMatricule;
        private Guna.UI2.WinForms.Guna2TextBox txtPrenom;
        private Guna.UI2.WinForms.Guna2TextBox txtNom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEtu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMatricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStatus;
        private System.Windows.Forms.DataGridViewImageColumn dgvPhoto;
        private Guna.UI2.WinForms.Guna2GradientButton btnPacourir;
        private Guna.UI2.WinForms.Guna2GradientButton btnEnregistrer;
    }
}