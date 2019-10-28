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
    public partial class chooseActionForm : Form
    {

        

        public chooseActionForm()
        {
            InitializeComponent();
        }

        private void chooseActionForm_Load(object sender, EventArgs e)
        {


        }

        private void buttonStatusMgmt_Click(object sender, EventArgs e)
        {
            managementForm mgmtforminstance = new managementForm();

            this.Hide();

            mgmtforminstance.Show();
        }

        private void buttonDrugs_Click(object sender, EventArgs e)
        {
            drugsForm drugsforminstance = new drugsForm();

            this.Hide();

            drugsforminstance.Show();
        }

        private void chooseActionForm_FormClosing(object sender, FormClosingEventArgs e)
        {


            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

            this.Close();

            loginForm.Instance.userText.Clear();
            loginForm.Instance.passText.Clear();

            debutForm.DebutInstance.Show();
        }
    }
}
