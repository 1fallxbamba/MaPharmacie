using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Net.Mail;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace MaPharmacie
{
    public partial class newCredentialsForm : Form
    {
        public newCredentialsForm()
        {
            InitializeComponent();
        }

        private void AskCredentialsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {

            if (textBoxPhcyName.Text.Length == 0)
            {
                MessageBox.Show("La case 'Nom de pharmacie' ne peut pas être vide", "Réessayer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxAddress.Text.Length == 0)
            {
                MessageBox.Show("La case 'Adresse' ne peut pas être vide", "Réessayer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxNumber.Text.Length == 0)
            {
                MessageBox.Show("La case 'Numéro de téléphone' ne peut pas être vide", "Réessayer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxNewUsername.Text.Length == 0)
            {
                MessageBox.Show("La case 'Nom d'utilisateur' ne peut pas être vide", "Réessayer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxNewPass.Text.Length == 0)
            {
                MessageBox.Show("La case 'Mot de passe' ne peut pas être vide", "Réessayer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (MessageBox.Show("Valider l'envoi du formulaire ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string number = textBox221.Text + textBoxNumber.Text;

                    var pwdbytes = Encoding.UTF8.GetBytes(textBoxNewPass.Text);

                    string pwd = Convert.ToBase64String(pwdbytes);

               

                    MySql.Data.MySqlClient.MySqlDataReader mySqlReader = null;
                                        
                    MySql.Data.MySqlClient.MySqlConnection mySqlConnexion;

                    string myConnectionString;
                    myConnectionString = "server=127.0.0.1; uid=root; pwd=; database=pharmacydb";

                    mySqlConnexion = new MySql.Data.MySqlClient.MySqlConnection();

                    mySqlConnexion.ConnectionString = myConnectionString;

                    string mySqlQuery = "INSERT INTO pharmacies (p_Username, p_Name, p_Location, p_Number) VALUES ('" + textBoxNewUsername.Text + "' , '" + textBoxPhcyName.Text + "' , '" + textBoxAddress.Text + "' , '" + number + "' )";

                    string mysSqlQuery2 = "INSERT INTO users (Username, Password) VALUES ('" + textBoxNewUsername.Text.Trim() + "', '" + pwd + "')";

                    string mySqlQuery3 = "SELECT * FROM pharmacies WHERE p_Username= '" + textBoxNewUsername.Text + "' ";
                                        
                    MySql.Data.MySqlClient.MySqlCommand mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand(mySqlQuery, mySqlConnexion);

                    MySql.Data.MySqlClient.MySqlCommand mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand(mysSqlQuery2, mySqlConnexion);

                    MySql.Data.MySqlClient.MySqlCommand mySqlCommand3 = new MySql.Data.MySqlClient.MySqlCommand(mySqlQuery3, mySqlConnexion);
                                        
                    try
                    {

                        mySqlConnexion.Open();

                        mySqlReader = mySqlCommand3.ExecuteReader();
                                                
                        if (mySqlReader.Read())
                        {
                            MessageBox.Show("Ce nom d'utilisateur existe déjà !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                        else
                        {

                            mySqlReader.Close();

                            mySqlCommand.ExecuteNonQuery();

                            mySqlCommand2.ExecuteNonQuery();

                            MessageBox.Show("Nouvel utilisateur créé pour " + textBoxPhcyName.Text + ".\nVous pouvez maintenant vous connecter !", "Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            string fileNamedebut = @"C:\Users\";
                            string fileNamemiddle = fileNamedebut + Environment.UserName;
                            string fullFileName = fileNamemiddle + @"\AppData\Local\alreadyHasCredentials.txt";

                            Byte[] fileContent = new UTF8Encoding(true).GetBytes("T R U E");

                            FileStream fileStream = File.Create(fullFileName);

                            fileStream.Write(fileContent, 0, fileContent.Length);

                            File.SetAttributes(fullFileName, FileAttributes.Hidden);

                            fileStream.Dispose();

                            this.Hide();

                            debutForm.DebutInstance.Show();

                        }

                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {

                        MessageBox.Show("Erreur : " + ex.Message);

                    }


                }

            }

        }

        private void AskCredentialsForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TextBoxPhcyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();

            debutForm.DebutInstance.Show();

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void CheckBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxShowPass.Checked == true)
            {
                textBoxNewPass.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxNewPass.UseSystemPasswordChar = true;
            }

        }
    }
}
