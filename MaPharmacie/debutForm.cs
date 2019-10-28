using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MaPharmacie
{
    public partial class debutForm : Form
    {
        public debutForm()
        {
            InitializeComponent();
        }

        private static debutForm _debutinstance;

        public static debutForm DebutInstance
        {
            get
            {
                if (_debutinstance == null)
                {
                    _debutinstance = new debutForm();
                }

                return _debutinstance;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {

            this.Hide();

            loginForm.Instance.Show();

        }

        private void ButtonRequestCredentials_Click(object sender, EventArgs e)
        {

            string fileNamedebut = @"C:\Users\";
            string fileNamemiddle = fileNamedebut + Environment.UserName;
            string fullFileName = fileNamemiddle + @"\AppData\Local\alreadyHasCredentials.txt";

            if (File.Exists(fullFileName))
            {
                MessageBox.Show("Vous avez déjà des identifiants ! Veuillez vous connecter directement", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                buttonRequestCredentials.Enabled = false;
            }
            else
            {

                this.Hide();

                newCredentialsForm askCredentialsFormInstance = new newCredentialsForm();

                askCredentialsFormInstance.Show();

            }    

        }

        private void DebutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void DebutForm_Load(object sender, EventArgs e)
        {

            _debutinstance = this;

            
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("\nNom : Bamba Fall" + "\n\n" +
                "Adresse e-mail : fbamba99@gmail.com" + "\n\n" +
                "Numéro de téléphone : (SN) +221 77 690 72 17 ", "Infos développeur", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
