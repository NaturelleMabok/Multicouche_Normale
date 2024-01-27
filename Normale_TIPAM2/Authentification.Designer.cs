namespace Normale_TIPAM2
{
    partial class Authentification
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMotdepasse = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnConnecter = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEffacer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCreerCompte = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(368, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiez Vous";
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
            this.txtNom.Location = new System.Drawing.Point(470, 130);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNom.PlaceholderText = "entrer votre nom";
            this.txtNom.SelectedText = "";
            this.txtNom.Size = new System.Drawing.Size(389, 53);
            this.txtNom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom d\'utilisateur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 56);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mot de passe\r\n\r\n";
            // 
            // txtMotdepasse
            // 
            this.txtMotdepasse.BorderRadius = 10;
            this.txtMotdepasse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMotdepasse.DefaultText = "";
            this.txtMotdepasse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMotdepasse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMotdepasse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMotdepasse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMotdepasse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMotdepasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtMotdepasse.ForeColor = System.Drawing.Color.Black;
            this.txtMotdepasse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMotdepasse.Location = new System.Drawing.Point(470, 234);
            this.txtMotdepasse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMotdepasse.Name = "txtMotdepasse";
            this.txtMotdepasse.PasswordChar = '.';
            this.txtMotdepasse.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtMotdepasse.PlaceholderText = "entrer votre mot de passe";
            this.txtMotdepasse.SelectedText = "";
            this.txtMotdepasse.Size = new System.Drawing.Size(389, 53);
            this.txtMotdepasse.TabIndex = 1;
            // 
            // btnConnecter
            // 
            this.btnConnecter.BorderRadius = 10;
            this.btnConnecter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConnecter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConnecter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConnecter.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConnecter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConnecter.FillColor = System.Drawing.Color.DarkBlue;
            this.btnConnecter.FillColor2 = System.Drawing.Color.Blue;
            this.btnConnecter.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnConnecter.ForeColor = System.Drawing.Color.White;
            this.btnConnecter.Location = new System.Drawing.Point(48, 449);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(249, 45);
            this.btnConnecter.TabIndex = 3;
            this.btnConnecter.Text = "Connecter";
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.BorderRadius = 10;
            this.btnEffacer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEffacer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEffacer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEffacer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEffacer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEffacer.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEffacer.FillColor2 = System.Drawing.Color.Blue;
            this.btnEffacer.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnEffacer.ForeColor = System.Drawing.Color.White;
            this.btnEffacer.Location = new System.Drawing.Point(377, 449);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(249, 45);
            this.btnEffacer.TabIndex = 3;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnCreerCompte
            // 
            this.btnCreerCompte.BorderRadius = 10;
            this.btnCreerCompte.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreerCompte.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreerCompte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreerCompte.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreerCompte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreerCompte.FillColor = System.Drawing.Color.MediumBlue;
            this.btnCreerCompte.FillColor2 = System.Drawing.Color.Blue;
            this.btnCreerCompte.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCreerCompte.ForeColor = System.Drawing.Color.White;
            this.btnCreerCompte.Location = new System.Drawing.Point(684, 449);
            this.btnCreerCompte.Name = "btnCreerCompte";
            this.btnCreerCompte.Size = new System.Drawing.Size(249, 45);
            this.btnCreerCompte.TabIndex = 3;
            this.btnCreerCompte.Text = "Creer un compte";
            this.btnCreerCompte.Click += new System.EventHandler(this.btnCreerCompte_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btnCreerCompte);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.btnEffacer);
            this.guna2Panel1.Controls.Add(this.txtNom);
            this.guna2Panel1.Controls.Add(this.btnConnecter);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.txtMotdepasse);
            this.guna2Panel1.Location = new System.Drawing.Point(43, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1064, 544);
            this.guna2Panel1.TabIndex = 4;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 568);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Authentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtMotdepasse;
        private Guna.UI2.WinForms.Guna2GradientButton btnConnecter;
        private Guna.UI2.WinForms.Guna2GradientButton btnEffacer;
        private Guna.UI2.WinForms.Guna2GradientButton btnCreerCompte;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}

