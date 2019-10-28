using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaPharmacie
{
    public partial class drugsForm : Form
    {

        private string phcy_name;

        private static readonly HttpClient client = new HttpClient();
        public drugsForm()
        {
            InitializeComponent();
        }

        private void drugsForm_Load(object sender, EventArgs e)
        {

            buttonAvail.Enabled = true;
            buttonNoAvail.Enabled = true;

            ArrayList yea = new ArrayList();

            MySql.Data.MySqlClient.MySqlConnection mySqlConnexion;

            MySql.Data.MySqlClient.MySqlDataReader mySqlReader = null;

            MySql.Data.MySqlClient.MySqlDataReader mySqlReader2 = null;

            string myConnectionString;
            myConnectionString = "server=127.0.0.1; uid=root; pwd=; database=pharmacydb";

            mySqlConnexion = new MySql.Data.MySqlClient.MySqlConnection();

            mySqlConnexion.ConnectionString = myConnectionString;


            string mySqlQuery = "SELECT d_Name FROM drugs ";

            mySqlConnexion.Open();

            MySql.Data.MySqlClient.MySqlCommand mySqlCommand = new MySql.Data.MySqlClient.MySqlCommand(mySqlQuery, mySqlConnexion);

            mySqlReader = mySqlCommand.ExecuteReader();



            while (mySqlReader.Read())
            {
                yea.Add(mySqlReader.GetString(0));

            }

            comboBoxDrugs.DataSource = yea;

            mySqlConnexion.Close();

            string mySqlQuery2 = "SELECT p_Name FROM pharmacies WHERE p_Username = '" + loginForm.Instance.userInfo + "' ";

            MySql.Data.MySqlClient.MySqlCommand mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand(mySqlQuery2, mySqlConnexion);

            mySqlConnexion.Open();

            mySqlReader2 = mySqlCommand2.ExecuteReader();

            if (mySqlReader2.Read())
            {
                phcy_name = mySqlReader2.GetString(0);
            }

            

        }

        private void drugsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

            loginForm.Instance.userText.Clear();
            loginForm.Instance.passText.Clear();

            //debutForm debutforminstance = new debutForm();

            this.Close();

            debutForm.DebutInstance.Show();

            //debutforminstance.Show();
        }

        private void buttonAvail_Click(object sender, EventArgs e)
        {

            buttonNoAvail.Enabled = true;

            string pName = phcy_name;
            string dName = comboBoxDrugs.SelectedItem.ToString();

            client.GetAsync("http://localhost/pharmacyapi/updatedrugavailYES.php?phname=" + pName + "&drname=" + dName);

            buttonAvail.Enabled = false;

            MessageBox.Show("Le médicament " + dName + " est maintenant disponible dans votre pharmacie", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonNoAvail_Click(object sender, EventArgs e)
        {

            buttonAvail.Enabled = true;

            string pName = phcy_name;
            string dName = comboBoxDrugs.SelectedItem.ToString();

            client.GetAsync("http://localhost/pharmacyapi/updatedrugavailNO.php?phname=" + pName + "&drname=" + dName);

            buttonNoAvail.Enabled = false;

            MessageBox.Show("Le médicament " + dName + " n'est maintenant plus disponible dans votre pharmacie", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDrugs_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAvail.Enabled = true;
            buttonNoAvail.Enabled = true;
        }
    }
}
