using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;


namespace DAL
{
    class Cryptography
    {
        public static string Encrypter(String textedeCryptage)
        {
            string EncryptionKey = "tipam2@2023xxxxxxxxxx237doualalogbessouiuc";
            //convertit la chaine de texte en tableau d'otects en utilisant l'encodage unicode
            byte[] clearBytes = Encoding.Unicode.GetBytes(textedeCryptage);
            //creer un nouvel objet AES(Advanced Encryption Standard)  pour le chiffrement
            using (Aes encryptor = Aes.Create())
            {
                //definit la cle de chiffrement en decrivant une cle a partir de la cle principale
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[]{
                            0x49,0x76,0x61,0x6e,0x20,0x4d,0x65,0x64,0x76,0x65,0x64,0x65,0x76
                        });
                encryptor.Key = pdb.GetBytes(32);// Definit la cle (256 bits)
                encryptor.IV = pdb.GetBytes(16);// definit le vecteur d'initialisation(IV)(128 bits)
                //utilise un  MemoryStream pour stocker les donnees chiffrees
                using (MemoryStream ms = new MemoryStream())
                {
                    //creer un CryptoStream pour effectuer le chiffrement 
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        // ecrit les donnees claires dans le CryptoStream pour chiffrer
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    // Convertit les donnees chiffrees en une chaine Base64 et la renvoie 
                    textedeCryptage = Convert.ToBase64String(ms.ToArray());
                }

            }
            return textedeCryptage;
        }
        public static string Decrypter(string texteCrypte)
        {
            ///Cle de chiffrement (devrait etre idententique a celle utilisee pour le chiffrement)
            string EncryptionKey = "tipam2@2023xxxxxxxxxx237doualalogbessouiuc";
            //Nous pouvons changer la cle de chiffrement selon nos besoins mais la cle de chiffrement doit etre identique a la cle de chiffrement
            //Remplace les espaces dans la chaine chiffree par le caractere '+'(pour decodage Base64)
            texteCrypte = texteCrypte.Replace(" ", "+");
            //Convertit la chaine chiffree en tableau d'octets en utilisant Base64
            byte[] cipherBytes = Convert.FromBase64String(texteCrypte);
            //Cree un nouvel objet AES (Advanced Encryption Standard) pour le dechiffrement
            using (Aes encryptor = Aes.Create())
            {
                //definit la cle de dechiffrement en decrivant une cle a partir de la cle principale
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[]{
                     0x49,0x76,0x61,0x6e,0x20,0x4d,0x65,0x64,0x76,0x65,0x64,0x65,0x76
                });
                encryptor.Key = pdb.GetBytes(32);//Definit la cle (256 bits)
                encryptor.IV = pdb.GetBytes(16);// Definit le vecteur d'initialisation (IV)(128 bits)
                //Utilise un MemoryStream pour stocker les donnees dechiffrees
                using (MemoryStream ms = new MemoryStream())
                {
                    //creer un CryptoStream pour effectuer le dechiffrement
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        // Ecrit les donnees chiffrees dans le CryptoStream pour les dechiffrer
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    //Convertit les donnes dechiffrees en une chaine en uilisant l'encodage Unicode et la renvoie
                    texteCrypte = Encoding.Unicode.GetString(ms.ToArray());
                }
                return texteCrypte;
            }

        }
    }
}
