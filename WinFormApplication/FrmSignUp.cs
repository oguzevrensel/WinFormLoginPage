using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApplication
{
    public partial class FrmSignUp : Form
    {

        UserProcess userProcess;
        public FrmSignUp()
        {
            InitializeComponent();
            userProcess = UserProcess.GetInstance();
        }

        

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUserName.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtRepeatPassword.Text) ||
                string.IsNullOrEmpty(txtQuestion.Text) ||
                string.IsNullOrEmpty(txtAnswer.Text))
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz");
                return;
            }

            if(txtPassword.Text.Trim() != txtRepeatPassword.Text.Trim())
            {
                MessageBox.Show("Şifreler Uyuşmuyor");
                return;
            }

            User user = new User(txtUserName.Text, txtPassword.Text, txtQuestion.Text, txtAnswer.Text);
            MessageBox.Show(userProcess.AddUser(user));

            string userName = txtUserName.Text.Trim();

            Login frm = (Login)Application.OpenForms["Login"];
            frm.txtUserName.Text = userName;
            frm.txtUserName.Enabled = false;
            this.Close();


        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmSignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
