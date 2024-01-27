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
    public partial class CreerCompte : Form
    {
        UserBLL ub = new UserBLL();
        UserDAL ud = new UserDAL();
        public CreerCompte()
        {
            InitializeComponent();
        }
        public void clearFrom()
        {
            txtNom.Text = string.Empty;
            txtConfirm.Text = string.Empty;
            txtMotdepasse.Text = string.Empty;
        }

        private void btnCreerCompte_Click(object sender, EventArgs e)
        {
            ub.nom = txtNom.Text;
            ub.motdepasse = txtMotdepasse.Text;

            if (string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtMotdepasse.Text) || string.IsNullOrEmpty(txtConfirm.Text))
            {
                MessageBox.Show("Tout les champs ne sont pas correctement remplie", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMotdepasse.Text != txtConfirm.Text)
            {
                MessageBox.Show("Les mots de passe ne sont pas identiques", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool userExist = ud.userexiste(ub);
                //MessageBox.Show(""+userExist);
                if (userExist == true)
                {
                    //int req = da.userinsert(usr);
                    //MessageBox.Show("" + req);
                    MessageBox.Show("Ce nom d'utilisateur existe deja dans la base de donnes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ud.userinsert(ub);
                    clearFrom();
                    //MessageBox.Show(""+req);
                    MessageBox.Show("votre Compte a ete creer avec success", "Nouveau Compte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }

            }
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            Authentification au = new Authentification();
            au.Show();
        }

        private void CreerCompte_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        #region LoadData
        private void LoadData()
        {
            try
            {
                
                DataTable dt = ud.UserSelect(ub);
                //trier le datatable par l'id(USERId) de la plus petite a la plus grande
                DataView dv = dt.DefaultView;
                dv.Sort = "ID ASC";
                DataTable sorteDt = dv.ToTable();
                //assurer vous que la datagridview  existe deja dans votre code
                dgvu.Rows.Clear();
                foreach (DataRow item in sorteDt.Rows)
                {
                    int n = dgvu.Rows.Add();
                    dgvu.Rows[n].Cells["dvgId"].Value = item["Id"].ToString();

                    dgvu.Rows[n].Cells["dgvNom"].Value = item["username"].ToString();
                    dgvu.Rows[n].Cells["dvgPassword"].Value = item["password"].ToString();
                   
                   


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur lors du chargement des donnes " + ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion
    }
}
