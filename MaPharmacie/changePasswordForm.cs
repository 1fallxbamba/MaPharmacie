using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaPharmacie
{
    public partial class changePasswordForm : Form
    {
        public changePasswordForm()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

            MySql.Data.MySqlClient.MySqlDataReader mySqlReader = null;
            MySql.Data.MySqlClient.MySqlDataReader mySqlReader2 = null;

            MySql.Data.MySqlClient.MySqlConnection mySqlConnexion;

            string myConnectionString;
            myConnectionString = "server=127.0.0.1; uid=root; pwd=; database=pharmacydb";

            mySqlConnexion = new MySql.Data.MySqlClient.MySqlConnection();

            mySqlConnexion.ConnectionString = myConnectionString;

            if (textBoxUsername.Text.Length == 0)
            {
                MessageBox.Show("La case 'Nom d'utilisateur' ne peut pas être vide", "Réessayer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxCurrentPass.Text.Length == 0)
            {
                MessageBox.Show("La case 'Mot de passe par défaut' ne peut pas être vide", "Réessayer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxNewPass.Text.Length == 0)
            {
                MessageBox.Show("La case 'Nouveau mot de passe' ne peut pas être vide", "Réessayer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxConfirm.Text.Length == 0)
            {
                MessageBox.Show("La case 'Confirmer le mot de passe' ne peut pas être vide", "Réessayer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                mySqlConnexion.Open();

                var pwdbytes = Encoding.UTF8.GetBytes(textBoxCurrentPass.Text);
                var pwdbytes2 = Encoding.UTF8.GetBytes(textBoxNewPass.Text);


                string pwd1 = Convert.ToBase64String(pwdbytes);
                string pwd2 = Convert.ToBase64String(pwdbytes2);

                string mySqlQuery = "SELECT * FROM users WHERE Password = '" + pwd1 + "' ";

                MySql.Data.MySqlClient.MySqlCommand mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand(mySqlQuery, mySqlConnexion);

                mySqlReader = mySqlCommand.ExecuteReader();

                if (mySqlReader.Read())
                {

                    mySqlReader.Close();

                    string mySqlQuery2 = "SELECT * FROM users WHERE Username= '" + textBoxUsername.Text + "' ";

                    MySql.Data.MySqlClient.MySqlCommand mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand(mySqlQuery2, mySqlConnexion);

                    mySqlReader2 = mySqlCommand2.ExecuteReader();

                    if (mySqlReader2.Read())
                    {

                        if (textBoxNewPass.Text != textBoxConfirm.Text)
                        {
                            MessageBox.Show("Les nouveaux mots de passe ne correspondent pas, veuillez revérifier !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        else
                        {

                            mySqlQuery = "UPDATE users SET Password='" + pwd2 + "' WHERE Password = '" + pwd1 + "' AND Username= '" + textBoxUsername.Text + "' ";

                            mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand(mySqlQuery, mySqlConnexion);

                            mySqlReader2.Close();


                            if (mySqlCommand.ExecuteNonQuery() == 0)
                            {
                                MessageBox.Show("Le nom d'utilisateur que vous avez entré ne correspond pas au mot de passe que vous avez entré ! Veuillez réessayer", "Entrez un mot de passe valide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Mot de passe mis à jour ! Vous pouvez maintenant vous reconnecter", "Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Close();

                                debutForm.DebutInstance.Show();
                            }

                            

                        }

                    }
                    else
                    {
                        MessageBox.Show("Ce nom d'utilisateur n'existe pas !", "Utilisateur inexistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    MessageBox.Show("L'ancien mot de passe que vous avez entré est incorrect !", "Mot de passe par actuel incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void ChangePasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            if(checkBox1.Checked == true)
            {

                textBoxCurrentPass.UseSystemPasswordChar = false;
                textBoxNewPass.UseSystemPasswordChar = false;
                textBoxConfirm.UseSystemPasswordChar = false;

            }
            else
            {

                textBoxCurrentPass.UseSystemPasswordChar = true;
                textBoxNewPass.UseSystemPasswordChar = true;
                textBoxConfirm.UseSystemPasswordChar = true;

            }

            
        }

        private void TextBoxConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();

            debutForm.DebutInstance.Show();
        }
    }
}
