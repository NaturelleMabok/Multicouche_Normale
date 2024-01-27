using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace Normale_TIPAM2
{
    public partial class Authentification : Form
    {

        UserBLL ub = new UserBLL();
        UserDAL ud = new UserDAL();

        public Authentification()
        {
            InitializeComponent();
        }
        public void clearFrom()
        {
            txtNom.Text = string.Empty;
            txtMotdepasse.Text = string.Empty;
        }

        private void btnCreerCompte_Click(object sender, EventArgs e)
        {
            CreerCompte cc = new CreerCompte();
            cc.Show();
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            ub.nom = txtNom.Text;
            ub.motdepasse = txtMotdepasse.Text;

            bool verify = ud.loginUser(ub);
            //MessageBox.Show(""+verify);
            if (verify == true)
            {
                MessageBox.Show("Connection bien Etablie", "CONNEXION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                EnregistrerEtudiant ee= new EnregistrerEtudiant();
                ee.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect", "CONNEXION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtMotdepasse.Text = string.Empty;
            txtNom.Text = string.Empty;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
