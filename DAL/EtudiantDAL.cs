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
   public class EtudiantDAL
    {

       #region Methode insert

       public void Etudiantinsert(EtudiantBLL ed)
       {
           using (SqlConnection cnx = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Naturelle\Desktop\IUC\PAM2\MULTICOUCHE\Normale_TIPAM2\DAL\StudentDB.mdf;Integrated Security=True"))
           // using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
           {

               cnx.Open();
               string query = "INSERT INTO Students (nom,prenom,matricule,sexe,date,classe,status,photo) VALUES (@nom,@prenom,@matricule,@sexe,@date,@classe,@status,@photo)";
               SqlCommand cmd = new SqlCommand(query, cnx);
               cmd.Parameters.AddWithValue("@nom", ed.nom);
               cmd.Parameters.AddWithValue("@prenom", ed.prenom);
               cmd.Parameters.AddWithValue("@matricule", ed.matricule);
               cmd.Parameters.AddWithValue("@sexe", ed.sexe);
               cmd.Parameters.AddWithValue("@date", ed.date);
               cmd.Parameters.AddWithValue("@classe", ed.classe);
               cmd.Parameters.AddWithValue("@status", ed.status);
               cmd.Parameters.AddWithValue("@photo", ed.photo);
               cmd.ExecuteNonQuery();
           }

       }
       #endregion
       #region Methode Select

       public DataTable EtudiantSelect(EtudiantBLL ed)
       {
           DataTable dt = new DataTable();
           using (SqlConnection cnx = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Naturelle\Desktop\IUC\PAM2\MULTICOUCHE\Normale_TIPAM2\DAL\StudentDB.mdf;Integrated Security=True"))
           // using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
           {

               cnx.Open();
               string query = " SELECT * FROM students ORDER BY nom ASC ";
               SqlCommand cmd = new SqlCommand(query, cnx);
               SqlDataAdapter da = new SqlDataAdapter(cmd);
               da.Fill(dt);

           }
           return dt;

       }
       #endregion
       #region existetudiant
       public bool etudiantexiste(EtudiantBLL ed)
       {
           if (ed == null || string.IsNullOrEmpty(ed.nom))
           {
               return false;
           }
           //using (SqlConnection cn= new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
           using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Naturelle\Desktop\IUC\PAM2\MULTICOUCHE\Normale_TIPAM2\DAL\StudentDB.mdf;Integrated Security=True"))
           {
               cn.Open();
               string query = " SELECT COUNT(*) FROM  [students] WHERE nom=@nom";
               SqlCommand cmd = new SqlCommand(query, cn);
               cmd.Parameters.AddWithValue("@nom", ed.nom);
               // execute scalar permet de retourner le nombre de fois que la requete est verifier
               int n = (int)cmd.ExecuteScalar();
               return n > 0;
           }
       }
       #endregion
    }
}
