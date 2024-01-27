using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UserDAL
    {
        #region insertutilisateur
        //methode permettant de creer un nouveau compte
        public void userinsert(UserBLL usr)
        {
            //using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Naturelle\Desktop\IUC\PAM2\MULTICOUCHE\Normale_TIPAM2\DAL\StudentDB.mdf;Integrated Security=True"))
            {
                cn.Open();
                string query = " INSERT INTO [users] (username,password) VALUES (@username,@password)";
                SqlCommand cmd = new SqlCommand(query, cn);
                // on encrypte le mot de passe avant de stocker dans la base de donne
                string password = Cryptography.Encrypter(usr.motdepasse);
                cmd.Parameters.AddWithValue("@username", usr.nom);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();

            }
        }
        #endregion

        #region existUser
        public bool userexiste(UserBLL usr)
        {
            if (usr == null || string.IsNullOrEmpty(usr.nom))
            {
                return false;
            }
            //using (SqlConnection cn= new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Naturelle\Desktop\IUC\PAM2\MULTICOUCHE\Normale_TIPAM2\DAL\StudentDB.mdf;Integrated Security=True"))
            {
                cn.Open();
                string query = " SELECT COUNT(*) FROM  [users] WHERE username=@username";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@username", usr.nom);
                // execute scalar permet de retourner le nombre de fois que la requete est verifier
                int n = (int)cmd.ExecuteScalar();
                return n > 0;
            }
        }
        #endregion

        #region connectUser
        public bool loginUser(UserBLL usr)
        {
            //using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Naturelle\Desktop\IUC\PAM2\MULTICOUCHE\Normale_TIPAM2\DAL\StudentDB.mdf;Integrated Security=True"))
            {
                cn.Open();
                string query = " SELECT password FROM  [users] WHERE username=@username";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@username", usr.nom);
                //cmd.Parameters.AddWithValue("@password", usr.password);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //reecuperation du mot de passe dans la BD
                    string bdpassword = reader.GetString(0);
                    // decriptage du mot de passe de la bd
                    string getPassword = Cryptography.Decrypter(bdpassword);
                    //comparaison entre le mot de passe de la bd decrypter et le mot de passe entrer par l'utilisateur
                    if (getPassword == usr.motdepasse)
                    {
                        return true;
                    }
                }

            }
            return false;
        }


        #endregion
        #region selectUser
        public DataTable UserSelect(UserBLL usr)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Naturelle\Desktop\IUC\PAM2\MULTICOUCHE\Normale_TIPAM2\DAL\StudentDB.mdf;Integrated Security=True"))
                {
                    cn.Open();
                    string query = "select * from users order by username ASC";
                    using (SqlCommand cmd = new SqlCommand(query, cn))

                    using (SqlDataAdapter sdap = new SqlDataAdapter(cmd))
                    {
                        sdap.Fill(dt);
                    }
                }


            }
            catch (SqlException ex)
            {
                throw new Exception("Erreur lors de la recuperation des utilisateurs", ex);
            }
            return dt;

        }
        #endregion
    }
}
