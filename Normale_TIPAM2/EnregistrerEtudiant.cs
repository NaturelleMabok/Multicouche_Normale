using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using BLL;
using DAL;

namespace Normale_TIPAM2
{
    public partial class EnregistrerEtudiant : Form
    {
        EtudiantBLL eb = new EtudiantBLL();
        EtudiantDAL ed = new EtudiantDAL();
        public EnregistrerEtudiant()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPacourir_Click(object sender, EventArgs e)
        {
            // creer une nouvelle instance de la classe openFileDialog qui permet a  l'utilisateur de selectionner un fichier a ouvrir
            OpenFileDialog openfiledialog = new OpenFileDialog();
            // definir un filtre pour specifier quel type de fichiers
            openfiledialog.Filter = "Images(*.jpg;*.jpeg;*.png;*.bmp;*gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            //affiche la boite de dialogue de selection de fichier et attend que l'utilisateur fasse son choix
            //si l'utilisateur appuie sur le bouton ok dans la boite de dialogue
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                //charger l'image depuis le fichier selectionner ^par l'utilisateur enc reant une instance  de la classe a partir du chemin  du fichier
                using (Image img = Image.FromFile(openfiledialog.FileName))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        //on peut choisir le format approprie qui permet de stocker l'image
                        ImageFormat imageFormat = ImageFormat.Jpeg;// par defaut nous utlison le format jpeg
                        string fileExtension = Path.GetExtension(openfiledialog.FileName).ToLower();
                        if (fileExtension == ".png")
                        {
                            //le fichier est une image png
                            imageFormat = ImageFormat.Png;

                        }
                        else if (fileExtension == ".bmp")
                        {
                            //le fichier est une image bmp
                            imageFormat = ImageFormat.Bmp;
                        }
                        else if (fileExtension == ".gif")
                        {
                            //le fichier est une image gif
                            imageFormat = ImageFormat.Gif;
                        }
                        // sauvegarder l'image  dans le format choisi dans le memorystream
                        img.Save(ms, imageFormat);
                        //convertir le contenu du memoryStream en un tableau de byte (bytes[]
                        //et l'attribue a la propriete da.photo de userBll
                        eb.photo = ms.ToArray();
                    }
                    pbUser.Image = new Bitmap(openfiledialog.FileName);
                }
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            eb.nom = txtNom.Text;
            eb.prenom = txtPrenom.Text;
            eb.matricule = txtMatricule.Text;
            eb.classe = txtClasse.Text;
            eb.date = DateTime.Parse(dtp.Value.ToString("dd/MM/yyyy"));



            if (string.IsNullOrEmpty(eb.nom) || string.IsNullOrEmpty(eb.classe) || string.IsNullOrEmpty(eb.matricule) || string.IsNullOrEmpty(eb.prenom))
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (eb != null && ed.etudiantexiste(eb))
                {
                    MessageBox.Show("Desole cet etudiant existe deja", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //determination du status 
                    bool sexe = (cmbSexe.SelectedIndex == 0);
                    bool pension = (cmbPension.SelectedIndex == 0);
                    eb.status = pension;
                    eb.sexe = sexe;
                    //appel de la methode d'insertion de l'etudiant
                    try
                    {
                        ed.Etudiantinsert(eb);
                        MessageBox.Show("Etudiant  ajouter avec succes ", "Ajout Produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Desole une erreur s'est produit lors de l'ajout d'un etudiant " + ex, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   // clearForm();
                }
            }

        }
        #region load
        private void LoadData()
         {
             try
             {
                 //appele la methode stockselect pour recuperer les donnees du stock
                 DataTable dt = ed.EtudiantSelect(eb);
                 //trier le datatable par l'id(prodId) de la plus petite a la plus grande
                 DataView dv = dt.DefaultView;
                 dv.Sort = "ID ASC";
                 DataTable sorteDt = dv.ToTable();
                 //assurer vous que la datagridview  existe deja dans votre code
                 dgvEtu.Rows.Clear();
                 foreach (DataRow item in sorteDt.Rows)
                 {
                     int n = dgvEtu.Rows.Add();
                     dgvEtu.Rows[n].Cells["dgvN"].Value = item["Id"].ToString();

                    dgvEtu.Rows[n].Cells["dgvNom"].Value = item["nom"].ToString();
                     dgvEtu.Rows[n].Cells["dgvPrenom"].Value = item["prenom"].ToString();
                  dgvEtu.Rows[n].Cells["dgvMatricule"].Value = item["matricule"].ToString();
                   // Convertir la valeur du sexe en chaine feminin ou masculin
                bool sexe = (bool)item["sexe"];
               dgvEtu.Rows[n].Cells["dgvSexe"].Value = sexe ? "feminin" : "masculin";
            dgvEtu.Rows[n].Cells["dgvDate"].Value = Convert.ToDateTime(item["date"].ToString());
           dgvEtu.Rows[n].Cells["dgvClasse"].Value = item["classe"].ToString();
           // Convertir la valeur du status en chaine soldé ou non solde
                bool status = (bool)item["status"];
               dgvEtu.Rows[n].Cells["dgvStatus"].Value = status ? "soldé" : "non soldé";
                     //recupere les donnes binaires de la colonne photo
                     if (item["photo"] != DBNull.Value)
                     {
                         byte[] photobytes = (byte[])item["photo"];
                         //convertir les donnes bnaires en image
                         using (MemoryStream ms = new MemoryStream(photobytes))
                         {
                             Image originalImage = Image.FromStream(ms);
                             //redimensionner l'image pour correspondre a la taille de la colonne
                             int imageSize = 64;//taille souhaitee de l'image(64*64,par exemple)
                             Image resizedImage = ResizeImage(originalImage, imageSize, imageSize);
                             dgvEtu.Rows[n].Cells["dgvPhoto"].Value = resizedImage;
                         }
                     }


                 }
             }
             catch (Exception ex) {
                 MessageBox.Show("erreur lors du chargement des donnes " + ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }

         }
         #endregion

        #region redimensionner l'image
        // fonction pour redimensionner une image
        private Image ResizeImage(Image sourceImage, int width, int height)
        {
            // creation d'une nouvelle instace de la classe bitmap
            //pour l'image redimensionne avec la largeur et hauteur
            Bitmap resized = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resized))
            {
                // definit  le mode l'interpolationt pour le redimensionnement
                //L'interpolation bicubique de haute qualite produit un resultat lisse
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                // desinne l'image source source (non redimensionne) sur l'image avec les dimension 0,0,width,height
                g.DrawImage(sourceImage, 0, 0, width, height);
            }
            return resized;
        }
        #endregion

        private void EnregistrerEtudiant_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
