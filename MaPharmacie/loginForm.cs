using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Windows.Forms;

namespace MaPharmacie
{
    public partial class loginForm : Form
    {

        public TextBox userText, passText;

        public string userInfo { get; set; }

        private static loginForm _instance;

        public static loginForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new loginForm();
                }

                return _instance;
            }
        }

        public loginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            _instance = this;

            userText = textBoxUserName;
            passText = textBoxPassword;

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {

            MySql.Data.MySqlClient.MySqlConnection mySqlConnexion;

            MySql.Data.MySqlClient.MySqlDataReader mySqlReader = null;

            string myConnectionString;
            myConnectionString = "server=127.0.0.1; uid=root; pwd=; database=pharmacydb";

            mySqlConnexion = new MySql.Data.MySqlClient.MySqlConnection();

            mySqlConnexion.ConnectionString = myConnectionString;

            try
            {

                mySqlConnexion.Open();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var pwdbytes = Encoding.UTF8.GetBytes(textBoxPassword.Text);

            string pwd = Convert.ToBase64String(pwdbytes);

            string sqlString = "SELECT * FROM users WHERE Username= '" + textBoxUserName.Text + "' AND Password= '" + pwd + "' ";

            MySql.Data.MySqlClient.MySqlCommand mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand(sqlString, mySqlConnexion);

            mySqlReader = mySqlCommand.ExecuteReader();

            if (mySqlReader.Read())
            {

                userInfo = textBoxUserName.Text;

                MessageBox.Show("Bienvenue " + textBoxUserName.Text.ToUpperInvariant(), "Connexion réussie");

                chooseActionForm chooseactionforminstance = new chooseActionForm();

                this.Hide();

                chooseactionforminstance.Show();

            }

            else
            {
                if (textBoxUserName.Text.Length == 0)
                {
                    MessageBox.Show("La case 'Nom d'utilisateur' ne peut pas être vide", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (textBoxPassword.Text.Length == 0)
                {
                    MessageBox.Show("La case 'Mot de Passe' ne peut pas être vide", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("Nom d'utilisateur et/ou Mot de passe incorrect", "Identifiants incorrects", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            changePasswordForm chgpwdfrmInstance = new changePasswordForm();

            this.Hide();

            chgpwdfrmInstance.Show();
   
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();

            debutForm.DebutInstance.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CheckBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowPass.Checked == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
