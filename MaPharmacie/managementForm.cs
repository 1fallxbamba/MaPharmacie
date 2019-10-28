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
    public partial class managementForm : Form
    {
        public managementForm()
        {
            InitializeComponent();
        }

        private string phcy_name;
        private bool _islogout { get; set; }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            radioButtonOpened.Enabled = false;
            radioButtonClosed.Enabled = false;
            radioButtonGuard.Enabled = false;

            button1.Enabled = false;

            MySql.Data.MySqlClient.MySqlConnection mySqlConnexion;

            MySql.Data.MySqlClient.MySqlDataReader mySqlReader = null;

            string myConnectionString;
            myConnectionString = "server=127.0.0.1; uid=root; pwd=; database=pharmacydb";

            mySqlConnexion = new MySql.Data.MySqlClient.MySqlConnection();

            mySqlConnexion.ConnectionString = myConnectionString;

            string mySqlQuery = "SELECT p_Name FROM pharmacies WHERE p_Username = '" + loginForm.Instance.userInfo + "' ";

            mySqlConnexion.Open();

            MySql.Data.MySqlClient.MySqlCommand mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand(mySqlQuery, mySqlConnexion);

            mySqlReader = mySqlCommand.ExecuteReader();

            if (mySqlReader.Read())
            {
                phcy_name = mySqlReader.GetString(0);
            }

            this.Text = "Ma Pharmacie - Gestion de statut : " + phcy_name;

            label4.Text = "--Connecté en tant que : " + loginForm.Instance.userInfo + "-/" + phcy_name;

        }

        private void ManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            debutForm.DebutInstance.Show();

            loginForm.Instance.userText.Clear();
            loginForm.Instance.passText.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Êtes vous sûr de vouloir vous déconnecter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                _islogout = true;

                this.Close();

                loginForm.Instance.userText.Clear();
                loginForm.Instance.passText.Clear();

                debutForm.DebutInstance.Show();

            }
 
        }

        private void RadioButtonOpened_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButtonOpened.Checked == true)
            {

                radioButtonOpened.BackColor = Color.Lime;
                radioButtonClosed.BackColor = DefaultBackColor;
                radioButtonGuard.BackColor = DefaultBackColor;

                button1.Enabled = false;
                buttonChangeStatus.Enabled = true;

                string status = "Ouverte";

                radioButtonClosed.Enabled = false;
                radioButtonGuard.Enabled = false;

                MySql.Data.MySqlClient.MySqlConnection mySqlConnexion;

                MySql.Data.MySqlClient.MySqlDataReader mySqlReader = null;

                string myConnectionString;
                myConnectionString = "server=127.0.0.1; uid=root; pwd=; database=pharmacydb";

                mySqlConnexion = new MySql.Data.MySqlClient.MySqlConnection();

                mySqlConnexion.ConnectionString = myConnectionString;

                string mySqlQuery = "SELECT * FROM pharmacies WHERE p_Username = '" + loginForm.Instance.userInfo + "' ";

                try
                {

                    mySqlConnexion.Open();

                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MySql.Data.MySqlClient.MySqlCommand mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand(mySqlQuery, mySqlConnexion);

                mySqlReader = mySqlCommand.ExecuteReader();

                if (mySqlReader.Read())
                {

                    mySqlReader.Close();

                    mySqlQuery = "UPDATE pharmacies SET p_Status ='" + status + "' WHERE p_Username = '" + loginForm.Instance.userInfo + "' ";

                    mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand(mySqlQuery, mySqlConnexion);

                    mySqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Statut changé avec succés !", "Opération effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void ButtonChangeStatus_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Voulez vous changer de statut ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                buttonChangeStatus.Enabled = false;

                radioButtonOpened.Enabled = true;
                radioButtonClosed.Enabled = true;
                radioButtonGuard.Enabled = true;
            }

        }

        private void RadioButtonClosed_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonClosed.Checked == true)
            {

                radioButtonClosed.BackColor = Color.Red;
                radioButtonOpened.BackColor = DefaultBackColor;
                radioButtonGuard.BackColor = DefaultBackColor;

                button1.Enabled = true;

                buttonChangeStatus.Enabled = true;

                string status = "Fermée";

                radioButtonOpened.Enabled = false;
                radioButtonGuard.Enabled = false;

                MySql.Data.MySqlClient.MySqlConnection mySqlConnexion;

                MySql.Data.MySqlClient.MySqlDataReader mySqlReader = null;

                string myConnectionString;
                myConnectionString = "server=127.0.0.1; uid=root; pwd=; database=pharmacydb";

                mySqlConnexion = new MySql.Data.MySqlClient.MySqlConnection();

                mySqlConnexion.ConnectionString = myConnectionString;

                string mySqlQuery = "SELECT * FROM pharmacies WHERE p_Username = '" + loginForm.Instance.userInfo + "' ";

                try
                {

                    mySqlConnexion.Open();

                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MySql.Data.MySqlClient.MySqlCommand mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand(mySqlQuery, mySqlConnexion);

                mySqlReader = mySqlCommand.ExecuteReader();

                if (mySqlReader.Read())
                {

                    mySqlReader.Close();

                    mySqlQuery = "UPDATE pharmacies SET p_Status ='" + status + "' WHERE p_Username = '" + loginForm.Instance.userInfo + "' ";

                    mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand(mySqlQuery, mySqlConnexion);

                    mySqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Statut changé avec succés !", "Opération effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void RadioButtonGuard_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonGuard.Checked == true)
            {

                radioButtonGuard.BackColor = Color.Orange;
                radioButtonOpened.BackColor = DefaultBackColor;
                radioButtonClosed.BackColor = DefaultBackColor;

                button1.Enabled = false;

                buttonChangeStatus.Enabled = true;

                string status = "En garde";

                radioButtonOpened.Enabled = false;
                radioButtonClosed.Enabled = false;

                MySql.Data.MySqlClient.MySqlConnection mySqlConnexion;

                MySql.Data.MySqlClient.MySqlDataReader mySqlReader = null;

                string myConnectionString;
                myConnectionString = "server=127.0.0.1; uid=root; pwd=; database=pharmacydb";

                mySqlConnexion = new MySql.Data.MySqlClient.MySqlConnection();

                mySqlConnexion.ConnectionString = myConnectionString;

                string mySqlQuery = "SELECT * FROM pharmacies WHERE p_Username = '" + loginForm.Instance.userInfo + "' ";

                try
                {

                    mySqlConnexion.Open();

                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MySql.Data.MySqlClient.MySqlCommand mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand(mySqlQuery, mySqlConnexion);

                mySqlReader = mySqlCommand.ExecuteReader();

                if (mySqlReader.Read())
                {

                    mySqlReader.Close();

                    mySqlQuery = "UPDATE pharmacies SET p_Status ='" + status + "' WHERE p_Username = '" + loginForm.Instance.userInfo + "' ";

                    mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand(mySqlQuery, mySqlConnexion);

                    mySqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Statut changé avec succés !", "Opération effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }
    }
}
